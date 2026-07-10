namespace p2pconn
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            var brand = System.Drawing.Color.FromArgb(99, 102, 241);
            var brandDark = System.Drawing.Color.FromArgb(79, 70, 229);
            var bgPage = System.Drawing.Color.FromArgb(248, 250, 252);
            var bgCard = System.Drawing.Color.White;
            var textP = System.Drawing.Color.FromArgb(15, 23, 42);
            var textS = System.Drawing.Color.FromArgb(100, 116, 139);
            var border = System.Drawing.Color.FromArgb(226, 232, 240);
            var green = System.Drawing.Color.FromArgb(34, 197, 94);
            var greenBg = System.Drawing.Color.FromArgb(220, 252, 231);
            var amber = System.Drawing.Color.FromArgb(234, 179, 8);
            var amberBg = System.Drawing.Color.FromArgb(254, 249, 195);
            var red = System.Drawing.Color.FromArgb(239, 68, 68);

            var fTitle = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            var fSection = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            var fBody = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            var fSmall = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            var fMono = new System.Drawing.Font("Consolas", 11F);
            var fHuge = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);

            // 容器
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlPages = new System.Windows.Forms.Panel();
            this.pgConnect = new System.Windows.Forms.Panel();
            this.cardRemote = new System.Windows.Forms.Panel();
            this.lblRemoteTitle = new System.Windows.Forms.Label();
            this.txtRemote = new System.Windows.Forms.TextBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cardWan = new System.Windows.Forms.Panel();
            this.lblWanTitle = new System.Windows.Forms.Label();
            this.txtWan = new System.Windows.Forms.TextBox();
            this.btnCopyWan = new System.Windows.Forms.Button();
            this.cardLan = new System.Windows.Forms.Panel();
            this.lblLanTitle = new System.Windows.Forms.Label();
            this.txtLan = new System.Windows.Forms.TextBox();
            this.btnCopyLan = new System.Windows.Forms.Button();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.lblChatTitle = new System.Windows.Forms.Label();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDesktop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFps = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();

            // 旧引用别名
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtmyHost = this.txtWan;
            this.txtLocalHost = this.txtLan;
            this.txtRemoteIP = this.txtRemote;
            this.r_chat = this.rtbChat;
            this.txtnsg = this.txtInput;
            this.button1 = this.btnCopyWan;
            this.button2 = this.btnConnect;
            this.button3 = this.btnCopyLan;
            this.button4 = this.btnSend;
            this.btn_paste = this.btnPaste;
            this.btnRdp = this.btnDesktop;
            this.lblFPS = this.lblFps;
            this.lblkb = this.lblDelay;

            // 浮动占位控件（兼容原有事件）
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dspeed = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlPages.SuspendLayout();
            this.pgConnect.SuspendLayout();
            this.cardRemote.SuspendLayout();
            this.cardWan.SuspendLayout();
            this.cardLan.SuspendLayout();
            this.pnlChat.SuspendLayout();
            this.SuspendLayout();

            // 工具函数
            System.Action<System.Windows.Forms.Button, System.Drawing.Color, System.Drawing.Color> flatBtn = (b, bg, fg) =>
            {
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = bg;
                b.ForeColor = fg;
                b.Cursor = System.Windows.Forms.Cursors.Hand;
                b.UseVisualStyleBackColor = false;
            };

            // ========= pnlLeft 左侧导航 =========
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 56;
            this.pnlLeft.Controls.Add(this.lblBrand);

            this.lblBrand.Text = "L";
            this.lblBrand.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = brand;
            this.lblBrand.Location = new System.Drawing.Point(4, 12);
            this.lblBrand.Size = new System.Drawing.Size(48, 48);
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ========= pnlPages =========
            this.pnlPages.BackColor = bgPage;
            this.pnlPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPages.Controls.Add(this.pgConnect);

            // ========= pgConnect =========
            this.pgConnect.BackColor = bgPage;
            this.pgConnect.Controls.Add(this.cardWan);
            this.pgConnect.Controls.Add(this.cardLan);
            this.pgConnect.Controls.Add(this.cardRemote);
            this.pgConnect.Controls.Add(this.pnlChat);
            this.pgConnect.Controls.Add(this.btnDesktop);
            this.pgConnect.Controls.Add(this.lblStatus);
            this.pgConnect.Controls.Add(this.lblFps);
            this.pgConnect.Controls.Add(this.lblDelay);
            this.pgConnect.Padding = new System.Windows.Forms.Padding(28, 20, 28, 16);

            // ---- cardWan ----
            this.cardWan.BackColor = bgCard;
            this.cardWan.Location = new System.Drawing.Point(28, 20);
            this.cardWan.Size = new System.Drawing.Size(360, 90);
            this.cardWan.Controls.Add(this.lblWanTitle);
            this.cardWan.Controls.Add(this.txtWan);
            this.cardWan.Controls.Add(this.btnCopyWan);

            this.lblWanTitle.Text = "外网 IP";
            this.lblWanTitle.Font = fSection;
            this.lblWanTitle.ForeColor = textP;
            this.lblWanTitle.Location = new System.Drawing.Point(16, 14);
            this.lblWanTitle.Size = new System.Drawing.Size(200, 24);

            this.txtWan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWan.BackColor = bgPage;
            this.txtWan.Font = fMono;
            this.txtWan.ForeColor = textP;
            this.txtWan.Location = new System.Drawing.Point(16, 44);
            this.txtWan.Size = new System.Drawing.Size(280, 28);
            this.txtWan.ReadOnly = true;

            flatBtn(this.btnCopyWan, brand, System.Drawing.Color.White);
            this.btnCopyWan.Font = fBody;
            this.btnCopyWan.Text = "复制";
            this.btnCopyWan.Location = new System.Drawing.Point(304, 44);
            this.btnCopyWan.Size = new System.Drawing.Size(48, 28);
            this.btnCopyWan.Click += new System.EventHandler(this.button1_Click);

            // ---- cardLan ----
            this.cardLan.BackColor = bgCard;
            this.cardLan.Location = new System.Drawing.Point(408, 20);
            this.cardLan.Size = new System.Drawing.Size(360, 90);
            this.cardLan.Controls.Add(this.lblLanTitle);
            this.cardLan.Controls.Add(this.txtLan);
            this.cardLan.Controls.Add(this.btnCopyLan);

            this.lblLanTitle.Text = "内网 IP";
            this.lblLanTitle.Font = fSection;
            this.lblLanTitle.ForeColor = textP;
            this.lblLanTitle.Location = new System.Drawing.Point(16, 14);
            this.lblLanTitle.Size = new System.Drawing.Size(200, 24);

            this.txtLan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLan.BackColor = bgPage;
            this.txtLan.Font = fMono;
            this.txtLan.ForeColor = textP;
            this.txtLan.Location = new System.Drawing.Point(16, 44);
            this.txtLan.Size = new System.Drawing.Size(280, 28);
            this.txtLan.ReadOnly = true;

            flatBtn(this.btnCopyLan, brand, System.Drawing.Color.White);
            this.btnCopyLan.Font = fBody;
            this.btnCopyLan.Text = "复制";
            this.btnCopyLan.Location = new System.Drawing.Point(304, 44);
            this.btnCopyLan.Size = new System.Drawing.Size(48, 28);
            this.btnCopyLan.Click += new System.EventHandler(this.button3_Click);

            // ---- cardRemote ----
            this.cardRemote.BackColor = bgCard;
            this.cardRemote.Location = new System.Drawing.Point(28, 124);
            this.cardRemote.Size = new System.Drawing.Size(740, 100);
            this.cardRemote.Controls.Add(this.lblRemoteTitle);
            this.cardRemote.Controls.Add(this.txtRemote);
            this.cardRemote.Controls.Add(this.btnPaste);
            this.cardRemote.Controls.Add(this.btnConnect);

            this.lblRemoteTitle.Text = "远端地址";
            this.lblRemoteTitle.Font = fSection;
            this.lblRemoteTitle.ForeColor = textP;
            this.lblRemoteTitle.Location = new System.Drawing.Point(16, 14);
            this.lblRemoteTitle.Size = new System.Drawing.Size(200, 24);

            this.txtRemote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemote.BackColor = bgPage;
            this.txtRemote.Font = fMono;
            this.txtRemote.ForeColor = textP;
            this.txtRemote.Location = new System.Drawing.Point(16, 48);
            this.txtRemote.Size = new System.Drawing.Size(540, 28);

            flatBtn(this.btnPaste, System.Drawing.Color.FromArgb(243, 244, 246), textP);
            this.btnPaste.Font = fBody;
            this.btnPaste.Text = "粘贴";
            this.btnPaste.Location = new System.Drawing.Point(564, 48);
            this.btnPaste.Size = new System.Drawing.Size(64, 28);
            this.btnPaste.Click += new System.EventHandler(this.btn_paste_Click);

            flatBtn(this.btnConnect, green, System.Drawing.Color.White);
            this.btnConnect.Font = fHuge;
            this.btnConnect.Text = "连接";
            this.btnConnect.Location = new System.Drawing.Point(636, 46);
            this.btnConnect.Size = new System.Drawing.Size(96, 32);
            this.btnConnect.Click += new System.EventHandler(this.button2_Click);

            // ---- pnlChat ----
            this.pnlChat.BackColor = bgCard;
            this.pnlChat.Location = new System.Drawing.Point(28, 240);
            this.pnlChat.Size = new System.Drawing.Size(560, 220);
            this.pnlChat.Controls.Add(this.lblChatTitle);
            this.pnlChat.Controls.Add(this.rtbChat);
            this.pnlChat.Controls.Add(this.txtInput);
            this.pnlChat.Controls.Add(this.btnSend);

            this.lblChatTitle.Text = "💬 聊天";
            this.lblChatTitle.Font = fSection;
            this.lblChatTitle.ForeColor = textP;
            this.lblChatTitle.Location = new System.Drawing.Point(16, 14);
            this.lblChatTitle.Size = new System.Drawing.Size(200, 24);

            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbChat.BackColor = bgPage;
            this.rtbChat.Font = fBody;
            this.rtbChat.ForeColor = textP;
            this.rtbChat.Location = new System.Drawing.Point(16, 44);
            this.rtbChat.Size = new System.Drawing.Size(528, 120);
            this.rtbChat.ReadOnly = true;
            this.rtbChat.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.r_chat_LinkClicked);
            this.rtbChat.TextChanged += new System.EventHandler(this.r_chat_TextChanged);

            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.BackColor = bgPage;
            this.txtInput.Font = fBody;
            this.txtInput.ForeColor = textP;
            this.txtInput.Location = new System.Drawing.Point(16, 176);
            this.txtInput.Size = new System.Drawing.Size(444, 28);

            flatBtn(this.btnSend, brand, System.Drawing.Color.White);
            this.btnSend.Font = fHuge;
            this.btnSend.Text = "发送";
            this.btnSend.Location = new System.Drawing.Point(468, 176);
            this.btnSend.Size = new System.Drawing.Size(76, 28);
            this.btnSend.Click += new System.EventHandler(this.button4_Click);

            // ---- btnDesktop ----
            flatBtn(this.btnDesktop, brandDark, System.Drawing.Color.White);
            this.btnDesktop.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnDesktop.Text = "🖥  远程桌面";
            this.btnDesktop.Location = new System.Drawing.Point(600, 240);
            this.btnDesktop.Size = new System.Drawing.Size(168, 220);
            this.btnDesktop.Click += new System.EventHandler(this.btnRdp_Click);

            // ---- 状态标签 ----
            this.lblStatus.Text = "● 就绪";
            this.lblStatus.Font = fSmall;
            this.lblStatus.ForeColor = textS;
            this.lblStatus.Location = new System.Drawing.Point(28, 476);
            this.lblStatus.Size = new System.Drawing.Size(300, 24);

            this.lblDelay.Text = "延迟: --";
            this.lblDelay.Font = fSmall;
            this.lblDelay.ForeColor = textS;
            this.lblDelay.Location = new System.Drawing.Point(340, 476);
            this.lblDelay.Size = new System.Drawing.Size(120, 24);

            this.lblFps.Text = "帧率: --";
            this.lblFps.Font = fSmall;
            this.lblFps.ForeColor = textS;
            this.lblFps.Location = new System.Drawing.Point(480, 476);
            this.lblFps.Size = new System.Drawing.Size(120, 24);

            // 浮动（隐藏控件）
            this.dataGridView1.Location = new System.Drawing.Point(-1000, -1000);
            this.dataGridView1.Size = new System.Drawing.Size(100, 40);
            this.button6.Location = new System.Drawing.Point(-1000, -1000);
            this.button7.Location = new System.Drawing.Point(-1000, -1000);
            this.dspeed.Location = new System.Drawing.Point(-1000, -1000);
            this.checkBox1.Location = new System.Drawing.Point(-1000, -1000);
            this.richTextBox1.Location = new System.Drawing.Point(-1000, -1000);
            this.pictureBox1.Location = new System.Drawing.Point(-1000, -1000);

            // ========= Form1 =========
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.DoubleBuffered = true;
            this.ClientSize = new System.Drawing.Size(820, 540);
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dspeed);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = fBody;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.BackColor = bgPage;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(836, 580);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LDesktop 远程协助";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChat.ResumeLayout(false);
            this.cardLan.ResumeLayout(false);
            this.cardWan.ResumeLayout(false);
            this.cardRemote.ResumeLayout(false);
            this.pgConnect.ResumeLayout(false);
            this.pnlPages.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlPages;
        private System.Windows.Forms.Panel pgConnect;
        private System.Windows.Forms.Panel cardWan;
        private System.Windows.Forms.Label lblWanTitle;
        private System.Windows.Forms.TextBox txtWan;
        private System.Windows.Forms.Button btnCopyWan;
        private System.Windows.Forms.Panel cardLan;
        private System.Windows.Forms.Label lblLanTitle;
        private System.Windows.Forms.TextBox txtLan;
        private System.Windows.Forms.Button btnCopyLan;
        private System.Windows.Forms.Panel cardRemote;
        private System.Windows.Forms.Label lblRemoteTitle;
        private System.Windows.Forms.TextBox txtRemote;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFps;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Panel pnlChat;
        private System.Windows.Forms.Label lblChatTitle;
        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDesktop;

        // 旧引用（别名）
        private System.Windows.Forms.TextBox txtmyHost;
        private System.Windows.Forms.TextBox txtLocalHost;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.RichTextBox r_chat;
        private System.Windows.Forms.TextBox txtnsg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btnRdp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox dspeed;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFPS;
        private System.Windows.Forms.Label lblkb;
    }
}
