using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Simeonov
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User userLoggedIn = (User)Session["user"];
            if (userLoggedIn != null) {
                userId.InnerHtml = " Welcome back, " + userLoggedIn.FirstName;

            }
           
        }
    }
}