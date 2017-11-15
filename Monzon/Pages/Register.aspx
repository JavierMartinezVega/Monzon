<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Monzon.Pages.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">Sign up</div>

        <asp:Panel runat="server" ID="pnlPassword">
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label7">Username:</asp:Label>
                <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>
                <asp:Panel runat="server" ID="pnlUsernameError" Visible="false">You must specify a valid Username</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label3">Name:</asp:Label>
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <asp:Panel runat="server" ID="pnlNameError" Visible="false">You must specify a valid Name</asp:Panel>
            </asp:Panel>
              <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label1">Surname:</asp:Label>
                <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
                  <asp:Panel runat="server" ID="pnlSurnameError" Visible="false">You must specify a valid Surname</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label4">Email:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
                <asp:Panel runat="server" ID="pnlEmailError" Visible="false">You must specify a valid Email</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label5">Phone (optional):</asp:Label>
                <asp:TextBox runat="server" ID="txtMessage"></asp:TextBox>
            </asp:Panel>
             <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label2">Password:</asp:Label>
                <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
                 <asp:Panel runat="server" ID="pnlPasswordError" Visible="false">You must specify a valid Password</asp:Panel>
            </asp:Panel>
             <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label6">Password (repeat):</asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordRepeat"></asp:TextBox>
                 <asp:Panel runat="server" ID="pnlPasswordRepeatError" Visible="false">Passwords don´t match</asp:Panel>
            </asp:Panel>
            <asp:Button Text="Sign up" runat="server" CssClass="saveButton" ID="btnSend" OnClick="Unnamed13_Click"/>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
