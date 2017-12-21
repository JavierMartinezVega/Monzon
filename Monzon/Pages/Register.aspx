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
                <asp:Panel runat="server" ID="pnlUsernameError" CssClass="error" Visible="false">You must specify a valid username</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label3">Name:</asp:Label>
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <asp:Panel runat="server" ID="pnlNameError" CssClass="error" Visible="false">You must specify a valid name</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label1">Surname:</asp:Label>
                <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
                <asp:Panel runat="server" ID="pnlSurnameError" CssClass="error" Visible="false">You must specify a valid surname</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label4">Email:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
                <asp:Panel runat="server" ID="pnlEmailError"  CssClass="error" Visible="false">You must specify a valid email</asp:Panel>
            </asp:Panel>
                <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label5">Phone (optional):</asp:Label>
                <asp:TextBox runat="server" ID="txtMessage"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label2">Password:</asp:Label>
                <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
                <asp:Panel runat="server" ID="pnlPasswordError" CssClass="error" Visible="false">You must specify a valid password</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label6">Password (repeat):</asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordRepeat"></asp:TextBox>
                <asp:Panel runat="server" ID="pnlPasswordRepeatError" CssClass="error" Visible="false">Passwords don´t match</asp:Panel>
            </asp:Panel>
            <%--  <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="lblTimezone">Time Zone (optional):</asp:Label>
                <asp:DropDownList runat="server"  ID="cboTimezone"  />
            </asp:Panel>--%>
            <asp:Panel runat="server" CssClass="contentItemGroup">
                <asp:Panel runat="server" CssClass="contentItem">
                    <asp:Label runat="server" ID="lblCoordX">Coord X:</asp:Label>
                    <asp:TextBox runat="server" ID="txtCoordX"></asp:TextBox>
                </asp:Panel>
                <asp:Panel runat="server" CssClass="contentItem">
                    <asp:Label runat="server" ID="lblCoordY">Coord Y:</asp:Label>
                    <asp:TextBox runat="server" ID="txtCoordY"></asp:TextBox>
                </asp:Panel>
                <asp:Panel runat="server" ID="pnlCoordsError" CssClass="error" Visible="false">You must specify valid coords</asp:Panel>
            </asp:Panel>
            
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Button Text="Submit" runat="server" CssClass="saveButton" ID="btnSend" OnClick="Unnamed13_Click"/>
            </asp:Panel>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
