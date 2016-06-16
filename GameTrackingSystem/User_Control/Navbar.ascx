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
            <img src="../img/logo2.png"class="navbar-brand" style="siz; width: 300px; height: 120px;" ></img>
        </div>
        <!-- Collection of nav links and other content for toggling -->
        <div id="navbarCollapse" class="collapse navbar-collapse">
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
        </div>
    </nav>