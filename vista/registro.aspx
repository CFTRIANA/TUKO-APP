<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/controler/registro.aspx.cs" Inherits="vista_registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro</title>
    <style type="text/css">
        .cuadroLogin {
            background: white;
            width: 76em;
            height: 460px;
            position: relative;
            margin: auto;
            padding: 2em;
            border-radius: 1em;
            color: black;
            display:block;
            align-items: center;
            top: 6px;
            left: -13px;
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
        .auto-style1 {
            font-size: small;
        }
    </style>
</head>
<body style="height: 540px; width: 1637px">
    <form id="form1" runat="server">
        <div class="tituloRegistro">


            <asp:Label ID="Label1" runat="server"  text-align="center" Text="Bienvenido a la fundacion TUKO" BorderColor="#3366FF"></asp:Label>


        </div>


        <div class="cuadroLogin">
            <div class="formtlo">
                Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Direccion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Codigo de rol </div>
            <div style="display:flex">
                <asp:TextBox ID="Txt_nombre" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="175px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Uregistro" runat="server" ControlToValidate="Txt_nombre" ErrorMessage="*" ValidationGroup="registro" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_apellido" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="175px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_Direccion" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="175px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_rol" runat="server"></asp:TextBox>
            </div> 
            <div class="formtlo">🔒contraseña&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 🔒<span class="auto-style1">confirmar contraseña</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Correo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono </div>
            <div style="display:flex">
                <asp:TextBox ID="Txt_contraseña" runat="server" OnTextChanged="Txt_contraseña_TextChanged" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Cregistro" runat="server" ControlToValidate="Txt_contraseña" ErrorMessage="*" ValidationGroup="registro" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_contraseñaCon" runat="server" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_Correo" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="214px" TextMode="Email"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:TextBox ID="Txt_telefono" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="175px" TextMode="Number"></asp:TextBox>
            </div>
            <asp:Button ID="B_registrar" runat="server" OnClick="B_registrar_Click" Text="Confirmar" ValidationGroup="registro" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="VolverA" runat="server" OnClick="Button1_Click" Text="Volver" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
