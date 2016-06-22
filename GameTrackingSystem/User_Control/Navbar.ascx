<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navbar.ascx.cs" Inherits="GameTrackingSystem.User_Control.Navbar" %>
 <nav role="navigation" class="navbar navbar-inverse">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" data-target="#navbarCollapse" data-toggle="collapse" class="navbar-toggle">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <img src="../img/logo2.png"class="navbar-brand" style="width: 300px; height: 120px;" />
        </div>
        <!-- Collection of nav links and other content for toggling -->
        <%--<div id="navbarCollapse" class="collapse navbar-collapse">
            <ul class="nav navbar-nav">
                 <li id="home" runat="server"><a href="../HomePage.aspx">Home</a></li>
                <li id="game" runat="server"><a href="../loginPage.aspx">Games</a></li>
                <li id="about" runat="server"><a href="../About.aspx">About</a></li>
                <li id="feedback" runat="server"><a href="../FeedBack.aspx">FeedBack</a></li>
               
            </ul>
            <ul class="nav navbar-nav navbar-right">
                <li id="Login" runat="server"><a href="../LoginPage.aspx">Login</a></li>
                <li id="Register" runat="server"><a href="../Register.aspx">Register</a></li>
            </ul>
        </div>--%>

     <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right">
                <li id="home" runat="server"><a href="/HomePage.aspx"><i class="fa fa-home fa-lg"></i> Home</a></li>

                <asp:PlaceHolder ID="PublicPlaceHolder" runat="server">
                    <li id="login" runat="server"><a href="../LoginPage.aspx"><i class="fa fa-sign-in fa-lg"></i> Login</a></li>
                    <li id="register" runat="server"><a href="../Register.aspx"><i class="fa fa-user-plus fa-lg"></i> Register</a></li>
                </asp:PlaceHolder>

              <%--  <asp:PlaceHolder ID="UserPlaceHolder" runat="server">
                    <li id="users" runat="server"><a href="/Admin/Users.aspx"><i class="fa fa-users fa-lg"></i> Users</a></li>
                </asp:PlaceHolder>--%>

                <asp:PlaceHolder ID="ContosoPlaceHolder" runat="server">
                    <li id="home1" runat="server"><a href="../HomePage.aspx"><i class="fa fa-map-signs fa-lg"></i> Home</a></li>
                    <li id="game" runat="server"><a href="../SecurePages/Games.aspx"><i class="fa fa-leanpub fa-lg"></i> Games</a></li>
                    <li id="about" runat="server"><a href="../About.aspx"><i class="fa fa-book fa-lg"></i> About</a></li>
                    <li id="logout" runat="server"><a href="/Logout.aspx"><i class="fa fa-sign-out fa-lg"></i> Logout</a></li>
                </asp:PlaceHolder>

                <li id="feedback" runat="server"><a href="../FeedBack.aspx"><i class="fa fa-phone fa-lg"></i> Contact</a></li>
            </ul>
        </div>

    </nav>