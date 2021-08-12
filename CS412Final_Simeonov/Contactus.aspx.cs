using CS412Final_Simeonov.Repository;
using CS412Final_Simeonov.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Simeonov
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private readonly static IError error = new Error();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { //do something

            }
        }

        protected void submitButton_ContactUsClick(object sender, EventArgs e)
        {
            string fName = firstname.Text,
                    lName = lastName.Text,
                    em = email.Text,
                    msg = message.Text;
            List<String> errors = new List<string>();
            contactUsErrors.Visible = false;
            if (string.IsNullOrWhiteSpace(fName))
            {
                errors.Add("First name can not be empty");
            }
            if (string.IsNullOrWhiteSpace(lName))
            {
                errors.Add("Last name can not be empty");
            }
            if (string.IsNullOrWhiteSpace(em))
            {
                errors.Add("Email can not be empty");
            }
            if (string.IsNullOrWhiteSpace(msg))
            {
                errors.Add("Message can not be empty");
            }


            if (errors.Count > 0)
            {
                contactUsErrors.Visible = true;
                errorsList.Text = string.Join("<br />", errors);
                return;
            }

            ContactUsWithFeedback(fName, lName, em, msg);

        }

        private void ContactUsWithFeedback(string fName, string lName, string em, string msg)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.To.Add("didolaneca@yahoo.com");
                mailMessage.From = new MailAddress(mailMessage.From.Address);
                mailMessage.Subject = "Contact Us Form";
                mailMessage.ReplyToList.Add(em.Trim());
                mailMessage.Body = $@"
                                    <p>User mail: {em}</p>
                                    <p>User name: {fName + " " + lName}</p>
                                    <p>User message: {msg}</p>
                            ";
                mailMessage.IsBodyHtml = true;

                using (SmtpClient client = new SmtpClient())
                {
                    try
                    {
                        client.Send(mailMessage);
                    }
                    catch (Exception ex)
                    {
                        error.Log(ex);
                        return;
                    }
                }
            }
            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.To.Add(em.Trim());
                //mailMessage.From = new MailAddress("didolaneca@yahoo.com");
                mailMessage.From = new MailAddress(mailMessage.From.Address);
                mailMessage.Subject = "Thank you for contacting us";
                mailMessage.ReplyToList.Add(mailMessage.From.Address);
                mailMessage.Body = "Thank you for contacting us. Your feedback is appreciated ";

                using (SmtpClient client = new SmtpClient())
                {
                    try
                    {
                        client.Send(mailMessage);
                    }
                    catch (Exception ex)
                    {
                        error.Log(ex);
                        return;
                    }
                }
            }
            Response.Write("Thank You For Contacting us");
            Response.Redirect("Contactus.aspx");
        }
    }
}