using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_tourism
{
    public partial class CityWebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["country_selection"].ToString();
            TextBox2.Text = Session["state_selection"].ToString();
            TextBox3.Text = Session["city_selection"].ToString();

            if ((Session["city_selection"].ToString() == "Pune"))

            {
                
                divpune.Visible = true;
                divmumbai.Visible = false;
                divindore.Visible = false;
                divbhopal.Visible = false;
            }

            if ((Session["city_selection"].ToString() == "Mumbai"))

            {

                divpune.Visible = false;
                divmumbai.Visible = true;
                divindore.Visible = false;
                divbhopal.Visible = false;
            }
            if ((Session["city_selection"].ToString() == "Indore"))

            {

                divpune.Visible = false;
                divmumbai.Visible = false;
                divindore.Visible = true;
                divbhopal.Visible = false;
            }
            if ((Session["city_selection"].ToString() == "Bhopal"))

            {

                divpune.Visible = false;
                divmumbai.Visible = false;
                divindore.Visible = false;
                divbhopal.Visible = true;
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
               
        }
    }
}