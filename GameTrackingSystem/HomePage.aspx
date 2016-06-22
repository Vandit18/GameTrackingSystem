<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="GameTrackingSystem.HomePage" %>
<%@ Register Src="~/User_Control/gameView.ascx" TagName="gamedisplay" TagPrefix="GameTracker" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div class="col-lg-12" >
       <div class="col-md-offset-2 col-lg-8">
    <h3 align="center">
    <asp:Label ID="Heading" CssClass="label label-pill label-primary" runat="server"></asp:Label></h3>
           </div></div>
    <div class="col-lg-12" >
       <div class="col-md-offset-2 col-lg-8" >
           <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div> 
      
    </div>

    
      <nav>
          
  <ul class="pager">
    <asp:Button ID="PreviousButton" runat="server" CssClass="btn btn-info" Text="Previous" OnClick="PreviousButton_Click" />
    <asp:Button ID="Current" runat="server" CssClass="btn btn-info" Text="Current" onClick="Current_Click" />
    <asp:Button ID="NextButton" runat="server" CssClass="btn btn-info" Text="Next" OnClick="NextButton_Click" />
  </ul>
</nav>          
</asp:Content>
