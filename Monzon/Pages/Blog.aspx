<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="Monzon.Pages.Blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">Blog</div>
            <asp:Panel runat="server" ID="pnlPosts" CssClass="BlogPage"></asp:Panel>

            <asp:Panel runat="server" ID="pnlMore" Visible="false">
                <asp:Button Text="Load more" runat="server" CssClass="saveButton" OnClick="Unnamed13_Click"/>
            </asp:Panel>
        <div runat="server" ID="prueba"></div>
    </asp:Panel>
</asp:Content>
