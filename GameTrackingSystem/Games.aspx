<%@ Page Title="Game Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="GameTrackingSystem.Games" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Game Details</h1>
                <h5>All Fields are Required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="GameNameTextBox">Game Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="GameNameTextBox" placeholder="Game Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GLoactionTextBox">Game Location</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="GLocationTextBox" placeholder="Game Locaiton" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GDescriptionTextBox">Game Description</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="GameDesc" placeholder="Game Description" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TeamA">Team A</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeamA" placeholder="TeamA" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TeamB">Team B</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeamB" placeholder="TeamB" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TeamAScore">TeamA Score</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeamAScore" placeholder="TeamAScore" required="true" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TeamBScore">TeamB Score</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeamBScore" placeholder="TeamBScore" required="true" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="Spectators">Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="Spectators" placeholder="Spectators" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="WinningTeam">WinningTeam</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="WinningTeam" placeholder="WinningTeam" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="GameDateTextBox">Game Date</label>
                    <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="GameDateTextBox" placeholder="Game Date Format: mm/dd/yyyy" required="true"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Invalid Date! Format: mm/dd/yyyy"
                        ControlToValidate="GameDateTextBox" MinimumValue="01/01/2000" MaximumValue="01/01/2999"
                        Type="Date" Display="Dynamic" BackColor="Red" ForeColor="White" Font-Size="Large"></asp:RangeValidator>
                </div>
                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" 
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" onclick="SaveButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
