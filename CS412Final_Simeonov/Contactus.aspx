<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Contactus.aspx.cs" Inherits="CS412Final_Simeonov.WebForm3" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                <input type="text" id="firstname" class="fadeIn second" name="firstname" placeholder="First Name">
                <input type="text" id="Lastname" class="fadeIn third" name="lastname" placeholder="Last Name">
                <input type="text" id="Message" class="fadeIn third" name="message" placeholder="Message">
                <input type="submit" class="fadeIn fourth" value="Submit">
            </form>

            <%--<div id="formFooter">
                <a class="underlineHover" href="SignUp.aspx">Not an User? Sign Up!</a>
            </div>--%>

        </div>
    </div>
</asp:Content>
