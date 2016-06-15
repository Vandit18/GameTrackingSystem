<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="GameTrackingSystem.LoginPage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

     
        <h2 class="form-signin-heading">Please Log in</h2>
        <label for="inputUserName" class="sr-only">User Name</label>
        <asp:TextBox runat="server" type="userName" id="inputUserName" class="form-control" placeholder="User Name" required="true"/>
        <label for="inputPassword" class="sr-only">Password</label>
        <asp:TextBox runat="server" type="password" id="inputPassword" class="form-control" placeholder="Password" required="true"/>
        <asp:button runat="server" class="btn btn-lg btn-primary btn-block" type="submit" Text="Log in"></asp:button>
      

    </div> <!-- /container -->


</asp:Content>
