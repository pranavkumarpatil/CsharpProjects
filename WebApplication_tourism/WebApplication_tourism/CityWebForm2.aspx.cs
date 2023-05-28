using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_tourism
{
    public partial class CityWebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Request.QueryString["citynm"];

            if (Request.QueryString["citynm"] == "Pune")
            {
                divpune.Visible = true;
                divmumbai.Visible = false;
                divindore.Visible = false;
                divbhopal.Visible = false;

            }

            if (Request.QueryString["citynm"] == "Mumbai")
            {
                divpune.Visible = false;
                divmumbai.Visible = true;
                divindore.Visible = false;
                divbhopal.Visible = false;

            }
            if (Request.QueryString["citynm"] == "Indore")
            {
                divpune.Visible = false;
                divmumbai.Visible = false;
                divindore.Visible = true;
                divbhopal.Visible = false;

            }
            if (Request.QueryString["citynm"] == "Bhopal")
            {
                divpune.Visible = false;
                divmumbai.Visible = false;
                divindore.Visible = false;
                divbhopal.Visible = true;

            }


        }
    }
}