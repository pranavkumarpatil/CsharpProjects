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
    public partial class Application_Approval_frm : Form
    {
        public Application_Approval_frm()
        {
            InitializeComponent();
        }

        private void aprovalfrm_applnocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void Application_Approval_frm_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string sqlquery3 = "select APPLICATION_ID from RTO_VEHICLE_REG_Table";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery3, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            aprovalfrm_applnocomboBox.DataSource = dt;
           
        }

        private void aprovalfrm_applnocomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string strapplid = aprovalfrm_applnocomboBox.SelectedValue.ToString();
            string sqlquery4 = "select * from RTO_VEHICLE_REG_Table where APPLICATION_ID='" + strapplid + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery4, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            aprovalfrm_makernametextBox.Text = dt.Rows[0].ItemArray[1].ToString();    //Get Make name
            aprovalfrm_modeltextBox.Text = dt.Rows[0].ItemArray[2].ToString();   //Get Model name
            aprovalfrm_engnotextBox.Text = dt.Rows[0].ItemArray[3].ToString();    // Get engine no
            aprovalfrm_chassistextBox.Text=dt.Rows[0].ItemArray[4].ToString();    //Get Chassis no
            aprovalfrm_colortextBox.Text=dt.Rows[0].ItemArray[5].ToString();   //Get color
            aprovalfrm_vehicleclastextBox.Text= dt.Rows[0].ItemArray[6].ToString(); //Get vehicle Class
            aprovalfrm_fueltypetextBox.Text=dt.Rows[0].ItemArray[7].ToString();   //Get Fuel Type
            aprovalfrm_seatcaptextBox.Text=dt.Rows[0].ItemArray[8].ToString();  //Get Seat Capacity
            aprovalfrm_standcaptextBox.Text=dt.Rows[0].ItemArray[9].ToString();  // Get standing seat Capacity
            aprovalfrm_regiauthtextBox.Text=dt.Rows[0].ItemArray[10].ToString(); //Get Registering Authority
            aprovalfrm_issuedatedateTimePicker.Text=dt.Rows[0].ItemArray[11].ToString(); //Get issue date
            aprovalfrm_validdatedateTimePicker1.Text=dt.Rows[0].ItemArray[12].ToString(); // Get Valid date
            aprovalfrm_insurancecotextBox.Text= dt.Rows[0].ItemArray[13].ToString();  //Get Insurance Company
            aprovalfrm_insurancenotextBox.Text=dt.Rows[0].ItemArray[14].ToString();  //Get Insurance No.
            aprovalfrm_ownernametextBox.Text=dt.Rows[0].ItemArray[15].ToString();  //Get Owner Name
            aprovalfrm_owneraddrstextBox.Text=dt.Rows[0].ItemArray[16].ToString();  //Get Owner Address
            aprovalfrm_mobnotextBox.Text=dt.Rows[0].ItemArray[17].ToString(); //Get Owner Mobile.
            ApplStatus_label.Text=dt.Rows[0].ItemArray[18].ToString(); //Get Application Status


        }

        private void aprovalfrm_issuedatedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void aprovalfrm_approvebutton_Click(object sender, EventArgs e)
        {
            string strapplid = aprovalfrm_applnocomboBox.SelectedValue.ToString();
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string sqlquery = "select APPL_STATUS from RTO_VEHICLE_REG_Table where APPLICATION_ID='" + strapplid + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if ((dt.Rows[0].ItemArray[0].ToString() != "Approved") && (dt.Rows[0].ItemArray[0].ToString() != "Rejected"))
            {
                MessageBox.Show("Vehicle Registration Application is Approved. Generate Registration No");
                string strcmd1 = "update RTO_VEHICLE_REG_Table set APPL_STATUS='Approved' where APPLICATION_ID='" + strapplid + "'";
                SqlCommand cmd1 = new SqlCommand(strcmd1, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
               

            }
            else
            {
                MessageBox.Show("Application status is either Approved or Rejected");
            }

                                  
            
        }

        private void aprovalfrm_rejectbutton_Click(object sender, EventArgs e)
        {
            string strapplid = aprovalfrm_applnocomboBox.SelectedValue.ToString();
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string sqlquery = "select APPL_STATUS from RTO_VEHICLE_REG_Table where APPLICATION_ID='" + strapplid + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if ((dt.Rows[0].ItemArray[0].ToString() != "Approved") && (dt.Rows[0].ItemArray[0].ToString() != "Rejected"))
            {

                MessageBox.Show("Vehicle Registration Application is Rejected.");
                string strcmd1 = "update RTO_VEHICLE_REG_Table set APPL_STATUS='Rejected' where APPLICATION_ID='" + strapplid + "'";
                SqlCommand cmd1 = new SqlCommand(strcmd1, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                this.Close();

            }
            else
            {
                MessageBox.Show("Application Status is either Rejected or Approved");
            }

               
        }

        private void aprovalfrm_canclebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
