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
    public partial class Role_Perm_frm : Form
    {
        public Role_Perm_frm()
        {
            InitializeComponent();
            
        }

        private void Role_Perm_frm_Load(object sender, EventArgs e)
        {
            if (SQLConClass.globalnewuserregistered!="")
            {
                string strnewregistereduser = SQLConClass.globalnewuserregistered;
                Role_Permfrm_usernametextBox.Text = strnewregistereduser;
                Role_Permfrm_usernametextBox.Enabled = false;                
                MessageBox.Show("Assign the previleges to " + strnewregistereduser);

               
            }

           
        }

        private void Role_Permfrm_usernametextBox_KeyDown(object sender, KeyEventArgs e)
        {
                        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void Role_Permfrm_usernametextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strusername = Role_Permfrm_usernametextBox.Text.ToUpper();

            Role_Previlege_Class obj1 = new Role_Previlege_Class();
               
                if (obj1.getnewuserprevileges(strusername))
                {
                    Role_Permfrm_roletextBox.Text = obj1.Usr_Role.ToString();
                    Role_Permfrm_usermanagecheckBox.Checked = obj1.User_Manage_Perm;
                    Role_Permfrm_vehicleRegicheckBox.Checked = obj1.Veh_Reg_Perm;
                    Role_Permfrm_VehicleApprovcheckBox.Checked = obj1.Veh_Aproval_Perm;
                    Role_Permfrm_dlmanagmentcheckBox.Checked = obj1.DL_Manage_Perm;
                    UserRegfrm_GetDatabutton.Enabled=false;
                }
                else
                {
                MessageBox.Show("Enter the correct User Name");
                Role_Permfrm_usernametextBox.Text = "";
                UserRegfrm_GetDatabutton.Enabled = true;
                }
            
        }

        private void UserRegfrm_submitbutton_Click(object sender, EventArgs e)
        {
            if (Role_Permfrm_usernametextBox.Text != "")
            {
                bool Usr_M, Veh_Reg, Veh_Aprv, Dl_M;
                string strRole, strusername;

                Veh_Reg = Convert.ToBoolean(Role_Permfrm_vehicleRegicheckBox.Checked.ToString());
                Veh_Aprv = Convert.ToBoolean(Role_Permfrm_VehicleApprovcheckBox.Checked.ToString());
                Dl_M = Convert.ToBoolean(Role_Permfrm_dlmanagmentcheckBox.Checked.ToString());
                Usr_M = Convert.ToBoolean(Role_Permfrm_usermanagecheckBox.Checked.ToString());
                strRole = Role_Permfrm_roletextBox.Text;
                strusername = Role_Permfrm_usernametextBox.Text.ToUpper();

                if (UserRegfrm_GetDatabutton.Enabled == false)
                {
                    //update the table
                    Role_Previlege_Class obj1 = new Role_Previlege_Class();
                    obj1.previlegeupdatefn(strusername, strRole, Veh_Reg, Veh_Aprv, Dl_M, Usr_M);
                    this.Close();

                }
                else
                {
                    //insert in the table
                    Role_Previlege_Class obj1 = new Role_Previlege_Class();
                    obj1.previlegeinsertfn(strusername, strRole, Veh_Reg, Veh_Aprv, Dl_M, Usr_M);
                    SQLConClass.globalnewuserregistered = "";
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("User Name filed can not be blank");
            }
        }

        private void UserRegfrm_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
