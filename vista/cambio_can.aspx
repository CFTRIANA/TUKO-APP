
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/controler/cambio_can.aspx.cs" Inherits="vista_cambio_can" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 766px; width: 994px">
            selecciona el dato que deseas cambiar , ademas del nombre y edad del canino ( raza no puede ser modificada)<br />
            <br />
&nbsp;
            <br />
            seleccciona el dato que deseas cambiar
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButtonList ID="Seleccion_cambio" runat="server" OnSelectedIndexChanged="Seleccion_cambio_SelectedIndexChanged" Width="166px">
                <asp:ListItem Value="Nom_Can">Nombre</asp:ListItem>
                <asp:ListItem Value="Vacu_Can">Vacunas</asp:ListItem>
                <asp:ListItem Value="Eda_Can">Edad</asp:ListItem>
                <asp:ListItem Value="Desc_Can">Descripcion</asp:ListItem>
                <asp:ListItem Value="Estd_Can">Estado</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Digita el cambio <br />
            <br />
            <asp:TextBox ID="Txt_cambio" runat="server" Height="16px" OnTextChanged="Txt_cambio_TextChanged"></asp:TextBox>
            <br />
            <br />
            escibre la edad del canino<br />
            <br />
            <asp:TextBox ID="txt_can_edad" runat="server" Height="16px" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            digita el nombre de tu perro<br />
            <asp:TextBox ID="txt_can_nom" runat="server" Height="16px"></asp:TextBox>
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
