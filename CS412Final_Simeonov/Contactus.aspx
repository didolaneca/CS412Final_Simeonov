<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Contactus.aspx.cs" Inherits="CS412Final_Simeonov.WebForm3" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="Nav" runat="server">
    <div class="pos-f-t">
        <nav class="navbar sticky-top justify-content-end navbar-light bg-ligh">
            <a class="navbar-brand" href="#"><i runat="server" id="userId" class="far fa-user"></i></a>
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
                    <li class="nav-item">
                        <a class="nav-link" href="AddItem.aspx">Add Item</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
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
                <asp:Button ID="submitButton" runat="server" CssClass="fadeIn fourth" Text="Send" OnClick="submitButton_ContactUsClick"/>
                <asp:Panel ID="contactUsErrors" runat="server" Visible="false">
                <asp:Label ID="errorsList" runat="server" Text="Label" CssClass="authErrors"></asp:Label>
            </asp:Panel>
            </form>

            <%--<div id="formFooter">
                <a class="underlineHover" href="SignUp.aspx">Not an User? Sign Up!</a>
            </div>--%>
        </div>
    </div>
</asp:Content>
