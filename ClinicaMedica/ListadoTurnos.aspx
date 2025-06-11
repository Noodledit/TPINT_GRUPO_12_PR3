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
            width: 414px;
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
        <p>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Turnos Asignados</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
        <asp:Button ID="btnBuscar" runat="server" Text="Consultar Turno" />
        <asp:TextBox ID="txtBuscador" runat="server" style="margin-bottom: 0px">Ingrese Dni</asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" Text="Consultar por Fecha" />
                        <asp:DropDownList ID="DropDownList1" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
        <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvTurnos_SelectedIndexChanged" Width="353px">
            <Columns>
                <asp:TemplateField HeaderText="Doctor(a)"></asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha"></asp:TemplateField>
                <asp:TemplateField HeaderText="Sitio de Consulta"></asp:TemplateField>
                <asp:TemplateField HeaderText="Estado de Turno"></asp:TemplateField>
            </Columns>
        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
