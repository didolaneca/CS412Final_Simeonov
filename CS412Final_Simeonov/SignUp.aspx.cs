using CS412Final_Simeonov.DAL;
using CS412Final_Simeonov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS412Final_Simeonov
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_SignUpClick(object sender, EventArgs e)
        {
           string usrname = username.Text,
                    passwrd = password.Text,
                    frstName = firstName.Text,
                    lstName = LastName.Text,
                    eMail = email.Text,
                    phoneNbr = phone_number.Text,
                    sTreet = street.Text,
                    cIty = city.Text,
                    sTate = state.Text,
                    pOstalCode = postalCode.Text,
                    cOuntry = country.Text

                ;
            List<String> errors = new List<string>();
            signUpErrors.Visible = false;

            if (string.IsNullOrWhiteSpace(usrname))
            {
                errors.Add("Username can not be empty");
            }

            if (string.IsNullOrWhiteSpace(passwrd))
            {
                errors.Add("Password can not be empty");
            }

            if (string.IsNullOrWhiteSpace(frstName))
            {
                errors.Add("First name can not be empty");
            }

            if (string.IsNullOrWhiteSpace(lstName))
            {
                errors.Add("Last name can not be empty");
            }

            if (string.IsNullOrWhiteSpace(eMail))
            {
                errors.Add("Email name can not be empty");
            }

            if (string.IsNullOrWhiteSpace(sTreet))
            {
                errors.Add("Street can not be empty");
            }

            if (string.IsNullOrWhiteSpace(cIty))
            {
                errors.Add("City can not be empty");
            }

            if (string.IsNullOrWhiteSpace(sTate))
            {
                errors.Add("State can not be empty");
            }

            if (string.IsNullOrWhiteSpace(pOstalCode))
            {
                errors.Add("Postal code can not be empty");
            }
            
            if (string.IsNullOrWhiteSpace(cOuntry))
            {
                errors.Add("Country can not be empty");
            }

            if (errors.Count > 0)
            {
                signUpErrors.Visible = true;
                errorsList.Text = string.Join("<br />", errors);
                return;
            }

            User user = new User()
            {
                FirstName = frstName,
                LastName = lstName,
                Email = eMail,
                PhoneNumber = phoneNbr,
                Username = usrname,
                Password = passwrd,
                Address = new Address() {
                    //Confirm if this is the best way to do it???
                    UserId = UserDAL.LastUserId() + 1,
                    Street = sTreet,
                    City = cIty,
                    State = sTate,
                    PostalCode = pOstalCode,
                    Country = cOuntry

                }
            };
            //Calling the DAL and registering the new user
            UserDAL.SaveUser(user);

            Response.Redirect("Login.aspx");

            if (true)
            {
                Response.Write("Hello from Sign Up");
            }
        }

    }
}