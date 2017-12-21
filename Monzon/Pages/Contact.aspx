<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Monzon.Pages.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">Contact</div>

        <asp:Panel runat="server" ID="pnlPassword">
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label3">Name:</asp:Label>
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label4">Email:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label5">Message:</asp:Label>
                <asp:TextBox runat="server" ID="txtMessage" TextMode="MultiLine" Width="100%" Height="20%"></asp:TextBox>
            </asp:Panel>
            
             <asp:Panel runat="server" CssClass="contentItem">
                <asp:Button Text="Send" runat="server" CssClass="saveButton" ID="btnSend" OnClick="Unnamed13_Click"/>
             </asp:Panel>
             <asp:Panel runat="server" CssClass="contentItem" ID="pnlOk" Visible="false">
                <asp:Label runat="server">You email was succesfuly sent</asp:Label>
             </asp:Panel>
             <asp:Panel runat="server" CssClass="contentItem" ID="pnlError" Visible="false">
                <asp:Label runat="server">There was an unexpected error sending your message</asp:Label>
             </asp:Panel>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
