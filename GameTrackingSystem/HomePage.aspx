<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="GameTrackingSystem.HomePage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="col-lg-12" >
        <div class="col-md-offset-2 col-lg-8">
           <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                    ID="GameGridView" AutoGenerateColumns="false" DataKeyNames="GameID"
                       PagerStyle-CssClass="pagination-ys">
                    <Columns>
                   
                        <asp:BoundField DataField="GameName" HeaderText="Game Name" Visible="true" SortExpression="GameName" />
                        <asp:BoundField DataField="GameLocation" HeaderText="Game Location" Visible="true" SortExpression="GameLocation" />
                         <asp:BoundField DataField="GameDescription" HeaderText="Game Description" Visible="true" SortExpression="GameDescription" />
                        <asp:BoundField DataField="TeamA" HeaderText="Team A" Visible="true" SortExpression="TeamA" />
                        <asp:BoundField DataField="TeamB" HeaderText="Team B" Visible="true" SortExpression="TeamB" />
                        <asp:BoundField DataField="TeamAScore" HeaderText="Team A Score" Visible="true" SortExpression="TeamAScore" />
                        <asp:BoundField DataField="TeamBScore" HeaderText="Team B Score" Visible="true" SortExpression="TeamBScore" />
                        <asp:BoundField DataField="Spectators" HeaderText="Spectators" Visible="true" SortExpression="Spectators" />
                        <asp:BoundField DataField="WinningTeam" HeaderText="WinningTeam" Visible="true" SortExpression="WinningTeam" />
                        <asp:BoundField DataField="GameDate" HeaderText="Game Date" Visible="true" SortExpression="GameDate"
                            DataFormatString="{0:MMM dd, yyyy}" />
                                            </Columns>
                </asp:GridView>
        </div> 
    </div>                                   
</asp:Content>
