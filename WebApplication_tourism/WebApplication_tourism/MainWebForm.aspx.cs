using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication_tourism
{
    public partial class MainWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DropDownList2.Enabled = false;
                DropDownList3.Enabled = false;

                //SQL Connection Code   
                SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
                string sqlquery = "select distinct(COUNTRY) from TOURISM_TABLE";
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                DropDownList1.DataSource = ds;
                DropDownList1.DataBind();

                ListItem listcountry = new ListItem("select country");
                DropDownList1.Items.Insert(0, listcountry);
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["country_selection"] = DropDownList1.SelectedValue; 
            Session["state_selection"] = DropDownList2.SelectedValue;
            Session["city_selection"] = DropDownList3.SelectedValue;

            Response.Redirect("CityWebForm1");
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
          
            
                DropDownList2.Enabled = true;

            ListItem listcity = new ListItem("select city");
            DropDownList3.Items.Insert(0, listcity);
            DropDownList3.SelectedIndex = 0;


               DropDownList3.Enabled = false;
            //SQL Connection Code   
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
                string sqlquery = "select distinct(STATE) from TOURISM_TABLE";
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                DropDownList2.DataSource = ds;
                DropDownList2.DataBind();

                ListItem listsate = new ListItem("select state");
                DropDownList2.Items.Insert(0, listsate);
                


        }

        protected void DropDownList2_TextChanged(object sender, EventArgs e)
        {
          
            DropDownList3.Enabled = true;
            //SQL Connection Code   
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=RTO_MANAGMENT_SYS_DB;Persist Security Info=True;User ID=sa;Password=India@15; trusted_connection=no");
            string sqlquery = "select distinct(CITY) from TOURISM_TABLE";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            DropDownList3.DataSource = ds;
            DropDownList3.DataBind();

            ListItem listcity = new ListItem("select city");
            DropDownList3.Items.Insert(0, listcity);

        }

        protected void DropDownList3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string city;
            city = DropDownList3.SelectedValue.ToString();
            Response.Redirect("CityWebForm2?citynm="+city);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}