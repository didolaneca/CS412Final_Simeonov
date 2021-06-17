<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CS412Final_Simeonov.WebForm2" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<link href="Content/Site.css" rel="stylesheet" />
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" ClientIDMode="Static" runat="server">
    <div class="wrapper fadeInDown">
        <div id="formContent">
            <!-- Tabs Titles -->

            <!-- Icon -->
            <div class="fadeIn first">
                <img src="Content/Icons/defaultUser.svg" id="icon" alt="User Icon" />
            </div>

            <!-- Login Form -->
            <form>
                <asp:TextBox ID="email" runat="server" CssClass="fadeIn second" name="email" placeholder="email"></asp:TextBox>
                <%--<input type="text" id="email" class="fadeIn second" placeholder="Enter Email" name="email" required>--%>
                <asp:TextBox ID="username" runat="server" CssClass="fadeIn third" name="username" placeholder="username"></asp:TextBox>
                <%--<input type="text" id="login" class="fadeIn third" name="login" placeholder="username">--%>
                <asp:TextBox ID="password" runat="server" CssClass="fadeIn fourt" name="password" placeholder="password"></asp:TextBox>
                <%--<input type="text" id="password" class="fadeIn fourth" name="login" placeholder="password">--%>
                <asp:Button ID="submitButton" runat="server" CssClass="fadeIn fourth" Text="Sign Up" OnClick="submitButton_SignUpClick"/>
                <%--<input type="submit" class="fadeIn fourth" value="Sign Up">--%>
            </form>

            <div id="formFooter">
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="underlineHover" href="Login.aspx">Already an User? Log In!</asp:HyperLink>
                <%--<a class="underlineHover" href="Login.aspx">Already an User? Log In!</a>--%>
            </div>

        </div>
    </div>
</asp:Content>
