using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_RTO
{
    public partial class Vehicle_Reg_frm : Form
    {
        public Vehicle_Reg_frm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vehicle_Reg_frm_submitbutton_Click(object sender, EventArgs e)
        {
            string strCompany, strModel, strColor, strVehicletype, strChassisno, strEngineno, strOwnername;
            string strOwnerAdd, strownerMobno, strowneremail, strOwneraadharno, strOwnerPAN, strCustCode, strVehiCode, strApplicationID;
            DateTime RegDate;
            bool DocUploaded;

            strCompany = Vehicle_Reg_frm_compaytextBox.Text;
            strModel = Vehicle_Reg_frm_modeltextBox.Text;
            strVehicletype = Vehicle_Reg_frm_vehtypecomboBox.SelectedItem.ToString();
            strColor = Vehicle_Reg_frm_colortextBox.Text;
            strChassisno = Vehicle_Reg_frm_chassistextBox.Text;
            strEngineno = Vehicle_Reg_frm_enginetextBox.Text;
            strOwnername = Vehicle_Reg_frm_nametextBox.Text;
            strOwnerAdd = Vehicle_Reg_frm_addrstextBox.Text;
            strownerMobno = Vehicle_Reg_frm_mobtextBox.Text;
            strowneremail = Vehicle_Reg_frm_emailtextBox.Text;
            strOwneraadharno = Vehicle_Reg_frm_aadhartextBox.Text;
            strOwnerPAN = Vehicle_Reg_frm_pantextBox.Text;
            RegDate = Vehicle_Reg_frm_RegdateTimePicker.Value;
            DocUploaded = Vehicle_Reg_frm_docstatuscheckBox.Checked;
            strCustCode = "CUSTCODE_" + strownerMobno;
            strVehiCode = "VEHICODE_" + strEngineno;

            if (strCompany != "" || strModel != "" || strColor != "" || strChassisno != "" || strEngineno != "" ||
                strOwnername != "" || strOwnerAdd != "" || strownerMobno != "" || strowneremail != "" || strOwneraadharno != "" || strOwnerPAN != "")
            {
                Vehicle_Reg_Class Obj1 = new Vehicle_Reg_Class();
                Obj1.Customerdatainsertfn(strCustCode, strOwnername, strOwnerAdd, strOwnerPAN, strOwneraadharno, strownerMobno, strowneremail);  //Insert Custmoer Details
                Obj1.Vehicledatainsertfn(strVehiCode, strCompany, strModel, strColor, strVehicletype);                                      // Insert Vehicle Details

                SQLConClass Obj2 = new SQLConClass();
                DataTable dt = new DataTable();
                dt = Obj2.Getdatatablefrmdb("Customer", "Cust_Code", strCustCode);
                int cust_id = Convert.ToInt16(dt.Rows[0].ItemArray[0].ToString());
                DataTable dt1 = new DataTable();
                dt1 = Obj2.Getdatatablefrmdb("Vehicle", "Veh_Code", strVehiCode);
                int veh_id = Convert.ToInt16(dt.Rows[0].ItemArray[0].ToString());

                strApplicationID = "APPLICATIONID-" + cust_id.ToString() + veh_id.ToString();

                Obj1.Cust_Vehicle_datainsertfn(cust_id, strCustCode, veh_id, strVehiCode, strEngineno, strChassisno, RegDate, strApplicationID);
                Obj1.Documentstatusupdatefn(cust_id, DocUploaded);

                MessageBox.Show("Your Application ID is " + strApplicationID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Blank Field, all fields should be filled");
            }
        }

        private void Vehicle_Reg_frm_Load(object sender, EventArgs e)
        {

        }

        private void Vehicle_Reg_frm_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
