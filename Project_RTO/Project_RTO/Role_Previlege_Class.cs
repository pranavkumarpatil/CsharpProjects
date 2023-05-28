using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Project_RTO
{
    internal class Role_Previlege_Class
    {
        public string Usr_Name { get; set; }
        public string Usr_Role { get; set; }
        public bool Veh_Reg_Perm { get; set; }
        public bool Veh_Aproval_Perm { get; set; }
        public bool DL_Manage_Perm { get; set; }
        public bool User_Manage_Perm { get; set; }

        public bool getnewuserprevileges(string Usr_Name)
        {
            DataClassesDataContext Obj1 = new DataClassesDataContext();

            var newuser = from a in Obj1.Roles_Permissions
                          where a.Usr_Name == Usr_Name
                          select a;

            Usr_Name = newuser.First().Usr_Name;
            Usr_Role = newuser.First().Usr_Role;
            Veh_Reg_Perm = Convert.ToBoolean(newuser.First().Veh_Reg_Perm);
            Veh_Aproval_Perm = Convert.ToBoolean(newuser.First().Veh_Aproval_Perm);
            DL_Manage_Perm = Convert.ToBoolean(newuser.First().DL_Manage_Perm);
            User_Manage_Perm = Convert.ToBoolean(newuser.First().User_Manage_Perm);

            return true;

        }

        
        public void previlegeupdatefn(string strusername, string strRole, bool Veh_Reg, bool Veh_Aprv, bool Dl_M, bool Usr_M)
        {

            string sqlquery = "exec proc_userprevilegeupdate " + strusername + ", '" + strRole + "', '" + Veh_Reg + "', '" + Veh_Aprv + "', '" + Dl_M + "', '" + Usr_M  + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            MessageBox.Show("User Pervileges updated successfully");
        }

        public void previlegeinsertfn(string strusername, string strRole, bool Veh_Reg, bool Veh_Aprv, bool Dl_M, bool Usr_M)
        {

            string sqlquery = "exec proc_userprevilegeinsert " + strusername + ", '" + strRole + "', '" + Veh_Reg + "', '" + Veh_Aprv + "', '" + Dl_M + "', '" + Usr_M + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            MessageBox.Show("New User Pervileges Inserted successfully");
        }




    }
}
