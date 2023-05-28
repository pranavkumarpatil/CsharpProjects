using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTO_Management
{
    public partial class MDIParent_frm : Form
    {
        private int childFormNumber = 0;

        public MDIParent_frm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void loginTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void signUpTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp_frm signup_Frmobj = new SignUp_frm();
            signup_Frmobj.MdiParent = this;
            signup_Frmobj.Show();
        }

        private void forgotPasswordTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forgotpassword_frm forgotpass_Frmobj = new Forgotpassword_frm();
            forgotpass_Frmobj.MdiParent = this;
            forgotpass_Frmobj.Show();

        }

        private void dashboardQickLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newVehicleApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application_Vehicle_frm applivehicle_Frmobj = new Application_Vehicle_frm();
            applivehicle_Frmobj.MdiParent = this;
            applivehicle_Frmobj.Show();
        }

        private void applicationApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application_Approval_frm appliaprovalvehicle_Frmobj = new Application_Approval_frm();
            appliaprovalvehicle_Frmobj.MdiParent = this;
            appliaprovalvehicle_Frmobj.Show();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginTabToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login_frm login_Frmobj = new Login_frm();
            login_Frmobj.MdiParent = this;
            login_Frmobj.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard1_frm dashboard_Frmobj = new Dashboard1_frm();
            dashboard_Frmobj.MdiParent = this;
            dashboard_Frmobj.Show();
        }
    }
    
}
