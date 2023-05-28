using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_RTO
{
    public partial class UserReg_frm : Form
    {
        public UserReg_frm()
        {
            InitializeComponent();
        }

        private void UserReg_frm_Load(object sender, EventArgs e)
        {
           UserRegfrm_Closebutton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strempcode = UserRegfrm_EmpcodeextBox.Text;

            DataClassesDataContext obj1 = new DataClassesDataContext();
            var q = (from a in obj1.GetTable<Employee>()
                     where a.Emp_Code == strempcode
                     select a).SingleOrDefault();

            
            if (q != null)
            {
                int emp_idtemp = q.Emp_Id;
                UserRegfrm_nametextBox.Text = q.Emp_Name;
                UserRegfrm_empidtextBox.Text = q.Emp_Id.ToString();
                UserRegfrm_mobtextBox.Text = q.Emp_Mob;
                UserRegfrm_emailtextBox.Text = q.Emp_Email;
                UserRegfrm_addrstextBox.Text = q.Emp_Address;
                UserRegfrm_dateTimePicker.Text = q.Emp_Join_Date.ToString();
                UserRegfrm_aadhartextBox.Text = q.Emp_Aadhar;
                UserRegfrm_pantextBox.Text = q.Emp_Pan;
               
            }
            else
            {
                MessageBox.Show("Enter Correct employee code");
            }

            var query = (from b in obj1.GetTable<Department>() join
                        c in obj1.GetTable<X_Emp_Dept>() on b.Dept_Id equals c.Dept_Id where c.Emp_Id == q.Emp_Id
                        select b).SingleOrDefault();

            UserRegfrm_deptloctextBox.Text = query.Dept_Location.ToString();
            UserRegfrm_depttextBox.Text = query.Dept_Name.ToString();


            //select dept_name, dept_location from Department, X_Emp_Dept where Department.dept_id=X_Emp_Dept.dept_id and X_Emp_Dept.Emp_id=strEmpid;
            //select dept_name, dept_location from Department where dept_id=(select dept_id from X_Emp_Dept where Emp_ID=strEmpid);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                       
           
        }

        private void UserRegfrm_submitbutton_Click(object sender, EventArgs e)
        {
            string strUsr_Name, strUsr_Password, strEmp_Code; 
            int Emp_Id;
            strUsr_Name = UserRegfrm_useridtextBox.Text.ToUpper();
            strUsr_Password = UserRegfrm_passwordtextBox.Text;
            Emp_Id = Convert.ToInt16(UserRegfrm_empidtextBox.Text);
            strEmp_Code = UserRegfrm_EmpcodeextBox.Text;

            UserReg_Class userReg_ClassObj = new UserReg_Class();  
            if (userReg_ClassObj.UpdateLoginTablefn(strUsr_Name, strUsr_Password, Emp_Id, strEmp_Code))   // Insert new User ID & Password in Login Table
            {
                MessageBox.Show("User Name and Password Details saved successfully");
                SQLConClass.globalnewuserregistered = strUsr_Name;
                UserRegfrm_useridtextBox.Enabled = false;
                UserRegfrm_passwordtextBox.Enabled = false;
            }



            Role_Perm_frm Userprevilage_Frmobj = new Role_Perm_frm();
            Userprevilage_Frmobj.Show();
            UserRegfrm_Closebutton.Visible = true;
            UserRegfrm_canclebutton.Visible = false;



            SQLConClass Obj1 = new SQLConClass();
            DataTable dt = new DataTable();
            dt = Obj1.Getdatatablefrmdb("Login", "Usr_Name", strUsr_Name);
            int Login_Id = Convert.ToInt16(dt.Rows[0].ItemArray[0].ToString());
            userReg_ClassObj.passwordchangelogtablefn(Login_Id, strUsr_Name, strUsr_Password);   // Insert new User ID & Password in Password Change Log Table




        }

        private void UserRegfrm_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserRegfrm_Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
