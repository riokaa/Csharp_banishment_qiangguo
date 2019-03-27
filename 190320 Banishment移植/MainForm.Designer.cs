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
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MainSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPicBoxRikka = new System.Windows.Forms.PictureBox();
            this.MainBtnRun = new System.Windows.Forms.Button();
            this.MainGroupBoxController = new System.Windows.Forms.GroupBox();
            this.MainController = new System.Windows.Forms.TextBox();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.tabPageAnnounce = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainTab.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer1)).BeginInit();
            this.MainSplitContainer1.Panel2.SuspendLayout();
            this.MainSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicBoxRikka)).BeginInit();
            this.MainGroupBoxController.SuspendLayout();
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
            this.tabPageMain.Controls.Add(this.MainSplitContainer);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(902, 616);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "主页";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.MainSplitContainer.Name = "MainSplitContainer";
            this.MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.MainSplitContainer1);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.MainGroupBoxController);
            this.MainSplitContainer.Size = new System.Drawing.Size(896, 610);
            this.MainSplitContainer.SplitterDistance = 426;
            this.MainSplitContainer.TabIndex = 4;
            // 
            // MainSplitContainer1
            // 
            this.MainSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer1.Name = "MainSplitContainer1";
            // 
            // MainSplitContainer1.Panel2
            // 
            this.MainSplitContainer1.Panel2.Controls.Add(this.MainProgressBar);
            this.MainSplitContainer1.Panel2.Controls.Add(this.MainGrid);
            this.MainSplitContainer1.Panel2.Controls.Add(this.MainPicBoxRikka);
            this.MainSplitContainer1.Panel2.Controls.Add(this.MainBtnRun);
            this.MainSplitContainer1.Size = new System.Drawing.Size(896, 426);
            this.MainSplitContainer1.SplitterDistance = 694;
            this.MainSplitContainer1.TabIndex = 6;
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainProgressBar.Location = new System.Drawing.Point(0, 356);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(198, 23);
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
            this.MainGrid.Location = new System.Drawing.Point(0, 72);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.RowTemplate.Height = 27;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MainGrid.Size = new System.Drawing.Size(198, 307);
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
            this.MainPicBoxRikka.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPicBoxRikka.Location = new System.Drawing.Point(0, 0);
            this.MainPicBoxRikka.Name = "MainPicBoxRikka";
            this.MainPicBoxRikka.Size = new System.Drawing.Size(198, 72);
            this.MainPicBoxRikka.TabIndex = 3;
            this.MainPicBoxRikka.TabStop = false;
            // 
            // MainBtnRun
            // 
            this.MainBtnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainBtnRun.Location = new System.Drawing.Point(0, 379);
            this.MainBtnRun.Name = "MainBtnRun";
            this.MainBtnRun.Size = new System.Drawing.Size(198, 47);
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
            this.tabPageUser.Location = new System.Drawing.Point(4, 25);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(902, 616);
            this.tabPageUser.TabIndex = 1;
            this.tabPageUser.Text = "个人中心";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // tabPageAnnounce
            // 
            this.tabPageAnnounce.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnnounce.Name = "tabPageAnnounce";
            this.tabPageAnnounce.Size = new System.Drawing.Size(902, 616);
            this.tabPageAnnounce.TabIndex = 2;
            this.tabPageAnnounce.Text = "公告";
            this.tabPageAnnounce.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.MainSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer1)).EndInit();
            this.MainSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicBoxRikka)).EndInit();
            this.MainGroupBoxController.ResumeLayout(false);
            this.MainGroupBoxController.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TabPage tabPageAnnounce;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.GroupBox MainGroupBoxController;
        public System.Windows.Forms.TextBox MainController;
        private System.Windows.Forms.SplitContainer MainSplitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox MainPicBoxRikka;
        public System.Windows.Forms.DataGridView MainGrid;
        public System.Windows.Forms.ProgressBar MainProgressBar;
        public System.Windows.Forms.Button MainBtnRun;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}