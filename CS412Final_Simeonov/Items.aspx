<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="CS412Final_Simeonov.WebForm6" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ItemScript" runat="server">
    <script src="Script/Items.js"></script>
</asp:Content>
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
                    <li class="nav-item">
                        <a class="nav-link" runat="server" OnClick="LogOut" href="Login.aspx">Log Out</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container body-items">
        <div class="container-fluid">
        <div class="row" id="displayItems">
        </div>
        <div class="row">
            <div class="col-sm" align="center">
            <button type="submit" id="fetchMoreItems" style="margin-top: 15px;" class="btn btn-primary">Show more Items</button>
                </div>
        </div>
    </div>
    </div>
    
</asp:Content>

