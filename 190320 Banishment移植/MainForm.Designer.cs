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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.UserGroupBoxPro = new System.Windows.Forms.GroupBox();
            this.tabPageAnnounce = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
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
            this.UserSplitter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter2)).BeginInit();
            this.UserSplitter2.Panel1.SuspendLayout();
            this.UserSplitter2.Panel2.SuspendLayout();
            this.UserSplitter2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImgHead)).BeginInit();
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
            this.MainPicBoxRikka.BackgroundImage = global::Banishment.Properties.Resources.Rikka;
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
            this.UserImgHead.BackgroundImage = global::Banishment.Properties.Resources.MainIcon;
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
            this.UserTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTable.Location = new System.Drawing.Point(0, 0);
            this.UserTable.Name = "UserTable";
            this.UserTable.Padding = new System.Windows.Forms.Padding(16);
            this.UserTable.RowCount = 4;
            this.UserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.UserTable.Size = new System.Drawing.Size(298, 146);
            this.UserTable.TabIndex = 2;
            // 
            // UserGroupBoxPro
            // 
            this.UserGroupBoxPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserGroupBoxPro.Location = new System.Drawing.Point(0, 0);
            this.UserGroupBoxPro.Name = "UserGroupBoxPro";
            this.UserGroupBoxPro.Size = new System.Drawing.Size(594, 610);
            this.UserGroupBoxPro.TabIndex = 0;
            this.UserGroupBoxPro.TabStop = false;
            this.UserGroupBoxPro.Text = "Pro";
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
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(902, 616);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "设置";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Location = new System.Drawing.Point(4, 25);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(902, 616);
            this.tabPageAbout.TabIndex = 4;
            this.tabPageAbout.Text = "关于";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 645);
            this.Controls.Add(this.MainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Banishment C#";
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
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter1)).EndInit();
            this.UserSplitter1.ResumeLayout(false);
            this.UserSplitter2.Panel1.ResumeLayout(false);
            this.UserSplitter2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserSplitter2)).EndInit();
            this.UserSplitter2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserImgHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
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
    }
}