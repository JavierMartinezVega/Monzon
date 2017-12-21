<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="Monzon.Pages.Members" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">Members</div>
        
        <ul class="tabs">
            <li role="presentation"><asp:LinkButton ID="btnPersonal" runat="server" OnClick="PersonalBtn_Click">Leader</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnEmail" runat="server" OnClick="EmailBtn_Click">Range 4</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnPassword" runat="server" OnClick="PasswordBtn_Click">Range 3</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnApply" runat="server" OnClick="ApplyBtn_Click">Range 2</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnActive" runat="server" OnClick="ActiveBtn_Click">Rnage 1</asp:LinkButton></li>
        </ul>
        
        <asp:Panel runat="server" ID="pnlPersonal" >
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="lblUser">User:</asp:Label>
                <asp:Label runat="server" ID="lblUserData"></asp:Label>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="lblName">Name:</asp:Label>
                <asp:Label runat="server" ID="lblNameData"></asp:Label>
            </asp:Panel>
            <asp:Button Text="Message" runat="server" CssClass="saveButton" ID="btnMessageLeader" OnClick="btnMessageLeader_Click" Visible="false"/>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlEmail" Visible="false">
            <asp:Panel runat="server" CssClass="contentItem" ID="pnlR4" >
           
            </asp:Panel>
        </asp:Panel>

        <asp:Panel runat="server" ID="pnlPassword" Visible="false">
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label3">Actual:</asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordOld"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label4">Nueva:</asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordNew"></asp:TextBox>
            </asp:Panel>
    
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label5">Repetir Nueva:</asp:Label>
                <asp:TextBox runat="server" ID="txtPasswordNewRepeat"></asp:TextBox>
            </asp:Panel>
            <asp:Button Text="Guardar" runat="server" CssClass="saveButton" OnClick="Unnamed13_Click"/>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlApply" Visible="false">
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label9">Actual:</asp:Label>
                <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label10">Nueva:</asp:Label>
                <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
            </asp:Panel>
    
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label11">Repetir Nueva:</asp:Label>
                <asp:TextBox runat="server" ID="TextBox3"></asp:TextBox>
            </asp:Panel>
            <asp:Button Text="Guardar" runat="server" CssClass="saveButton" OnClick="Unnamed13_Click"/>
        </asp:Panel>
        
         <asp:Panel runat="server" ID="pnlActive" Visible="false">
           
            <asp:Button Text="Mark me as active this week" runat="server" CssClass="saveButton" OnClick="Unnamed13_Click"/>
        </asp:Panel>

    </asp:Panel>
</asp:Content>
