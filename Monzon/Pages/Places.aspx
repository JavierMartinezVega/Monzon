<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Places.aspx.cs" Inherits="Monzon.Pages.Places" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">Places</div>
        
        
        
        <asp:Panel runat="server" ID="pnlGrid" >
            <asp:GridView runat="server" ID="gridPlaces" AllowPaging="true" AutoGenerateColumns="False">
                <alternatingrowstyle BackColor="White" ForeColor="#284775"></alternatingrowstyle>
                <Columns>
                    <asp:BoundField DataField="UNIQUE_ID" Visible="false"/>
                    <asp:BoundField DataField="NAME" HeaderText="NAME"/>
                    <asp:BoundField DataField="X" HeaderText="COORD X"/>
                    <asp:BoundField DataField="Y" HeaderText="COORD Y"/>
                    <asp:BoundField DataField="SUBTITLE" HeaderText="DESCRIPTION"/>
                    <asp:BoundField DataField="PLACE_TYPE.CAPTION" HeaderText="PLACE TYPE"/>
                </Columns>
            </asp:GridView>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlAdd" Visible="false">
            <asp:Button runat="server" CssClass="saveButton" Text="ADD A PLACE"/>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
