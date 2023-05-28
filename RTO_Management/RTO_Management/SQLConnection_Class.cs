using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace RTO_Management
{
    public class SQLConnection_Class
    {
       
        public void sqlcon()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");

        }
        public DataSet sqladdpter(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

    }
}
