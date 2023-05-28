using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_RTO
{
    public class SQLConClass
    {
        public static SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PROJECT_RTO;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
        public static string globleusernmpara = "";
        public static string globleuserpasspara = "";
        public static string globalnewuserregistered = "";


       public DataTable Getdatatablefrmdb (string tablename, string tablecolumnname, string value)
        {
            string sqlquery = "select * from " + tablename + " where " + tablecolumnname + "='" + value + "'";

            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, SQLConClass.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;

        }






    }
}
