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
    public partial class Forgotpassword_frm : Form
    {
        public Forgotpassword_frm()
        {
            InitializeComponent();
        }

        private void forgotpassfrm_loginbutton_Click(object sender, EventArgs e)
        {
            string strEmpID, strfrgPassword;
            strEmpID = forgotpassfrm_empidtextBox5.Text;                      //Emp ID Stored in string
            strfrgPassword = forgotpassfrm_passwordtextBox2.Text;             //Password Stored in string
                                   

            //SQL Connection Code   
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string sqlquery2 = "select * from RTO_EMP_DETAILS_Table where EMPLOYEE_ID='" + strEmpID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery2,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
                            
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Employee ID Successfully Verified, Password is updated");
                string strcmd1 = "update RTO_EMP_DETAILS_Table set EMPLOYEE_PASSWORD='" + strfrgPassword + "' where EMPLOYEE_ID='" + strEmpID + "'";
                SqlCommand cmd1 = new SqlCommand(strcmd1, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Provided Employee ID is not available in database, Please Sign Up First");
                this.Close();
            }
        }

        private void forgotpass_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
