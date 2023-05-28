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

namespace RTO_Management
{
    public partial class Dashboard1_frm : Form
    {
        string strusernametemp;
        public void userdata(string usernm)
        {
            
            strusernametemp = usernm;
        }
        public Dashboard1_frm()
        {
            InitializeComponent();
            
        }

        private void dashfrm_registlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application_Vehicle_frm settingsForm = new Application_Vehicle_frm();    //after successful verification it will open next form
            settingsForm.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application_Vehicle_frm settingsForm = new Application_Vehicle_frm();    //after successful verification it will open next form
            settingsForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application_Approval_frm settingsForm = new Application_Approval_frm();
            settingsForm.Show();
        }

        private void Dashboard1_frm_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = strusernametemp;
            //SQL Connection Code
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string sqlquery = "select EMPLOYEE_DESIGNATION from RTO_EMP_DETAILS_Table where EMPLOYEE_USER_NAME='" + strusernametemp + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if ((dt.Rows[0].ItemArray[0].ToString() != "SUPERVISOR") && (dt.Rows[0].ItemArray[0].ToString() != "ADMIN"))
            {
                dashboardfrm_NewAppbutton.Enabled = true;
                dashboardfrm_trackappbutton.Enabled = true;
                dashboardfrm_aaplistbutton.Enabled = true;
                dashboardfrm_appapprovalpbutton.Enabled = false;
            }
            else
            {
                dashboardfrm_NewAppbutton.Enabled = true;
                dashboardfrm_trackappbutton.Enabled = true;
                dashboardfrm_aaplistbutton.Enabled = true;
                dashboardfrm_appapprovalpbutton.Enabled = true;

            }
        }
    }
}
