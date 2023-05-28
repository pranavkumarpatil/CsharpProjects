using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_RTO
{
    internal class VehApplicationAprovalClass
    {

        public string strCompany { get; set; }
        public string strModel { get; set; }
        public string strColor { get; set; }
        public string strVehicletype { get; set; }
        public string strChassisno { get; set; }
        public string strEngineno { get; set; }
        public string strOwnername { get; set; }
        public string strOwnerAdd { get; set; }
        public string strownerMobno { get; set; }
        public string strowneremail { get; set; }
        public string strOwneraadharno { get; set; }
        public string strOwnerPAN { get; set; }
        public DateTime RegDate { get; set; }
        public bool DocUploaded { get; set; }
        public int Cust_id { get; set; }
        public int Veh_id { get; set; }
        public string strApp_status { get; set; }


        public bool getregistrationtabledetails(string strApplicationID)
        {
            DataClassesDataContext Obj1 = new DataClassesDataContext();

            var regdetails = (from a in Obj1.GetTable<Registration>()
                             where a.Application_ID == strApplicationID
                             select a).SingleOrDefault(); 

            strEngineno = regdetails.EngineNo.ToString();
            strChassisno = regdetails.ChassisNo.ToString();
            RegDate = Convert.ToDateTime(regdetails.Reg_Apply_Date);
            Cust_id = Convert.ToInt16(regdetails.Cust_Id);
            Veh_id = Convert.ToInt16(regdetails.Veh_Id);
            strApp_status = regdetails.Application_Status.ToString();

            return true;

        }

        public bool getcustomertabledetails(string strApplicationID, int Cust_id)
        {
            DataClassesDataContext Obj1 = new DataClassesDataContext();
            var custdetails = (from b in Obj1.GetTable<Customer>()
                         join c in Obj1.GetTable<Registration>() on b.Cust_Id equals c.Cust_Id
                         where c.Application_ID == strApplicationID
                         select b).SingleOrDefault();

            strOwnername = custdetails.Cust_Name.ToString();
            strOwnerAdd = custdetails.Cust_Address.ToString();
            strownerMobno = custdetails.Cust_Mob.ToString();
            strowneremail = custdetails.Cust_Email.ToString();
            strOwneraadharno = custdetails.Cust_Aadhar.ToString();
            strOwnerPAN = custdetails.Cust_Pan.ToString();
            
            return true;

        }

        public bool getvehicletabledetails(string strApplicationID, int Veh_id)
        {
            DataClassesDataContext Obj1 = new DataClassesDataContext();
            var vehdetails = (from b in Obj1.GetTable<Vehicle>()
                               join c in Obj1.GetTable<Registration>() on b.Veh_Id equals c.Veh_Id
                               where c.Application_ID == strApplicationID
                               select b).SingleOrDefault();

            strCompany = vehdetails.Veh_Company.ToString();
            strModel = vehdetails.Veh_Model.ToString();
            strColor = vehdetails.Veh_Color.ToString();
            strVehicletype = vehdetails.Veh_Type.ToString();
            
            return true;

        }

        public bool getdocumenttabledetails(string strApplicationID, int Cust_id)
        {
            DataClassesDataContext Obj1 = new DataClassesDataContext();
            var docdetails = (from b in Obj1.GetTable<X_Cust_Doc>()
                              join c in Obj1.GetTable<Registration>() on b.Cust_Id equals c.Cust_Id
                              where c.Application_ID == strApplicationID
                              select b).SingleOrDefault();

            DocUploaded = Convert.ToBoolean(docdetails.Doc_Upload);
            
            return true;

        }

        public string getVehicleRegistrationNo(int length = 4)

        {
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validChars = "0123456789";
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

        public void VehicleRegNofn(string VehicleRegNo, string strApplicationID)
        {

            string sqlquery = "exec proc_registrationnoinsert '" + VehicleRegNo + "', '" + strApplicationID + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, SQLConClass.con);
            SQLConClass.con.Open();           //Connection open here 
            cmd.ExecuteNonQuery();
            SQLConClass.con.Close();          //Connection Close here 
            MessageBox.Show("Registration Number Logged successfully");
        }












    }
}
