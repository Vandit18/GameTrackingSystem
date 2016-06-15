<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameEditPage.aspx.cs" Inherits="GameTrackingSystem.GameEditPage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Games</h1>
                <a href="Games.aspx" class="btn btn-success btn-sm"><i class="fa fa-plus"></i>Add Game</a>

                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                    ID="GameGridView" AutoGenerateColumns="false" DataKeyNames="GameID"
                    
                    PagerStyle-CssClass="pagination-ys">
                    <Columns>
                        
                        <asp:BoundField DataField="GameName" HeaderText="Game Name" Visible="true" SortExpression="GameName" />
                        <asp:BoundField DataField="GameLocation" HeaderText="Game Location" Visible="true" SortExpression="GameLocation" />
                        
                        <asp:BoundField DataField="GameDate" HeaderText="Game Date" Visible="true" SortExpression="GameDate"
                            DataFormatString="{0:MMM dd, yyyy}" />
                        <asp:HyperLinkField HeaderText="Edit" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Edit" 
                            NavigateUrl="~/Game.aspx.cs" ControlStyle-CssClass="btn btn-primary btn-sm" runat="server"
                            DataNavigateUrlFields="GameID" DataNavigateUrlFormatString="Game.aspx?GameID={0}" />
                        <asp:CommandField  HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete"
                            ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
