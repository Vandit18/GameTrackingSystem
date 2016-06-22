<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navbar.ascx.cs" Inherits="GameTrackingSystem.User_Control.Navbar" %>
 <nav role="navigation" class="navbar navbar-inverse" style="color:white">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" data-target="#navbarCollapse" data-toggle="collapse" class="navbar-toggle">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<label style="font-size:x-large"><i class="fa fa-futbol-o fa-2x" aria-hidden="true"></i>      VJKM</label>
        </div>
        <!-- Collection of nav links and other content for toggling -->
          <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right">
                <li id="home" runat="server"><a href="/HomePage.aspx"><i class="fa fa-home fa-lg"></i> Home</a></li>

                <asp:PlaceHolder ID="PublicPlaceHolder" runat="server">
                    <li id="login" runat="server"><a href="../LoginPage.aspx"><i class="fa fa-sign-in fa-lg"></i> Login</a></li>
                    <li id="register" runat="server"><a href="../Register.aspx"><i class="fa fa-user-plus fa-lg"></i> Register</a></li>
                </asp:PlaceHolder>

                <asp:PlaceHolder ID="UserPlaceHolder" runat="server">
                   
                </asp:PlaceHolder>

                <asp:PlaceHolder ID="VJKMPlaceHolder" runat="server">
                    <li id="game" runat="server"><a href="../SecurePages/Games.aspx"><i class="fa fa-leanpub fa-lg"></i> Games</a></li>
                    <li id="logout" runat="server"><a href="/Logout.aspx"><i class="fa fa-sign-out fa-lg"></i> Logout</a></li>
                    <li id="gameEdit" runat="server"><a href="../SecurePages/GameEditPage.aspx"><i class="fa fa-pencil" aria-hidden="true"></i> GameEdit</a></li>
                </asp:PlaceHolder>

                <li id="about" runat="server"><a href="../About.aspx"><i class="fa fa-book fa-lg"></i> About</a></li>
                <li id="feedback" runat="server"><a href="../FeedBack.aspx"><i class="fa fa-envelope-o" aria-hidden="true"></i> Contact</a></li>
            </ul>
        </div>

 </nav>