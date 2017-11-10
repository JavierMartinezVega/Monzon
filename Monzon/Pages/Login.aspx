<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Monzon.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <style>
        body {
            background: #404040;
        }
         .box {
             margin: -142px 0 0 -120px;
             background: #ffffff;
             position: fixed;
             min-height: 200px;
             width: 500px;
             border-radius: 5px;
             padding: 0;
             z-index: 4;
             top: 42%;
             right: 0;
             left: 50%;
         }
        .box .logo {
            text-transform: uppercase;
            /*margin: 48px auto 0;*/
            margin: 56px auto 24px;
            outline: none;
            width: 240px;
            left: 50%;
        }
        .box .logo img {
            height: 100%;
            width: 100%;
        }
        .box .alert {
            background-color: #fff;
            border-radius: 3px;
            text-align: center;
            padding: 16px 12px;
            margin: 24px auto;
            transition: .3s;
            color: #E60000;
            width: 320px;
        }
        .box form {
            width: 100%;
            margin: 0;
        }
        .box form md-input-container {
            margin: 18px 10% 0;
            height: 36px;
            float: left;
            width: 80%;
            padding: 0;
        }
        .box form md-input-container label {
            color: rgba(0, 0, 0, 0.5) !important;
        }
        .box form .actions {
            text-align: center;
            float: left;
            width: 100%;
            padding: 0;
        }
        .box form .actions button {
            background: #404040;
            padding: 0 24px;
            transition: .6s;
            margin: 32px 0;
            color: #fff;
        }
        .box form .actions .activeButton {
            background: #09f;
        }
        .box form .actions md-progress-circular {
            margin: 26px 0 0 -25px !important;
            transition-delay: .6s;
            transform: scale(0);
            position: absolute;
            transition: .6s;
            z-index: -1;
            left: 50%;
        }
        .box form .actions md-progress-circular .md-inner .md-left .md-half-circle {
            border-left-color: #03A9F4;
            border-top-color: #03A9F4;
        }
        .box form .actions md-progress-circular .md-inner .md-right .md-half-circle {
            border-right-color: #03A9F4;
            border-top-color: #03A9F4;
        }
        .box form .actions md-progress-circular .md-inner .md-gap {
            border-top-color: #03A9F4;
            border-bottom-color: #03A9F4;
        }
        .box form .actions .scaleIn {
            transform: scale(0);
        }
        .box form .actions .scaleOut {
            transform: scale(1);
        }
        .box form .subactions {
            text-align: center;
            margin: 0 5% 12px;
            float: left;
            padding: 0;
            width: 90%;
        }
        .box form .subactions button {
            background: transparent;
            text-transform: inherit;
            margin: 6px 0 0 1%;
            padding: 0 12px;
            width: 32%;
        }
        .box form .subactions button span {
            color: #999;
        }
        .box form .subactions button:hover {
            background: #e1e1e1;
        }
    </style>
    <asp:Panel runat="server" class="box">
        <div class="logo"><img alt="Logo" src="images/gasflow-grey.png"></div>
        <asp:Panel runat="server" ID="pnlFobiden" class="alert" Visible="false">
            El Usuario o la Contraseña es incorrecta
        </asp:Panel>
        <form id="formLogin" runat="server" name="formLogin">
            <asp:label runat="server" for="txtUser">Usuario</asp:label>
            <asp:TextBox runat="server" autofocus="true" ID="txtUser" type="text"/>
            <br/>
            <asp:label runat="server" for= "txtPass">Contraseña</asp:label>
            <asp:TextBox runat="server" autofocus="true" ID="txtPass" type="password"/>
            <asp:LinkButton runat="server" OnClick="btnPasswordRecovery_Click" ID="btnPasswordRecovery">Forgot password?</asp:LinkButton>
            <div class="actions">
                <asp:button runat="server" class="activeButton" type="submit" Text="Entrar" OnClick="Unnamed3_Click">
                </asp:button>
            </div>
        </form>
    </asp:Panel>
</body>
</html>
