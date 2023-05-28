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
    public partial class SignUp_frm : Form
    {
        public SignUp_frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signupfrm_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit();
        }

        private void SignUp_frm_Load(object sender, EventArgs e)
        {

        }

        private void signupfrm_submitbutton_Click(object sender, EventArgs e)
        {
            
            string strUserName, strPassword, strEmpfirstname, strEmplastname,strEmpdesig,strPAN,strAadhar,strMob,strEmail,straddres, Empid;
            

            strEmpfirstname = signupfrm_fnametextBox3.Text.ToUpper();    //Employee First Name Stored in string
            strEmplastname = signupfrm_lnametextBox1.Text.ToUpper();     //Employee Last Name Stored in string
            strEmpdesig = signupfrm_empdesigtextBox6.Text.ToUpper();               //Employee Designation Stored in string
            strPAN = signupfrm_pantextBox9.Text.ToUpper();                         //Employee PAN Stored in string
            strAadhar = signupfrm_aadhartextBox10.Text;                  //Employee Aadhar Stored in string
            strMob = signupfrm_mobtextBox7.Text;                         //Employee Mobile no Stored in string
            strEmail = signupfrm_emailtextBox8.Text.ToUpper();                     //Employee email Stored in string
            straddres = signupfrm_addrstextBox4.Text.ToUpper();                    //Employee address Stored in string
            strUserName = signupfrm_useridtextBox1.Text.ToUpper();       //User ID Stored in string
            strPassword = signupfrm_passwordtextBox2.Text;               //Password Stored in string
            Empid = signupfrm_empidtextBox5.Text;                       //Employee ID Stored in string


            Validation_Class txtboxobj1 = new Validation_Class();
            if (
                (txtboxobj1.blanktextbx(strEmpfirstname) == true) || (txtboxobj1.blanktextbx(strEmplastname) == true)
                || (txtboxobj1.blanktextbx(strEmpdesig) == true) || (txtboxobj1.blanktextbx(strPAN) == true)
                || (txtboxobj1.blanktextbx(strAadhar) == true) || (txtboxobj1.blanktextbx(strMob) == true)
                || (txtboxobj1.blanktextbx(strEmail) == true) || (txtboxobj1.blanktextbx(straddres) == true)
                || (txtboxobj1.blanktextbx(strUserName) == true) || (txtboxobj1.blanktextbx(strPassword) == true)
                || (txtboxobj1.blanktextbx(Empid) == true)
                )
            {
                MessageBox.Show("Blank Field, Please fill all the details on the form");
            }


            //SQL Connection Code   
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string sqlquery1 = "select * from RTO_EMP_DETAILS_Table where EMPLOYEE_ID='" + Empid + "'";
            //SqlDataAdapter sda = new SqlDataAdapter(sqlquery1,con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            SQLConnection_Class connectobj2 = new SQLConnection_Class();
            DataSet dsobj2 = new DataSet();
            dsobj2 = connectobj2.sqladdpter(sqlquery1);

            if (dsobj2.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Employee ID Already exist please try another");

            }
            else
            {
                string strsqlcmd = "insert into RTO_EMP_DETAILS_Table values(@EMPLOYEE_ID,@EMPLOYEE_FIRST_NAME,@EMPLOYEE_LAST_NAME,@EMPLOYEE_DESIGNATION,@EMPLOYEE_ADDRESS,@EMPLOYEE_MOBILE,@EMPLOYEE_EMAIL,@EMPLOYEE_PAN,@EMPLOYEE_AADHAR,@EMPLOYEE_USER_NAME,@EMPLOYEE_PASSWORD,@EMPLOYEE_IS_ACTIVE)";
                bool isactive = true;

                SqlCommand cmd1 = new SqlCommand(strsqlcmd, con);
                cmd1.Parameters.AddWithValue("EMPLOYEE_ID", Empid);
                cmd1.Parameters.AddWithValue("EMPLOYEE_FIRST_NAME", strEmpfirstname);
                cmd1.Parameters.AddWithValue("EMPLOYEE_LAST_NAME", strEmplastname);
                cmd1.Parameters.AddWithValue("EMPLOYEE_DESIGNATION", strEmpdesig);
                cmd1.Parameters.AddWithValue("EMPLOYEE_ADDRESS", straddres);
                cmd1.Parameters.AddWithValue("EMPLOYEE_MOBILE", strMob);
                cmd1.Parameters.AddWithValue("EMPLOYEE_EMAIL", strEmail);
                cmd1.Parameters.AddWithValue("EMPLOYEE_PAN", strPAN);
                cmd1.Parameters.AddWithValue("EMPLOYEE_AADHAR", strAadhar);
                cmd1.Parameters.AddWithValue("EMPLOYEE_USER_NAME", strUserName);
                cmd1.Parameters.AddWithValue("EMPLOYEE_PASSWORD", strPassword);
                cmd1.Parameters.AddWithValue("EMPLOYEE_IS_ACTIVE", isactive);

                con.Open();           //Connection open here 
                cmd1.ExecuteNonQuery();
                con.Close();          //Connection Close here 
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }





            //SqlCommand cmd1 = new SqlCommand("insert into RTO_USER_LOGIN_Table values(@USER_NAME,@USER_PASSWORD,@EMPLOYEE_NAME,@EMPLOYEE_ID)", con);
            //cmd1.Parameters.AddWithValue("USER_NAME", strUserName);
            //cmd1.Parameters.AddWithValue("USER_PASSWORD", strPassword);
            //cmd1.Parameters.AddWithValue("EMPLOYEE_NAME", strEmpfirstname);
            //cmd1.Parameters.AddWithValue("EMPLOYEE_ID", Empid);

            //if (signupfrm_textBox2.Text != string.Empty || signupfrm_textBox1.Text != string.Empty)
            //{
            //    //if (txtpassword.Text == txtconfirmpassword.Text)
            //    //{
            //        cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", cn);
            //        dr = cmd.ExecuteReader();
            //        if (dr.Read())
            //        {
            //            dr.Close();
            //            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            dr.Close();
            //            cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
            //            cmd.Parameters.AddWithValue("username", txtusername.Text);
            //            cmd.Parameters.AddWithValue("password", txtpassword.Text);
            //            cmd.ExecuteNonQuery();
            //            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //}
            //else
            //{
            //    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void signupfrm_titlelable3_Click(object sender, EventArgs e)
        {

        }
    }
}
