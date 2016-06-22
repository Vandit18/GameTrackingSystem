<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="gameView.ascx.cs" Inherits="GameTrackingSystem.User_Control.gameView" %>


<div class="displaydiv">
    <h2>
        <asp:Label runat="server" ID="gameheading"></asp:Label>
    </h2>
    <div>
        <h4>
              <asp:Label runat="server" ID="teamAname"></asp:Label>
            &nbsp;<asp:Label runat="server" ID="TeamAScore"></asp:Label>
        &nbsp;----
            <asp:Label runat="server" ID="teamBname"></asp:Label>
            &nbsp;<asp:Label runat="server" ID="TeamBScore"></asp:Label>
        </h4>
    </div>
    <div>
        <h4>
            Game Description:<asp:Label runat="server" ID="description"></asp:Label>
        </h4>
    </div>
    <div>
        <h4>
             Stadium:<asp:Label runat="server" ID="location"></asp:Label>
            &nbsp;&nbsp;
            Date:<asp:Label runat="server" ID="time"></asp:Label>
        </h4>
    </div>
   <div>
       <h4>
            WinningTeam: <asp:Label runat="server" ID="winningteam"></asp:Label> 
             &nbsp;&nbsp; 
             Spectators: <asp:Label runat="server" ID="SpecNumber"></asp:Label>
       </h4>
   </div>
    <div>
        <h4>
              <asp:Label runat="server" ID="resultA"></asp:Label>
            <br />
              <asp:Label runat="server" ID="resultB"></asp:Label>
        </h4>
    </div>
</div>
