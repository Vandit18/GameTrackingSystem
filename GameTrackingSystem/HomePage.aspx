<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="GameTrackingSystem.HomePage" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="col-lg-12" >
        <div class="col-md-offset-2 col-lg-8">
           <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                    ID="GameGridView" AutoGenerateColumns="False" DataKeyNames="GameID"
                       PagerStyle-CssClass="pagination-ys" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
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
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />

<PagerStyle CssClass="pagination-ys" BackColor="#999999" ForeColor="Black" HorizontalAlign="Center"></PagerStyle>
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
        </div> 
    </div>                                   
</asp:Content>
