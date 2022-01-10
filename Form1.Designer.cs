namespace Pocket48Tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.quickFillButton = new System.Windows.Forms.Button();
            this.lastliveIdLabel = new System.Windows.Forms.Label();
            this.getLiveIdText = new System.Windows.Forms.TextBox();
            this.JsonResponseText = new System.Windows.Forms.TextBox();
            this.checkLiveListButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.downloadDanmukuButton = new System.Windows.Forms.Button();
            this.commandLabel = new System.Windows.Forms.Label();
            this.danmukuLabel = new System.Windows.Forms.Label();
            this.streamLabel = new System.Windows.Forms.Label();
            this.downloadVideoButton = new System.Windows.Forms.Button();
            this.commandText = new System.Windows.Forms.TextBox();
            this.danmukuText = new System.Windows.Forms.TextBox();
            this.playStreamText = new System.Windows.Forms.TextBox();
            this.checkLiveOneButton = new System.Windows.Forms.Button();
            this.liveIdText = new System.Windows.Forms.TextBox();
            this.liveIdLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.userNameVerifyRadioButton = new System.Windows.Forms.RadioButton();
            this.TokenVerifyRadioButton = new System.Windows.Forms.RadioButton();
            this.pocketVerifyComboBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TokenText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PAText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.blackListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.checkBlackListButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pocketVerifyComboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 411);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.quickFillButton);
            this.tabPage1.Controls.Add(this.lastliveIdLabel);
            this.tabPage1.Controls.Add(this.getLiveIdText);
            this.tabPage1.Controls.Add(this.JsonResponseText);
            this.tabPage1.Controls.Add(this.checkLiveListButton);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.userIdLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询直播数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // quickFillButton
            // 
            this.quickFillButton.Location = new System.Drawing.Point(359, 259);
            this.quickFillButton.Name = "quickFillButton";
            this.quickFillButton.Size = new System.Drawing.Size(117, 31);
            this.quickFillButton.TabIndex = 13;
            this.quickFillButton.Text = "快速填充(&F)";
            this.quickFillButton.UseVisualStyleBackColor = true;
            this.quickFillButton.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // lastliveIdLabel
            // 
            this.lastliveIdLabel.AutoSize = true;
            this.lastliveIdLabel.Location = new System.Drawing.Point(47, 267);
            this.lastliveIdLabel.Name = "lastliveIdLabel";
            this.lastliveIdLabel.Size = new System.Drawing.Size(127, 20);
            this.lastliveIdLabel.TabIndex = 12;
            this.lastliveIdLabel.Text = "最近一次的liveId:";
            // 
            // getLiveIdText
            // 
            this.getLiveIdText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getLiveIdText.Location = new System.Drawing.Point(180, 261);
            this.getLiveIdText.Name = "getLiveIdText";
            this.getLiveIdText.Size = new System.Drawing.Size(173, 27);
            this.getLiveIdText.TabIndex = 11;
            // 
            // JsonResponseText
            // 
            this.JsonResponseText.Location = new System.Drawing.Point(47, 67);
            this.JsonResponseText.Multiline = true;
            this.JsonResponseText.Name = "JsonResponseText";
            this.JsonResponseText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.JsonResponseText.Size = new System.Drawing.Size(429, 183);
            this.JsonResponseText.TabIndex = 10;
            // 
            // checkLiveListButton
            // 
            this.checkLiveListButton.Location = new System.Drawing.Point(276, 20);
            this.checkLiveListButton.Name = "checkLiveListButton";
            this.checkLiveListButton.Size = new System.Drawing.Size(94, 37);
            this.checkLiveListButton.TabIndex = 9;
            this.checkLiveListButton.Text = "查询(&C)";
            this.checkLiveListButton.UseVisualStyleBackColor = true;
            this.checkLiveListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "陈琳（6431）",
            "谢天依（6743）",
            "熊心瑶（327574）",
            "毛译晗（614731）",
            "王睿琦（530390）"});
            this.comboBox1.Location = new System.Drawing.Point(106, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(47, 29);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(69, 20);
            this.userIdLabel.TabIndex = 7;
            this.userIdLabel.Text = "成员ID：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.downloadDanmukuButton);
            this.tabPage2.Controls.Add(this.commandLabel);
            this.tabPage2.Controls.Add(this.danmukuLabel);
            this.tabPage2.Controls.Add(this.streamLabel);
            this.tabPage2.Controls.Add(this.downloadVideoButton);
            this.tabPage2.Controls.Add(this.commandText);
            this.tabPage2.Controls.Add(this.danmukuText);
            this.tabPage2.Controls.Add(this.playStreamText);
            this.tabPage2.Controls.Add(this.checkLiveOneButton);
            this.tabPage2.Controls.Add(this.liveIdText);
            this.tabPage2.Controls.Add(this.liveIdLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "录播下载";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // downloadDanmukuButton
            // 
            this.downloadDanmukuButton.Location = new System.Drawing.Point(353, 288);
            this.downloadDanmukuButton.Name = "downloadDanmukuButton";
            this.downloadDanmukuButton.Size = new System.Drawing.Size(148, 40);
            this.downloadDanmukuButton.TabIndex = 18;
            this.downloadDanmukuButton.Text = "下载弹幕(&M)";
            this.downloadDanmukuButton.UseVisualStyleBackColor = true;
            this.downloadDanmukuButton.Visible = false;
            this.downloadDanmukuButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(35, 234);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(327, 20);
            this.commandLabel.TabIndex = 17;
            this.commandLabel.Text = "下载命令（基于Windows Terminal+ffmpeg）";
            this.commandLabel.Visible = false;
            // 
            // danmukuLabel
            // 
            this.danmukuLabel.AutoSize = true;
            this.danmukuLabel.Location = new System.Drawing.Point(35, 160);
            this.danmukuLabel.Name = "danmukuLabel";
            this.danmukuLabel.Size = new System.Drawing.Size(99, 20);
            this.danmukuLabel.TabIndex = 16;
            this.danmukuLabel.Text = "弹幕流地址：";
            this.danmukuLabel.Visible = false;
            // 
            // streamLabel
            // 
            this.streamLabel.AutoSize = true;
            this.streamLabel.Location = new System.Drawing.Point(35, 63);
            this.streamLabel.Name = "streamLabel";
            this.streamLabel.Size = new System.Drawing.Size(99, 20);
            this.streamLabel.TabIndex = 15;
            this.streamLabel.Text = "直播流地址：";
            this.streamLabel.Visible = false;
            // 
            // downloadVideoButton
            // 
            this.downloadVideoButton.Location = new System.Drawing.Point(35, 288);
            this.downloadVideoButton.Name = "downloadVideoButton";
            this.downloadVideoButton.Size = new System.Drawing.Size(145, 40);
            this.downloadVideoButton.TabIndex = 14;
            this.downloadVideoButton.Text = "下载视频(&D)";
            this.downloadVideoButton.UseVisualStyleBackColor = true;
            this.downloadVideoButton.Visible = false;
            this.downloadVideoButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // commandText
            // 
            this.commandText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commandText.Location = new System.Drawing.Point(35, 257);
            this.commandText.Name = "commandText";
            this.commandText.ReadOnly = true;
            this.commandText.Size = new System.Drawing.Size(466, 25);
            this.commandText.TabIndex = 13;
            this.commandText.Visible = false;
            this.commandText.DoubleClick += new System.EventHandler(this.commandText_DoubleClick);
            // 
            // danmukuText
            // 
            this.danmukuText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.danmukuText.Location = new System.Drawing.Point(35, 183);
            this.danmukuText.Multiline = true;
            this.danmukuText.Name = "danmukuText";
            this.danmukuText.ReadOnly = true;
            this.danmukuText.Size = new System.Drawing.Size(466, 48);
            this.danmukuText.TabIndex = 12;
            this.danmukuText.Visible = false;
            this.danmukuText.DoubleClick += new System.EventHandler(this.danmukuText_DoubleClick);
            // 
            // playStreamText
            // 
            this.playStreamText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playStreamText.Location = new System.Drawing.Point(35, 86);
            this.playStreamText.Multiline = true;
            this.playStreamText.Name = "playStreamText";
            this.playStreamText.ReadOnly = true;
            this.playStreamText.Size = new System.Drawing.Size(466, 71);
            this.playStreamText.TabIndex = 11;
            this.playStreamText.Visible = false;
            this.playStreamText.DoubleClick += new System.EventHandler(this.playStreamText_DoubleClick);
            // 
            // checkLiveOneButton
            // 
            this.checkLiveOneButton.Location = new System.Drawing.Point(324, 20);
            this.checkLiveOneButton.Name = "checkLiveOneButton";
            this.checkLiveOneButton.Size = new System.Drawing.Size(114, 38);
            this.checkLiveOneButton.TabIndex = 2;
            this.checkLiveOneButton.Text = "获取信息(&G)";
            this.checkLiveOneButton.UseVisualStyleBackColor = true;
            this.checkLiveOneButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // liveIdText
            // 
            this.liveIdText.Location = new System.Drawing.Point(94, 26);
            this.liveIdText.Name = "liveIdText";
            this.liveIdText.Size = new System.Drawing.Size(224, 27);
            this.liveIdText.TabIndex = 1;
            // 
            // liveIdLabel
            // 
            this.liveIdLabel.AutoSize = true;
            this.liveIdLabel.Location = new System.Drawing.Point(35, 29);
            this.liveIdLabel.Name = "liveIdLabel";
            this.liveIdLabel.Size = new System.Drawing.Size(63, 20);
            this.liveIdLabel.TabIndex = 0;
            this.liveIdLabel.Text = "liveId：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.userNameVerifyRadioButton);
            this.tabPage3.Controls.Add(this.TokenVerifyRadioButton);
            this.tabPage3.Controls.Add(this.pocketVerifyComboBox);
            this.tabPage3.Controls.Add(this.blackListView);
            this.tabPage3.Controls.Add(this.checkBlackListButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(560, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "拉黑查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // userNameVerifyRadioButton
            // 
            this.userNameVerifyRadioButton.AutoSize = true;
            this.userNameVerifyRadioButton.Location = new System.Drawing.Point(183, 18);
            this.userNameVerifyRadioButton.Name = "userNameVerifyRadioButton";
            this.userNameVerifyRadioButton.Size = new System.Drawing.Size(135, 24);
            this.userNameVerifyRadioButton.TabIndex = 8;
            this.userNameVerifyRadioButton.Text = "用户名密码验证";
            this.userNameVerifyRadioButton.UseVisualStyleBackColor = true;
            this.userNameVerifyRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TokenVerifyRadioButton
            // 
            this.TokenVerifyRadioButton.AutoSize = true;
            this.TokenVerifyRadioButton.Checked = true;
            this.TokenVerifyRadioButton.Location = new System.Drawing.Point(52, 18);
            this.TokenVerifyRadioButton.Name = "TokenVerifyRadioButton";
            this.TokenVerifyRadioButton.Size = new System.Drawing.Size(105, 24);
            this.TokenVerifyRadioButton.TabIndex = 7;
            this.TokenVerifyRadioButton.TabStop = true;
            this.TokenVerifyRadioButton.Text = "Token验证";
            this.TokenVerifyRadioButton.UseVisualStyleBackColor = true;
            this.TokenVerifyRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pocketVerifyComboBox
            // 
            this.pocketVerifyComboBox.Controls.Add(this.label6);
            this.pocketVerifyComboBox.Controls.Add(this.pictureBox1);
            this.pocketVerifyComboBox.Controls.Add(this.TokenText);
            this.pocketVerifyComboBox.Controls.Add(this.label4);
            this.pocketVerifyComboBox.Controls.Add(this.PAText);
            this.pocketVerifyComboBox.Controls.Add(this.label3);
            this.pocketVerifyComboBox.Location = new System.Drawing.Point(27, 54);
            this.pocketVerifyComboBox.Name = "pocketVerifyComboBox";
            this.pocketVerifyComboBox.Size = new System.Drawing.Size(448, 121);
            this.pocketVerifyComboBox.TabIndex = 6;
            this.pocketVerifyComboBox.TabStop = false;
            this.pocketVerifyComboBox.Text = "认证";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("等距更纱黑体 SC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(183, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "点击登录口袋48";
            this.label6.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // TokenText
            // 
            this.TokenText.Location = new System.Drawing.Point(87, 69);
            this.TokenText.Name = "TokenText";
            this.TokenText.Size = new System.Drawing.Size(311, 27);
            this.TokenText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "token:";
            // 
            // PAText
            // 
            this.PAText.Location = new System.Drawing.Point(87, 34);
            this.PAText.Name = "PAText";
            this.PAText.Size = new System.Drawing.Size(311, 27);
            this.PAText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "pa:";
            // 
            // blackListView
            // 
            this.blackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.blackListView.Location = new System.Drawing.Point(27, 181);
            this.blackListView.Name = "blackListView";
            this.blackListView.Size = new System.Drawing.Size(448, 169);
            this.blackListView.TabIndex = 3;
            this.blackListView.UseCompatibleStateImageBehavior = false;
            this.blackListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "UID";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "成员名称";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "所属Team";
            this.columnHeader4.Width = 120;
            // 
            // checkBlackListButton
            // 
            this.checkBlackListButton.Location = new System.Drawing.Point(349, 12);
            this.checkBlackListButton.Name = "checkBlackListButton";
            this.checkBlackListButton.Size = new System.Drawing.Size(111, 36);
            this.checkBlackListButton.TabIndex = 2;
            this.checkBlackListButton.Text = "开始查询(&S)";
            this.checkBlackListButton.UseVisualStyleBackColor = true;
            this.checkBlackListButton.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(560, 378);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "设置";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "许可证(&L)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 231);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "录播下载";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Location = new System.Drawing.Point(232, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 65);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "终端";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(170, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "cmd";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 26);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(164, 24);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Windows Terminal";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(23, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 65);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下载格式";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(138, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 24);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "avi";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "flv";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "mp4";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "录播下载依赖 ffmpeg，如果已在系统中配置好环境变量，就无需在此单独配置，否则请配置好 ffmpeg 的文件地址";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(406, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ffmpeg 路径：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(619, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(189, 20);
            this.toolStripStatusLabel1.Text = "Pocket48Tool by Dr.Thril";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 470);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket48Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pocketVerifyComboBox.ResumeLayout(false);
            this.pocketVerifyComboBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox JsonResponseText;
        private System.Windows.Forms.Button checkLiveListButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button checkLiveOneButton;
        private System.Windows.Forms.TextBox liveIdText;
        private System.Windows.Forms.Label liveIdLabel;
        private System.Windows.Forms.TextBox playStreamText;
        private System.Windows.Forms.TextBox danmukuText;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.Button downloadVideoButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button checkBlackListButton;
        private System.Windows.Forms.TextBox getLiveIdText;
        private System.Windows.Forms.ListView blackListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton userNameVerifyRadioButton;
        private System.Windows.Forms.RadioButton TokenVerifyRadioButton;
        private System.Windows.Forms.GroupBox pocketVerifyComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TokenText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PAText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lastliveIdLabel;
        private System.Windows.Forms.Button quickFillButton;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Label danmukuLabel;
        private System.Windows.Forms.Label streamLabel;
        private System.Windows.Forms.Button downloadDanmukuButton;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
