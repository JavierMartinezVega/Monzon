<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Monzon.Master" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="Monzon.Pages.Map" %>

 

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <%-- <asp:Panel runat="server" CssClass="contentBox">--%>
        <!--<div class="pageTitle">Contact</div>-->
        
        <!-- ALTO:510 ANCHO:1022 -->
        
        
  
        <asp:Panel runat="server" CssClass="map" ID="pnlMap" >
            <asp:Panel runat="server" ID="pnlAdd" CssClass="AddButton" OnClick="pnlAdd_Click" ToolTip="Add a place"></asp:Panel>
        </asp:Panel>

</asp:Content>
