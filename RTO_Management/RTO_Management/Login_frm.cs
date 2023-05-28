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
    public delegate void deluserpassdata(string username);
    public partial class Login_frm : Form
    {
        
        public Login_frm()
        {
            InitializeComponent();
        }

        private void loginfrm_loginbutton_Click(object sender, EventArgs e)
        {
            string strUserName, strPassword;
            strUserName = loginfrm_usernametextBox1.Text.ToUpper();   //User Name Stored in string
            strPassword = loginfrm_passwordtextBox2.Text;             //Password Stored in string
                                                                      //Validation_Class textblankobj = new Validation_Class();
           
            //SQL Connection Code   
            //SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string sqlquery = "select * from RTO_EMP_DETAILS_Table where EMPLOYEE_USER_NAME='" + strUserName + "' and EMPLOYEE_PASSWORD='" + strPassword + "'";
            //SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            SQLConnection_Class connectobj1 = new SQLConnection_Class();
            DataSet dsobj1 = new DataSet();
            dsobj1 = connectobj1.sqladdpter(sqlquery);

            Login_Class loginobj = new Login_Class();
           if ( loginobj.loginfn(dsobj1, strUserName, strPassword))
            {
                Dashboard1_frm settingsForm = new Dashboard1_frm();        //after successful verification it will open next form
                deluserpassdata userpassdata = new deluserpassdata(settingsForm.userdata);  // Delegate used to transfer username to dashboard form
                userpassdata(strUserName);
                settingsForm.Show();
                this.Close();
            }

            //if (dsobj1.Tables[0].Rows.Count > 0)
            //{
            //    MessageBox.Show("Successfully loged in");

            //    Dashboard1_frm settingsForm = new Dashboard1_frm();        //after successful verification it will open next form
            //    settingsForm.Show();

            //this.Close();
            //}
            //else
            //{
            //    if ((textblankobj.blanktextbx(strUserName) == true) || (textblankobj.blanktextbx(strPassword) == true))
            //    {
            //        MessageBox.Show("Username or Password filed is blank");
            //    }
            //    else

            //    { MessageBox.Show("Please enter Correct Username and Password"); }
            //}


                      



        }

        private void loginfrm_canclebutton_Click(object sender, EventArgs e)
        {
              this.Close();
             // Application.Exit();
        }

        private void loginfrm_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void Login_frm_Load(object sender, EventArgs e)
        {

        }

        private void loginfrm_signupbutton_Click(object sender, EventArgs e)
        {
            SignUp_frm settingsForm = new SignUp_frm();        // it will open next form
            settingsForm.Show();
        }

        private void loginfrm_textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                MessageBox.Show("Caps Lock key Pressed");
            }

        }

        private void loginfrm_textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.CapsLock)
            {
                MessageBox.Show("Caps Lock key Pressed");
            }
        }

        private void loginfrm_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgotpassword_frm settingsnewForm = new Forgotpassword_frm();        // it will open next form
            settingsnewForm.Show();
        }
    }
}
