<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="GameTrackingSystem.HomePage" %>
<%@ Register Src="~/User_Control/gameView.ascx" TagName="gamedisplay" TagPrefix="GameTracker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div class="col-lg-12" >
        <div class="col-lg-2">
            <img src="img/ronaldo.jpg" style="width:220px; height:400px"/>
        </div>
        <div class="col-lg-8">
        <img src="../img/trophy.png" style="display:block; margin:auto; height:100px; width:100px;" />
        <div align="center">
        <asp:Label ID="Heading" CssClass="label label-pill label-success" runat="server"></asp:Label></div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
        <div class="col-lg-2">
            <img src="img/messi.png" style="width:220px; height:400px"/>
        </div>
    </div>
   
    <nav>
          
  <ul class="pager">
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="Previous" OnClick="PreviousButton_Click" />
    <asp:Button ID="Button2" runat="server" CssClass="btn btn-success" Text="Current" onClick="Current_Click" />
    <asp:Button ID="Button3" runat="server" CssClass="btn btn-success" Text="Next" OnClick="NextButton_Click" />
  </ul>
</nav>   
 <br /> <br />      
</asp:Content>

