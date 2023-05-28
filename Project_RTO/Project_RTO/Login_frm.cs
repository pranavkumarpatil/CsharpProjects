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
    
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void loginfrm_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginfrm_loginbutton_Click(object sender, EventArgs e)
        {
            string strUserName, strPassword;
            strUserName = loginfrm_usernametextBox.Text.ToUpper();   //User Name Stored in string
            strPassword = loginfrm_passwordtextBox.Text;             //Password Stored in string
            SQLConClass.globleusernmpara = strUserName;               //User Name Stored in global string parameter
            SQLConClass.globleuserpasspara = strPassword;             //User Name Stored in global string parameter

            string sqlquery = "select * from Login where Usr_Name='" + strUserName + "' and Usr_Password='" + strPassword + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, SQLConClass.con );
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0].ItemArray[5].ToString() == "True")
            {
                Update_Password_frm update_Password_FrmObj = new Update_Password_frm();
                update_Password_FrmObj.Show();

            }


                Login_Class loginobj = new Login_Class();
            if ((loginobj.loginfn(dt, strUserName, strPassword))==true)
            {
                string sqlquery1 = "select * from Roles_Permission where Usr_Name='" + strUserName + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(sqlquery1, SQLConClass.con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);


                bool Usr_M, Veh_Reg, Veh_Aprv, Dl_M;
                Veh_Reg = Convert.ToBoolean(dt1.Rows[0].ItemArray[3].ToString());
                Veh_Aprv = Convert.ToBoolean(dt1.Rows[0].ItemArray[4].ToString());
                Dl_M = Convert.ToBoolean(dt1.Rows[0].ItemArray[5].ToString());
                Usr_M = Convert.ToBoolean(dt1.Rows[0].ItemArray[6].ToString());



                Control[] controls = this.MdiParent.Controls.Find("menuStrip1", true);  //find the name of strip  created by you
                foreach (Control ctrl in controls)
                {
                    if (ctrl.Name == "menuStrip1") // match if found so you can iterate in it
                    {
                        MenuStrip strip = ctrl as MenuStrip;
                        strip.Items["loginTabToolStripMenuItem"].Enabled = false; //Disable Login Menu
                        strip.Items["logoutToolStripMenuItem"].Enabled=true;
                        

                        if (Usr_M == true)                                        //Enable User Reg Menu
                        {
                          strip.Items["userRegistrationToolStripMenuItem"].Enabled = true;
                          
                        }
                        if (Veh_Reg == true || Veh_Aprv == true)
                        {
                            strip.Items["vehicleManagmentToolStripMenuItem"].Enabled = true;

                        }

                        foreach (ToolStripMenuItem  toolstrip in strip.Items)
                        {
                            if (toolstrip.Name == "vehicleManagmentToolStripMenuItem")
                            {
                                ToolStripMenuItem toolStripMenuItem = toolstrip as ToolStripMenuItem;

                                if (Veh_Reg == true)
                                {
                                    
                                    toolStripMenuItem.DropDownItems["registerVehicleToolStripMenuItem"].Enabled = true;
                                   
                                }
                                else
                                {
                                    toolStripMenuItem.DropDownItems["registerVehicleToolStripMenuItem"].Enabled = false;
                                }

                                if (Veh_Aprv == true)
                                {
                                  
                                    toolStripMenuItem.DropDownItems["approveVehicleToolStripMenuItem"].Enabled = true;
                                }
                                else
                                {
                                    toolStripMenuItem.DropDownItems["approveVehicleToolStripMenuItem"].Enabled = false;
                                }

                            }
                        }
                        
                        
                        if (Dl_M == true)
                        { strip.Items["dlmanagementlToolStripMenuItem"].Enabled = true; }

                    }
                   
                }
                Control[] controls2 = this.MdiParent.Controls.Find("label1", true);  //find the name of lable  created by you
                foreach (Control ctrl2 in controls2)
                {
                    if (ctrl2.Name == "label1") // match if found so you can iterate in it
                    {
                       Label lbl = ctrl2 as Label;
                        lbl.Text = "Logged in User Name is: " + strUserName;

                    }

                }


                int log_id = Convert.ToInt16(dt.Rows[0].ItemArray[0].ToString()); 
                bool loginattempfail = false;

                loginobj.loginlogupdatefn(log_id, strUserName, loginattempfail);   // To update Login-Logout Log Table

                this.Close();
               
            }




        }

        private void loginfrm_forgotpasslinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strUserName, strnewPassword, strEmpName, strEmpEmail;
            bool Usr_Password_Change = true;

            strUserName = loginfrm_usernametextBox.Text.ToUpper();
            if (strUserName != "")
            {
                Login_Class Obj1 = new Login_Class();
                strnewPassword = Obj1.CreateRandomPassword();
                Obj1.GetEmployeeNameEmail(strUserName);
                strEmpEmail = Obj1.Emp_Email;
                strEmpName = Obj1.Emp_Name;
                Obj1.forgotpasswordfn(strUserName, strnewPassword, strEmpName, strEmpEmail);
                Obj1.UpdateLogintablepasswordchangefn(strUserName, strnewPassword, Usr_Password_Change);
                Obj1.UpdatePasswordchangelogtablefn(strUserName, strnewPassword);
                MessageBox.Show("New Password has been sent to your registered Email. Kindly relogin with new Password");

            }
            else
            {
                MessageBox.Show("Enter the User Name");
            }

        }
    }
}
