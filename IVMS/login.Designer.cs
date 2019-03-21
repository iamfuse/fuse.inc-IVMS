namespace IVMS
{
    partial class login
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stngsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.brightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bleftPanel
            // 
            this.bleftPanel.Size = new System.Drawing.Size(250, 677);
            this.bleftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bleftPanel_Paint);
            // 
            // brightPanel
            // 
            this.brightPanel.Controls.Add(this.panel3);
            this.brightPanel.Controls.Add(this.label1);
            this.brightPanel.Controls.Add(this.loginBtn);
            this.brightPanel.Controls.Add(this.passwordTxt);
            this.brightPanel.Controls.Add(this.label2);
            this.brightPanel.Controls.Add(this.usernameLabel);
            this.brightPanel.Controls.Add(this.passwordErrorLabel);
            this.brightPanel.Controls.Add(this.usernameTxt);
            this.brightPanel.Controls.Add(this.usernameErrorLabel);
            this.brightPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brightPanel.Size = new System.Drawing.Size(1261, 677);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(480, 251);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(483, 274);
            this.usernameTxt.MaxLength = 50;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(225, 27);
            this.usernameTxt.TabIndex = 1;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Location = new System.Drawing.Point(552, 249);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.usernameErrorLabel.TabIndex = 2;
            this.usernameErrorLabel.Text = "*";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(483, 336);
            this.passwordTxt.MaxLength = 50;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(225, 27);
            this.passwordTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Location = new System.Drawing.Point(548, 308);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(15, 20);
            this.passwordErrorLabel.TabIndex = 5;
            this.passwordErrorLabel.Text = "*";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Location = new System.Drawing.Point(516, 382);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(160, 35);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Your Login Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stngsBtn
            // 
            this.stngsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stngsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.stngsBtn.FlatAppearance.BorderSize = 0;
            this.stngsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stngsBtn.Location = new System.Drawing.Point(1186, 0);
            this.stngsBtn.Name = "stngsBtn";
            this.stngsBtn.Size = new System.Drawing.Size(75, 31);
            this.stngsBtn.TabIndex = 8;
            this.stngsBtn.Text = "Settings";
            this.stngsBtn.UseVisualStyleBackColor = true;
            this.stngsBtn.Click += new System.EventHandler(this.stngsBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.stngsBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 646);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1261, 31);
            this.panel3.TabIndex = 9;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 737);
            this.Name = "login";
            this.Text = "login";
            this.brightPanel.ResumeLayout(false);
            this.brightPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stngsBtn;
        private System.Windows.Forms.Panel panel3;
    }
}