using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMAT1610PersonalWebsite
{
    public partial class frm_Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // New Code Start
            Model.InputValidator validate = new Model.InputValidator();
            string ValidateResponse = validate.validateSignUp(txtFirstname.Text.Trim(), txtLastname.Text.Trim(), txtAddress.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim());
            if (ValidateResponse != "1")
            {
                lblInfo.Text = ValidateResponse;
                return;
            }
            // New Code End


            Model.UserController controller = new Model.UserController();
            // Check if user exists
            if (controller.SelectUser(txtEmail.Text).ID == 0)
            {
                if (controller.AddNewUser(new Model.tbl_UserInfo { Address = txtAddress.Text.Trim(), Email = txtEmail.Text.Trim(), Firstname = txtFirstname.Text.Trim(), Lastname = txtLastname.Text.Trim() }, txtPassword.Text.Trim()))
                {
                    //User Created Successfully
                    lblInfo.Text = "User created successfully";
                    txtAddress.Enabled = false;
                    txtEmail.Enabled = false;
                    txtFirstname.Enabled = false;
                    txtLastname.Enabled = false;
                    txtPassword.Enabled = false;
                }
                else
                {
                    //User NOT Created Successfully
                    lblInfo.Text = "ERROR occured while creating user";
                }

            }
            else
            {
                // email already exists
                lblInfo.Text = "User Already Exist";

            }
        }
    }
}