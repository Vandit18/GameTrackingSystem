<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="gameView.ascx.cs" Inherits="GameTrackingSystem.User_Control.gameView" %>


<div class="displaydiv">
    <h3>
        <i class="fa fa-futbol-o" aria-hidden="true"></i>
        <asp:Label runat="server" ID="gameheading"></asp:Label>
    </h3>
    <div>
        <h4>
              <asp:Label runat="server" ID="teamAname"></asp:Label>
            &nbsp;<asp:Label runat="server" ID="TeamAScore"></asp:Label>
        &nbsp;&nbsp;:&nbsp;&nbsp;
            <asp:Label runat="server" ID="teamBname"></asp:Label>
            &nbsp;<asp:Label runat="server" ID="TeamBScore"></asp:Label>
        </h4>
    </div>
    <div>
        <h5>
            <asp:Label runat="server" ID="description"></asp:Label>
        </h5>
    </div>
    <div>
        <h5>
             Stadium:<asp:Label runat="server" ID="location"></asp:Label>
            &nbsp;&nbsp;
            <asp:Label runat="server" ID="time"></asp:Label>
        </h5>
    </div>
   <div>
       <h5>
            Total Goals : <asp:Label runat="server" ID="TotalGoals"></asp:Label> 
             &nbsp;&nbsp; 
             Spectators: <asp:Label runat="server" ID="SpecNumber"></asp:Label>
       </h5>
   </div>
    <div>
        <h4>
                 <i class="fa fa-trophy" aria-hidden="true"></i>
              <asp:Label runat="server" ID="resultA"></asp:Label>
        </h4>
    </div>
</div>
