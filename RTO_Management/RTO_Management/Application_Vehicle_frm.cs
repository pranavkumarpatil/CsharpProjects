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

namespace RTO_Management
{
    public partial class Application_Vehicle_frm : Form
    {
        public Application_Vehicle_frm()
        {
            InitializeComponent();
        }

        private void applfrm_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applfrm_submitbutton_Click(object sender, EventArgs e)
        {
            string strMake, strModel, strEnginNo, strChassisNo, strColour, strVehclss, strFueltype, strSeatcap, 
                strStandseatcap, strRegauth,strInsurco, strInsurno, strOwnername, strOwneradd, strOwnermob, strApplictaionID;
            DateTime Issuedate, Validuptodate;

            strMake = applfrm_makernametextBox3.Text.ToUpper();              //Make Name Stored in string
            strModel = applfrm_modeltextBox1.Text.ToUpper();                 //Model Name Stored in string
            strEnginNo = applfrm_engnotextBox5.Text.ToUpper();              //Engine No Stored in string
            strChassisNo = applfrm_chassistextBox6.Text.ToUpper();          //Chassis No Stored in string
            strColour = applfrm_colortextBox9.Text.ToUpper();               //Colour Name Stored in string
            strVehclss = applfrm_vehicleclastextBox10.Text.ToUpper();       //Vehicle Class Name Stored in string
            strFueltype = applfrm_fueltypetextBox7.Text.ToUpper();          //fuel type Stored in string
            strSeatcap = applfrm_seatcaptextBox3.Text.ToUpper();            //Seat Capacity Stored in string
            strStandseatcap = applfrm_standcaptextBox5.Text.ToUpper();      //Standing Seat capacity Stored in string
            strRegauth = applfrm_regiauthtextBox4.Text.ToUpper();           //Registration Authority Stored in string
            strInsurco = applfrm_insurancecotextBox1.Text.ToUpper();       //Insurance Compnay Stored in string
            strInsurno = applfrm_insurancenotextBox2.Text.ToUpper();       //Insurance No in string
            strOwnername = applfrm_ownernametextBox8.Text.ToUpper();       //Owner Name Stored in string
            strOwneradd = applfrm_owneraddrstextBox4.Text.ToUpper();       //Owner address Stored in string
            strOwnermob = applfrm_mobnotextBox6.Text.ToUpper();            //Owner Mobile No Stored in string

            Issuedate = Convert.ToDateTime(applfrm_validdatedateTimePicker2.Text);      //Issue Date Stored 
            Validuptodate = Convert.ToDateTime(applfrm_validdatedateTimePicker1.Text);  //Valid Upto Date Stored 

            

            Validation_Class txtboxobj1 = new Validation_Class();
            if (
                (txtboxobj1.blanktextbx(strMake) == true) || (txtboxobj1.blanktextbx(strModel) == true)
                || (txtboxobj1.blanktextbx(strEnginNo) == true) || (txtboxobj1.blanktextbx(strChassisNo) == true)
                || (txtboxobj1.blanktextbx(strColour) == true) || (txtboxobj1.blanktextbx(strVehclss) == true)
                || (txtboxobj1.blanktextbx(strFueltype) == true) || (txtboxobj1.blanktextbx(strSeatcap) == true)
                || (txtboxobj1.blanktextbx(strStandseatcap) == true) || (txtboxobj1.blanktextbx(strRegauth) == true)
                || (txtboxobj1.blanktextbx(strInsurco) == true) || (txtboxobj1.blanktextbx(strInsurno) == true)
                || (txtboxobj1.blanktextbx(strOwnername) == true) || (txtboxobj1.blanktextbx(strOwneradd) == true)
                || (txtboxobj1.blanktextbx(strOwnermob) == true)
                )
            {
                MessageBox.Show("Blank Field, Please fill all the details on the form");
            }

            else
            {
                strApplictaionID = "MH"+ strEnginNo.Substring(0, 4) + "_" + strChassisNo.Substring(0, 4);

                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");

                string strsqlcmd2 = "insert into RTO_VEHICLE_REG_Table values(@APPLICATION_ID,@MAKE_NAME,@MODEL_NAME,@ENGINE_NUM,@CHASSIS_NUM,@COLOUR,@VEHICLE_CLASS,@FUEL_TYPE,@SEAT_CAP,@STAND_SEAT_CAP,@REG_AUTH,@ISSUE_DATE,@VALIDUPTO_DATE,@INSUR_COM,@INSUR_NUM,@OWNER_NAME,@OWNER_ADDR,@OWNER_MOB,@APPL_STATUS)";

                SqlCommand cmd2 = new SqlCommand(strsqlcmd2, con);
                cmd2.Parameters.AddWithValue("APPLICATION_ID", strApplictaionID);
                cmd2.Parameters.AddWithValue("MAKE_NAME", strMake);
                cmd2.Parameters.AddWithValue("MODEL_NAME", strModel);
                cmd2.Parameters.AddWithValue("ENGINE_NUM", strEnginNo);
                cmd2.Parameters.AddWithValue("CHASSIS_NUM", strChassisNo);
                cmd2.Parameters.AddWithValue("COLOUR", strColour);
                cmd2.Parameters.AddWithValue("VEHICLE_CLASS", strVehclss);
                cmd2.Parameters.AddWithValue("FUEL_TYPE", strFueltype);
                cmd2.Parameters.AddWithValue("SEAT_CAP", strSeatcap);
                cmd2.Parameters.AddWithValue("STAND_SEAT_CAP", strStandseatcap);
                cmd2.Parameters.AddWithValue("REG_AUTH", strRegauth);
                cmd2.Parameters.AddWithValue("ISSUE_DATE", Issuedate);
                cmd2.Parameters.AddWithValue("VALIDUPTO_DATE", Validuptodate);
                cmd2.Parameters.AddWithValue("INSUR_COM", strInsurco);
                cmd2.Parameters.AddWithValue("INSUR_NUM", strInsurno);
                cmd2.Parameters.AddWithValue("OWNER_NAME", strOwnername);
                cmd2.Parameters.AddWithValue("OWNER_ADDR", strOwneradd);
                cmd2.Parameters.AddWithValue("OWNER_MOB", strOwnermob);
                cmd2.Parameters.AddWithValue("APPL_STATUS", "Submitted");

                con.Open();           //Connection open here 
                cmd2.ExecuteNonQuery();
                con.Close();          //Connection Close here 
                MessageBox.Show("Your Application is submitted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }


        }
    }
}
