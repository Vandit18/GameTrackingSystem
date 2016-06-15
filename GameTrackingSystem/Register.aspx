<%@ Page Title="Register Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GameTrackingSystem.Register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container">
        <div class="row">
            <div class="col-md-6 text-center">
                <h1>Register here</h1>
            </div>
        </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label class="control-label" for="UserNameTextBox">User Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="UserNameTextBox" placeholder="User Name" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" CssClass="alert-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="User Name is required" ControlToValidate="UserNameTextBox"></asp:RequiredFieldValidator>
                </div>
                
                <div class="form-group">
                    <label class="control-label" for="PassTextBox">Password</label>
                    <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="PasswordTextBox" placeholder="Password" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" CssClass="alert-danger" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Password is required" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label class="control-label" for="ConfPassTextBox">Confirm Password</label>
                    <asp:TextBox runat="server" TextMode="Password" CssClass="form-control" ID="ConfirmPasswordTextBox" placeholder="ConfirmPassword" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator Display="Dynamic" CssClass="alert-danger" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Password is required" ControlToValidate="ConfirmPasswordTextBox"></asp:RequiredFieldValidator>
                </div>
                <div class="text-right">
                    <a class="btn btn-warning btn-lg" id="CancelButton" href="HomePage.aspx">Cancel</a>
                    <asp:Button runat="server" CssClass="btn btn-primary btn-lg" ID="RegisterButton" Text="Register" CausesValidation="true" OnClick="RegisterButton_Click"/>
                </div>
            </div>
        </div>
    

</asp:Content>
