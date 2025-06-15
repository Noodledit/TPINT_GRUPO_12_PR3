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
<body style="margin: 0; background-color: #BDC4D4;">
    <style>
    .boton-hover {
        transition: transform 0.3s ease, box-shadow 0.3s ease;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.2);
        border-radius: 6px;
    }

    .boton-hover:hover {
        transform: scale(1.03);
        box-shadow: 0 6px 15px rgba(0, 0, 0, 0.2);
        cursor: pointer;
    }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            width: 152px;
        }
        .auto-style5 {
            width: 1171px;
        }
    </style>

    <form id="form1" runat="server">
        <header style="
            background: linear-gradient(90deg, #2B3D5B, #15253F);
            color: white;
            height: 100px; 
            border-radius: 20px;
            ///border-radius: 0 0 10,6% 10%;
            padding: 20px 40px;
            box-shadow: 0 4px 10px rgba(0,0,0,0.1);
            justify-content: space-between;" 
            align-items: center;

            class="auto-style1">
            <section>
            <asp:Button ID="btnUn_Login" runat="server" Style="float: right; margin-right: 10px;" Text="Ingresar" OnClick="btnUn_Login_Click" CssClass="boton-hover"/>
            <asp:Label ID="lblBienvenidoUsuario" Style="float: right; margin-right: 10px;" runat="server"></asp:Label>
            <asp:TextBox ID="txtContrasenia" runat="server" Style="float: right; margin-right: 1px;" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblContrasenia" runat="server" Style="float: right; margin-right: 1px;" Text="Contraseña:"></asp:Label>
            <asp:TextBox ID="txtUsuario" Style="float: right; margin-right: 10px;" runat="server"></asp:TextBox>
            <asp:Label ID="lblNombreUsuario" runat="server" Style="float: right; margin-right: 1px;" Text="Nombre de usuario:"></asp:Label>
            </section>
            <h1>Clinica Medica 🏥</h1>
            <nav style="align-content: end; justify-content: end;">
                <asp:HyperLink ID="hlListadoTurnos" runat="server">Listado de turnos </asp:HyperLink>
                &nbsp;&nbsp;
                <asp:HyperLink ID="hlAsignacionTurnos" runat="server" NavigateUrl="~/AsignacionTurnos.aspx" Style="color: #7A859D;">Asignacion de Turnos</asp:HyperLink>
    </nav>
        </header>
        <main>
           <section style="
    background: #7A859D;
    margin: 10% auto;
    border-radius: 20px;
    padding: 20px;
    box-shadow: 0 8px 20px rgba(0, 0, 0, 0.5);
   // border: 2px solid #5c6a82;" 
    class="auto-style2">
                <div>
                    <br />
                <asp:Label ID="lblTituloTurnosAsignados" runat="server" Font-Bold="True" Font-Size="24pt" Font-Underline="True" style="margin-left: 3%; padding-bottom: 6%;" Text="Turnos Asignados" ForeColor="White"></asp:Label>
                </div>
                <div style="margin: 25px 10px 5px 20px;">
                <asp:Button ID="btnBuscar" runat="server" style="margin-left:10px; margin-bottom: 2%" Text="Consultar Turno" CssClass="boton-hover" />
                <asp:TextBox ID="txtBuscador" runat="server" style="margin-bottom: 3%">Ingrese DNI: </asp:TextBox>
                </div>
                <div style="margin: 5px 10px 15px 20px;">
                            <asp:Button Style="margin-left:10px;" ID="btnFiltroFecha" runat="server" Text="Consultar por Fecha" CssClass="boton-hover" Width="144px"/>
                            <asp:DropDownList ID="ddlFechas" runat="server" Height="17px"></asp:DropDownList>
                </div>
                <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" Width="658px"> 
                    <Columns>
                        <asp:TemplateField HeaderText="Doctor(a)"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Sitio de Consulta"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado de Turno"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Paciente"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Contacto del Medico"></asp:TemplateField>
                        <asp:TemplateField HeaderText="Opciones"></asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style5">
                            <asp:Button ID="btnMostrarTodo" runat="server" Text="Mostrar Todo" />
                        </td>
                        <td class="auto-style4">
                            <asp:Button ID="btnConsultarEstado" runat="server" Text="Consultar por Estado" Width="141px" />
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <br />
            </section>            
        </main>
        <footer>


        </footer>
    </form>
</body>
</html>
