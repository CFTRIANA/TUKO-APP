
<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="~/controler/cambio_rol.aspx.cs" Inherits="vista_cambio_rol" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 822px; width: 994px">
            selecciona el rol al&nbsp; que deseas cambiar , ademas insertar&nbsp; el&nbsp; nombre , apellido y correo de la persona&nbsp; ( la clave de seguridad es necesaria para realizar la&nbsp; modificacion)<br />
            <br />
&nbsp;
            <br />
            seleccciona el ROL al&nbsp; que deseas cambiar la persona:
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="Seleccion_rol" runat="server" OnSelectedIndexChanged="Seleccion_cambio_SelectedIndexChanged" Width="197px">
                <asp:ListItem Value="1">1 = &quot;usuario&quot; </asp:ListItem>
                <asp:ListItem Value="2">2 = &quot;administrador&quot;</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Digita el nombre de la persona&nbsp; <br />
            <br />
            <asp:TextBox ID="Txt_nombre" runat="server" Height="16px" OnTextChanged="Txt_cambio_TextChanged"></asp:TextBox>
            <br />
            <br />
            escibre el apellido de la persona<br />
            <br />
            <asp:TextBox ID="txt_apellido" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            digita el correo de la persona<br />
            <br />
            <asp:TextBox ID="txt_correo" runat="server" Height="16px" TextMode="Email"></asp:TextBox>
            <br />
            <br />
            digita el clave de seguridad<br />
            <br />
            <asp:TextBox ID="txt_clave" runat="server" Height="16px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            si estas seguro dar click en enviar<br />
            <br />
            <asp:Button ID="Benviar" runat="server" Height="58px" Text="enviar" Width="312px" OnClick="Benviar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            si no es asi , o deseas volver al anterior menu , dale en volver<br />
            <br />
&nbsp;<asp:Button ID="Bvolver" runat="server" Height="58px" Text="volver" Width="304px" OnClick="Bvolver_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
