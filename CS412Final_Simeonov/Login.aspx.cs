using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Simeonov
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { //do something

            }
        }

        protected void submitButton_LoginClick(object sender, EventArgs e)
        {
            string usrname = username.Text,
                    passwrd = password.Text;
            List<String> errors = new List<string>();
            signUpErrors.Visible = false;
            if (string.IsNullOrWhiteSpace(usrname)){
                errors.Add("Username can not be empty");
            }

            if (string.IsNullOrWhiteSpace(passwrd)){
                errors.Add("Password can not be empty");
            }

            if (errors.Count > 0) {
                signUpErrors.Visible = true;
                errorsList.Text = string.Join("<br />", errors);
                return;
            }


            Response.Redirect("Items.aspx");
            if (true) {
                Response.Write("Hello from login");
            }
        }
    }
}