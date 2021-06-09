<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CS412Final_Simeonov.WebForm2" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link href="Content/Site.css" rel="stylesheet" />
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<p>I'm the sign up page</p>
    <div class="container">
        <h1>Sign Up</h1>
        <p>Please fill in this form to create an account.</p>
        <hr>

        <label for="email"><b>Email</b></label>
        <input type="text" placeholder="Enter Email" name="email" required>

        <label for="psw"><b>Password</b></label>
        <input type="password" placeholder="Enter Password" name="psw" required>

        <label for="psw-repeat"><b>Repeat Password</b></label>
        <input type="password" placeholder="Repeat Password" name="psw-repeat" required>

        <label>
          <input type="checkbox" checked="checked" name="remember" style="margin-bottom:15px"> Remember me
        </label>

        <div class="clearfix">
          <button type="button" class="cancelbtn">Cancel</button>
          <button type="submit" class="signupbtn">Sign Up</button>
        </div>
    </div>--%>
    <div class="wrapper fadeInDown">
        <div id="formContent">
            <!-- Tabs Titles -->

            <!-- Icon -->
            <div class="fadeIn first">
                <img src="Content/Icons/defaultUser.svg" id="icon" alt="User Icon" />
            </div>

            <!-- Login Form -->
            <form>
                <input type="text" id="email" class="fadeIn second" placeholder="Enter Email" name="email" required>
                <input type="text" id="login" class="fadeIn third" name="login" placeholder="username">
                <input type="text" id="password" class="fadeIn fourth" name="login" placeholder="password">
                <input type="submit" class="fadeIn fourth" value="Sign Up">
            </form>

            <div id="formFooter">
                <a class="underlineHover" href="Login.aspx">Already an User? Log In!</a>
            </div>

        </div>
    </div>
</asp:Content>
