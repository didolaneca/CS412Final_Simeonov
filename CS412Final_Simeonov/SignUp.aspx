<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CS412Final_Simeonov.WebForm2" %>

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
