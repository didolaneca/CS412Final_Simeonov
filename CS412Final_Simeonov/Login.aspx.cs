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
            
        }

        protected void submitButton_LoginClick(object sender, EventArgs e)
        {
            if (true) {
                Response.Write("Hello from login");
            }
        }
    }
}