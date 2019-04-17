namespace Banishment {
    partial class ActivateForm {
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
            this.ActivateTextBox = new System.Windows.Forms.TextBox();
            this.ActivateBtn = new System.Windows.Forms.Button();
            this.ActivateLabelWarn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.58242F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.41758F));
            this.tableLayoutPanel1.Controls.Add(this.ActivateTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ActivateBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ActivateLabelWarn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 74);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ActivateTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ActivateTextBox, 2);
            this.ActivateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivateTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ActivateTextBox.Location = new System.Drawing.Point(3, 3);
            this.ActivateTextBox.Name = "ActivateTextBox";
            this.ActivateTextBox.Size = new System.Drawing.Size(358, 30);
            this.ActivateTextBox.TabIndex = 0;
            // 
            // ActivateBtn
            // 
            this.ActivateBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivateBtn.Location = new System.Drawing.Point(249, 40);
            this.ActivateBtn.Name = "ActivateBtn";
            this.ActivateBtn.Size = new System.Drawing.Size(112, 31);
            this.ActivateBtn.TabIndex = 1;
            this.ActivateBtn.Text = "解除封印";
            this.ActivateBtn.UseVisualStyleBackColor = true;
            this.ActivateBtn.Click += new System.EventHandler(this.ActivateBtn_Click);
            // 
            // ActivateLabelWarn
            // 
            this.ActivateLabelWarn.AutoSize = true;
            this.ActivateLabelWarn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivateLabelWarn.ForeColor = System.Drawing.Color.Red;
            this.ActivateLabelWarn.Location = new System.Drawing.Point(3, 37);
            this.ActivateLabelWarn.Name = "ActivateLabelWarn";
            this.ActivateLabelWarn.Size = new System.Drawing.Size(240, 37);
            this.ActivateLabelWarn.TabIndex = 2;
            this.ActivateLabelWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 98);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ActivateForm";
            this.Text = "激活卡激活";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox ActivateTextBox;
        private System.Windows.Forms.Button ActivateBtn;
        private System.Windows.Forms.Label ActivateLabelWarn;
    }
}