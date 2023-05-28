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
    public partial class ApplicationAprovalForm : Form
    {
        public ApplicationAprovalForm()
        {
            InitializeComponent();
        }

        private void aprovalfrm__vehicleclasslable_Click(object sender, EventArgs e)
        {

        }

        private void aprovalfrm_vehicleclastextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApplicationAprovalForm_Load(object sender, EventArgs e)
        {
            string sqlquery3 = "select Application_ID from Registration where Application_Status='Submitted'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery3, SQLConClass.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            aprovalfrm_applnocomboBox.DataSource = dt;
            aprovalfrm_regnotextBox.Enabled = false;
            aprovalfrm_regnogenbutton.Enabled = false;
        }

        private void aprovalfrm_applnocomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string strApplicationID =aprovalfrm_applnocomboBox.SelectedValue.ToString();
            VehApplicationAprovalClass Obj1 = new VehApplicationAprovalClass();
            Obj1.getregistrationtabledetails(strApplicationID);
            ApplStatus_label.Text = Obj1.strApp_status;
            int fCust_Id = Obj1.Cust_id;
            int fVeh_Id = Obj1.Veh_id;
            string fEngineNo = Obj1.strEngineno;
            string fChassisNo = Obj1.strChassisno;
            DateTime fRegdate = Obj1.RegDate;

            Obj1.getcustomertabledetails(strApplicationID, fCust_Id);
            string fOwnerName = Obj1.strOwnername;
            string fOwnerAdd = Obj1.strOwnerAdd;
            string fOwnerMobno = Obj1.strownerMobno;
            string fOwneremail = Obj1.strowneremail;
            string fOwnerPAN = Obj1.strOwnerPAN;
            string fOwneraadharno = Obj1.strOwneraadharno;

            Obj1.getvehicletabledetails(strApplicationID, fVeh_Id);
            string fCompany = Obj1.strCompany;
            string fModel = Obj1.strModel;
            string fColor = Obj1.strColor;
            string fVehicletype = Obj1.strVehicletype;
            Obj1.getdocumenttabledetails(strApplicationID, fCust_Id);
            bool fdocustatus = Obj1.DocUploaded;

            aprovalfrm_aadhartextBox.Text = fOwneraadharno;
            aprovalfrm_chassistextBox.Text = fChassisNo;
            aprovalfrm_colortextBox.Text = fColor;
            aprovalfrm_vehicletypetextBox.Text = fVehicletype;
            aprovalfrm_companytextBox.Text = fCompany;
            aprovalfrm_modeltextBox.Text = fModel;
            aprovalfrm_emailtextBox.Text = fOwneremail;
            aprovalfrm_engnotextBox.Text = fEngineNo;
            aprovalfrm_mobnotextBox.Text = fOwnerMobno;
            aprovalfrm_owneraddrstextBox.Text = fOwnerAdd;
            aprovalfrm_ownernametextBox.Text = fOwnerName;
            aprovalfrm_pantextBox.Text = fOwnerPAN;
            aprovalfrm_regdatedateTimePicker.Value = fRegdate;
            checkBox1.Checked = fdocustatus;


        }

        private void aprovalfrm_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aprovalfrm_approvebutton_Click(object sender, EventArgs e)
        {
            string strApplicationID = aprovalfrm_applnocomboBox.SelectedValue.ToString();
            string sqlquery = "select Application_Status from Registration where Application_ID='" + strApplicationID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, SQLConClass.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if ((dt.Rows[0].ItemArray[0].ToString() != "Approved") && (dt.Rows[0].ItemArray[0].ToString() != "Rejected"))
            {
                MessageBox.Show("Vehicle Registration Application is Approved. Generate Registration No");
                string strcmd1 = "update Registration set Application_Status='Approved' where Application_ID='" + strApplicationID + "'";
                SqlCommand cmd1 = new SqlCommand(strcmd1, SQLConClass.con);
                SQLConClass.con.Open();
                cmd1.ExecuteNonQuery();
                SQLConClass.con.Close();

                ApplStatus_label.Text = "Approved";
                
                aprovalfrm_regnogenbutton.Enabled = true;


            }
            else
            {
                MessageBox.Show("Application status is either Approved or Rejected");
            }
        }

        private void aprovalfrm_rejectbutton_Click(object sender, EventArgs e)
        {
            string strApplicationID = aprovalfrm_applnocomboBox.SelectedValue.ToString();
            string sqlquery = "select Application_Status from Registration where Application_ID='" + strApplicationID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, SQLConClass.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if ((dt.Rows[0].ItemArray[0].ToString() != "Approved") && (dt.Rows[0].ItemArray[0].ToString() != "Rejected"))
            {
                ApplStatus_label.Text = "Rejected";
                MessageBox.Show("Vehicle Registration Application is Rejected.");
                string strcmd1 = "update Registration set Application_Status='Rejected' where Application_ID='" + strApplicationID + "'";
                SqlCommand cmd1 = new SqlCommand(strcmd1, SQLConClass.con);
                SQLConClass.con.Open();
                cmd1.ExecuteNonQuery();
                SQLConClass.con.Close();


                this.Close();

            }
            else
            {
                MessageBox.Show("Application Status is either Rejected or Approved");
            }
        }

        private void aprovalfrm_regnogenbutton_Click(object sender, EventArgs e)
        {
            string strApplicationID = aprovalfrm_applnocomboBox.SelectedValue.ToString();
            string sqlquery = "select Application_Status from Registration where Application_ID='" + strApplicationID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, SQLConClass.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if ((dt.Rows[0].ItemArray[0].ToString() == "Approved"))
            { 
            VehApplicationAprovalClass Obj1 = new VehApplicationAprovalClass();
            string regno = Obj1.getVehicleRegistrationNo();
            string VehicleRegNo = "MH12-AA" + regno;
            aprovalfrm_regnotextBox.Text = VehicleRegNo;
            
            Obj1.VehicleRegNofn(VehicleRegNo, strApplicationID);
            }
            else 
            {
                MessageBox.Show("Approve the Application First");
            }

        }
    }
}
