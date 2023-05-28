using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace RTO_Management
{
    internal class Login_Class
    {

        public  bool loginfn(DataSet ds, string username, string password)
        {


            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Successfully loged in");

               /* Dashboard1_frm settingsForm = new Dashboard1_frm(); */       //after successful verification it will open next form
                //settingsForm.Show();
                return true;
                
            }
            else
            {
                Validation_Class txtboxobj = new Validation_Class();
                if ((txtboxobj.blanktextbx(username) == true) || (txtboxobj.blanktextbx(password) == true))
                {
                    MessageBox.Show("Username or Password filed is blank");
                }
                else

                { MessageBox.Show("Please enter Correct Username and Password"); }
               return false;
            }

                     
                       
        }


       



        


    }
}

