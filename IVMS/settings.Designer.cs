namespace IVMS
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.serverErrorLabel = new System.Windows.Forms.Label();
            this.databaseErrorLabel = new System.Windows.Forms.Label();
            this.sdbTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.useridErrorLabel = new System.Windows.Forms.Label();
            this.suidTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.spwdErrorLabel = new System.Windows.Forms.Label();
            this.spwdTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.bleftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bleftPanel
            // 
            this.bleftPanel.Controls.Add(this.saveBtn);
            this.bleftPanel.Controls.Add(this.isCB);
            this.bleftPanel.Controls.Add(this.spwdErrorLabel);
            this.bleftPanel.Controls.Add(this.spwdTxt);
            this.bleftPanel.Controls.Add(this.label8);
            this.bleftPanel.Controls.Add(this.useridErrorLabel);
            this.bleftPanel.Controls.Add(this.suidTxt);
            this.bleftPanel.Controls.Add(this.label6);
            this.bleftPanel.Controls.Add(this.sdbTxt);
            this.bleftPanel.Controls.Add(this.label4);
            this.bleftPanel.Controls.Add(this.serverErrorLabel);
            this.bleftPanel.Controls.Add(this.serverTxt);
            this.bleftPanel.Controls.Add(this.label1);
            this.bleftPanel.Controls.Add(this.databaseErrorLabel);
            this.bleftPanel.Size = new System.Drawing.Size(250, 890);
            // 
            // brightPanel
            // 
            this.brightPanel.Size = new System.Drawing.Size(1291, 890);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(5, 114);
            this.serverTxt.MaxLength = 50;
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(241, 27);
            this.serverTxt.TabIndex = 1;
            // 
            // serverErrorLabel
            // 
            this.serverErrorLabel.AutoSize = true;
            this.serverErrorLabel.Location = new System.Drawing.Point(49, 88);
            this.serverErrorLabel.Name = "serverErrorLabel";
            this.serverErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.serverErrorLabel.TabIndex = 2;
            this.serverErrorLabel.Text = "*";
            // 
            // databaseErrorLabel
            // 
            this.databaseErrorLabel.AutoSize = true;
            this.databaseErrorLabel.Location = new System.Drawing.Point(72, 146);
            this.databaseErrorLabel.Name = "databaseErrorLabel";
            this.databaseErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.databaseErrorLabel.TabIndex = 5;
            this.databaseErrorLabel.Text = "*";
            // 
            // sdbTxt
            // 
            this.sdbTxt.Location = new System.Drawing.Point(5, 172);
            this.sdbTxt.MaxLength = 50;
            this.sdbTxt.Name = "sdbTxt";
            this.sdbTxt.Size = new System.Drawing.Size(241, 27);
            this.sdbTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // useridErrorLabel
            // 
            this.useridErrorLabel.AutoSize = true;
            this.useridErrorLabel.Location = new System.Drawing.Point(58, 205);
            this.useridErrorLabel.Name = "useridErrorLabel";
            this.useridErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.useridErrorLabel.TabIndex = 8;
            this.useridErrorLabel.Text = "*";
            // 
            // suidTxt
            // 
            this.suidTxt.Location = new System.Drawing.Point(6, 231);
            this.suidTxt.MaxLength = 50;
            this.suidTxt.Name = "suidTxt";
            this.suidTxt.Size = new System.Drawing.Size(241, 27);
            this.suidTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "User ID";
            // 
            // spwdErrorLabel
            // 
            this.spwdErrorLabel.AutoSize = true;
            this.spwdErrorLabel.Location = new System.Drawing.Point(70, 267);
            this.spwdErrorLabel.Name = "spwdErrorLabel";
            this.spwdErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.spwdErrorLabel.TabIndex = 11;
            this.spwdErrorLabel.Text = "*";
            // 
            // spwdTxt
            // 
            this.spwdTxt.Location = new System.Drawing.Point(6, 293);
            this.spwdTxt.MaxLength = 50;
            this.spwdTxt.Name = "spwdTxt";
            this.spwdTxt.Size = new System.Drawing.Size(241, 27);
            this.spwdTxt.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Password";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(9, 335);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(156, 24);
            this.isCB.TabIndex = 12;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(4, 388);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(240, 39);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 950);
            this.Name = "settings";
            this.Text = "settings";
            this.bleftPanel.ResumeLayout(false);
            this.bleftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label databaseErrorLabel;
        private System.Windows.Forms.TextBox sdbTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label serverErrorLabel;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.Label useridErrorLabel;
        private System.Windows.Forms.TextBox suidTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label spwdErrorLabel;
        private System.Windows.Forms.TextBox spwdTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox isCB;
    }
}