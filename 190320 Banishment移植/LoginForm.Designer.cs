namespace Banishment {
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicBoxRikka)).BeginInit();
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
            this.LoginTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.LoginTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.LoginTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginTable.Location = new System.Drawing.Point(0, 123);
            this.LoginTable.Name = "LoginTable";
            this.LoginTable.RowCount = 4;
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LoginTable.Size = new System.Drawing.Size(358, 172);
            this.LoginTable.TabIndex = 5;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LoginPicBoxRikka;
        private System.Windows.Forms.TableLayoutPanel LoginTable;
    }
}