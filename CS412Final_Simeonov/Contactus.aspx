<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Contactus.aspx.cs" Inherits="CS412Final_Simeonov.WebForm3" %>

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
                <asp:TextBox ID="firstname" runat="server" CssClass="fadeIn first" name="firstName" placeholder="First name"></asp:TextBox>
                <asp:TextBox ID="lastName" runat="server" CssClass="fadeIn second" name="lastName" placeholder="Last name"></asp:TextBox>
                <asp:TextBox ID="email" runat="server" CssClass="fadeIn third" name="email" placeholder="email"></asp:TextBox>
                <%--<input type="text" id="firstname" class="fadeIn second" name="firstname" placeholder="First Name">
                <input type="text" id="Lastname" class="fadeIn third" name="lastname" placeholder="Last Name">--%>
                <asp:TextBox ID="message" runat="server" CssClass="fadeIn third" name="message" placeholder="Message"></asp:TextBox>
                <%--<input type="text" id="Message" class="fadeIn third" name="message" placeholder="Message">--%>
                <asp:Button ID="submitButton" runat="server" CssClass="fadeIn fourth" Text="Submit" OnClick="submitButton_ContactUsClick"/>
                <%--<input type="submit" class="fadeIn fourth" value="Submit">--%>
            </form>

            <%--<div id="formFooter">
                <a class="underlineHover" href="SignUp.aspx">Not an User? Sign Up!</a>
            </div>--%>
        </div>
    </div>
</asp:Content>
