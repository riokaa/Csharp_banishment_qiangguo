﻿namespace Banishment {
    partial class LoginForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoginPicBoxRikka = new System.Windows.Forms.PictureBox();
            this.LoginTable = new System.Windows.Forms.TableLayoutPanel();
            this.LoginPanel1 = new System.Windows.Forms.Panel();
            this.LoginBtnLogin = new System.Windows.Forms.Button();
            this.LoginTable3 = new System.Windows.Forms.TableLayoutPanel();
            this.LoginForgetLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginRespLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBoxRikka)).BeginInit();
            this.LoginTable.SuspendLayout();
            this.LoginPanel1.SuspendLayout();
            this.LoginTable3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoginPicBoxRikka);
            this.panel1.Controls.Add(this.LoginTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 295);
            this.panel1.TabIndex = 0;
            // 
            // LoginPicBoxRikka
            // 
            this.LoginPicBoxRikka.BackgroundImage = global::Banishment.Properties.Resources.Rikka;
            this.LoginPicBoxRikka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginPicBoxRikka.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginPicBoxRikka.Location = new System.Drawing.Point(0, 0);
            this.LoginPicBoxRikka.Name = "LoginPicBoxRikka";
            this.LoginPicBoxRikka.Size = new System.Drawing.Size(358, 119);
            this.LoginPicBoxRikka.TabIndex = 6;
            this.LoginPicBoxRikka.TabStop = false;
            // 
            // LoginTable
            // 
            this.LoginTable.ColumnCount = 2;
            this.LoginTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.65363F));
            this.LoginTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.34637F));
            this.LoginTable.Controls.Add(this.LoginPanel1, 0, 3);
            this.LoginTable.Controls.Add(this.LoginTable3, 0, 2);
            this.LoginTable.Controls.Add(this.label1, 0, 0);
            this.LoginTable.Controls.Add(this.label2, 0, 1);
            this.LoginTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginTable.Location = new System.Drawing.Point(0, 123);
            this.LoginTable.Name = "LoginTable";
            this.LoginTable.RowCount = 4;
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LoginTable.Size = new System.Drawing.Size(358, 172);
            this.LoginTable.TabIndex = 5;
            // 
            // LoginPanel1
            // 
            this.LoginTable.SetColumnSpan(this.LoginPanel1, 2);
            this.LoginPanel1.Controls.Add(this.LoginBtnLogin);
            this.LoginPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPanel1.Location = new System.Drawing.Point(3, 132);
            this.LoginPanel1.Name = "LoginPanel1";
            this.LoginPanel1.Size = new System.Drawing.Size(352, 37);
            this.LoginPanel1.TabIndex = 0;
            // 
            // LoginBtnLogin
            // 
            this.LoginBtnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBtnLogin.Location = new System.Drawing.Point(0, 0);
            this.LoginBtnLogin.Margin = new System.Windows.Forms.Padding(9);
            this.LoginBtnLogin.Name = "LoginBtnLogin";
            this.LoginBtnLogin.Size = new System.Drawing.Size(352, 37);
            this.LoginBtnLogin.TabIndex = 0;
            this.LoginBtnLogin.Text = "登陆";
            this.LoginBtnLogin.UseVisualStyleBackColor = true;
            this.LoginBtnLogin.Click += new System.EventHandler(this.LoginBtnLogin_Click);
            // 
            // LoginTable3
            // 
            this.LoginTable3.ColumnCount = 2;
            this.LoginTable.SetColumnSpan(this.LoginTable3, 2);
            this.LoginTable3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.LoginTable3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LoginTable3.Controls.Add(this.LoginForgetLabel, 1, 0);
            this.LoginTable3.Controls.Add(this.LoginRespLabel, 0, 0);
            this.LoginTable3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTable3.Location = new System.Drawing.Point(3, 89);
            this.LoginTable3.Name = "LoginTable3";
            this.LoginTable3.RowCount = 1;
            this.LoginTable3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoginTable3.Size = new System.Drawing.Size(352, 37);
            this.LoginTable3.TabIndex = 1;
            // 
            // LoginForgetLabel
            // 
            this.LoginForgetLabel.AutoSize = true;
            this.LoginForgetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginForgetLabel.Location = new System.Drawing.Point(249, 0);
            this.LoginForgetLabel.Name = "LoginForgetLabel";
            this.LoginForgetLabel.Size = new System.Drawing.Size(100, 37);
            this.LoginForgetLabel.TabIndex = 0;
            this.LoginForgetLabel.TabStop = true;
            this.LoginForgetLabel.Text = "忘记密码？";
            this.LoginForgetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginForgetLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginForgetLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginRespLabel
            // 
            this.LoginRespLabel.AutoSize = true;
            this.LoginRespLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginRespLabel.ForeColor = System.Drawing.Color.Red;
            this.LoginRespLabel.Location = new System.Drawing.Point(3, 0);
            this.LoginRespLabel.Name = "LoginRespLabel";
            this.LoginRespLabel.Size = new System.Drawing.Size(240, 37);
            this.LoginRespLabel.TabIndex = 1;
            this.LoginRespLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 295);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "登陆";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBoxRikka)).EndInit();
            this.LoginTable.ResumeLayout(false);
            this.LoginTable.PerformLayout();
            this.LoginPanel1.ResumeLayout(false);
            this.LoginTable3.ResumeLayout(false);
            this.LoginTable3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LoginPicBoxRikka;
        private System.Windows.Forms.TableLayoutPanel LoginTable;
        private System.Windows.Forms.Panel LoginPanel1;
        private System.Windows.Forms.Button LoginBtnLogin;
        private System.Windows.Forms.TableLayoutPanel LoginTable3;
        private System.Windows.Forms.LinkLabel LoginForgetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LoginRespLabel;
    }
}