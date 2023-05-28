using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Project_RTO
{
    internal class UserReg_Class

    {
        public object GetUserDetailsfn(string strempcode)
        {
            DataClassesDataContext obj1 = new DataClassesDataContext();
            var q = (from a in obj1.GetTable<Employee>()
                     where a.Emp_Code == strempcode
                     select a).SingleOrDefault();
            
            return q;
        }

        public bool UpdateLoginTablefn(string strUsr_Name, string strUsr_Password, int Emp_Id, string strEmp_Code)
        {
            string sqlquery = "exec proc_usernmpassadd " + strUsr_Name + ", '" + strUsr_Password + "', '" + Emp_Id + "', '" + strEmp_Code + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
          
            return true;
        }

        public bool passwordchangelogtablefn(int Login_Id, string strUsr_Name, string strUsr_Password)
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
