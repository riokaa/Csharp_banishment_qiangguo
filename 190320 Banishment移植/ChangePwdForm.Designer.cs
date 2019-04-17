namespace Banishment {
    partial class ChangePwdForm {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pwdb = new System.Windows.Forms.TextBox();
            this.Pwda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnChange = new System.Windows.Forms.Button();
            this.LabelWarn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.6875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.3125F));
            this.tableLayoutPanel1.Controls.Add(this.Pwdb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Pwda, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pwd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Pwdb
            // 
            this.Pwdb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pwdb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pwdb.Location = new System.Drawing.Point(114, 77);
            this.Pwdb.Name = "Pwdb";
            this.Pwdb.Size = new System.Drawing.Size(203, 30);
            this.Pwdb.TabIndex = 7;
            this.Pwdb.UseSystemPasswordChar = true;
            // 
            // Pwda
            // 
            this.Pwda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pwda.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pwda.Location = new System.Drawing.Point(114, 40);
            this.Pwda.Name = "Pwda";
            this.Pwda.Size = new System.Drawing.Size(203, 30);
            this.Pwda.TabIndex = 6;
            this.Pwda.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "确认新密码：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pwd
            // 
            this.Pwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pwd.Location = new System.Drawing.Point(114, 3);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(203, 30);
            this.Pwd.TabIndex = 5;
            this.Pwd.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.92357F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.07643F));
            this.tableLayoutPanel2.Controls.Add(this.BtnChange, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelWarn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 114);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 33);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // BtnChange
            // 
            this.BtnChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnChange.Location = new System.Drawing.Point(210, 3);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(101, 27);
            this.BtnChange.TabIndex = 0;
            this.BtnChange.Text = "修改";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // LabelWarn
            // 
            this.LabelWarn.AutoSize = true;
            this.LabelWarn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelWarn.ForeColor = System.Drawing.Color.Red;
            this.LabelWarn.Location = new System.Drawing.Point(3, 0);
            this.LabelWarn.Name = "LabelWarn";
            this.LabelWarn.Size = new System.Drawing.Size(201, 33);
            this.LabelWarn.TabIndex = 1;
            this.LabelWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 174);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChangePwdForm";
            this.Text = "修改密码";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Pwdb;
        private System.Windows.Forms.TextBox Pwda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pwd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Label LabelWarn;
    }
}