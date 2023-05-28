using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_RTO
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;
                        

        public MDIParent()
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
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
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

        private void loginTabToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login_frm login_Frmobj = new Login_frm();
            login_Frmobj.MdiParent = this;
            login_Frmobj.Show();
            login_Frmobj.WindowState = FormWindowState.Maximized;

        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
                        
            
                loginTabToolStripMenuItem.Enabled = true;
                userRegistrationToolStripMenuItem.Enabled = false;
                vehicleManagmentToolStripMenuItem.Enabled = false;
                dlmanagementlToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = false;
                label1.Text = "User not Logged In";
            
            
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MDIParent_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void MDIParent_Activated(object sender, EventArgs e)
        {
            
        }

        private void previToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role_Perm_frm Userprevilage_Frmobj = new Role_Perm_frm();
            Userprevilage_Frmobj.MdiParent = this;
            Userprevilage_Frmobj.Show();
        }

        private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserReg_frm UserReg_Frmobj = new UserReg_frm();
            UserReg_Frmobj.MdiParent = this;
            UserReg_Frmobj.Show();
            UserReg_Frmobj.WindowState = FormWindowState.Maximized;

        }

        private void registerVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicle_Reg_frm Vehicle_Reg_frmobj = new Vehicle_Reg_frm();
            Vehicle_Reg_frmobj.MdiParent = this;
            Vehicle_Reg_frmobj.Show();
            Vehicle_Reg_frmobj.WindowState = FormWindowState.Maximized;
        }

        private void approveVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationAprovalForm ApplicationAprovalFormObj = new ApplicationAprovalForm();
            ApplicationAprovalFormObj.MdiParent = this;
            ApplicationAprovalFormObj.Show();
            ApplicationAprovalFormObj.WindowState = FormWindowState.Maximized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strUserName = SQLConClass.globleusernmpara;
           
            string sqlquery = "select LoginOut_Id from loginlogotlog where Usr_Name='" + strUserName + "' and Logoutdatetime is NULL";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, SQLConClass.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int log_id = Convert.ToInt16(dt.Rows[0].ItemArray[0].ToString());
            Login_Class logoutobj = new Login_Class();
            logoutobj.logoutlogupdatefn(log_id, strUserName);  // To update Login-Logout Log Table

            Login_frm login_FrmObj = new Login_frm();
            login_FrmObj.MdiParent = this;  
            login_FrmObj.Show();
            login_FrmObj.WindowState = FormWindowState.Maximized;
            loginTabToolStripMenuItem.Enabled = true;
            userRegistrationToolStripMenuItem.Enabled = false;
            vehicleManagmentToolStripMenuItem.Enabled = false;
            dlmanagementlToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            label1.Text = "User not Logged In";

        }

        private void dlmanagementlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DL Management is future scope, Currently not included in project");
        }
    }
}
