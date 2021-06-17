<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CS412Final_Simeonov.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Content/Site.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
        <link rel="stylesheet" href="https://pro.fontawesome.com/releases/v5.10.0/css/all.css" integrity="sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p" crossorigin="anonymous" />
        <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
</asp:Content>
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
                <asp:TextBox ID="login" runat="server" CssClass="fadeIn second" name="login" placeholder="login"></asp:TextBox>
                <asp:TextBox ID="password" runat="server" CssClass="fadeIn third" name="password" placeholder="password"></asp:TextBox>
                <%--<input type="text" id="login" class="fadeIn second" name="login" placeholder="login">--%>

                <%--<input type="text" id="password" class="fadeIn third" name="login" placeholder="password">--%>
                <asp:Button ID="submitButton" runat="server" CssClass="fadeIn fourth" Text="Log In" OnClick="submitButton_LoginClick"/>
                <%--<input type="submit" class="fadeIn fourth" value="Log In">--%>
            </form>

            <div id="formFooter">
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="underlineHover" href="SignUp.aspx">Not an User? Sign Up!</asp:HyperLink>
            </div>

        </div>
    </div>
</asp:Content>
