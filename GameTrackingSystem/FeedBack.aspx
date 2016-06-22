<%@ Page Title="FeedBack Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FeedBack.aspx.cs" Inherits="GameTrackingSystem.FeedBack" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- Page Header -->
      <!-- Main Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                <p>Want to get in touch with me? Fill out the form below to send me a message and I will try to get back to you within 24 hours!</p>
               
                
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                     <asp:TextBox runat="server" CssClass="form-control" ID="FirstNameTextBox" placeholder="FirstName" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="fnRequired" CssClass="alert-danger" ControlToValidate="FirstNameTextBox" Display="Dynamic" SetFocusOnError="true" ErrorMessage="First Name Required"></asp:RequiredFieldValidator>
                            <p class="help-block text-danger"></p>
                      
                            <asp:Label ID="LabelEmail" runat="server" Text=""></asp:Label>
                            <asp:TextBox runat="server" TextMode="Email" CssClass="form-control" ID="EmailTextBox" placeholder="Email" required="true"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="EmailRequired" CssClass="alert-danger" ControlToValidate="EmailTextBox" Display="Dynamic" SetFocusOnError="true" ErrorMessage="Email Required"></asp:RequiredFieldValidator>
                            <p class="help-block text-danger"></p>
                       
                            
                            <asp:TextBox runat="server" TextMode="Phone" CssClass="form-control" ID="ContactTextBox" placeholder="ContactNumber" required="true" pattern="^([0|\+[0-9]{1,5})?([1-9][0-9]{9})$" title="Your Phone Number should start with + sign,country code and number"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="PhoneRequired" CssClass="alert-danger" ControlToValidate="ContactTextBox" Display="Dynamic" SetFocusOnError="true" ErrorMessage="Contact Number Required"></asp:RequiredFieldValidator>
                            <p class="help-block text-danger"></p>
                      
                        <asp:TextBox runat="server" CssClass="form-control" ID="CommentTextBox" placeholder="Comment" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ID="cmtRequired" CssClass="alert-danger" ControlToValidate="CommentTextBox" Display="Dynamic" SetFocusOnError="true" ErrorMessage="Comment Required"></asp:RequiredFieldValidator>
                            <p class="help-block text-danger"></p>
                       
                    <div id="success"></div>
                    <div class="row">
                        <div class="form-group col-xs-12">
                            <asp:Button runat="server" Text="Submit" cssclass="btn btn-default" OnClick="Unnamed_Click"></asp:Button>
                        </div>
                    </div>
                            </div>
                        </div>
                
            </div>
        </div>
    </div>
</asp:Content>
