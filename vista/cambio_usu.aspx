
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/controler/cambio_usu.aspx .cs" Inherits="vista_cambio_usu" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 853px; width: 994px">
            selecciona el dato que deseas cambiar , ademas de tu nombre , tu correo , apellido
            <br />
            y el cambio que realizaras (ESTADO y ROL&nbsp;&nbsp; no puede ser modificada)<br />
            <br />
&nbsp;
            <br />
            seleccciona el dato que deseas cambiar
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="Seleccion_cambio" runat="server" OnSelectedIndexChanged="Seleccion_cambio_SelectedIndexChanged" Width="166px">
                <asp:ListItem Value="Nom_Usu">Nombre</asp:ListItem>
                <asp:ListItem Value="Apell_Usu">Apellido</asp:ListItem>
                <asp:ListItem Value="Direcc_Usu">Direccion</asp:ListItem>
                <asp:ListItem Value="Correo_Usu">Correo</asp:ListItem>
                <asp:ListItem Value="Contra_Usu">Contraseña</asp:ListItem>
                <asp:ListItem Value="Telef_Usu">Telefono</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Digita el cambio 
            <br />
            <asp:TextBox ID="Txt_cambio" runat="server" Height="16px" OnTextChanged="Txt_cambio_TextChanged"></asp:TextBox>
            <br />
            <br />
            escibre tu correo<br />
            <asp:TextBox ID="txt_usu_correo" runat="server" Height="16px" TextMode="Email"></asp:TextBox>
            <br />
            <br />
            digita tu nombre <br />
            <asp:TextBox ID="txt_usu_nombre" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            <br />
            digita tu apellido<br />
            <asp:TextBox ID="txt_usu_apelli" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            si esats seguro da click en enviar<br />
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
