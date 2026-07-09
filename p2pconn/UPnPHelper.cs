using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace p2pconn
{
    /// <summary>
    /// UPnP / NAT-PMP 端口自动映射助手。
    /// 优先调用 Windows 自带 HNetCfg.NATUPnP COM 接口，
    /// 失败则 SSDP 发现 UPnP IGD 后 SOAP 调用 AddPortMapping。
    /// 成功 → 外网可直连；失败 → 提示用户手动配置路由器端口转发。
    /// </summary>
    public static class UPnPHelper
    {
        public class Result
        {
            public bool Success;
            public string ExternalIp;
            public string Message;
            public bool NeedManual; // true 表示需要用户手动配置路由器
        }

        /// <summary>
        /// 同步尝试添加端口映射（后台线程调用）
        /// </summary>
        public static Result TryPortMapping(int internalPort, int externalPort,
            string protocol = "UDP", string description = "LDesktop Remote Assist")
        {
            // 1. 优先尝试 NATUPnP COM（Windows 自带）
            var comResult = TryViaCom(internalPort, externalPort, protocol, description);
            if (comResult.Success) return comResult;

            // 2. 回退：SSDP 发现 UPnP IGD + SOAP
            var ssdpResult = TryViaSsdp(internalPort, externalPort, protocol, description);
            if (ssdpResult.Success) return ssdpResult;

            // 3. 全部失败 → 返回手动配置提示
            return new Result
            {
                Success = false,
                ExternalIp = "",
                NeedManual = true,
                Message = "未能在路由器上自动开放端口。\r\n" +
                          "请手动登录路由器后台，进入「端口转发 / 虚拟服务器 / NAT」，添加规则：\r\n" +
                          $"  外部端口 {externalPort}/{protocol}  →  内部 IP {GetLocalIPv4()} : {internalPort}/{protocol}\r\n" +
                          "配置完成后再次启动 LDesktop 即可被外网直连。"
            };
        }

        // ========== 方案 1：HNetCfg.NATUPnP COM ==========
        private static Result TryViaCom(int internalPort, int externalPort, string protocol, string description)
        {
            try
            {
                Type t = Type.GetTypeFromProgID("HNetCfg.NATUPnP");
                if (t == null) return Fail("系统未注册 HNetCfg.NATUPnP");

                dynamic nat = Activator.CreateInstance(t);
                string localIp = GetLocalIPv4();
                if (string.IsNullOrEmpty(localIp)) return Fail("无法获取本机内网 IP");

                // 静态映射
                bool added = false;
                try
                {
                    dynamic staticMaps = nat.StaticPortMappingCollection;
                    if (staticMaps != null)
                    {
                        try { staticMaps.Remove(externalPort, protocol); } catch { }
                        staticMaps.Add(externalPort, protocol, internalPort, localIp, true, description);
                        added = true;
                    }
                }
                catch { }

                // 动态映射
                if (!added)
                {
                    try
                    {
                        dynamic dynMaps = nat.DynamicPortMappingCollection;
                        if (dynMaps != null)
                        {
                            dynMaps.Add(externalPort, protocol, internalPort, localIp, true, description);
                            added = true;
                        }
                    }
                    catch { }
                }

                if (!added) return Fail("路由器未启用 UPnP 或映射被拒绝");

                // 取外网 IP
                string extIp = "";
                try
                {
                    dynamic extObj = nat.ExternalIPAddress;
                    if (extObj != null) extIp = extObj.ToString();
                }
                catch { }

                if (!string.IsNullOrEmpty(extIp) && extIp != "0.0.0.0")
                {
                    return Ok(extIp, $"UPnP 成功：外网可直连 {extIp}:{externalPort}");
                }
                return Ok("", $"UPnP 端口映射成功（外网 IP 由 STUN 探测）");
            }
            catch (Exception ex)
            {
                return Fail("COM 异常：" + ex.Message);
            }
        }

        // ========== 方案 2：SSDP 发现 + SOAP ==========
        private static Result TryViaSsdp(int internalPort, int externalPort, string protocol, string description)
        {
            try
            {
                string location = SsdpDiscover();
                if (string.IsNullOrEmpty(location)) return Fail("未发现 UPnP IGD 设备");

                string ctrlUrl = ReadControlUrl(location);
                if (string.IsNullOrEmpty(ctrlUrl)) return Fail("UPnP 设备无 WANConnection 服务");

                string externalIp = SoapGetExternalIp(ctrlUrl);
                bool ok = SoapAddPortMapping(ctrlUrl, internalPort, externalPort, protocol, description);
                if (!ok) return Fail("路由器拒绝 AddPortMapping");

                if (!string.IsNullOrEmpty(externalIp))
                    return Ok(externalIp, $"UPnP 成功：外网可直连 {externalIp}:{externalPort}");
                return Ok("", "UPnP 端口映射成功（外网 IP 由 STUN 探测）");
            }
            catch (Exception ex)
            {
                return Fail("SSDP 异常：" + ex.Message);
            }
        }

        private static string SsdpDiscover()
        {
            using (UdpClient udp = new UdpClient())
            {
                udp.Client.ReceiveTimeout = 3000;
                IPEndPoint mcast = new IPEndPoint(IPAddress.Parse("239.255.255.250"), 1900);
                string req =
                    "M-SEARCH * HTTP/1.1\r\n" +
                    "HOST: 239.255.255.250:1900\r\n" +
                    "MAN: \"ssdp:discover\"\r\n" +
                    "MX: 2\r\n" +
                    "ST: urn:schemas-upnp-org:device:InternetGatewayDevice:1\r\n\r\n";
                byte[] b = Encoding.ASCII.GetBytes(req);
                udp.Send(b, b.Length, mcast);

                DateTime deadline = DateTime.Now.AddSeconds(4);
                while (DateTime.Now < deadline)
                {
                    try
                    {
                        IPEndPoint from = new IPEndPoint(IPAddress.Any, 0);
                        byte[] resp = udp.Receive(ref from);
                        string text = Encoding.ASCII.GetString(resp);
                        foreach (string line in text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))
                        {
                            if (line.StartsWith("LOCATION:", StringComparison.OrdinalIgnoreCase))
                                return line.Substring("LOCATION:".Length).Trim();
                        }
                    }
                    catch (SocketException) { break; }
                    catch { continue; }
                }
            }
            return null;
        }

        private static string ReadControlUrl(string deviceDescriptionUrl)
        {
            try
            {
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load(deviceDescriptionUrl);
                System.Xml.XmlNamespaceManager ns = new System.Xml.XmlNamespaceManager(doc.NameTable);
                ns.AddNamespace("u", "urn:schemas-upnp-org:device-1-0");

                string[] svcTypes = {
                    "urn:schemas-upnp-org:service:WANIPConnection:1",
                    "urn:schemas-upnp-org:service:WANPPPConnection:1"
                };
                foreach (string st in svcTypes)
                {
                    System.Xml.XmlNodeList list = doc.SelectNodes($"//u:service[u:serviceType='{st}']", ns);
                    if (list != null && list.Count > 0)
                    {
                        System.Xml.XmlNode svc = list[0];
                        string ctrl = svc.SelectSingleNode("u:controlURL", ns)?.InnerText;
                        string stType = svc.SelectSingleNode("u:serviceType", ns)?.InnerText;
                        if (!string.IsNullOrEmpty(ctrl) && !string.IsNullOrEmpty(stType))
                        {
                            if (!ctrl.StartsWith("http"))
                                ctrl = new Uri(new Uri(deviceDescriptionUrl), ctrl).ToString();
                            UPnPContext.CacheType(ctrl, stType);
                            return ctrl;
                        }
                    }
                }
            }
            catch { }
            return null;
        }

        private static string SoapGetExternalIp(string ctrlUrl)
        {
            try
            {
                string svcType = UPnPContext.GetCachedType(ctrlUrl);
                string soap =
                    "<?xml version=\"1.0\"?>" +
                    "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">" +
                    $"<s:Body><u:GetExternalIPAddress xmlns:u=\"{svcType}\"></u:GetExternalIPAddress></s:Body></s:Envelope>";
                string resp = PostSoap(ctrlUrl, svcType, "GetExternalIPAddress", soap);
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.LoadXml(resp);
                System.Xml.XmlNode n = doc.GetElementsByTagName("NewExternalIPAddress")[0];
                return n?.InnerText ?? "";
            }
            catch { return ""; }
        }

        private static bool SoapAddPortMapping(string ctrlUrl, int internalPort, int externalPort,
            string protocol, string description)
        {
            try
            {
                string svcType = UPnPContext.GetCachedType(ctrlUrl);
                string localIp = GetLocalIPv4();
                string soap =
                    "<?xml version=\"1.0\"?>" +
                    "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\">" +
                    $"<s:Body><u:AddPortMapping xmlns:u=\"{svcType}\">" +
                    "<NewRemoteHost></NewRemoteHost>" +
                    $"<NewExternalPort>{externalPort}</NewExternalPort>" +
                    $"<NewProtocol>{protocol}</NewProtocol>" +
                    $"<NewInternalPort>{internalPort}</NewInternalPort>" +
                    $"<NewInternalClient>{localIp}</NewInternalClient>" +
                    "<NewEnabled>1</NewEnabled>" +
                    $"<NewPortMappingDescription>{description}</NewPortMappingDescription>" +
                    "<NewLeaseDuration>0</NewLeaseDuration>" +
                    "</u:AddPortMapping></s:Body></s:Envelope>";
                string resp = PostSoap(ctrlUrl, svcType, "AddPortMapping", soap);
                return resp.Contains("AddPortMappingResponse") && !resp.Contains("UPnPError");
            }
            catch { return false; }
        }

        private static string PostSoap(string ctrlUrl, string svcType, string action, string soap)
        {
            WebRequest req = WebRequest.Create(ctrlUrl);
            req.Method = "POST";
            req.ContentType = "text/xml; charset=\"utf-8\"";
            req.Timeout = 5000;
            req.Headers.Add("SOAPAction: \"" + svcType + "#" + action + "\"");
            byte[] data = Encoding.UTF8.GetBytes(soap);
            req.ContentLength = data.Length;
            using (System.IO.Stream s = req.GetRequestStream()) s.Write(data, 0, data.Length);
            using (WebResponse resp = req.GetResponse())
            using (System.IO.Stream rs = resp.GetResponseStream())
            using (System.IO.StreamReader sr = new System.IO.StreamReader(rs, Encoding.UTF8))
                return sr.ReadToEnd();
        }

        // ========== 工具 ==========
        public static void RemovePortMapping(int externalPort, string protocol = "UDP")
        {
            try
            {
                Type t = Type.GetTypeFromProgID("HNetCfg.NATUPnP");
                if (t == null) return;
                dynamic nat = Activator.CreateInstance(t);
                try { nat.StaticPortMappingCollection?.Remove(externalPort, protocol); } catch { }
                try { nat.DynamicPortMappingCollection?.Remove(externalPort, protocol); } catch { }
            }
            catch { }
        }

        public static string GetLocalIPv4()
        {
            try
            {
                using (Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    s.Connect("8.8.8.8", 65530);
                    return ((IPEndPoint)s.LocalEndPoint).Address.ToString();
                }
            }
            catch
            {
                foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                    if (ip.AddressFamily == AddressFamily.InterNetwork) return ip.ToString();
                return "";
            }
        }

        public static string GetDefaultGatewayIPv4()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus != OperationalStatus.Up) continue;
                if (ni.NetworkInterfaceType != NetworkInterfaceType.Ethernet &&
                    ni.NetworkInterfaceType != NetworkInterfaceType.Wireless80211) continue;
                var gw = ni.GetIPProperties().GatewayAddresses.FirstOrDefault();
                if (gw != null && gw.Address != null && gw.Address.AddressFamily == AddressFamily.InterNetwork)
                    return gw.Address.ToString();
            }
            return null;
        }

        private static Result Ok(string ip, string msg) => new Result { Success = true, ExternalIp = ip, Message = msg, NeedManual = false };
        private static Result Fail(string reason) => new Result { Success = false, ExternalIp = "", Message = reason, NeedManual = false };
    }

    /// <summary>缓存 ctrlUrl → serviceType 映射</summary>
    internal static class UPnPContext
    {
        private static string _ctrlUrl;
        private static string _svcType;
        public static void CacheType(string ctrlUrl, string svcType) { _ctrlUrl = ctrlUrl; _svcType = svcType; }
        public static string GetCachedType(string ctrlUrl) => ctrlUrl == _ctrlUrl ? _svcType : "";
    }
}
