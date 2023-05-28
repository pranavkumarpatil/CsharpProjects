using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Project_RTO
{
    internal class Vehicle_Reg_Class
    {

        public void Customerdatainsertfn(string strCustCode, string strOwnername, string strOwnerAdd, string strOwnerPAN, string strOwneraadharno, string strownerMobno, string strowneremail)
        {

            string sqlquery = "exec proc_custdatainsert " + strCustCode + ", '" + strOwnername + "', '" + strOwnerAdd + "', '" + strOwnerPAN + "', '" + strOwneraadharno + "', '" + strownerMobno + "', '" + strowneremail + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            //MessageBox.Show("Customer Details Logged successfully");
        }

        public void Vehicledatainsertfn(string strVehiCode, string strCompany, string strModel, string strColor, string strVehicleType)
        {

            string sqlquery = "exec proc_Vehicledatainsert " + strVehiCode + ", '" + strCompany + "', '" + strModel + "', '" + strColor + "', '" + strVehicleType + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            //MessageBox.Show("Vehicle Details Logged successfully");
        }

        public void Cust_Vehicle_datainsertfn(int cust_id, string strCustCode, int veh_id, string strVehiCode, string strEngineno, string strChassisno, DateTime RegDate, string strApplicationID)
        {

            string sqlquery = "exec proc_Cust_Vehi_Datainsert " + cust_id + ", '" + strCustCode + "', '" + veh_id + "', '" + strVehiCode + "', '" + strEngineno + "', '" + strChassisno + "', '" + RegDate + "', '" + strApplicationID + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            //MessageBox.Show("Customer_Vehicle Common Details Logged successfully");
        }

        

        public void Documentstatusupdatefn(int cust_id, bool DocUploaded)
        {

            string sqlquery = "exec proc_Docuploadestatusinsert " + cust_id + ", '" + DocUploaded + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            //MessageBox.Show("Documnet Upload status Logged successfully");
        }




    }
}
