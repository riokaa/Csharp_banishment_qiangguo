namespace Banishment {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.MainSplitter = new System.Windows.Forms.SplitContainer();
            this.MainSplitter1 = new System.Windows.Forms.SplitContainer();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPicBoxRikka = new System.Windows.Forms.PictureBox();
            this.MainBtnRun = new System.Windows.Forms.Button();
            this.MainGroupBoxController = new System.Windows.Forms.GroupBox();
            this.MainController = new System.Windows.Forms.TextBox();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.UserSplitter = new System.Windows.Forms.SplitContainer();
            this.UserSplitter1 = new System.Windows.Forms.SplitContainer();
            this.UserSplitter2 = new System.Windows.Forms.SplitContainer();
            this.UserImgHead = new System.Windows.Forms.PictureBox();
            this.UserTable = new System.Windows.Forms.TableLayoutPanel();
            this.UserLabelVipDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserLabelVipStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserLabelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTable2 = new System.Windows.Forms.TableLayoutPanel();
            this.UserBtnRegister = new System.Windows.Forms.Button();
            this.UserBtnLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserBtnChangePwd = new System.Windows.Forms.Button();
            this.UserBtnActivate = new System.Windows.Forms.Button();
            this.UserBtnGetPro = new System.Windows.Forms.Button();
            this.UserGroupBoxPro = new System.Windows.Forms.GroupBox();
            this.UserLinkLabelProDetail = new System.Windows.Forms.LinkLabel();
            this.UserPicProCloud = new System.Windows.Forms.PictureBox();
            this.tabPageAnnounce = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetCheckIcon360 = new System.Windows.Forms.CheckBox();
            this.SetCheckNoVoice = new System.Windows.Forms.CheckBox();
            this.SetBtnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetCheckAutoShutdown = new System.Windows.Forms.CheckBox();
            this.SetCheckAutoClose = new System.Windows.Forms.CheckBox();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.AboutBtnFeedback = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NotifyShow = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.SetUpdateSource = new System.Windows.Forms.ComboBox();
            this.MainTab.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).BeginInit();
            this.MainSplitter.Panel1.SuspendLayout();
            this.MainSplitter.Panel2.SuspendLayout();
            this.MainSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter1)).BeginInit();
            this.MainSplitter1.Panel2.SuspendLayout();
            this.MainSplitter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicBoxRikka)).BeginInit();
            this.MainGroupBoxController.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter)).BeginInit();
            this.UserSplitter.Panel1.SuspendLayout();
            this.UserSplitter.Panel2.SuspendLayout();
            this.UserSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter1)).BeginInit();
            this.UserSplitter1.Panel1.SuspendLayout();
            this.UserSplitter1.Panel2.SuspendLayout();
            this.UserSplitter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter2)).BeginInit();
            this.UserSplitter2.Panel1.SuspendLayout();
            this.UserSplitter2.Panel2.SuspendLayout();
            this.UserSplitter2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImgHead)).BeginInit();
            this.UserTable.SuspendLayout();
            this.UserTable2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.UserGroupBoxPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicProCloud)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabPageMain);
            this.MainTab.Controls.Add(this.tabPageUser);
            this.MainTab.Controls.Add(this.tabPageAnnounce);
            this.MainTab.Controls.Add(this.tabPageSettings);
            this.MainTab.Controls.Add(this.tabPageAbout);
            this.MainTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Multiline = true;
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(910, 645);
            this.MainTab.TabIndex = 1;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.MainSplitter);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(902, 616);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "主页";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // MainSplitter
            // 
            this.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitter.Location = new System.Drawing.Point(3, 3);
            this.MainSplitter.Name = "MainSplitter";
            this.MainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitter.Panel1
            // 
            this.MainSplitter.Panel1.Controls.Add(this.MainSplitter1);
            // 
            // MainSplitter.Panel2
            // 
            this.MainSplitter.Panel2.Controls.Add(this.MainGroupBoxController);
            this.MainSplitter.Size = new System.Drawing.Size(896, 610);
            this.MainSplitter.SplitterDistance = 426;
            this.MainSplitter.TabIndex = 4;
            // 
            // MainSplitter1
            // 
            this.MainSplitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitter1.Location = new System.Drawing.Point(0, 0);
            this.MainSplitter1.Name = "MainSplitter1";
            // 
            // MainSplitter1.Panel2
            // 
            this.MainSplitter1.Panel2.Controls.Add(this.MainProgressBar);
            this.MainSplitter1.Panel2.Controls.Add(this.MainGrid);
            this.MainSplitter1.Panel2.Controls.Add(this.MainPicBoxRikka);
            this.MainSplitter1.Panel2.Controls.Add(this.MainBtnRun);
            this.MainSplitter1.Size = new System.Drawing.Size(896, 426);
            this.MainSplitter1.SplitterDistance = 672;
            this.MainSplitter1.TabIndex = 6;
            this.MainSplitter1.TabStop = false;
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainProgressBar.Location = new System.Drawing.Point(0, 356);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(220, 23);
            this.MainProgressBar.TabIndex = 5;
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.MainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGrid.Location = new System.Drawing.Point(0, 123);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.RowTemplate.Height = 27;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MainGrid.Size = new System.Drawing.Size(220, 256);
            this.MainGrid.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "积分一览表";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "积分";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MainPicBoxRikka
            // 
            this.MainPicBoxRikka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainPicBoxRikka.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPicBoxRikka.Location = new System.Drawing.Point(0, 0);
            this.MainPicBoxRikka.Name = "MainPicBoxRikka";
            this.MainPicBoxRikka.Size = new System.Drawing.Size(220, 123);
            this.MainPicBoxRikka.TabIndex = 3;
            this.MainPicBoxRikka.TabStop = false;
            // 
            // MainBtnRun
            // 
            this.MainBtnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainBtnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainBtnRun.Location = new System.Drawing.Point(0, 379);
            this.MainBtnRun.Name = "MainBtnRun";
            this.MainBtnRun.Size = new System.Drawing.Size(220, 47);
            this.MainBtnRun.TabIndex = 2;
            this.MainBtnRun.Text = "开始执行";
            this.MainBtnRun.UseVisualStyleBackColor = true;
            this.MainBtnRun.Click += new System.EventHandler(this.MainBtnRun_Click);
            // 
            // MainGroupBoxController
            // 
            this.MainGroupBoxController.Controls.Add(this.MainController);
            this.MainGroupBoxController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGroupBoxController.Location = new System.Drawing.Point(0, 0);
            this.MainGroupBoxController.Name = "MainGroupBoxController";
            this.MainGroupBoxController.Size = new System.Drawing.Size(896, 180);
            this.MainGroupBoxController.TabIndex = 4;
            this.MainGroupBoxController.TabStop = false;
            this.MainGroupBoxController.Text = "控制台";
            // 
            // MainController
            // 
            this.MainController.AcceptsReturn = true;
            this.MainController.BackColor = System.Drawing.SystemColors.Window;
            this.MainController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainController.Location = new System.Drawing.Point(3, 21);
            this.MainController.Multiline = true;
            this.MainController.Name = "MainController";
            this.MainController.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainController.Size = new System.Drawing.Size(890, 156);
            this.MainController.TabIndex = 1;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.UserSplitter);
            this.tabPageUser.Location = new System.Drawing.Point(4, 25);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(902, 616);
            this.tabPageUser.TabIndex = 1;
            this.tabPageUser.Text = "个人中心";
            this.tabPageUser.UseVisualStyleBackColor = true;
            this.tabPageUser.Enter += new System.EventHandler(this.TabPageUser_Enter);
            // 
            // UserSplitter
            // 
            this.UserSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSplitter.Location = new System.Drawing.Point(3, 3);
            this.UserSplitter.Name = "UserSplitter";
            // 
            // UserSplitter.Panel1
            // 
            this.UserSplitter.Panel1.Controls.Add(this.UserSplitter1);
            // 
            // UserSplitter.Panel2
            // 
            this.UserSplitter.Panel2.Controls.Add(this.UserGroupBoxPro);
            this.UserSplitter.Size = new System.Drawing.Size(896, 610);
            this.UserSplitter.SplitterDistance = 298;
            this.UserSplitter.TabIndex = 0;
            // 
            // UserSplitter1
            // 
            this.UserSplitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSplitter1.Location = new System.Drawing.Point(0, 0);
            this.UserSplitter1.Name = "UserSplitter1";
            this.UserSplitter1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // UserSplitter1.Panel1
            // 
            this.UserSplitter1.Panel1.Controls.Add(this.UserSplitter2);
            // 
            // UserSplitter1.Panel2
            // 
            this.UserSplitter1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.UserSplitter1.Size = new System.Drawing.Size(298, 610);
            this.UserSplitter1.SplitterDistance = 300;
            this.UserSplitter1.TabIndex = 0;
            // 
            // UserSplitter2
            // 
            this.UserSplitter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserSplitter2.Location = new System.Drawing.Point(0, 0);
            this.UserSplitter2.Name = "UserSplitter2";
            this.UserSplitter2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // UserSplitter2.Panel1
            // 
            this.UserSplitter2.Panel1.Controls.Add(this.UserImgHead);
            // 
            // UserSplitter2.Panel2
            // 
            this.UserSplitter2.Panel2.Controls.Add(this.UserTable);
            this.UserSplitter2.Size = new System.Drawing.Size(298, 300);
            this.UserSplitter2.SplitterDistance = 150;
            this.UserSplitter2.TabIndex = 0;
            // 
            // UserImgHead
            // 
            this.UserImgHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserImgHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserImgHead.Location = new System.Drawing.Point(0, 0);
            this.UserImgHead.Name = "UserImgHead";
            this.UserImgHead.Size = new System.Drawing.Size(298, 150);
            this.UserImgHead.TabIndex = 0;
            this.UserImgHead.TabStop = false;
            // 
            // UserTable
            // 
            this.UserTable.ColumnCount = 2;
            this.UserTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.24832F));
            this.UserTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.75168F));
            this.UserTable.Controls.Add(this.UserLabelVipDate, 1, 2);
            this.UserTable.Controls.Add(this.label5, 0, 2);
            this.UserTable.Controls.Add(this.UserLabelVipStatus, 1, 1);
            this.UserTable.Controls.Add(this.label3, 0, 1);
            this.UserTable.Controls.Add(this.UserLabelUsername, 1, 0);
            this.UserTable.Controls.Add(this.label1, 0, 0);
            this.UserTable.Controls.Add(this.UserTable2, 0, 3);
            this.UserTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTable.Location = new System.Drawing.Point(0, 0);
            this.UserTable.Name = "UserTable";
            this.UserTable.RowCount = 4;
            this.UserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserTable.Size = new System.Drawing.Size(298, 146);
            this.UserTable.TabIndex = 2;
            // 
            // UserLabelVipDate
            // 
            this.UserLabelVipDate.AutoSize = true;
            this.UserLabelVipDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLabelVipDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserLabelVipDate.Location = new System.Drawing.Point(113, 72);
            this.UserLabelVipDate.Name = "UserLabelVipDate";
            this.UserLabelVipDate.Size = new System.Drawing.Size(182, 36);
            this.UserLabelVipDate.TabIndex = 5;
            this.UserLabelVipDate.Text = "可以不注册登陆";
            this.UserLabelVipDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "到期时间：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserLabelVipStatus
            // 
            this.UserLabelVipStatus.AutoSize = true;
            this.UserLabelVipStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLabelVipStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserLabelVipStatus.Location = new System.Drawing.Point(113, 36);
            this.UserLabelVipStatus.Name = "UserLabelVipStatus";
            this.UserLabelVipStatus.Size = new System.Drawing.Size(182, 36);
            this.UserLabelVipStatus.TabIndex = 3;
            this.UserLabelVipStatus.Text = "若不用Pro的功能";
            this.UserLabelVipStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pro状态：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserLabelUsername
            // 
            this.UserLabelUsername.AutoSize = true;
            this.UserLabelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLabelUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserLabelUsername.Location = new System.Drawing.Point(113, 0);
            this.UserLabelUsername.Name = "UserLabelUsername";
            this.UserLabelUsername.Size = new System.Drawing.Size(182, 36);
            this.UserLabelUsername.TabIndex = 1;
            this.UserLabelUsername.Text = "未登录呢";
            this.UserLabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTable2
            // 
            this.UserTable2.ColumnCount = 2;
            this.UserTable.SetColumnSpan(this.UserTable2, 2);
            this.UserTable2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserTable2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserTable2.Controls.Add(this.UserBtnRegister, 1, 0);
            this.UserTable2.Controls.Add(this.UserBtnLogin, 0, 0);
            this.UserTable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTable2.Location = new System.Drawing.Point(3, 111);
            this.UserTable2.Name = "UserTable2";
            this.UserTable2.RowCount = 1;
            this.UserTable2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserTable2.Size = new System.Drawing.Size(292, 32);
            this.UserTable2.TabIndex = 6;
            // 
            // UserBtnRegister
            // 
            this.UserBtnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserBtnRegister.Location = new System.Drawing.Point(149, 0);
            this.UserBtnRegister.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.UserBtnRegister.Name = "UserBtnRegister";
            this.UserBtnRegister.Size = new System.Drawing.Size(140, 32);
            this.UserBtnRegister.TabIndex = 1;
            this.UserBtnRegister.Text = "注册";
            this.UserBtnRegister.UseVisualStyleBackColor = true;
            // 
            // UserBtnLogin
            // 
            this.UserBtnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserBtnLogin.Location = new System.Drawing.Point(3, 0);
            this.UserBtnLogin.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.UserBtnLogin.Name = "UserBtnLogin";
            this.UserBtnLogin.Size = new System.Drawing.Size(140, 32);
            this.UserBtnLogin.TabIndex = 0;
            this.UserBtnLogin.Text = "登陆";
            this.UserBtnLogin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.UserBtnChangePwd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserBtnActivate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserBtnGetPro, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UserBtnChangePwd
            // 
            this.UserBtnChangePwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserBtnChangePwd.Enabled = false;
            this.UserBtnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtnChangePwd.Location = new System.Drawing.Point(3, 3);
            this.UserBtnChangePwd.Name = "UserBtnChangePwd";
            this.UserBtnChangePwd.Size = new System.Drawing.Size(292, 45);
            this.UserBtnChangePwd.TabIndex = 0;
            this.UserBtnChangePwd.Text = "修改密码";
            this.UserBtnChangePwd.UseVisualStyleBackColor = true;
            this.UserBtnChangePwd.Click += new System.EventHandler(this.UserBtnChangePwd_Click);
            // 
            // UserBtnActivate
            // 
            this.UserBtnActivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserBtnActivate.Enabled = false;
            this.UserBtnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtnActivate.Location = new System.Drawing.Point(3, 54);
            this.UserBtnActivate.Name = "UserBtnActivate";
            this.UserBtnActivate.Size = new System.Drawing.Size(292, 45);
            this.UserBtnActivate.TabIndex = 1;
            this.UserBtnActivate.Text = "激活Pro功能";
            this.UserBtnActivate.UseVisualStyleBackColor = true;
            this.UserBtnActivate.Click += new System.EventHandler(this.UserBtnActivate_Click);
            // 
            // UserBtnGetPro
            // 
            this.UserBtnGetPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserBtnGetPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBtnGetPro.Location = new System.Drawing.Point(3, 105);
            this.UserBtnGetPro.Name = "UserBtnGetPro";
            this.UserBtnGetPro.Size = new System.Drawing.Size(292, 45);
            this.UserBtnGetPro.TabIndex = 2;
            this.UserBtnGetPro.Text = "获取Pro功能";
            this.UserBtnGetPro.UseVisualStyleBackColor = true;
            this.UserBtnGetPro.Click += new System.EventHandler(this.UserBtnGetPro_Click);
            // 
            // UserGroupBoxPro
            // 
            this.UserGroupBoxPro.Controls.Add(this.UserLinkLabelProDetail);
            this.UserGroupBoxPro.Controls.Add(this.UserPicProCloud);
            this.UserGroupBoxPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGroupBoxPro.Location = new System.Drawing.Point(0, 0);
            this.UserGroupBoxPro.Name = "UserGroupBoxPro";
            this.UserGroupBoxPro.Size = new System.Drawing.Size(594, 610);
            this.UserGroupBoxPro.TabIndex = 0;
            this.UserGroupBoxPro.TabStop = false;
            this.UserGroupBoxPro.Text = "Pro";
            // 
            // UserLinkLabelProDetail
            // 
            this.UserLinkLabelProDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLinkLabelProDetail.AutoSize = true;
            this.UserLinkLabelProDetail.Location = new System.Drawing.Point(467, 586);
            this.UserLinkLabelProDetail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.UserLinkLabelProDetail.Name = "UserLinkLabelProDetail";
            this.UserLinkLabelProDetail.Size = new System.Drawing.Size(121, 15);
            this.UserLinkLabelProDetail.TabIndex = 1;
            this.UserLinkLabelProDetail.TabStop = true;
            this.UserLinkLabelProDetail.Text = "Pro有哪些功能？";
            this.UserLinkLabelProDetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UserLinkLabelProDetail_LinkClicked);
            // 
            // UserPicProCloud
            // 
            this.UserPicProCloud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPicProCloud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserPicProCloud.Location = new System.Drawing.Point(6, 24);
            this.UserPicProCloud.Name = "UserPicProCloud";
            this.UserPicProCloud.Size = new System.Drawing.Size(582, 553);
            this.UserPicProCloud.TabIndex = 0;
            this.UserPicProCloud.TabStop = false;
            // 
            // tabPageAnnounce
            // 
            this.tabPageAnnounce.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnnounce.Name = "tabPageAnnounce";
            this.tabPageAnnounce.Size = new System.Drawing.Size(902, 616);
            this.tabPageAnnounce.TabIndex = 2;
            this.tabPageAnnounce.Text = "公告";
            this.tabPageAnnounce.UseVisualStyleBackColor = true;
            this.tabPageAnnounce.Enter += new System.EventHandler(this.TabPageAnnounce_Enter);
            this.tabPageAnnounce.Leave += new System.EventHandler(this.TabPageAnnounce_Leave);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.groupBox2);
            this.tabPageSettings.Controls.Add(this.SetBtnApply);
            this.tabPageSettings.Controls.Add(this.groupBox1);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(902, 616);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "设置";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SetCheckIcon360);
            this.groupBox2.Controls.Add(this.SetCheckNoVoice);
            this.groupBox2.Location = new System.Drawing.Point(9, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pro选项";
            // 
            // SetCheckIcon360
            // 
            this.SetCheckIcon360.AutoSize = true;
            this.SetCheckIcon360.Enabled = false;
            this.SetCheckIcon360.Location = new System.Drawing.Point(6, 49);
            this.SetCheckIcon360.Name = "SetCheckIcon360";
            this.SetCheckIcon360.Size = new System.Drawing.Size(128, 19);
            this.SetCheckIcon360.TabIndex = 5;
            this.SetCheckIcon360.Text = "图标伪装成360";
            this.SetCheckIcon360.UseVisualStyleBackColor = true;
            // 
            // SetCheckNoVoice
            // 
            this.SetCheckNoVoice.AutoSize = true;
            this.SetCheckNoVoice.Enabled = false;
            this.SetCheckNoVoice.Location = new System.Drawing.Point(6, 24);
            this.SetCheckNoVoice.Name = "SetCheckNoVoice";
            this.SetCheckNoVoice.Size = new System.Drawing.Size(59, 19);
            this.SetCheckNoVoice.TabIndex = 4;
            this.SetCheckNoVoice.Text = "静音";
            this.SetCheckNoVoice.UseVisualStyleBackColor = true;
            // 
            // SetBtnApply
            // 
            this.SetBtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetBtnApply.Location = new System.Drawing.Point(784, 376);
            this.SetBtnApply.Name = "SetBtnApply";
            this.SetBtnApply.Size = new System.Drawing.Size(110, 37);
            this.SetBtnApply.TabIndex = 1;
            this.SetBtnApply.Text = "应用";
            this.SetBtnApply.UseVisualStyleBackColor = true;
            this.SetBtnApply.Click += new System.EventHandler(this.SetBtnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SetUpdateSource);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SetCheckAutoShutdown);
            this.groupBox1.Controls.Add(this.SetCheckAutoClose);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "首选项";
            // 
            // SetCheckAutoShutdown
            // 
            this.SetCheckAutoShutdown.AutoSize = true;
            this.SetCheckAutoShutdown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SetCheckAutoShutdown.Location = new System.Drawing.Point(6, 49);
            this.SetCheckAutoShutdown.Name = "SetCheckAutoShutdown";
            this.SetCheckAutoShutdown.Size = new System.Drawing.Size(164, 19);
            this.SetCheckAutoShutdown.TabIndex = 2;
            this.SetCheckAutoShutdown.Text = "积分刷满后自动关机";
            this.SetCheckAutoShutdown.UseVisualStyleBackColor = true;
            // 
            // SetCheckAutoClose
            // 
            this.SetCheckAutoClose.AutoSize = true;
            this.SetCheckAutoClose.Location = new System.Drawing.Point(6, 24);
            this.SetCheckAutoClose.Name = "SetCheckAutoClose";
            this.SetCheckAutoClose.Size = new System.Drawing.Size(179, 19);
            this.SetCheckAutoClose.TabIndex = 1;
            this.SetCheckAutoClose.Text = "积分刷满后自动关程序";
            this.SetCheckAutoClose.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.label2);
            this.tabPageAbout.Controls.Add(this.AboutBtnFeedback);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 25);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(902, 616);
            this.tabPageAbout.TabIndex = 4;
            this.tabPageAbout.Text = "关于";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "By：板。";
            // 
            // AboutBtnFeedback
            // 
            this.AboutBtnFeedback.Enabled = false;
            this.AboutBtnFeedback.Location = new System.Drawing.Point(667, 118);
            this.AboutBtnFeedback.Name = "AboutBtnFeedback";
            this.AboutBtnFeedback.Size = new System.Drawing.Size(147, 36);
            this.AboutBtnFeedback.TabIndex = 0;
            this.AboutBtnFeedback.Text = "快捷反馈（Pro）";
            this.AboutBtnFeedback.UseVisualStyleBackColor = true;
            this.AboutBtnFeedback.Click += new System.EventHandler(this.AboutBtnFeedback_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.NotifyMenu;
            this.NotifyIcon.Text = "Ba";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotifyShow,
            this.NotifyExit});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(109, 52);
            // 
            // NotifyShow
            // 
            this.NotifyShow.Name = "NotifyShow";
            this.NotifyShow.Size = new System.Drawing.Size(108, 24);
            this.NotifyShow.Text = "显示";
            this.NotifyShow.Click += new System.EventHandler(this.NotifyShow_Click);
            // 
            // NotifyExit
            // 
            this.NotifyExit.Name = "NotifyExit";
            this.NotifyExit.Size = new System.Drawing.Size(108, 24);
            this.NotifyExit.Text = "退出";
            this.NotifyExit.Click += new System.EventHandler(this.NotifyExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "更新源选择：";
            // 
            // SetUpdateSource
            // 
            this.SetUpdateSource.FormattingEnabled = true;
            this.SetUpdateSource.Items.AddRange(new object[] {
            "稳定版",
            "开发版"});
            this.SetUpdateSource.Location = new System.Drawing.Point(109, 74);
            this.SetUpdateSource.Name = "SetUpdateSource";
            this.SetUpdateSource.Size = new System.Drawing.Size(89, 23);
            this.SetUpdateSource.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 645);
            this.Controls.Add(this.MainTab);
            this.Name = "MainForm";
            this.Text = "Banishment C#";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MainTab.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.MainSplitter.Panel1.ResumeLayout(false);
            this.MainSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).EndInit();
            this.MainSplitter.ResumeLayout(false);
            this.MainSplitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter1)).EndInit();
            this.MainSplitter1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicBoxRikka)).EndInit();
            this.MainGroupBoxController.ResumeLayout(false);
            this.MainGroupBoxController.PerformLayout();
            this.tabPageUser.ResumeLayout(false);
            this.UserSplitter.Panel1.ResumeLayout(false);
            this.UserSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter)).EndInit();
            this.UserSplitter.ResumeLayout(false);
            this.UserSplitter1.Panel1.ResumeLayout(false);
            this.UserSplitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter1)).EndInit();
            this.UserSplitter1.ResumeLayout(false);
            this.UserSplitter2.Panel1.ResumeLayout(false);
            this.UserSplitter2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter2)).EndInit();
            this.UserSplitter2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserImgHead)).EndInit();
            this.UserTable.ResumeLayout(false);
            this.UserTable.PerformLayout();
            this.UserTable2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.UserGroupBoxPro.ResumeLayout(false);
            this.UserGroupBoxPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicProCloud)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageAnnounce;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.SplitContainer MainSplitter;
        private System.Windows.Forms.GroupBox MainGroupBoxController;
        public System.Windows.Forms.TextBox MainController;
        private System.Windows.Forms.SplitContainer MainSplitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox MainPicBoxRikka;
        public System.Windows.Forms.DataGridView MainGrid;
        public System.Windows.Forms.ProgressBar MainProgressBar;
        public System.Windows.Forms.Button MainBtnRun;
        public System.Windows.Forms.SplitContainer UserSplitter;
        public System.Windows.Forms.SplitContainer UserSplitter1;
        public System.Windows.Forms.SplitContainer UserSplitter2;
        private System.Windows.Forms.PictureBox UserImgHead;
        private System.Windows.Forms.TableLayoutPanel UserTable;
        private System.Windows.Forms.GroupBox UserGroupBoxPro;
        public System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button UserBtnChangePwd;
        public System.Windows.Forms.Button UserBtnActivate;
        public System.Windows.Forms.Button UserBtnGetPro;
        public System.Windows.Forms.Button AboutBtnFeedback;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel UserTable2;
        public System.Windows.Forms.Label UserLabelVipDate;
        public System.Windows.Forms.Label UserLabelVipStatus;
        public System.Windows.Forms.Label UserLabelUsername;
        public System.Windows.Forms.Button UserBtnRegister;
        public System.Windows.Forms.Button UserBtnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SetCheckAutoShutdown;
        private System.Windows.Forms.CheckBox SetCheckAutoClose;
        private System.Windows.Forms.Button SetBtnApply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem NotifyShow;
        private System.Windows.Forms.ToolStripMenuItem NotifyExit;
        private System.Windows.Forms.LinkLabel UserLinkLabelProDetail;
        private System.Windows.Forms.PictureBox UserPicProCloud;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox SetCheckIcon360;
        public System.Windows.Forms.CheckBox SetCheckNoVoice;
        public System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ComboBox SetUpdateSource;
        private System.Windows.Forms.Label label4;
    }
}