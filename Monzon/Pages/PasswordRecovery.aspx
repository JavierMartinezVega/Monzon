<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="PasswordRecovery.aspx.cs" Inherits="Monzon.Pages.PasswordRecovery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">Contact</div>

        <asp:Panel runat="server" ID="pnlPassword">
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="lblText">You will be sent an email with the instructions to change your password to the email address </asp:Label>
                <asp:Label runat="server" ID="lblEmail"></asp:Label>
            </asp:Panel>
            <asp:Button Text="Change password" runat="server" CssClass="saveButton" ID="btnSend" OnClick="Unnamed13_Click"/>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
