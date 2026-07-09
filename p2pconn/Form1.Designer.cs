namespace p2pconn
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            // ===== 调色板 =====
            System.Drawing.Color brand      = System.Drawing.Color.FromArgb(79, 70, 229);    // #4f46e5 主色 indigo
            System.Drawing.Color brandHover = System.Drawing.Color.FromArgb(67, 56, 202);
            System.Drawing.Color bgPage     = System.Drawing.Color.FromArgb(249, 250, 251);   // #f9fafb 淡灰底
            System.Drawing.Color bgCard     = System.Drawing.Color.White;
            System.Drawing.Color bgNav      = System.Drawing.Color.FromArgb(243, 244, 246);   // #f3f4f6
            System.Drawing.Color textP      = System.Drawing.Color.FromArgb(17, 24, 39);       // #111827
            System.Drawing.Color textS      = System.Drawing.Color.FromArgb(107, 114, 128);    // #6b7280
            System.Drawing.Color border     = System.Drawing.Color.FromArgb(229, 231, 235);   // #e5e7eb
            System.Drawing.Color green      = System.Drawing.Color.FromArgb(16, 185, 129);    // #10b981
            System.Drawing.Color greenBg    = System.Drawing.Color.FromArgb(209, 250, 229);   // 浅绿
            System.Drawing.Color amber      = System.Drawing.Color.FromArgb(245, 158, 11);    // #f59e0b
            System.Drawing.Color amberBg    = System.Drawing.Color.FromArgb(254, 243, 199);   // 浅黄
            System.Drawing.Color red        = System.Drawing.Color.FromArgb(239, 68, 68);

            System.Drawing.Font fTitle   = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fSection = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBody    = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            System.Drawing.Font fSmall   = new System.Drawing.Font("Microsoft YaHei UI", 9.5F);
            System.Drawing.Font fMono    = new System.Drawing.Font("Consolas", 11F);
            System.Drawing.Font fStatus  = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fNav      = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBtnBig   = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);

            // ===== 实例化所有控件 =====
            // 容器
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.navConnect = new System.Windows.Forms.Button();
            this.navStun = new System.Windows.Forms.Button();
            this.navDesktop = new System.Windows.Forms.Button();
            this.navAbout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();

            // 连接页
            this.pageConnect = new System.Windows.Forms.Panel();
            this.lblTitleConnect = new System.Windows.Forms.Label();
            this.lblSubConnect = new System.Windows.Forms.Label();
            this.pnlUpnpStatus = new System.Windows.Forms.Panel();
            this.lblUpnpIcon = new System.Windows.Forms.Label();
            this.lblUpnpText = new System.Windows.Forms.Label();
            this.cardWan = new System.Windows.Forms.Panel();
            this.lblWanTitle = new System.Windows.Forms.Label();
            this.txtWanIp = new System.Windows.Forms.TextBox();
            this.btnCopyWan = new System.Windows.Forms.Button();
            this.cardLan = new System.Windows.Forms.Panel();
            this.lblLanTitle = new System.Windows.Forms.Label();
            this.txtLanIp = new System.Windows.Forms.TextBox();
            this.btnCopyLan = new System.Windows.Forms.Button();
            this.cardRemote = new System.Windows.Forms.Panel();
            this.lblRemoteTitle = new System.Windows.Forms.Label();
            this.txtRemoteIp = new System.Windows.Forms.TextBox();
            this.btnPasteRemote = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.cardChat = new System.Windows.Forms.Panel();
            this.lblChatTitle = new System.Windows.Forms.Label();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtChatInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRemoteDesktop = new System.Windows.Forms.Button();

            // STUN 页
            this.pageStun = new System.Windows.Forms.Panel();
            this.lblTitleStun = new System.Windows.Forms.Label();
            this.lblSubStun = new System.Windows.Forms.Label();
            this.btnStunSave = new System.Windows.Forms.Button();
            this.btnStunDel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // 桌面设置页
            this.pageDesktop = new System.Windows.Forms.Panel();
            this.lblTitleDesktop = new System.Windows.Forms.Label();
            this.lblSubDesktop = new System.Windows.Forms.Label();
            this.cardDOptions = new System.Windows.Forms.Panel();
            this.lblD stretching = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.dspeed = new System.Windows.Forms.ComboBox();
            this.cardDStats = new System.Windows.Forms.Panel();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.lblDelayCaption = new System.Windows.Forms.Label();
            this.lblFpsCaption = new System.Windows.Forms.Label();
            this.lblFpsValue = new System.Windows.Forms.Label();
            this.lblDelayValue = new System.Windows.Forms.Label();

            // 关于页
            this.pageAbout = new System.Windows.Forms.Panel();
            this.lblTitleAbout = new System.Windows.Forms.Label();
            this.lblSubAbout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();

            // 旧引用兼容字段
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmyHost = new System.Windows.Forms.TextBox();
            this.txtLocalHost = new System.Windows.Forms.TextBox();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.r_chat = new System.Windows.Forms.RichTextBox();
            this.txtnsg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.btnRdp = new System.Windows.Forms.Button();
            this.lblFPS = new System.Windows.Forms.Label();
            this.lblkb = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNav.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pageConnect.SuspendLayout();
            this.pnlUpnpStatus.SuspendLayout();
            this.cardWan.SuspendLayout();
            this.cardLan.SuspendLayout();
            this.cardRemote.SuspendLayout();
            this.cardChat.SuspendLayout();
            this.pageStun.SuspendLayout();
            this.pageDesktop.SuspendLayout();
            this.cardDOptions.SuspendLayout();
            this.cardDStats.SuspendLayout();
            this.pageAbout.SuspendLayout();
            this.SuspendLayout();

            // ===== 扁平按钮工具：主色填充 =====
            System.Action<System.Windows.Forms.Button, System.Drawing.Color, System.Drawing.Color, System.Drawing.Font> brandBtn =
                (b, bg, fg, f) =>
            {
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = bg;
                b.ForeColor = fg;
                b.Font = f ?? fBody;
                b.Cursor = System.Windows.Forms.Cursors.Hand;
                b.UseVisualStyleBackColor = false;
            };

            // ===== 卡片工具：白底 =====
            System.Action<System.Windows.Forms.Panel> cardStyle = (c) =>
            {
                c.BackColor = bgCard;
                c.Padding = new System.Windows.Forms.Padding(0);
            };

            // ===== 导航按钮工具 =====
            System.Action<System.Windows.Forms.Button, string, int> makeNav = (btn, text, y) =>
            {
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = bgNav;
                btn.ForeColor = textP;
                btn.Font = fNav;
                btn textAlign = btn;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.UseVisualStyleBackColor = false;
                btn.Text = text;
                btn.Location = new System.Drawing.Point(0, y);
                btn.Size = new System.Drawing.Size(200, 48);
            };

            // ============= pnlNav (左侧导航) =============
            this.pnlNav.BackColor = bgNav;
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Width = 200;
            this.pnlNav.Controls.Add(this.lblBrand);
            this.pnlNav.Controls.Add(this.navConnect);
            this.pnlNav.Controls.Add(this.navStun);
            this.pnlNav.Controls.Add(this.navDesktop);
            this.pnlNav.Controls.Add(this.navAbout);

            this.lblBrand.Text = "LDesktop";
            this.lblBrand.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = brand;
            this.lblBrand.Location = new System.Drawing.Point(24, 28);
            this.lblBrand.Size = new System.Drawing.Size(160, 36);
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            makeNav(this.navConnect, "连   接", 110);
            makeNav(this.navStun,    "STUN",    168);
            makeNav(this.navDesktop, "桌面设置", 226);
            makeNav(this.navAbout,   "关   于", 284);
            this.navConnect.Click += new System.EventHandler(this.navConnect_Click);
            this.navStun.Click    += new System.EventHandler(this.navStun_Click);
            this.navDesktop.Click += new System.EventHandler(this.navDesktop_Click);
            this.navAbout.Click   += new System.EventHandler(this.navAbout_Click);

            // ============= pnlContent (右侧主区) =============
            this.pnlContent.BackColor = bgPage;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Controls.Add(this.pageAbout);
            this.pnlContent.Controls.Add(this.pageDesktop);
            this.pnlContent.Controls.Add(this.pageStun);
            this.pnlContent.Controls.Add(this.pageConnect);

            // 默认显示连接页
            this.pageConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageStun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageConnect.BackColor = bgPage;
            this.pageStun.BackColor = bgPage;
            this.pageDesktop.BackColor = bgPage;
            this.pageAbout.BackColor = bgPage;

            // ====================== 连接页 ======================
            this.pageConnect.Controls.Add(this.lblTitleConnect);
            this.pageConnect.Controls.Add(this.lblSubConnect);
            this.pageConnect.Controls.Add(this.pnlUpnpStatus);
            this.pageConnect.Controls.Add(this.cardWan);
            this.pageConnect.Controls.Add(this.cardLan);
            this.pageConnect.Controls.Add(this.cardRemote);
            this.pageConnect.Controls.Add(this.lblConnStatus);
            this.pageConnect.Controls.Add(this.cardChat);
            this.pageConnect.Controls.Add(this.btnRemoteDesktop);

            this.lblTitleConnect.Text = "远程连接";
            this.lblTitleConnect.Font = fTitle;
            this.lblTitleConnect.ForeColor = textP;
            this.lblTitleConnect.Location = new System.Drawing.Point(32, 24);
            this.lblTitleConnect.Size = new System.Drawing.Size(420, 32);

            this.lblSubConnect.Text = "通过 IP:端口 与对端建立 P2P 直连，连接后可远程控制对方桌面";
            this.lblSubConnect.Font = fSmall;
            this.lblSubConnect.ForeColor = textS;
            this.lblSubConnect.Location = new System.Drawing.Point(32, 60);
            this.lblSubConnect.Size = new System.Drawing.Size(700, 24);

            // ---- UPnP 状态条 ----
            this.pnlUpnpStatus.BackColor = amberBg;
            this.pnlUpnpStatus.Location = new System.Drawing.Point(32, 100);
            this.pnlUpnpStatus.Size = new System.Drawing.Size(752, 36);
            this.pnlUpnpStatus.Controls.Add(this.lblUpnpIcon);
            this.pnlUpnpStatus.Controls.Add(this.lblUpnpText);

            this.lblUpnpIcon.Text = "●";
            this.lblUpnpIcon.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUpnpIcon.ForeColor = amber;
            this.lblUpnpIcon.Location = new System.Drawing.Point(12, 4);
            this.lblUpnpIcon.Size = new System.Drawing.Size(28, 30);

            this.lblUpnpText.Text = "正在检测 UPnP/NAT 穿透状态…";
            this.lblUpnpText.Font = fStatus;
            this.lblUpnpText.ForeColor = textP;
            this.lblUpnpText.Location = new System.Drawing.Point(44, 8);
            this.lblUpnpText.Size = new System.Drawing.Size(700, 22);

            // ---- cardWan 外网IP ----
            cardStyle(this.cardWan);
            this.cardWan.Location = new System.Drawing.Point(32, 152);
            this.cardWan.Size = new System.Drawing.Size(370, 90);
            this.cardWan.Controls.Add(this.lblWanTitle);
            this.cardWan.Controls.Add(this.txtWanIp);
            this.cardWan.Controls.Add(this.btnCopyWan);

            this.lblWanTitle.Text = "外网 IP / WAN";
            this.lblWanTitle.Font = fSection;
            this.lblWanTitle.ForeColor = textP;
            this.lblWanTitle.Location = new System.Drawing.Point(16, 14);
            this.lblWanTitle.Size = new System.Drawing.Size(200, 24);

            this.txtWanIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWanIp.BackColor = bgPage;
            this.txtWanIp.ForeColor = textP;
            this.txtWanIp.Font = fMono;
            this.txtWanIp.Location = new System.Drawing.Point(16, 44);
            this.txtWanIp.Size = new System.Drawing.Size(280, 28);
            this.txtWanIp.ReadOnly = true;

            brandBtn(this.btnCopyWan, brand, System.Drawing.Color.White, fBody);
            this.btnCopyWan.Text = "复制";
            this.btnCopyWan.Location = new System.Drawing.Point(304, 44);
            this.btnCopyWan.Size = new System.Drawing.Size(56, 28);
            this.btnCopyWan.Click += new System.EventHandler(this.button1_Click);

            // ---- cardLan 内网IP ----
            cardStyle(this.cardLan);
            this.cardLan.Location = new System.Drawing.Point(414, 152);
            this.cardLan.Size = new System.Drawing.Size(370, 90);
            this.cardLan.Controls.Add(this.lblLanTitle);
            this.cardLan.Controls.Add(this.txtLanIp);
            this.cardLan.Controls.Add(this.btnCopyLan);

            this.lblLanTitle.Text = "内网 IP / LAN";
            this.lblLanTitle.Font = fSection;
            this.lblLanTitle.ForeColor = textP;
            this.lblLanTitle.Location = new System.Drawing.Point(16, 14);
            this.lblLanTitle.Size = new System.Drawing.Size(200, 24);

            this.txtLanIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLanIp.BackColor = bgPage;
            this.txtLanIp.ForeColor = textP;
            this.txtLanIp.Font = fMono;
            this.txtLanIp.Location = new System.Drawing.Point(16, 44);
            this.txtLanIp.Size = new System.Drawing.Size(280, 28);
            this.txtLanIp.ReadOnly = true;

            brandBtn(this.btnCopyLan, brand, System.Drawing.Color.White, fBody);
            this.btnCopyLan.Text = "复制";
            this.btnCopyLan.Location = new System.Drawing.Point(304, 44);
            this.btnCopyLan.Size = new System.Drawing.Size(56, 28);
            this.btnCopyLan.Click += new System.EventHandler(this.button3_Click);

            // ---- cardRemote 远端地址 ----
            cardStyle(this.cardRemote);
            this.cardRemote.Location = new System.Drawing.Point(32, 258);
            this.cardRemote.Size = new System.Drawing.Size(752, 110);
            this.cardRemote.Controls.Add(this.lblRemoteTitle);
            this.cardRemote.Controls.Add(this.txtRemoteIp);
            this.cardRemote.Controls.Add(this.btnPasteRemote);
            this.cardRemote.Controls.Add(this.btnConnect);

            this.lblRemoteTitle.Text = "远端地址 (IP:端口)";
            this.lblRemoteTitle.Font = fSection;
            this.lblRemoteTitle.ForeColor = textP;
            this.lblRemoteTitle.Location = new System.Drawing.Point(16, 14);
            this.lblRemoteTitle.Size = new System.Drawing.Size(300, 24);

            this.txtRemoteIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemoteIp.BackColor = bgPage;
            this.txtRemoteIp.ForeColor = textP;
            this.txtRemoteIp.Font = fMono;
            this.txtRemoteIp.Location = new System.Drawing.Point(16, 44);
            this.txtRemoteIp.Size = new System.Drawing.Size(560, 28);

            brandBtn(this.btnPasteRemote, System.Drawing.Color.FromArgb(243, 244, 246), textP, fBody);
            this.btnPasteRemote.Text = "粘贴";
            this.btnPasteRemote.Location = new System.Drawing.Point(584, 44);
            this.btnPasteRemote.Size = new System.Drawing.Size(64, 28);
            this.btnPasteRemote.Click += new System.EventHandler(this.btn_paste_Click);

            brandBtn(this.btnConnect, green, System.Drawing.Color.White, fBtnBig);
            this.btnConnect.Text = "连接远程";
            this.btnConnect.Location = new System.Drawing.Point(656, 42);
            this.btnConnect.Size = new System.Drawing.Size(80, 32);
            this.btnConnect.Click += new System.EventHandler(this.button2_Click);

            // ---- lblConnStatus 状态文本 ----
            this.lblConnStatus.Text = "● 就绪";
            this.lblConnStatus.Font = fStatus;
            this.lblConnStatus.ForeColor = textS;
            this.lblConnStatus.Location = new System.Drawing.Point(32, 380);
            this.lblConnStatus.Size = new System.Drawing.Size(560, 24);

            // ---- cardChat 聊天卡片 ----
            cardStyle(this.cardChat);
            this.cardChat.Location = new System.Drawing.Point(32, 416);
            this.cardChat.Size = new System.Drawing.Size(560, 170);
            this.cardChat.Controls.Add(this.lblChatTitle);
            this.cardChat.Controls.Add(this.rtbChat);
            this.cardChat.Controls.Add(this.txtChatInput);
            this.cardChat.Controls.Add(this.btnSend);

            this.lblChatTitle.Text = "💬 聊天";
            this.lblChatTitle.Font = fSection;
            this.lblChatTitle.ForeColor = textP;
            this.lblChatTitle.Location = new System.Drawing.Point(16, 12);
            this.lblChatTitle.Size = new System.Drawing.Size(200, 24);

            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbChat.BackColor = bgPage;
            this.rtbChat.ForeColor = textP;
            this.rtbChat.Font = fBody;
            this.rtbChat.Location = new System.Drawing.Point(16, 42);
            this.rtbChat.Size = new System.Drawing.Size(528, 80);
            this.rtbChat.ReadOnly = true;
            this.rtbChat.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.r_chat_LinkClicked);
            this.rtbChat.TextChanged += new System.EventHandler(this.r_chat_TextChanged);

            this.txtChatInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChatInput.BackColor = bgPage;
            this.txtChatInput.ForeColor = textP;
            this.txtChatInput.Font = fBody;
            this.txtChatInput.Location = new System.Drawing.Point(16, 130);
            this.txtChatInput.Size = new System.Drawing.Size(440, 28);

            brandBtn(this.btnSend, brand, System.Drawing.Color.White, fBtnBig);
            this.btnSend.Text = "发送";
            this.btnSend.Location = new System.Drawing.Point(464, 130);
            this.btnSend.Size = new System.Drawing.Size(80, 28);
            this.btnSend.Click += new System.EventHandler(this.button4_Click);

            // ---- btnRemoteDesktop 大按钮 ----
            brandBtn(this.btnRemoteDesktop, brand, System.Drawing.Color.White, fBtnBig);
            this.btnRemoteDesktop.Text = "🖥  远程桌面";
            this.btnRemoteDesktop.Location = new System.Drawing.Point(608, 416);
            this.btnRemoteDesktop.Size = new System.Drawing.Size(176, 170);
            this.btnRemoteDesktop.Click += new System.EventHandler(this.btnRdp_Click);

            // ====================== STUN 页 ======================
            this.pageStun.Controls.Add(this.lblTitleStun);
            this.pageStun.Controls.Add(this.lblSubStun);
            this.pageStun.Controls.Add(this.btnStunSave);
            this.pageStun.Controls.Add(this.btnStunDel);
            this.pageStun.Controls.Add(this.dataGridView1);

            this.lblTitleStun.Text = "STUN 服务器";
            this.lblTitleStun.Font = fTitle;
            this.lblTitleStun.ForeColor = textP;
            this.lblTitleStun.Location = new System.Drawing.Point(32, 24);
            this.lblTitleStun.Size = new System.Drawing.Size(420, 32);

            this.lblSubStun.Text = "用于 NAT 穿透 —— 公网 IP 探测所依赖的服务器列表";
            this.lblSubStun.Font = fSmall;
            this.lblSubStun.ForeColor = textS;
            this.lblSubStun.Location = new System.Drawing.Point(32, 60);
            this.lblSubStun.Size = new System.Drawing.Size(700, 24);

            brandBtn(this.btnStunSave, brand, System.Drawing.Color.White, fBtnBig);
            this.btnStunSave.Text = "保存列表";
            this.btnStunSave.Location = new System.Drawing.Point(32, 108);
            this.btnStunSave.Size = new System.Drawing.Size(140, 36);
            this.btnStunSave.Click += new System.EventHandler(this.button7_Click);

            brandBtn(this.btnStunDel, System.Drawing.Color.FromArgb(243, 244, 246), textP, fBtnBig);
            this.btnStunDel.Text = "删除选中";
            this.btnStunDel.Location = new System.Drawing.Point(180, 108);
            this.btnStunDel.Size = new System.Drawing.Size(140, 36);
            this.btnStunDel.Click += new System.EventHandler(this.button6_Click);

            this.dataGridView1.BackgroundColor = bgCard;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Server, this.Port });
            this.dataGridView1.Location = new System.Drawing.Point(32, 160);
            this.dataGridView1.Size = new System.Drawing.Size(752, 360);
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Font = fBody;
            this.dataGridView1.TabIndex = 0;

            this.Server.HeaderText = "STUN 服务器";
            this.Server.Name = "Server";
            this.Server.Width = 170;
            this.Port.HeaderText = "端口";
            this.Port.Name = "Port";

            // ====================== 桌面设置页 ======================
            this.pageDesktop.Controls.Add(this.lblTitleDesktop);
            this.pageDesktop.Controls.Add(this.lblSubDesktop);
            this.pageDesktop.Controls.Add(this.cardDOptions);
            this.pageDesktop.Controls.Add(this.cardDStats);

            this.lblTitleDesktop.Text = "桌面设置";
            this.lblTitleDesktop.Font = fTitle;
            this.lblTitleDesktop.ForeColor = textP;
            this.lblTitleDesktop.Location = new System.Drawing.Point(32, 24);
            this.lblTitleDesktop.Size = new System.Drawing.Size(420, 32);

            this.lblSubDesktop.Text = "远程桌面传输参数与实时统计";
            this.lblSubDesktop.Font = fSmall;
            this.lblSubDesktop.ForeColor = textS;
            this.lblSubDesktop.Location = new System.Drawing.Point(32, 60);
            this.lblSubDesktop.Size = new System.Drawing.Size(700, 24);

            cardStyle(this.cardDOptions);
            this.cardDOptions.Location = new System.Drawing.Point(32, 108);
            this.cardDOptions.Size = new System.Drawing.Size(370, 220);
            this.cardDOptions.Controls.Add(this.lblDstretching);
            this.cardDOptions.Controls.Add(this.checkBox1);
            this.cardDOptions.Controls.Add(this.lblSpeed);
            this.cardDOptions.Controls.Add(this.dspeed);

            this.lblDstretching.Text = "桌面缩放";
            this.lblDstretching.Font = fSection;
            this.lblDstretching.ForeColor = textP;
            this.lblDstretching.Location = new System.Drawing.Point(20, 20);
            this.lblDstretching.Size = new System.Drawing.Size(300, 24);

            this.checkBox1.AutoSize = false;
            this.checkBox1.Text = "自适应缩放 (Stretch)";
            this.checkBox1.Font = fBody;
            this.checkBox1.ForeColor = textP;
            this.checkBox1.Location = new System.Drawing.Point(20, 52);
            this.checkBox1.Size = new System.Drawing.Size(330, 32);
            this.checkBox1.Enabled = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);

            this.lblSpeed.Text = "传输速度 (KB/s)";
            this.lblSpeed.Font = fSection;
            this.lblSpeed.ForeColor = textP;
            this.lblSpeed.Location = new System.Drawing.Point(20, 100);
            this.lblSpeed.Size = new System.Drawing.Size(300, 24);

            this.dspeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dspeed.Items.AddRange(new object[] { "30", "50", "100", "200", "400", "800", "1000" });
            this.dspeed.Enabled = false;
            this.dspeed.Font = fBody;
            this.dspeed.Location = new System.Drawing.Point(20, 134);
            this.dspeed.Size = new System.Drawing.Size(330, 30);
            this.dspeed.SelectedIndexChanged += new System.EventHandler(this.dspeed_SelectedIndexChanged);

            cardStyle(this.cardDStats);
            this.cardDStats.Location = new System.Drawing.Point(414, 108);
            this.cardDStats.Size = new System.Drawing.Size(370, 220);
            this.cardDStats.Controls.Add(this.lblStatsTitle);
            this.cardDStats.Controls.Add(this.lblDelayCaption);
            this.cardDStats.Controls.Add(this.lblDelayValue);
            this.cardDStats.Controls.Add(this.lblFpsCaption);
            this.cardDStats.Controls.Add(this.lblFpsValue);

            this.lblStatsTitle.Text = "实时统计";
            this.lblStatsTitle.Font = fSection;
            this.lblStatsTitle.ForeColor = textP;
            this.lblStatsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblStatsTitle.Size = new System.Drawing.Size(300, 24);

            this.lblDelayCaption.Text = "延迟";
            this.lblDelayCaption.Font = fBody;
            this.lblDelayCaption.ForeColor = textS;
            this.lblDelayCaption.Location = new System.Drawing.Point(20, 70);
            this.lblDelayCaption.Size = new System.Drawing.Size(80, 30);

            this.lblDelayValue.Text = "-- ms";
            this.lblDelayValue.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblDelayValue.ForeColor = brand;
            this.lblDelayValue.Location = new System.Drawing.Point(110, 64);
            this.lblDelayValue.Size = new System.Drawing.Size(240, 36);

            this.lblFpsCaption.Text = "帧率";
            this.lblFpsCaption.Font = fBody;
            this.lblFpsCaption.ForeColor = textS;
            this.lblFpsCaption.Location = new System.Drawing.Point(20, 130);
            this.lblFpsCaption.Size = new System.Drawing.Size(80, 30);

            this.lblFpsValue.Text = "-- fps";
            this.lblFpsValue.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblFpsValue.ForeColor = green;
            this.lblFpsValue.Location = new System.Drawing.Point(110, 124);
            this.lblFpsValue.Size = new System.Drawing.Size(240, 36);

            // ====================== 关于页 ======================
            this.pageAbout.Controls.Add(this.lblTitleAbout);
            this.pageAbout.Controls.Add(this.lblSubAbout);
            this.pageAbout.Controls.Add(this.pictureBox1);
            this.pageAbout.Controls.Add(this.richTextBox1);

            this.lblTitleAbout.Text = "关于 LDesktop";
            this.lblTitleAbout.Font = fTitle;
            this.lblTitleAbout.ForeColor = textP;
            this.lblTitleAbout.Location = new System.Drawing.Point(32, 24);
            this.lblTitleAbout.Size = new System.Drawing.Size(420, 32);

            this.lblSubAbout.Text = "基于开源 p2p 项目汉化优化版";
            this.lblSubAbout.Font = fSmall;
            this.lblSubAbout.ForeColor = textS;
            this.lblSubAbout.Location = new System.Drawing.Point(32, 60);
            this.lblSubAbout.Size = new System.Drawing.Size(700, 24);

            this.pictureBox1.Image = global::p2p.Properties.Resources.p2p1;
            this.pictureBox1.Location = new System.Drawing.Point(60, 130);
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabStop = false;

            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.BackColor = bgPage;
            this.richTextBox1.Font = fBody;
            this.richTextBox1.ForeColor = textP;
            this.richTextBox1.Location = new System.Drawing.Point(180, 130);
            this.richTextBox1.Size = new System.Drawing.Size(500, 200);
            this.richTextBox1.Text = "LDesktop 远程协助\n\n一个基于 P2P 直连的远程控制工具，支持聊天与远程桌面。\n\n" +
                "源代码：https://github.com/miroslavpejic85/p2p\n" +
                "汉化优化：https://github.com/luoda2023/LDesktop\n";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);

            // ====================== 旧引用别名 ======================
            // 让 Form1.cs 原有事件代码无障碍引用
            this.txtmyHost    = this.txtWanIp;
            this.txtLocalHost = this.txtLanIp;
            this.txtRemoteIP = this.txtRemoteIp;
            this.r_chat       = this.rtbChat;
            this.txtnsg       = this.txtChatInput;
            this.button1      = this.btnCopyWan;
            this.button2      = this.btnConnect;
            this.button3      = this.btnCopyLan;
            this.button4      = this.btnSend;
            this.button6      = this.btnStunDel;
            this.button7      = this.btnStunSave;
            this.btn_paste    = this.btnPasteRemote;
            this.btnRdp       = this.btnRemoteDesktop;
            this.label4       = this.lblConnStatus;
            this.lblFPS       = this.lblFpsValue;
            this.lblkb        = this.lblDelayValue;

            // 旧 label 控件留空，不引用
            this.label3.Text = ""; this.label5.Text = ""; this.label13.Text = "";
            this.label14.Text = ""; this.label15.Text = "";

            // ====================== Form1 ======================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 620);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNav);
            this.Font = fBody;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = bgPage;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1040, 660);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LDesktop 远程协助";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cardDStats.ResumeLayout(false);
            this.cardDOptions.ResumeLayout(false);
            this.cardChat.ResumeLayout(false);
            this.cardRemote.ResumeLayout(false);
            this.cardLan.ResumeLayout(false);
            this.cardWan.ResumeLayout(false);
            this.pnlUpnpStatus.ResumeLayout(false);
            this.pageAbout.ResumeLayout(false);
            this.pageDesktop.ResumeLayout(false);
            this.pageStun.ResumeLayout(false);
            this.pageConnect.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // 导航
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button navConnect;
        private System.Windows.Forms.Button navStun;
        private System.Windows.Forms.Button navDesktop;
        private System.Windows.Forms.Button navAbout;
        private System.Windows.Forms.Panel pnlContent;

        // 连接页
        private System.Windows.Forms.Panel pageConnect;
        private System.Windows.Forms.Label lblTitleConnect;
        private System.Windows.Forms.Label lblSubConnect;
        private System.Windows.Forms.Panel pnlUpnpStatus;
        private System.Windows.Forms.Label lblUpnpIcon;
        private System.Windows.Forms.Label lblUpnpText;
        private System.Windows.Forms.Panel cardWan;
        private System.Windows.Forms.Label lblWanTitle;
        private System.Windows.Forms.TextBox txtWanIp;
        private System.Windows.Forms.Button btnCopyWan;
        private System.Windows.Forms.Panel cardLan;
        private System.Windows.Forms.Label lblLanTitle;
        private System.Windows.Forms.TextBox txtLanIp;
        private System.Windows.Forms.Button btnCopyLan;
        private System.Windows.Forms.Panel cardRemote;
        private System.Windows.Forms.Label lblRemoteTitle;
        private System.Windows.Forms.TextBox txtRemoteIp;
        private System.Windows.Forms.Button btnPasteRemote;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.Panel cardChat;
        private System.Windows.Forms.Label lblChatTitle;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtChatInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnRemoteDesktop;

        // STUN 页
        private System.Windows.Forms.Panel pageStun;
        private System.Windows.Forms.Label lblTitleStun;
        private System.Windows.Forms.Label lblSubStun;
        private System.Windows.Forms.Button btnStunSave;
        private System.Windows.Forms.Button btnStunDel;

        // 桌面设置页
        private System.Windows.Forms.Panel pageDesktop;
        private System.Windows.Forms.Label lblTitleDesktop;
        private System.Windows.Forms.Label lblSubDesktop;
        private System.Windows.Forms.Panel cardDOptions;
        private System.Windows.Forms.Label lblDstretching;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ComboBox dspeed;
        private System.Windows.Forms.Panel cardDStats;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblDelayCaption;
        private System.Windows.Forms.Label lblDelayValue;
        private System.Windows.Forms.Label lblFpsCaption;
        private System.Windows.Forms.Label lblFpsValue;

        // 关于页
        private System.Windows.Forms.Panel pageAbout;
        private System.Window.Forms.Label lblTitleAbout;
        private System.Windows.Forms.Label lblSubAbout;

        // 旧字段引用
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtmyHost;
        private System.Windows.Forms.TextBox txtLocalHost;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.RichTextBox r_chat;
        private System.Windows.Forms.TextBox txtnsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btnRdp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblkb;
    }
}
