namespace Project_RTO
{
    partial class Login_frm
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
            this.loginfrm_forgotpasslinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginfrm_titlelable = new System.Windows.Forms.Label();
            this.loginfrm_passwordtextBox = new System.Windows.Forms.TextBox();
            this.loginfrm_usernametextBox = new System.Windows.Forms.TextBox();
            this.loginfrm_lablepassword = new System.Windows.Forms.Label();
            this.loginfrm_lableuser = new System.Windows.Forms.Label();
            this.loginfrm_canclebutton = new System.Windows.Forms.Button();
            this.loginfrm_loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginfrm_forgotpasslinkLabel
            // 
            this.loginfrm_forgotpasslinkLabel.AutoSize = true;
            this.loginfrm_forgotpasslinkLabel.Location = new System.Drawing.Point(913, 321);
            this.loginfrm_forgotpasslinkLabel.Name = "loginfrm_forgotpasslinkLabel";
            this.loginfrm_forgotpasslinkLabel.Size = new System.Drawing.Size(116, 16);
            this.loginfrm_forgotpasslinkLabel.TabIndex = 14;
            this.loginfrm_forgotpasslinkLabel.TabStop = true;
            this.loginfrm_forgotpasslinkLabel.Text = "Forgot Password?";
            this.loginfrm_forgotpasslinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginfrm_forgotpasslinkLabel_LinkClicked);
            // 
            // loginfrm_titlelable
            // 
            this.loginfrm_titlelable.AutoSize = true;
            this.loginfrm_titlelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_titlelable.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.loginfrm_titlelable.Location = new System.Drawing.Point(742, 54);
            this.loginfrm_titlelable.Name = "loginfrm_titlelable";
            this.loginfrm_titlelable.Size = new System.Drawing.Size(527, 51);
            this.loginfrm_titlelable.TabIndex = 15;
            this.loginfrm_titlelable.Text = "RTO Managment System";
            // 
            // loginfrm_passwordtextBox
            // 
            this.loginfrm_passwordtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_passwordtextBox.ForeColor = System.Drawing.Color.Indigo;
            this.loginfrm_passwordtextBox.Location = new System.Drawing.Point(913, 220);
            this.loginfrm_passwordtextBox.MaxLength = 10;
            this.loginfrm_passwordtextBox.Multiline = true;
            this.loginfrm_passwordtextBox.Name = "loginfrm_passwordtextBox";
            this.loginfrm_passwordtextBox.PasswordChar = '*';
            this.loginfrm_passwordtextBox.Size = new System.Drawing.Size(201, 31);
            this.loginfrm_passwordtextBox.TabIndex = 9;
            this.loginfrm_passwordtextBox.WordWrap = false;
            // 
            // loginfrm_usernametextBox
            // 
            this.loginfrm_usernametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_usernametextBox.ForeColor = System.Drawing.Color.Indigo;
            this.loginfrm_usernametextBox.Location = new System.Drawing.Point(913, 149);
            this.loginfrm_usernametextBox.MaxLength = 10;
            this.loginfrm_usernametextBox.Multiline = true;
            this.loginfrm_usernametextBox.Name = "loginfrm_usernametextBox";
            this.loginfrm_usernametextBox.Size = new System.Drawing.Size(201, 33);
            this.loginfrm_usernametextBox.TabIndex = 8;
            this.loginfrm_usernametextBox.WordWrap = false;
            // 
            // loginfrm_lablepassword
            // 
            this.loginfrm_lablepassword.AutoSize = true;
            this.loginfrm_lablepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_lablepassword.Location = new System.Drawing.Point(810, 226);
            this.loginfrm_lablepassword.Name = "loginfrm_lablepassword";
            this.loginfrm_lablepassword.Size = new System.Drawing.Size(91, 20);
            this.loginfrm_lablepassword.TabIndex = 11;
            this.loginfrm_lablepassword.Text = "Password";
            // 
            // loginfrm_lableuser
            // 
            this.loginfrm_lableuser.AutoSize = true;
            this.loginfrm_lableuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_lableuser.Location = new System.Drawing.Point(811, 156);
            this.loginfrm_lableuser.Name = "loginfrm_lableuser";
            this.loginfrm_lableuser.Size = new System.Drawing.Size(74, 20);
            this.loginfrm_lableuser.TabIndex = 10;
            this.loginfrm_lableuser.Text = "User ID";
            // 
            // loginfrm_canclebutton
            // 
            this.loginfrm_canclebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_canclebutton.Location = new System.Drawing.Point(1019, 286);
            this.loginfrm_canclebutton.Name = "loginfrm_canclebutton";
            this.loginfrm_canclebutton.Size = new System.Drawing.Size(95, 32);
            this.loginfrm_canclebutton.TabIndex = 13;
            this.loginfrm_canclebutton.Text = "Cancle";
            this.loginfrm_canclebutton.UseVisualStyleBackColor = true;
            this.loginfrm_canclebutton.Click += new System.EventHandler(this.loginfrm_canclebutton_Click);
            // 
            // loginfrm_loginbutton
            // 
            this.loginfrm_loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_loginbutton.Location = new System.Drawing.Point(913, 286);
            this.loginfrm_loginbutton.Name = "loginfrm_loginbutton";
            this.loginfrm_loginbutton.Size = new System.Drawing.Size(88, 32);
            this.loginfrm_loginbutton.TabIndex = 12;
            this.loginfrm_loginbutton.Text = "Login";
            this.loginfrm_loginbutton.UseVisualStyleBackColor = true;
            this.loginfrm_loginbutton.Click += new System.EventHandler(this.loginfrm_loginbutton_Click);
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1003);
            this.Controls.Add(this.loginfrm_forgotpasslinkLabel);
            this.Controls.Add(this.loginfrm_titlelable);
            this.Controls.Add(this.loginfrm_passwordtextBox);
            this.Controls.Add(this.loginfrm_usernametextBox);
            this.Controls.Add(this.loginfrm_lablepassword);
            this.Controls.Add(this.loginfrm_lableuser);
            this.Controls.Add(this.loginfrm_canclebutton);
            this.Controls.Add(this.loginfrm_loginbutton);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "Login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Tab";
            this.Load += new System.EventHandler(this.Login_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel loginfrm_forgotpasslinkLabel;
        private System.Windows.Forms.Label loginfrm_titlelable;
        private System.Windows.Forms.TextBox loginfrm_passwordtextBox;
        private System.Windows.Forms.TextBox loginfrm_usernametextBox;
        private System.Windows.Forms.Label loginfrm_lablepassword;
        private System.Windows.Forms.Label loginfrm_lableuser;
        private System.Windows.Forms.Button loginfrm_canclebutton;
        private System.Windows.Forms.Button loginfrm_loginbutton;
    }
}

