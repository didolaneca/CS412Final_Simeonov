<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CS412Final_Simeonov.WebForm2" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link href="Content/Site.css" rel="stylesheet" />
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
