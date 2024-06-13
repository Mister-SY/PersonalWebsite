using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMAT1610PersonalWebsite
{
    public partial class frm_BlogHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Hi " + Convert.ToString(Session["firstname"]);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Page_Home.html"); //Please change 'page_Home.html' to your website home page 
        }
    }
}