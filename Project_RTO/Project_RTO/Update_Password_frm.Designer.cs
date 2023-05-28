namespace Project_RTO
{
    partial class Update_Password_frm
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
            this.Update_Password_frm_resetbutton = new System.Windows.Forms.Button();
            this.Update_Password_frm_infolable12 = new System.Windows.Forms.Label();
            this.Update_Password_frm_passwordtextBox = new System.Windows.Forms.TextBox();
            this.Update_Password_frm_newpasslable2 = new System.Windows.Forms.Label();
            this.Update_Password_frm_titlelable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Update_Password_frm_resetbutton
            // 
            this.Update_Password_frm_resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Password_frm_resetbutton.ForeColor = System.Drawing.Color.Indigo;
            this.Update_Password_frm_resetbutton.Location = new System.Drawing.Point(275, 149);
            this.Update_Password_frm_resetbutton.Name = "Update_Password_frm_resetbutton";
            this.Update_Password_frm_resetbutton.Size = new System.Drawing.Size(88, 32);
            this.Update_Password_frm_resetbutton.TabIndex = 33;
            this.Update_Password_frm_resetbutton.Text = "Reset";
            this.Update_Password_frm_resetbutton.UseVisualStyleBackColor = true;
            this.Update_Password_frm_resetbutton.Click += new System.EventHandler(this.forgotpassfrm_loginbutton_Click);
            // 
            // Update_Password_frm_infolable12
            // 
            this.Update_Password_frm_infolable12.AutoSize = true;
            this.Update_Password_frm_infolable12.ForeColor = System.Drawing.Color.Indigo;
            this.Update_Password_frm_infolable12.Location = new System.Drawing.Point(102, 193);
            this.Update_Password_frm_infolable12.Name = "Update_Password_frm_infolable12";
            this.Update_Password_frm_infolable12.Size = new System.Drawing.Size(423, 112);
            this.Update_Password_frm_infolable12.TabIndex = 32;
            this.Update_Password_frm_infolable12.Text = "Password Guidlines -\r\n1) Must be between 6 to 10 characters long.\r\n2) Can contain" +
    " any letters from a to z and any numbers from 0 through 9.\r\n3) Can not contain a" +
    "ny special characters.\r\n\r\n\r\n\r\n";
            // 
            // Update_Password_frm_passwordtextBox
            // 
            this.Update_Password_frm_passwordtextBox.Location = new System.Drawing.Point(316, 92);
            this.Update_Password_frm_passwordtextBox.MaxLength = 10;
            this.Update_Password_frm_passwordtextBox.Name = "Update_Password_frm_passwordtextBox";
            this.Update_Password_frm_passwordtextBox.Size = new System.Drawing.Size(214, 22);
            this.Update_Password_frm_passwordtextBox.TabIndex = 30;
            // 
            // Update_Password_frm_newpasslable2
            // 
            this.Update_Password_frm_newpasslable2.AutoSize = true;
            this.Update_Password_frm_newpasslable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Password_frm_newpasslable2.ForeColor = System.Drawing.Color.Indigo;
            this.Update_Password_frm_newpasslable2.Location = new System.Drawing.Point(101, 92);
            this.Update_Password_frm_newpasslable2.Name = "Update_Password_frm_newpasslable2";
            this.Update_Password_frm_newpasslable2.Size = new System.Drawing.Size(181, 20);
            this.Update_Password_frm_newpasslable2.TabIndex = 29;
            this.Update_Password_frm_newpasslable2.Text = "Enter new Password";
            // 
            // Update_Password_frm_titlelable
            // 
            this.Update_Password_frm_titlelable.AutoSize = true;
            this.Update_Password_frm_titlelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Password_frm_titlelable.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Update_Password_frm_titlelable.Location = new System.Drawing.Point(87, 21);
            this.Update_Password_frm_titlelable.Name = "Update_Password_frm_titlelable";
            this.Update_Password_frm_titlelable.Size = new System.Drawing.Size(495, 32);
            this.Update_Password_frm_titlelable.TabIndex = 27;
            this.Update_Password_frm_titlelable.Text = "Update System Genrated Password";
            // 
            // Update_Password_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 292);
            this.Controls.Add(this.Update_Password_frm_resetbutton);
            this.Controls.Add(this.Update_Password_frm_infolable12);
            this.Controls.Add(this.Update_Password_frm_passwordtextBox);
            this.Controls.Add(this.Update_Password_frm_newpasslable2);
            this.Controls.Add(this.Update_Password_frm_titlelable);
            this.Name = "Update_Password_frm";
            this.Text = "Update Password Tab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Update_Password_frm_resetbutton;
        private System.Windows.Forms.Label Update_Password_frm_infolable12;
        private System.Windows.Forms.TextBox Update_Password_frm_passwordtextBox;
        private System.Windows.Forms.Label Update_Password_frm_newpasslable2;
        private System.Windows.Forms.Label Update_Password_frm_titlelable;
    }
}