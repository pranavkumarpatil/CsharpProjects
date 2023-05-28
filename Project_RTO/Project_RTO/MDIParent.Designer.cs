namespace Project_RTO
{
    partial class MDIParent
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlmanagementlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Location = new System.Drawing.Point(0, 28);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1662, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 977);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1662, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginTabToolStripMenuItem,
            this.userRegistrationToolStripMenuItem,
            this.vehicleManagmentToolStripMenuItem,
            this.dlmanagementlToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1662, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginTabToolStripMenuItem
            // 
            this.loginTabToolStripMenuItem.Name = "loginTabToolStripMenuItem";
            this.loginTabToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.loginTabToolStripMenuItem.Text = "Login Tab";
            this.loginTabToolStripMenuItem.Click += new System.EventHandler(this.loginTabToolStripMenuItem_Click_1);
            // 
            // userRegistrationToolStripMenuItem
            // 
            this.userRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerUserToolStripMenuItem,
            this.previToolStripMenuItem});
            this.userRegistrationToolStripMenuItem.Name = "userRegistrationToolStripMenuItem";
            this.userRegistrationToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.userRegistrationToolStripMenuItem.Text = "User Managment";
            this.userRegistrationToolStripMenuItem.Click += new System.EventHandler(this.userRegistrationToolStripMenuItem_Click);
            // 
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.registerUserToolStripMenuItem.Text = "Register User";
            this.registerUserToolStripMenuItem.Click += new System.EventHandler(this.registerUserToolStripMenuItem_Click);
            // 
            // previToolStripMenuItem
            // 
            this.previToolStripMenuItem.Name = "previToolStripMenuItem";
            this.previToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.previToolStripMenuItem.Text = "Privileges & Role";
            this.previToolStripMenuItem.Click += new System.EventHandler(this.previToolStripMenuItem_Click);
            // 
            // vehicleManagmentToolStripMenuItem
            // 
            this.vehicleManagmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerVehicleToolStripMenuItem,
            this.approveVehicleToolStripMenuItem});
            this.vehicleManagmentToolStripMenuItem.Name = "vehicleManagmentToolStripMenuItem";
            this.vehicleManagmentToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.vehicleManagmentToolStripMenuItem.Text = "Vehicle Managment";
            // 
            // registerVehicleToolStripMenuItem
            // 
            this.registerVehicleToolStripMenuItem.Name = "registerVehicleToolStripMenuItem";
            this.registerVehicleToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.registerVehicleToolStripMenuItem.Text = "Register Vehicle";
            this.registerVehicleToolStripMenuItem.Click += new System.EventHandler(this.registerVehicleToolStripMenuItem_Click);
            // 
            // approveVehicleToolStripMenuItem
            // 
            this.approveVehicleToolStripMenuItem.Name = "approveVehicleToolStripMenuItem";
            this.approveVehicleToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.approveVehicleToolStripMenuItem.Text = "Approve Vehicle";
            this.approveVehicleToolStripMenuItem.Click += new System.EventHandler(this.approveVehicleToolStripMenuItem_Click);
            // 
            // dlmanagementlToolStripMenuItem
            // 
            this.dlmanagementlToolStripMenuItem.Name = "dlmanagementlToolStripMenuItem";
            this.dlmanagementlToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.dlmanagementlToolStripMenuItem.Text = "DL Managment";
            this.dlmanagementlToolStripMenuItem.Click += new System.EventHandler(this.dlmanagementlToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Status";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 1003);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent";
            this.Text = "MDIParent";
            this.Activated += new System.EventHandler(this.MDIParent_Activated);
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.MdiChildActivate += new System.EventHandler(this.MDIParent_MdiChildActivate);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dlmanagementlToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}



