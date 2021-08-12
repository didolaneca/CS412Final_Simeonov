<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CS412Final_Simeonov.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Content/Site.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
        <link rel="stylesheet" href="https://pro.fontawesome.com/releases/v5.10.0/css/all.css" integrity="sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p" crossorigin="anonymous" />
        <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Nav" runat="server">
    <div class="pos-f-t">
        <nav class="navbar float-right navbar-light bg-ligh">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
        </nav>
        <div class="collapse" id="navbarToggleExternalContent">
            <div class="bg-dark p-4">
                <ul class="nav flex-column">
                    <li class="nav-item">
                        <a class="nav-link" href="SignUp.aspx">Sign Up</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Login.aspx">Log In</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Contactus.aspx">Contact Us</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" ClientIDMode="Static" runat="server">
    <div class="wrapper fadeInDown">
        <div id="formContent">
            <!-- Tabs Titles -->

            <!-- Icon -->
            <div class="fadeIn first">
                <img src="Content/Icons/defaultUser.svg" id="icon" alt="User Icon" />
            </div>
            <script>

</script>
            <!-- Login Form -->
            <%--<form>--%>
            
            <asp:TextBox ID="firstName" runat="server" CssClass="fadeIn second" name="firstName" placeholder="First name"></asp:TextBox>
            <asp:TextBox ID="LastName" runat="server" CssClass="fadeIn second" name="lastName" placeholder="Last name"></asp:TextBox>
            

            <asp:TextBox ID="email" runat="server" CssClass="fadeIn second" name="email" placeholder="email"></asp:TextBox>
            <asp:TextBox ID="phone_number" runat="server" CssClass="fadeIn second" name="phone_number" placeholder="Phone Number"></asp:TextBox>
            <%--<input type="text" id="email" class="fadeIn second" placeholder="Enter Email" name="email" required>--%>
            <asp:TextBox ID="username" runat="server" CssClass="fadeIn third" name="username" placeholder="username"></asp:TextBox>
            <%--<input type="text" id="login" class="fadeIn third" name="login" placeholder="username">--%>
            <asp:TextBox ID="password" runat="server" CssClass="fadeIn fourt" name="password" placeholder="password"></asp:TextBox>
            <%--<input type="text" id="password" class="fadeIn fourth" name="login" placeholder="password">--%>
            <asp:TextBox ID="street" runat="server" CssClass="fadeIn fifth" name="street" placeholder="street"></asp:TextBox>
            <asp:TextBox ID="city" runat="server" CssClass="fadeIn fifth" name="city" placeholder="city"></asp:TextBox>
            <asp:TextBox ID="state" runat="server" CssClass="fadeIn fifth" name="state" placeholder="state"></asp:TextBox>
            <asp:TextBox ID="postalCode" runat="server" CssClass="fadeIn fifth" name="postalCode" placeholder="postalCode"></asp:TextBox>
            <asp:TextBox ID="country" runat="server" CssClass="fadeIn fifth" name="country" placeholder="country"></asp:TextBox>
            <%--<asp:Button ID="submitButton" runat="server" CssClass="fadeIn fourth" Text="Sign Up" OnClick="submitButton_SignUpClick" />--%>
            <%--<input type="submit" class="fadeIn fourth" value="Sign Up">--%>

            <%--</form>--%>

            <div id="formFooter">
                <asp:Button ID="Button1" runat="server" CssClass="fadeIn fourth" Text="Sign Up" OnClick="submitButton_SignUpClick" />
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="underlineHover" href="Login.aspx">Already an User? Log In!</asp:HyperLink>
                <%--<a class="underlineHover" href="Login.aspx">Already an User? Log In!</a>--%>
            </div>
            <asp:Panel ID="signUpErrors" runat="server" Visible="false">
                <asp:Label ID="errorsList" runat="server" Text="Label" CssClass="authErrors"></asp:Label>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
