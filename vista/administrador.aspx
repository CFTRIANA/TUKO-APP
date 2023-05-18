<%@ Page Title="" Language="C#" MasterPageFile="~/vista/MasterPage.master" AutoEventWireup="true" CodeFile="~/controler/administrador.aspx.cs" Inherits="vista_administrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="height: 363px; margin-top: 0px">
     
        tus modulos activos son los siguientes :<br />
        <asp:Button ID="Re_registrocan" runat="server" OnClick="Button1_Click" Text="Registrar Canino" Width="923px" />
        <asp:Button ID="Re_modif" runat="server" Text="Modificar Rol de Usuario" Width="922px" OnClick="Re_modif_Click" />
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Cambiar Datos Canino" Width="917px" OnClick="Button1_Click1" />
        <br />
        <br />
     
    </div>
  
    
         
</asp:Content>
