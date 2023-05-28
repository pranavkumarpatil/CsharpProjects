using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_conversion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            currencycalc.Visible = false;
            tempcalc.Visible = false;
            if (IsPostBack) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double outvalue=0;
            double multiplier1 = 1.8, multiplier2 = 0.5556;

            if (RadioButton1.Checked == true)
            {
               outvalue = ((Convert.ToDouble(TextBox1.Text) * multiplier1) + 32);

            }
            else if (RadioButton2.Checked == true)
            {
                outvalue = ((Convert.ToDouble(TextBox1.Text) - 32 ) * multiplier2);
            }

            if ((RadioButton1.Checked == true) || (RadioButton2.Checked == true))

            {
                string a = "tempconselect";
            }

            Session["selection"] = "tempconselect";

            Session["outvalue"] = outvalue;

            // Temp Cookie Creation

            //Response.Cookies["action"].Value = "Temp Converted";
            //Response.Cookies["type"].Value = "DegC_F";


            // Time based Cookie Creation

            HttpCookie useraction = new HttpCookie("useraction");
            useraction["name"] = "Pranav";
            useraction["lname"] = "Patil";
            //useraction.Expires.Add(new TimeSpan(0, 2, 0));
            useraction.Expires = DateTime.Now.AddHours(2);
            Response.Cookies.Add(useraction);

            Response.Redirect("Result_frm");

            //TextBox2.Text = outvalue.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double outvalue1=0;
            double multiplier1 = 0.013, multiplier2 = 76.31;

            if (RadioButton3.Checked == true)
            {
                outvalue1 = ((Convert.ToDouble(TextBox2.Text) * multiplier1));

            }
            else if (RadioButton4.Checked == true)
            {
                outvalue1 = (Convert.ToDouble(TextBox2.Text) * multiplier2);
            }

            if ((RadioButton3.Checked == true) || (RadioButton4.Checked == true))

            {
                string b = "currencyconselect";
            }

            Session["selection"] = "currencyconselect";

            Session["outvalue1"] = outvalue1;

            

            Response.Redirect("Result_frm");



        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
           
            tempcalc.Visible = true;
        }

        protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            currencycalc.Visible = true;
        }
    }
}