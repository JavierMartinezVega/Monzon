<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Monzon.Pages.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">My Account</div>
        
        <ul class="tabs">
            <li role="presentation"><asp:LinkButton ID="btnPersonal" runat="server" OnClick="PersonalBtn_Click">Personal Data</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnEmail" runat="server" OnClick="EmailBtn_Click">Email</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnPassword" runat="server" OnClick="PasswordBtn_Click">Password</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnApply" runat="server" OnClick="ApplyBtn_Click">Become a member</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnActive" runat="server" OnClick="ActiveBtn_Click">Become a member</asp:LinkButton></li>
        </ul>
        
        <asp:Panel runat="server" ID="pnlPersonal" >
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="lblName">Name:</asp:Label>
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label1">Surname:</asp:Label>
                <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
            </asp:Panel>
    
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label2">Phone (optional):</asp:Label>
                <asp:TextBox runat="server" ID="txtPhone"></asp:TextBox>
            </asp:Panel>
            <asp:Button Text="Save" runat="server" CssClass="saveButton" OnClick="Unnamed5_Click"/>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlEmail" Visible="false">
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label6">Current:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmailOld" Enabled="false"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label7">New:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmailNew"></asp:TextBox>
            </asp:Panel>
    
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label8">New (repeat):</asp:Label>
                <asp:TextBox runat="server" ID="txtEmailNewRepeat"></asp:TextBox>
            </asp:Panel>
            <asp:Button Text="Save" runat="server" CssClass="saveButton" OnClick="Unnamed9_Click"/>
        </asp:Panel>

        <asp:Panel runat="server" ID="pnlPassword" Visible="false">
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label3">Current:</asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordOld"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label4">New:</asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordNew"></asp:TextBox>
            </asp:Panel>
    
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label5">New (repeat):</asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordNewRepeat"></asp:TextBox>
            </asp:Panel>
            <asp:Button Text="Save" runat="server" CssClass="saveButton" OnClick="Unnamed13_Click"/>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlApply" Visible="false">
            * Be sure you meet all the requirements specified in the guild section before applying please. Applications that don´t meet the requirements will be probably discarded. To apply for the guild membership you must own an account here, you can apply directly while registering.
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label9">Player name:</asp:Label>
                <asp:TextBox runat="server" ID="txtPlayerName"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label10">Player coords (X / Y):</asp:Label>
                <asp:TextBox runat="server" ID="txtCoords"></asp:TextBox>
            </asp:Panel>
    
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label11">Previous guild (optional):</asp:Label>
                <asp:TextBox runat="server" ID="txtGuild"></asp:TextBox>
            </asp:Panel>
             <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label12">Comments (optional):</asp:Label>
                <asp:TextBox runat="server" ID="txtComments"></asp:TextBox>
            </asp:Panel>

            <asp:Button Text="Apply" runat="server" CssClass="saveButton" OnClick="Unnamed13_Click"/>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
