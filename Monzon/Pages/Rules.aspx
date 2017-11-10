<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Rules.aspx.cs" Inherits="Monzon.Pages.Rules" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" CssClass="contentBox">
        <div class="pageTitle">Mi Perfil</div>
        
        <ul class="tabs">
            <li role="presentation"><asp:LinkButton ID="btnPersonal" runat="server" OnClick="PersonalBtn_Click">Leader</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnEmail" runat="server" OnClick="EmailBtn_Click">Range 4</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnPassword" runat="server" OnClick="PasswordBtn_Click">Range 3</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnApply" runat="server" OnClick="ApplyBtn_Click">Range 2</asp:LinkButton></li>
            <li role="presentation"><asp:LinkButton ID="btnActive" runat="server" OnClick="ActiveBtn_Click">Rnage 1</asp:LinkButton></li>
        </ul>
        
        <asp:Panel runat="server" ID="pnlPersonal" >
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="lblName">Nombre:</asp:Label>
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label1">Apellidos:</asp:Label>
                <asp:TextBox runat="server" ID="txtSurname"></asp:TextBox>
            </asp:Panel>
    
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label2">Teléfono:</asp:Label>
                <asp:TextBox runat="server" ID="txtPhone"></asp:TextBox>
            </asp:Panel>
            <asp:Button Text="Guardar" runat="server" CssClass="saveButton" OnClick="Unnamed5_Click"/>
        </asp:Panel>
        
        <asp:Panel runat="server" ID="pnlEmail" Visible="false">
            <asp:Panel runat="server" CssClass="contentItem" >
                <asp:Label runat="server" ID="Label6">Actual:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmailOld" Enabled="false"></asp:TextBox>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label7">Nuevo:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmailNew"></asp:TextBox>
            </asp:Panel>
    
            <asp:Panel runat="server" CssClass="contentItem">
                <asp:Label runat="server" ID="Label8">Repetir Nuevo:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmailNewRepeat"></asp:TextBox>
            </asp:Panel>
            <asp:Button Text="Guardar" runat="server" CssClass="saveButton" OnClick="Unnamed9_Click"/>
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
