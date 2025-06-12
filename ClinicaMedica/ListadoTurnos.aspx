<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoTurnos.aspx.cs" Inherits="ClinicaMedica.ListadoTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20%;
        }
        .auto-style2 {
            width: 80%;
        }
    </style>
    </head>
<body style="margin: 0; background-color: #f8f9fa;">
    <form id="form1" runat="server">
        <header style="
            background: linear-gradient(90deg, #2a9df4, #38b000);
            color: white;
            height: 100px; 
            border-radius: 0 0 10% 10%;
            padding: 20px 40px;
            box-shadow: 0 4px 10px rgba(0,0,0,0.1);
            justify-content: space-between;" 
            align-items: center;

            class="auto-style1">
            <section>
            <asp:Button ID="btnUn_Login" runat="server" Style="float: right; margin-right: 10px;" Text="Ingresar" OnClick="btnUn_Login_Click" />
            <asp:Label ID="lblBienvenidoUsuario" Style="float: right; margin-right: 10px;" runat="server"></asp:Label>
            <asp:TextBox ID="txtContrasenia" runat="server" Style="float: right; margin-right: 1px;" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblContrasenia" runat="server" Style="float: right; margin-right: 1px;" Text="Contraseña:"></asp:Label>
            <asp:TextBox ID="txtUsuario" Style="float: right; margin-right: 10px;" runat="server"></asp:TextBox>
            <asp:Label ID="lblNombreUsuario" runat="server" Style="float: right; margin-right: 1px;" Text="Nombre de usuario:"></asp:Label>
            </section>
            <h1>Clinica Medica 🏥</h1>
            <nav style="align-content: end; justify-content: end;">
                <asp:HyperLink ID="hlListadoTurnos" runat="server">Listado de turnos </asp:HyperLink>
                <asp:HyperLink ID="hlAsignacionTurnos" runat="server">Asignacion de Turnos</asp:HyperLink>
    </nav>
        </header>
        <main>
            <section style="background: Cyan; margin: 10% auto; " class="auto-style2">
                <div>
                <asp:Label ID="lblTituloTurnosAsignados" runat="server" Font-Bold="True" Font-Size="24pt" Font-Underline="True" style="margin-left: 3%; padding-bottom: 6%;" Text="Turnos Asignados"></asp:Label>
                </div>
                <div style="margin: 25px 10px 5px 20px;">
                    Ingrese DNI:
                <asp:TextBox ID="txtBuscador" runat="server" style="margin-bottom: 3%"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" style="margin-left:10px; margin-bottom: 2%" Text="Consultar Turno" />
                </div>
                <div style="margin: 5px 10px 15px 20px;">
                            <asp:DropDownList ID="ddlFechas" runat="server"></asp:DropDownList>
                            <asp:Button Style="margin-left:10px;" ID="btnFiltroFecha" runat="server" Text="Consultar por Fecha" />
                </div>
                <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" Width="353px"> 
                    <Columns>
                        <asp:TemplateField HeaderText="Doctor(a)"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Sitio de Consulta"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado de Turno"></asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </section>            
        </main>
        <footer>


        </footer>
    </form>
</body>
</html>
