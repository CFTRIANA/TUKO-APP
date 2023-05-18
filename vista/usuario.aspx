<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterPage.master" AutoEventWireup="true" CodeFile="~/controler/usuario.aspx.cs" Inherits="vista_usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <p>
            hola bienvenido , estos son tus modulos :</p>
        <p>
            <asp:Button ID="B_cambiar" runat="server" OnClick="B_cambiar_Click" Text="Cambiar mis datos" Width="358px" />
        </p>
        <p>
            <asp:Button ID="B_caninos" runat="server" OnClick="B_caninos_Click" Text="Ver caninos" Width="358px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
</asp:Content>