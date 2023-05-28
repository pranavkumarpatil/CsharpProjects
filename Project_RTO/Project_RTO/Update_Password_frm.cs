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
    public partial class Update_Password_frm : Form
    {
        public Update_Password_frm()
        {
            InitializeComponent();
        }

        private void forgotpassfrm_loginbutton_Click(object sender, EventArgs e)
        {
            string strUserName = SQLConClass.globleusernmpara;
            string strPassword = Update_Password_frm_passwordtextBox.Text;  

            DataTable dt = new DataTable();
            SQLConClass sQLConClassObj = new SQLConClass();
            dt = sQLConClassObj.Getdatatablefrmdb("Login", "Usr_Name", strUserName);

            int Login_Id = Convert.ToInt16(dt.Rows[0].ItemArray[0]);

            Login_Class Obj1 = new Login_Class();
            Obj1.Newpasswordchangelogintableupdatefn(strUserName, strPassword);
            Obj1.NewpasswordchangepasswordchangelogtableInsertfn(Login_Id, strUserName, strPassword);
            this.Close();

        }
    }
}
