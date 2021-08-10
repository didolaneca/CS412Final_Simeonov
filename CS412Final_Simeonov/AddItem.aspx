<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="CS412Final_Simeonov.AddItem" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ItemScript" runat="server">
    <script src="Script/AddItem.js"></script>
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
                        <a class="nav-link" href="Contactus.aspx">Add Item</a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group" id="file-input-form">
        <div class="form-group row">
            <label for="itemName" class="col-sm-2 col-form-label text-right">Item Name</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="itemName" aria-describedby="emailHelp" placeholder="Enter Item Name">
            </div>
        </div>
        <div class="form-group row">
            <%-- <label for="description">Description</label>
            <input type="text" class="form-control" id="description" placeholder="Description">--%>
            <label for="description" class="col-sm-2 col-form-label text-right">Description</label>
            <div class="col-sm-10">
                <textarea class="form-control" id="description" rows="2" placeholder="Enter Item Description here"></textarea>
            </div>
        </div>
        <div class="form-group row">
            <label for="count" class="col-sm-2 col-form-label text-right">Count</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="count" placeholder="Count">
            </div>
        </div>
        <div class="form-group row">
            <label for="price" class="col-sm-2 col-form-label text-right">Price</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="price" placeholder="Price">
            </div>
        </div>
        <%-- <div class="form-check">
            <input type="checkbox" class="form-check-input" id="exampleCheck1">
            <label class="form-check-label" for="exampleCheck1">Check me out</label>
        </div>--%>
        <div class="form-group row">
            <label for="pictureInput" class="col-sm-2 col-form-label text-right">Attach picture here:</label>
            <div class="col-sm-10" id="divPicUpload">
                <input type="file" class="form-control-file" id="pictureInput">
            </div>
        </div>
        <button type="submit" id="addItem" class="btn btn-primary offset-sm-2 col-sm-2">Add Item</button>
    </div>
</asp:Content>
