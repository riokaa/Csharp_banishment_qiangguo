﻿namespace _190320_Banishment移植 {
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MainBtnRun = new System.Windows.Forms.Button();
            this.groupBoxController = new System.Windows.Forms.GroupBox();
            this.MainController = new System.Windows.Forms.ListBox();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.tabPageAnnounce = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.MainPicBoxRikka = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainTab.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.groupBoxController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicBoxRikka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tabPageMain);
            this.MainTab.Controls.Add(this.tabPageUser);
            this.MainTab.Controls.Add(this.tabPageAnnounce);
            this.MainTab.Controls.Add(this.tabPageSettings);
            this.MainTab.Controls.Add(this.tabPageAbout);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(872, 615);
            this.MainTab.TabIndex = 1;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.MainSplitContainer);
            this.tabPageMain.Controls.Add(this.groupBoxController);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(864, 586);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "主页";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.MainSplitContainer.Panel2.Controls.Add(this.MainPicBoxRikka);
            this.MainSplitContainer.Panel2.Controls.Add(this.MainBtnRun);
            this.MainSplitContainer.Size = new System.Drawing.Size(858, 414);
            this.MainSplitContainer.SplitterDistance = 648;
            this.MainSplitContainer.TabIndex = 4;
            // 
            // MainBtnRun
            // 
            this.MainBtnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainBtnRun.Location = new System.Drawing.Point(0, 367);
            this.MainBtnRun.Name = "MainBtnRun";
            this.MainBtnRun.Size = new System.Drawing.Size(206, 47);
            this.MainBtnRun.TabIndex = 2;
            this.MainBtnRun.Text = "开始执行";
            this.MainBtnRun.UseVisualStyleBackColor = true;
            // 
            // groupBoxController
            // 
            this.groupBoxController.Controls.Add(this.MainController);
            this.groupBoxController.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxController.Location = new System.Drawing.Point(3, 417);
            this.groupBoxController.Name = "groupBoxController";
            this.groupBoxController.Size = new System.Drawing.Size(858, 166);
            this.groupBoxController.TabIndex = 3;
            this.groupBoxController.TabStop = false;
            this.groupBoxController.Text = "控制台";
            // 
            // MainController
            // 
            this.MainController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainController.FormattingEnabled = true;
            this.MainController.ItemHeight = 15;
            this.MainController.Location = new System.Drawing.Point(3, 21);
            this.MainController.Name = "MainController";
            this.MainController.Size = new System.Drawing.Size(852, 142);
            this.MainController.TabIndex = 0;
            // 
            // tabPageUser
            // 
            this.tabPageUser.Location = new System.Drawing.Point(4, 25);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(864, 586);
            this.tabPageUser.TabIndex = 1;
            this.tabPageUser.Text = "个人中心";
            this.tabPageUser.UseVisualStyleBackColor = true;
            // 
            // tabPageAnnounce
            // 
            this.tabPageAnnounce.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnnounce.Name = "tabPageAnnounce";
            this.tabPageAnnounce.Size = new System.Drawing.Size(864, 586);
            this.tabPageAnnounce.TabIndex = 2;
            this.tabPageAnnounce.Text = "公告";
            this.tabPageAnnounce.UseVisualStyleBackColor = true;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(864, 586);
            this.tabPageSettings.TabIndex = 3;
            this.tabPageSettings.Text = "设置";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Location = new System.Drawing.Point(4, 25);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(864, 586);
            this.tabPageAbout.TabIndex = 4;
            this.tabPageAbout.Text = "关于";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // MainPicBoxRikka
            // 
            this.MainPicBoxRikka.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPicBoxRikka.Location = new System.Drawing.Point(0, 0);
            this.MainPicBoxRikka.Name = "MainPicBoxRikka";
            this.MainPicBoxRikka.Size = new System.Drawing.Size(206, 72);
            this.MainPicBoxRikka.TabIndex = 3;
            this.MainPicBoxRikka.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(206, 295);
            this.dataGridView1.TabIndex = 4;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 639);
            this.Controls.Add(this.MainTab);
            this.Name = "MainForm";
            this.Text = "Banishment C#";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTab.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.groupBoxController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPicBoxRikka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button MainBtnRun;
        private System.Windows.Forms.GroupBox groupBoxController;
        private System.Windows.Forms.ListBox MainController;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox MainPicBoxRikka;
    }
}