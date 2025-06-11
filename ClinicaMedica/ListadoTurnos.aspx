<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoTurnos.aspx.cs" Inherits="ClinicaMedica.ListadoTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 254px;
        }
        .auto-style3 {
            width: 260px;
        }
        .auto-style4 {
            width: 254px;
            height: 23px;
        }
        .auto-style5 {
            width: 260px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnUn_Login" runat="server" Style="float: right; margin-top: 10px; margin-right: 10px;" Text="Ingresar" OnClick="btnUn_Login_Click" />
        <asp:Label ID="lblBienvenidoUsuario" Style="float: right; margin-top: 10px; margin-right: 10px;" runat="server"></asp:Label>
        <asp:TextBox ID="txtContrasenia" runat="server" Style="float: right; margin-top: 10px; margin-right: 1px;" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblContrasenia" runat="server" Style="float: right; margin-top: 10px; margin-right: 1px;" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="txtUsuario" Style="float: right; margin-top: 10px; margin-right: 10px;" runat="server"></asp:TextBox>
        <asp:Label ID="lblNombreUsuario" runat="server" Style="float: right; margin-top: 10px; margin-right: 1px;" Text="Nombre de usuario:"></asp:Label>
        <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvTurnos_SelectedIndexChanged" Width="254px">
            <Columns>
                <asp:TemplateField HeaderText="Doctor(a)"></asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha"></asp:TemplateField>
                <asp:TemplateField HeaderText="Sitio de Consulta"></asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:TextBox ID="txtBuscador" runat="server" style="margin-bottom: 0px">Ingrese Dni</asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Consultar Turno" />
    </form>
</body>
</html>
