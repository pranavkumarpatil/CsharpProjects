namespace RTO_Management
{
    partial class Dashboard1_frm
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
            this.loginfrm_titlelable3 = new System.Windows.Forms.Label();
            this.dashboardfrm_NewAppbutton = new System.Windows.Forms.Button();
            this.dashboardfrm_appapprovalpbutton = new System.Windows.Forms.Button();
            this.dashboardfrm_trackappbutton = new System.Windows.Forms.Button();
            this.dashboardfrm_aaplistbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginfrm_titlelable3
            // 
            this.loginfrm_titlelable3.AutoSize = true;
            this.loginfrm_titlelable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginfrm_titlelable3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.loginfrm_titlelable3.Location = new System.Drawing.Point(26, 19);
            this.loginfrm_titlelable3.Name = "loginfrm_titlelable3";
            this.loginfrm_titlelable3.Size = new System.Drawing.Size(514, 51);
            this.loginfrm_titlelable3.TabIndex = 7;
            this.loginfrm_titlelable3.Text = "Dashboard : Quick Links";
            // 
            // dashboardfrm_NewAppbutton
            // 
            this.dashboardfrm_NewAppbutton.Location = new System.Drawing.Point(53, 132);
            this.dashboardfrm_NewAppbutton.Name = "dashboardfrm_NewAppbutton";
            this.dashboardfrm_NewAppbutton.Size = new System.Drawing.Size(198, 61);
            this.dashboardfrm_NewAppbutton.TabIndex = 12;
            this.dashboardfrm_NewAppbutton.Text = "New Vehicle Registration Application";
            this.dashboardfrm_NewAppbutton.UseVisualStyleBackColor = true;
            this.dashboardfrm_NewAppbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dashboardfrm_appapprovalpbutton
            // 
            this.dashboardfrm_appapprovalpbutton.Location = new System.Drawing.Point(284, 132);
            this.dashboardfrm_appapprovalpbutton.Name = "dashboardfrm_appapprovalpbutton";
            this.dashboardfrm_appapprovalpbutton.Size = new System.Drawing.Size(198, 61);
            this.dashboardfrm_appapprovalpbutton.TabIndex = 13;
            this.dashboardfrm_appapprovalpbutton.Text = "New Vehicle Registration Application Approval";
            this.dashboardfrm_appapprovalpbutton.UseVisualStyleBackColor = true;
            this.dashboardfrm_appapprovalpbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboardfrm_trackappbutton
            // 
            this.dashboardfrm_trackappbutton.Location = new System.Drawing.Point(284, 222);
            this.dashboardfrm_trackappbutton.Name = "dashboardfrm_trackappbutton";
            this.dashboardfrm_trackappbutton.Size = new System.Drawing.Size(198, 61);
            this.dashboardfrm_trackappbutton.TabIndex = 14;
            this.dashboardfrm_trackappbutton.Text = "Track Application";
            this.dashboardfrm_trackappbutton.UseVisualStyleBackColor = true;
            // 
            // dashboardfrm_aaplistbutton
            // 
            this.dashboardfrm_aaplistbutton.Location = new System.Drawing.Point(53, 222);
            this.dashboardfrm_aaplistbutton.Name = "dashboardfrm_aaplistbutton";
            this.dashboardfrm_aaplistbutton.Size = new System.Drawing.Size(198, 61);
            this.dashboardfrm_aaplistbutton.TabIndex = 15;
            this.dashboardfrm_aaplistbutton.Text = "New Vehicle Registration Application List";
            this.dashboardfrm_aaplistbutton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // Dashboard1_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 402);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dashboardfrm_aaplistbutton);
            this.Controls.Add(this.dashboardfrm_trackappbutton);
            this.Controls.Add(this.dashboardfrm_appapprovalpbutton);
            this.Controls.Add(this.dashboardfrm_NewAppbutton);
            this.Controls.Add(this.loginfrm_titlelable3);
            this.Name = "Dashboard1_frm";
            this.Text = "Dashboard1_frm";
            this.Load += new System.EventHandler(this.Dashboard1_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginfrm_titlelable3;
        private System.Windows.Forms.Button dashboardfrm_NewAppbutton;
        private System.Windows.Forms.Button dashboardfrm_appapprovalpbutton;
        private System.Windows.Forms.Button dashboardfrm_trackappbutton;
        private System.Windows.Forms.Button dashboardfrm_aaplistbutton;
        private System.Windows.Forms.TextBox textBox1;
    }
}