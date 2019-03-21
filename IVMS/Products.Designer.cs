namespace IVMS
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pNameErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnameTxt = new System.Windows.Forms.TextBox();
            this.pCodeErrorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pCodeTxt = new System.Windows.Forms.TextBox();
            this.HSNErrorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HSNTxt = new System.Windows.Forms.TextBox();
            this.pTypeErrorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pManuErrorLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pCB = new System.Windows.Forms.ComboBox();
            this.mCB = new System.Windows.Forms.ComboBox();
            this.bleftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bleftPanel
            // 
            this.bleftPanel.Controls.Add(this.mCB);
            this.bleftPanel.Controls.Add(this.pCB);
            this.bleftPanel.Controls.Add(this.label9);
            this.bleftPanel.Controls.Add(this.pManuErrorLabel);
            this.bleftPanel.Controls.Add(this.label7);
            this.bleftPanel.Controls.Add(this.pTypeErrorLabel);
            this.bleftPanel.Controls.Add(this.HSNTxt);
            this.bleftPanel.Controls.Add(this.label5);
            this.bleftPanel.Controls.Add(this.HSNErrorLabel);
            this.bleftPanel.Controls.Add(this.pCodeTxt);
            this.bleftPanel.Controls.Add(this.label3);
            this.bleftPanel.Controls.Add(this.pCodeErrorLabel);
            this.bleftPanel.Controls.Add(this.pnameTxt);
            this.bleftPanel.Controls.Add(this.label1);
            this.bleftPanel.Controls.Add(this.pNameErrorLabel);
            this.bleftPanel.Size = new System.Drawing.Size(250, 682);
            // 
            // brightPanel
            // 
            this.brightPanel.Size = new System.Drawing.Size(1208, 682);
            // 
            // pNameErrorLabel
            // 
            this.pNameErrorLabel.AutoSize = true;
            this.pNameErrorLabel.Location = new System.Drawing.Point(110, 111);
            this.pNameErrorLabel.Name = "pNameErrorLabel";
            this.pNameErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.pNameErrorLabel.TabIndex = 2;
            this.pNameErrorLabel.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // pnameTxt
            // 
            this.pnameTxt.Location = new System.Drawing.Point(12, 137);
            this.pnameTxt.MaxLength = 50;
            this.pnameTxt.Name = "pnameTxt";
            this.pnameTxt.Size = new System.Drawing.Size(223, 27);
            this.pnameTxt.TabIndex = 1;
            // 
            // pCodeErrorLabel
            // 
            this.pCodeErrorLabel.AutoSize = true;
            this.pCodeErrorLabel.Location = new System.Drawing.Point(105, 170);
            this.pCodeErrorLabel.Name = "pCodeErrorLabel";
            this.pCodeErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.pCodeErrorLabel.TabIndex = 5;
            this.pCodeErrorLabel.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Code";
            // 
            // pCodeTxt
            // 
            this.pCodeTxt.Location = new System.Drawing.Point(13, 195);
            this.pCodeTxt.MaxLength = 50;
            this.pCodeTxt.Name = "pCodeTxt";
            this.pCodeTxt.Size = new System.Drawing.Size(222, 27);
            this.pCodeTxt.TabIndex = 4;
            // 
            // HSNErrorLabel
            // 
            this.HSNErrorLabel.AutoSize = true;
            this.HSNErrorLabel.Location = new System.Drawing.Point(83, 225);
            this.HSNErrorLabel.Name = "HSNErrorLabel";
            this.HSNErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.HSNErrorLabel.TabIndex = 8;
            this.HSNErrorLabel.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "HSN Code";
            // 
            // HSNTxt
            // 
            this.HSNTxt.Location = new System.Drawing.Point(13, 252);
            this.HSNTxt.MaxLength = 50;
            this.HSNTxt.Name = "HSNTxt";
            this.HSNTxt.Size = new System.Drawing.Size(222, 27);
            this.HSNTxt.TabIndex = 7;
            // 
            // pTypeErrorLabel
            // 
            this.pTypeErrorLabel.AutoSize = true;
            this.pTypeErrorLabel.Location = new System.Drawing.Point(101, 281);
            this.pTypeErrorLabel.Name = "pTypeErrorLabel";
            this.pTypeErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.pTypeErrorLabel.TabIndex = 11;
            this.pTypeErrorLabel.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Product Type";
            // 
            // pManuErrorLabel
            // 
            this.pManuErrorLabel.AutoSize = true;
            this.pManuErrorLabel.Location = new System.Drawing.Point(158, 348);
            this.pManuErrorLabel.Name = "pManuErrorLabel";
            this.pManuErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.pManuErrorLabel.TabIndex = 13;
            this.pManuErrorLabel.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Product Manufacturer";
            // 
            // pCB
            // 
            this.pCB.FormattingEnabled = true;
            this.pCB.Location = new System.Drawing.Point(14, 311);
            this.pCB.Name = "pCB";
            this.pCB.Size = new System.Drawing.Size(221, 28);
            this.pCB.TabIndex = 14;
            // 
            // mCB
            // 
            this.mCB.FormattingEnabled = true;
            this.mCB.Location = new System.Drawing.Point(14, 374);
            this.mCB.Name = "mCB";
            this.mCB.Size = new System.Drawing.Size(221, 28);
            this.mCB.TabIndex = 15;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 742);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.bleftPanel.ResumeLayout(false);
            this.bleftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mCB;
        private System.Windows.Forms.ComboBox pCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label pNameErrorLabel;
        private System.Windows.Forms.Label pManuErrorLabel;
        private System.Windows.Forms.TextBox pnameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pCodeErrorLabel;
        private System.Windows.Forms.Label pTypeErrorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HSNTxt;
        private System.Windows.Forms.TextBox pCodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label HSNErrorLabel;
    }
}