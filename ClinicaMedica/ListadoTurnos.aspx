<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoTurnos.aspx.cs" Inherits="ClinicaMedica.ListadoTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Clinica Medica</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <section>
                <asp:Button ID="btnUn_Login" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Ingresar" CssClass="button" />
                <asp:Label ID="lblBienvenidoUsuario" runat="server" Style="float: right; margin-right: 10px;"></asp:Label>
                <asp:TextBox ID="txtContrasenia" runat="server" CssClass="txtBox-login" Style="float: right; margin-right: 10px; height: 20px;" TextMode="Password"></asp:TextBox>
                <asp:Label ID="lblContrasenia" runat="server" Style="float: right; margin-right: 2px; font-size: 15px;" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="txtBox-login" Style="float: right; margin-right: 10px; height: 20px;"></asp:TextBox>
                <asp:Label ID="lblNombreUsuario" runat="server" Style="float: right; margin-right: 4px; font-size: 15px;" Text="Nombre de usuario:"></asp:Label>
            </section>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica" />
                <div class="header-links">
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="ListadoTurnos.aspx" Text="Listado de Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarPaciente" runat="server" CssClass="header-link" NavigateUrl="RegistrarPaciente.aspx" Text="Agregar Paciente"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarMedico" runat="server" CssClass="header-link" NavigateUrl="RegistrarMedico.aspx" Text="Agregar Medico"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hListarMedicos" runat="server" CssClass="header-link" NavigateUrl="ListadoDeMedicos.aspx" Text="Listar Medicos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido">
            <div class="solapa">
                Turnos Asignados
            </div>
            <div class="caja">
                <div style="display: flex; align-items: center; gap: 20px;">
                    <asp:Button ID="btnBuscar" runat="server"  Text="Consultar Turno" CssClass="button" Width="210px" Height="40" />
                    <asp:TextBox ID="txtBuscador" runat="server" placeholder="Ingrese Dni" CssClass="txtBox-caja" Style=" margin-top: 18px;"> </asp:TextBox>
                </div>
                <div style="display: flex; align-items: center; gap: 20px;">
                    <asp:Button ID="btnFiltroFecha" runat="server" Text="Consultar por Fecha" CssClass="button" Width="210px" Height="40" />
                    <asp:DropDownList ID="ddlFechas" runat="server" CssClass="txtBox-caja" Style=" margin-top: 18px;"></asp:DropDownList>
                </div>
                <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" Width="658px">
                    <Columns>
                        <asp:TemplateField HeaderText=" Numero de turno">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_it_NumeroTurno" runat="server" Text='<%# Bind("NumeroTurno") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Especialidad">
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Doctor(a)">
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Contacto del Medico">
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Fecha">
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Horario">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Paciente">
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <table class="auto-style3">
                    <tr>
                        <td class="auto-style5">
                            <asp:Button ID="btnMostrarTodo" runat="server" Text="Mostrar Todo" CssClass="button" />
                        </td>
                        <td class="auto-style4">
                            <asp:Button ID="btnConsultarEstado" runat="server" Text="Consultar por Estado" Width="141px" CssClass="button" />
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlEstados" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
