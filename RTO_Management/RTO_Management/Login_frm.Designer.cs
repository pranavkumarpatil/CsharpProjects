namespace RTO_Management
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
            this.loginfrm_loginbutton = new System.Windows.Forms.Button();
            this.loginfrm_canclebutton = new System.Windows.Forms.Button();
            this.loginfrm_lable1 = new System.Windows.Forms.Label();
            this.loginfrm_lable2 = new System.Windows.Forms.Label();
            this.loginfrm_usernametextBox1 = new System.Windows.Forms.TextBox();
            this.loginfrm_passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.loginfrm_titlelable3 = new System.Windows.Forms.Label();
            this.loginfrm_infolable4 = new System.Windows.Forms.Label();
            this.loginfrm_signupbutton = new System.Windows.Forms.Button();
            this.loginfrm_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginfrm_loginbutton
            // 
            this.loginfrm_loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_loginbutton.Location = new System.Drawing.Point(318, 230);
            this.loginfrm_loginbutton.Name = "loginfrm_loginbutton";
            this.loginfrm_loginbutton.Size = new System.Drawing.Size(88, 32);
            this.loginfrm_loginbutton.TabIndex = 3;
            this.loginfrm_loginbutton.Text = "Login";
            this.loginfrm_loginbutton.UseVisualStyleBackColor = true;
            this.loginfrm_loginbutton.Click += new System.EventHandler(this.loginfrm_loginbutton_Click);
            // 
            // loginfrm_canclebutton
            // 
            this.loginfrm_canclebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_canclebutton.Location = new System.Drawing.Point(424, 230);
            this.loginfrm_canclebutton.Name = "loginfrm_canclebutton";
            this.loginfrm_canclebutton.Size = new System.Drawing.Size(95, 32);
            this.loginfrm_canclebutton.TabIndex = 4;
            this.loginfrm_canclebutton.Text = "Cancle";
            this.loginfrm_canclebutton.UseVisualStyleBackColor = true;
            this.loginfrm_canclebutton.Click += new System.EventHandler(this.loginfrm_canclebutton_Click);
            // 
            // loginfrm_lable1
            // 
            this.loginfrm_lable1.AutoSize = true;
            this.loginfrm_lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_lable1.Location = new System.Drawing.Point(216, 134);
            this.loginfrm_lable1.Name = "loginfrm_lable1";
            this.loginfrm_lable1.Size = new System.Drawing.Size(74, 20);
            this.loginfrm_lable1.TabIndex = 2;
            this.loginfrm_lable1.Text = "User ID";
            // 
            // loginfrm_lable2
            // 
            this.loginfrm_lable2.AutoSize = true;
            this.loginfrm_lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_lable2.Location = new System.Drawing.Point(215, 187);
            this.loginfrm_lable2.Name = "loginfrm_lable2";
            this.loginfrm_lable2.Size = new System.Drawing.Size(91, 20);
            this.loginfrm_lable2.TabIndex = 3;
            this.loginfrm_lable2.Text = "Password";
            // 
            // loginfrm_usernametextBox1
            // 
            this.loginfrm_usernametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_usernametextBox1.ForeColor = System.Drawing.Color.Indigo;
            this.loginfrm_usernametextBox1.Location = new System.Drawing.Point(318, 127);
            this.loginfrm_usernametextBox1.MaxLength = 10;
            this.loginfrm_usernametextBox1.Multiline = true;
            this.loginfrm_usernametextBox1.Name = "loginfrm_usernametextBox1";
            this.loginfrm_usernametextBox1.Size = new System.Drawing.Size(201, 33);
            this.loginfrm_usernametextBox1.TabIndex = 1;
            this.loginfrm_usernametextBox1.WordWrap = false;
            this.loginfrm_usernametextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginfrm_textBox1_KeyDown);
            // 
            // loginfrm_passwordtextBox2
            // 
            this.loginfrm_passwordtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_passwordtextBox2.ForeColor = System.Drawing.Color.Indigo;
            this.loginfrm_passwordtextBox2.Location = new System.Drawing.Point(318, 181);
            this.loginfrm_passwordtextBox2.MaxLength = 10;
            this.loginfrm_passwordtextBox2.Multiline = true;
            this.loginfrm_passwordtextBox2.Name = "loginfrm_passwordtextBox2";
            this.loginfrm_passwordtextBox2.PasswordChar = '*';
            this.loginfrm_passwordtextBox2.Size = new System.Drawing.Size(201, 31);
            this.loginfrm_passwordtextBox2.TabIndex = 2;
            this.loginfrm_passwordtextBox2.WordWrap = false;
            this.loginfrm_passwordtextBox2.TextChanged += new System.EventHandler(this.loginfrm_textBox2_TextChanged);
            this.loginfrm_passwordtextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginfrm_textBox2_KeyDown);
            // 
            // loginfrm_titlelable3
            // 
            this.loginfrm_titlelable3.AutoSize = true;
            this.loginfrm_titlelable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_titlelable3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.loginfrm_titlelable3.Location = new System.Drawing.Point(147, 23);
            this.loginfrm_titlelable3.Name = "loginfrm_titlelable3";
            this.loginfrm_titlelable3.Size = new System.Drawing.Size(527, 51);
            this.loginfrm_titlelable3.TabIndex = 6;
            this.loginfrm_titlelable3.Text = "RTO Managment System";
            // 
            // loginfrm_infolable4
            // 
            this.loginfrm_infolable4.AutoSize = true;
            this.loginfrm_infolable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_infolable4.Location = new System.Drawing.Point(318, 285);
            this.loginfrm_infolable4.Name = "loginfrm_infolable4";
            this.loginfrm_infolable4.Size = new System.Drawing.Size(100, 36);
            this.loginfrm_infolable4.TabIndex = 7;
            this.loginfrm_infolable4.Text = "Not an User ?\r\nRegister Here";
            // 
            // loginfrm_signupbutton
            // 
            this.loginfrm_signupbutton.ForeColor = System.Drawing.Color.Indigo;
            this.loginfrm_signupbutton.Location = new System.Drawing.Point(424, 288);
            this.loginfrm_signupbutton.Name = "loginfrm_signupbutton";
            this.loginfrm_signupbutton.Size = new System.Drawing.Size(75, 28);
            this.loginfrm_signupbutton.TabIndex = 6;
            this.loginfrm_signupbutton.Text = "Sign Up";
            this.loginfrm_signupbutton.UseVisualStyleBackColor = true;
            this.loginfrm_signupbutton.Click += new System.EventHandler(this.loginfrm_signupbutton_Click);
            // 
            // loginfrm_linkLabel1
            // 
            this.loginfrm_linkLabel1.AutoSize = true;
            this.loginfrm_linkLabel1.Location = new System.Drawing.Point(318, 265);
            this.loginfrm_linkLabel1.Name = "loginfrm_linkLabel1";
            this.loginfrm_linkLabel1.Size = new System.Drawing.Size(116, 16);
            this.loginfrm_linkLabel1.TabIndex = 5;
            this.loginfrm_linkLabel1.TabStop = true;
            this.loginfrm_linkLabel1.Text = "Forgot Password?";
            this.loginfrm_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginfrm_linkLabel1_LinkClicked);
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 342);
            this.Controls.Add(this.loginfrm_linkLabel1);
            this.Controls.Add(this.loginfrm_signupbutton);
            this.Controls.Add(this.loginfrm_infolable4);
            this.Controls.Add(this.loginfrm_titlelable3);
            this.Controls.Add(this.loginfrm_passwordtextBox2);
            this.Controls.Add(this.loginfrm_usernametextBox1);
            this.Controls.Add(this.loginfrm_lable2);
            this.Controls.Add(this.loginfrm_lable1);
            this.Controls.Add(this.loginfrm_canclebutton);
            this.Controls.Add(this.loginfrm_loginbutton);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Name = "Login_frm";
            this.Text = "Login Tab";
            this.Load += new System.EventHandler(this.Login_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginfrm_loginbutton;
        private System.Windows.Forms.Button loginfrm_canclebutton;
        private System.Windows.Forms.Label loginfrm_lable1;
        private System.Windows.Forms.Label loginfrm_lable2;
        private System.Windows.Forms.TextBox loginfrm_usernametextBox1;
        private System.Windows.Forms.TextBox loginfrm_passwordtextBox2;
        private System.Windows.Forms.Label loginfrm_titlelable3;
        private System.Windows.Forms.Label loginfrm_infolable4;
        private System.Windows.Forms.Button loginfrm_signupbutton;
        private System.Windows.Forms.LinkLabel loginfrm_linkLabel1;
    }
}

