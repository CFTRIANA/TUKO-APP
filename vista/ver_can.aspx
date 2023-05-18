<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/controler/ver_can.aspx.cs" Inherits="vista_ver_can" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Aqui puedes vizualizar los datos basicos de los perritos de la fundacion ( proximamente con fotos)<br />
        </div>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" DataSourceID="tabla_caninos_lista" Height="214px" DataKeyNames="Id_Can" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="1189px">
    <Columns>
        <asp:BoundField DataField="Id_Can" HeaderText="Id_Can" SortExpression="Id_Can" InsertVisible="False" ReadOnly="True" />
        <asp:BoundField DataField="Nom_Can" HeaderText="Nom_Can" SortExpression="Nom_Can" />
        <asp:BoundField DataField="Vacu_Can" HeaderText="Vacu_Can" SortExpression="Vacu_Can" />
        <asp:BoundField DataField="Eda_Can" HeaderText="Eda_Can" SortExpression="Eda_Can" />
        <asp:BoundField DataField="Desc_Can" HeaderText="Desc_Can" SortExpression="Desc_Can" />
        <asp:BoundField DataField="Estd_Can" HeaderText="Estd_Can" SortExpression="Estd_Can" />
        <asp:BoundField DataField="Id_Raz_Can" HeaderText="Id_Raz_Can" SortExpression="Id_Raz_Can" />
    </Columns>
</asp:GridView>
        <asp:SqlDataSource ID="tabla_caninos_lista" runat="server" ConnectionString="<%$ ConnectionStrings:TEST %>" SelectCommand="SELECT [Id_Can], [Nom_Can], [Vacu_Can], [Eda_Can], [Desc_Can], [Estd_Can], [Id_Raz_Can] FROM [CANINO] ORDER BY [Id_Can]"></asp:SqlDataSource>
        <p>
            si viste un perrito que te gusto , no dudes en apadrinarlo ...</p>
        <p>
        <asp:Button ID="B_volver" runat="server" OnClick="Button1_Click" Text="Volver " Height="54px" Width="403px" />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="51px" OnClick="Button1_Click1" Text="Apadrinar" Width="380px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
