using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_conversion
{
    public partial class Result_frm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["selection"] == "tempconselect")
            {
                TextBox1.Text = Session["outvalue"].ToString();
                currency.Visible = false;            }

            if (Session["selection"] == "currencyconselect")
            {
                TextBox2.Text = Session["outvalue1"].ToString();
                temperature.Visible = false;
            }

            //temp cookie
            //string act = string.Empty;
            //string type = string.Empty;

            //if (Request.Cookies["action"] != null)
            //{
            //    act = Request.Cookies["action"].Value;
            //    Label3.Text = act;

            //}
            //if (Request.Cookies["type"].Value != null)
            //{
            //    act = Request.Cookies["action"].Value;
            //    Label3.Text = type;

            //}

            string nm = string.Empty;
            string lnm = string.Empty;

            HttpCookie reqCookie = Request.Cookies["useraction"];
            if(reqCookie != null)
            {
                nm = reqCookie["name"].ToString();
                lnm = reqCookie["lname"].ToString();
                Label3.Text = nm;
                Label4.Text = lnm;
            }




        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}