<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoTurnos.aspx.cs" Inherits="ClinicaMedica.ListadoTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
    </form>
</body>
</html>
