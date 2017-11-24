<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Place.aspx.cs" Inherits="Monzon.Pages.Place" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">Blog</div>
        
            <asp:Panel runat="server" ID="pnlPosts" >
            
            </asp:Panel>

            <asp:Panel runat="server" ID="pnlMore" Visible="false">
                <asp:Button Text="View more" runat="server" CssClass="saveButton" OnClick="Unnamed13_Click"/>
            </asp:Panel>

    </asp:Panel>
</asp:Content>
