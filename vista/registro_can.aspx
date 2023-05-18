<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/controler/registro_can.aspx.cs" Inherits="vista_registro_can" %>

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
            width: 1016px;
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
        </style>
</head>
<body style="height: 540px; width: 1637px">
    <form id="form1" runat="server">
        <div class="tituloRegistro">


            Registro de Canino</div>


        <div class="cuadroLogin">
            <div class="formtlo">
                Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Edad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
            <div style="display:flex; width: 1101px;">
                <asp:TextBox ID="Txt_nomcan" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="175px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_Uregistro" runat="server" ControlToValidate="Txt_nomcan" ErrorMessage="*" ValidationGroup="registro" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_Edad" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="175px" TextMode="Number"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_Descan" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="175px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div> 
           
            <div class="formtlo">
                <br />
                # Raza&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Estado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                # de vacunas</div>
            <div style="display:flex">
                &nbsp;<asp:TextBox ID="Txt_razacan" runat="server" OnTextChanged="TB_Uregistro_TextChanged" Width="175px" TextMode="Number" MaxLength="2"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_estcan" runat="server" OnTextChanged="Txt_rol_TextChanged" TextMode="Number" Width="77px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Txt_vacu" runat="server" OnTextChanged="Txt_rol_TextChanged" TextMode="Number" Width="77px" MaxLength="2"></asp:TextBox>
                <br />
                <br />
            </div>
            <asp:Button ID="B_registrar" runat="server" OnClick="B_registrar_Click" Text="Enviar" ValidationGroup="registro" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="VolverA" runat="server" OnClick="Button1_Click" Text="cancelar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
