using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IMAT1610PersonalWebsite.Model;

namespace IMAT1610PersonalWebsite
{
    public partial class frm_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserController control = new UserController();
                string response = "";
                if (control.checkUsernameAndPassword(txtUsername.Text, txtPassword.Text, ref response))
                {
                    Session.Add("firstname", response);
                    Response.Redirect("frm_BlogHome.aspx"); // Please change 'frm_BlogHome.aspx' to your blog home page 
                }
                else
                {
                    lblInfo.Text = "Invalid Username or Password";
                }
            }
            catch (Exception ex)
            {

                lblInfo.Text = "An error occured";
            }
        }
    }
}