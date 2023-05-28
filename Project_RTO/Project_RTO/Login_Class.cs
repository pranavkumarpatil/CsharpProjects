using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Project_RTO
{
    internal class Login_Class
    {
        public string Emp_Name { get; set; }
        public string Emp_Email { get; set; }
        public bool loginfn(DataTable dt, string username, string password)
        {


            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Successfully loged in");
                
                return true;

            }
            else
            {
               
                if ((username == "") || (password == ""))
                {
                    MessageBox.Show("Username or Password filed is blank");
                }
                else

                { MessageBox.Show("Please enter Correct Username and Password"); }

                return false;
            }



        }

        public void loginlogupdatefn(int lgn_id, string username, bool attempt )
        {
            
            string sqlquery = "exec proc_logindatetime " + lgn_id + ", '" + username + "', '" + attempt + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            //MessageBox.Show("Login Details Logged successfully");
        }

        public void logoutlogupdatefn(int lgn_id, string username)
        {

            string sqlquery = "exec proc_logoutdatetime " + lgn_id + ", '" + username + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            //MessageBox.Show("LogOut Details Logged successfully");
        }

        public bool GetEmployeeNameEmail (string username)
        {
            DataClassesDataContext Obj1 = new DataClassesDataContext();
            var query = (from b in Obj1.GetTable<Employee>()
                         join c in Obj1.GetTable<Login>() on b.Emp_Code equals c.Emp_Code
                         where c.Usr_Name == username
                         select b).SingleOrDefault();

            Emp_Name = query.Emp_Name.ToString();
            Emp_Email = query.Emp_Email.ToString();

           

            return true;
        }

        public string CreateRandomPassword(int length = 10)
        {
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

            // Select one random character at a time from the string  
            // and create an array of chars  
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }


        public void forgotpasswordfn(String UserName, string UserPassword, string strEmpName, string strEmpEmail)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("pranavpatil1581992@gmail.com", "pranav@93");



            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("pranavpatil1581992@gmail.com");
            mailMessage.To.Add(strEmpEmail);
            mailMessage.Subject = "New UserName and Password Generated";
            mailMessage.Body = "Dear " + strEmpName + "," + Environment.NewLine;
            mailMessage.Body += "Your user name is " + UserName + " and temporary password is " + UserPassword + "." + Environment.NewLine;
            mailMessage.Body += "Regard," + Environment.NewLine;
            mailMessage.Body += "RTO Admin";



            smtpClient.Send(mailMessage);
        }

        public bool UpdateLogintablepasswordchangefn(string strUsr_Name, string strUsr_Password, bool Usr_Password_Change)
        {
            string sqlquery = "exec proc_logintablepasswordchange '" + strUsr_Name + "', '" + strUsr_Password + "', '" + Usr_Password_Change + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 

            return true;
        }

        public bool UpdatePasswordchangelogtablefn(string strUsr_Name, string strUsr_Password)
        {
            string sqlquery = "exec proc_Passwordchangelogtableupdate '" + strUsr_Name + "', '" + strUsr_Password + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 

            return true;
        }


        public bool Newpasswordchangelogintableupdatefn(string strUsr_Name, string strUsr_Password)
        {
            string sqlquery = "exec proc_Newpasswordchangelogintableupdate '" + strUsr_Name + "', '" + strUsr_Password + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 

            return true;
        }

        
        public bool NewpasswordchangepasswordchangelogtableInsertfn(int Login_Id, string strUsr_Name, string strUsr_Password)
        {
            string sqlquery = "exec proc_usernmpassaddtopasswordchangelogtable " + Login_Id + ", '" + strUsr_Name + "', '" + strUsr_Password + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 

            return true;
        }

    }





}
