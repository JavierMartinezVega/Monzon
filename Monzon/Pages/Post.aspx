<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Post.aspx.cs" Inherits="Monzon.Pages.Post" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle"><asp:Label runat="server" ID="lbltitle"></asp:Label></div>
        
        <asp:Panel runat="server" ID="pnlPersonal" >
          <asp:Image runat="server" ID="imgPost" Height="80px" Width="100%"/>
          <asp:Label runat="server" ID="lblPost"></asp:Label>
        </asp:Panel>
        
         <asp:Panel runat="server" ID="pnlActive" Visible="false">
            <asp:Button Text="View all posts" runat="server" CssClass="saveButton" OnClick="Unnamed13_Click"/>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
