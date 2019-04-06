namespace Banishment {
    partial class RegForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.RegSplitter = new System.Windows.Forms.SplitContainer();
            this.RegPicBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.RegUser = new System.Windows.Forms.TextBox();
            this.RegPwda = new System.Windows.Forms.TextBox();
            this.RegPwdb = new System.Windows.Forms.TextBox();
            this.RegBtnReg = new System.Windows.Forms.Button();
            this.RegLabelWarn = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RegVerify = new System.Windows.Forms.TextBox();
            this.RegVerifyPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RegSplitter)).BeginInit();
            this.RegSplitter.Panel1.SuspendLayout();
            this.RegSplitter.Panel2.SuspendLayout();
            this.RegSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegPicBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegVerifyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // RegSplitter
            // 
            this.RegSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegSplitter.Location = new System.Drawing.Point(0, 0);
            this.RegSplitter.Name = "RegSplitter";
            this.RegSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RegSplitter.Panel1
            // 
            this.RegSplitter.Panel1.Controls.Add(this.RegPicBox);
            // 
            // RegSplitter.Panel2
            // 
            this.RegSplitter.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.RegSplitter.Size = new System.Drawing.Size(392, 399);
            this.RegSplitter.SplitterDistance = 130;
            this.RegSplitter.TabIndex = 0;
            // 
            // RegPicBox
            // 
            this.RegPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegPicBox.BackgroundImage = global::Banishment.Properties.Resources.Rikka;
            this.RegPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RegPicBox.Location = new System.Drawing.Point(12, 12);
            this.RegPicBox.Name = "RegPicBox";
            this.RegPicBox.Size = new System.Drawing.Size(368, 115);
            this.RegPicBox.TabIndex = 0;
            this.RegPicBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.RegPwdb, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RegPwda, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RegUser, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RegEmail, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "邮箱：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 41);
            this.label7.TabIndex = 6;
            this.label7.Text = "确认密码：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 41);
            this.label9.TabIndex = 8;
            this.label9.Text = "验证码：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.RegBtnReg, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RegLabelWarn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 208);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(362, 39);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // RegEmail
            // 
            this.RegEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegEmail.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegEmail.Location = new System.Drawing.Point(113, 3);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(252, 34);
            this.RegEmail.TabIndex = 10;
            // 
            // RegUser
            // 
            this.RegUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegUser.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegUser.Location = new System.Drawing.Point(113, 44);
            this.RegUser.Name = "RegUser";
            this.RegUser.Size = new System.Drawing.Size(252, 34);
            this.RegUser.TabIndex = 11;
            // 
            // RegPwda
            // 
            this.RegPwda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegPwda.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegPwda.Location = new System.Drawing.Point(113, 85);
            this.RegPwda.Name = "RegPwda";
            this.RegPwda.Size = new System.Drawing.Size(252, 34);
            this.RegPwda.TabIndex = 12;
            this.RegPwda.UseSystemPasswordChar = true;
            // 
            // RegPwdb
            // 
            this.RegPwdb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegPwdb.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegPwdb.Location = new System.Drawing.Point(113, 126);
            this.RegPwdb.Name = "RegPwdb";
            this.RegPwdb.Size = new System.Drawing.Size(252, 34);
            this.RegPwdb.TabIndex = 13;
            this.RegPwdb.UseSystemPasswordChar = true;
            // 
            // RegBtnReg
            // 
            this.RegBtnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegBtnReg.Location = new System.Drawing.Point(256, 3);
            this.RegBtnReg.Name = "RegBtnReg";
            this.RegBtnReg.Size = new System.Drawing.Size(103, 33);
            this.RegBtnReg.TabIndex = 0;
            this.RegBtnReg.Text = "注册";
            this.RegBtnReg.UseVisualStyleBackColor = true;
            this.RegBtnReg.Click += new System.EventHandler(this.RegBtnReg_Click);
            // 
            // RegLabelWarn
            // 
            this.RegLabelWarn.AutoSize = true;
            this.RegLabelWarn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegLabelWarn.ForeColor = System.Drawing.Color.Red;
            this.RegLabelWarn.Location = new System.Drawing.Point(3, 0);
            this.RegLabelWarn.Name = "RegLabelWarn";
            this.RegLabelWarn.Size = new System.Drawing.Size(247, 39);
            this.RegLabelWarn.TabIndex = 1;
            this.RegLabelWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RegVerify, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RegVerifyPic, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(113, 167);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(252, 35);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // RegVerify
            // 
            this.RegVerify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegVerify.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegVerify.Location = new System.Drawing.Point(3, 3);
            this.RegVerify.Name = "RegVerify";
            this.RegVerify.Size = new System.Drawing.Size(120, 30);
            this.RegVerify.TabIndex = 11;
            // 
            // RegVerifyPic
            // 
            this.RegVerifyPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegVerifyPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegVerifyPic.Location = new System.Drawing.Point(129, 3);
            this.RegVerifyPic.Name = "RegVerifyPic";
            this.RegVerifyPic.Size = new System.Drawing.Size(120, 29);
            this.RegVerifyPic.TabIndex = 12;
            this.RegVerifyPic.TabStop = false;
            this.RegVerifyPic.Click += new System.EventHandler(this.RegVerifyPic_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 399);
            this.Controls.Add(this.RegSplitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegForm";
            this.Text = "注册";
            this.RegSplitter.Panel1.ResumeLayout(false);
            this.RegSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegSplitter)).EndInit();
            this.RegSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegPicBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegVerifyPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer RegSplitter;
        private System.Windows.Forms.PictureBox RegPicBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox RegPwdb;
        private System.Windows.Forms.TextBox RegPwda;
        private System.Windows.Forms.TextBox RegUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button RegBtnReg;
        private System.Windows.Forms.Label RegLabelWarn;
        private System.Windows.Forms.TextBox RegEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox RegVerify;
        private System.Windows.Forms.PictureBox RegVerifyPic;
    }
}