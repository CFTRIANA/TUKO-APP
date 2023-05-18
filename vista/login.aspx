<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/controler/login.aspx.cs" Inherits="vista_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <style type="text/css">

    
        .cuadroLogin {
            background: white;
            width: 20em;
            height: auto;
            position: relative;
            margin: auto;
            padding: 2em;
            border-radius: 1em;
            color: black;
            display:block;
            align-items: center;
            top: 8px;
            left: 407px;
        }
        .ub1 {
            text-align: left;
            font-weight: bold;
            margin-bottom: 0.5em;
            margin-top: 0.5em;
        }
        .formtlo {
            font-size: 2em;
            font-weight: bold;
            padding-bottom: 0.8em;
            color: black;
        }
        input {
            width: 100%;
            padding: 0.5em;
            font-size: 1em;
            border-radius: 5px;
            border: 1px solid black;
            color: black;
            text-align: left;
        }
        input[type=submit] {
            margin-top: 1.5em;
            width: 48%;
            text-align: center;
            align-items: center;
        }
        .botones{
            display:compact;
            align-items: center;
        }
        #form1 {
            height: 484px;
        }
    </style>
</head>
<body>
    
       
    <form id="form1" class="centrado" runat="server">
        <div class="cuadroLogin">
             <asp:Image ID="Image1" runat="server" ImageAlign="Baseline" ImageUrl="~/vista/logo.png" Width="400px" Height="300px" />
            <div class="formtlo">Inicio de Sesion</div>
            <div class="ub1">🔑 usuario</div>
            <div style="display:flex">
                <asp:TextBox ID="Usu_nametxt" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_user" runat="server" ControlToValidate="Usu_nametxt" ErrorMessage="*" ValidationGroup="login" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="ub1">🔒 contraseña</div>
            <div style="display:flex">
                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_pass" runat="server" ControlToValidate="Password" ErrorMessage="*" ValidationGroup="login" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div class="botones">
                <asp:Button ID="B_login" runat="server" OnClick="B_login_Click" Text="Entrar" ValidationGroup="login" />
                <asp:Button ID="B_registrar" runat="server" OnClick="B_registrar_Click" Text="Registar" />
            </div>
        </div>
    </form>
</body>
</html>
