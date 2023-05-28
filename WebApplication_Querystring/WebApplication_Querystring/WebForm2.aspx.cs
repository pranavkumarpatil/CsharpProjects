using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_Querystring
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Val"] == "1")
            {
                Button1.Enabled = false;    
            }

            if (Request.QueryString["val"] == "2")
            {
                Button2.Enabled = false;
            }

            TextBox1.Text = Request.QueryString["Val"];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}