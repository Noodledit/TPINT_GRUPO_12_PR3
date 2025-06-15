<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="ClinicaMedica.RegistrarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Clinica Medica</title>
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <header class="auto-style1">
            <h1>Clinica Medica 🏥</h1>
            <nav class="Navegador">
                <asp:HyperLink CssClass="HyperLink" ID="hlListadoTurnos" runat="server" NavigateUrl="~/ListadoTurnos.aspx" Style="color: #7A859D;">Listado de turnos </asp:HyperLink>
                &nbsp;&nbsp;
                <asp:HyperLink CssClass="HyperLink" ID="hlAsignacionTurnos" runat="server" NavigateUrl="~/AsignacionTurnos.aspx" Style="color: #7A859D;">Asignacion de Turnos</asp:HyperLink>
            </nav>
        </header>
        <main>
            <section class="form-container auto-style2">
                <asp:Label ID="lblTituloNuevoPaciente" runat="server" Font-Bold="True" Font-Size="24pt" Font-Underline="True" 
                    style="margin-bottom: 30px;" Text="Nuevo Paciente" ForeColor="White"></asp:Label>
                <div class="form-row">
                    <div class="form-col" style="display:inline;">
                        <div class="form-group">
                            <label class="form-label" for="txtNombre">Nombre:</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="auto-style3" placeholder="Claudio"></asp:TextBox>

                            <label class="form-label" for="txtApellido">Apellido:</label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="auto-style3" placeholder="Fernandez"></asp:TextBox>

                            <label class="form-label" for="ddlSexo">Sexo:</label>
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="auto-style3">
                                <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                                <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                                <asp:ListItem Text="Otro" Value="O"></asp:ListItem>
                            </asp:DropDownList>

                            <label class="form-label" for="txtNacionalidad">Nacionalidad:</label>
                            <asp:TextBox ID="txtNacionalidad" runat="server" CssClass="auto-style3" placeholder="Argentina"></asp:TextBox>

                            <label class="form-label" for="txtFechaNacimiento">Fecha de nacimiento:</label>
                            <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="auto-style3" placeholder="1/1/1992"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-col" style="display:inline;">
                            <label class="form-label" for="txtDireccion">Direccion:</label>
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="auto-style3" placeholder="Hipólito Yrigoyen 288"></asp:TextBox>

                            <label class="form-label" for="txtProvincia">Provincia:</label>
                            <asp:DropDownList ID="ddlProvincias" runat="server" CssClass="auto-style3">
                                <asp:ListItem Text="Seleccione Provincia" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Provincia 1" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Provincia 2" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Provincia 3" Value="3"></asp:ListItem>
                            </asp:DropDownList>

                            <label class="form-label" for="txtLocalidad">Localidad:</label>
                            <asp:DropDownList ID="ddlLocalidades" runat="server" CssClass="auto-style3">
                                <asp:ListItem Text="Seleccione Localidad" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Localidad 1" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Localidad 2" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Localidad 3" Value="3"></asp:ListItem>
                            </asp:DropDownList>

                            <label class="form-label" for="txtCorreo">Correo electrónico:</label>
                            <asp:TextBox ID="txtCorreo" runat="server" CssClass="auto-style3" placeholder="ejemplo@correo.com" TextMode="Email"></asp:TextBox>

                            <label class="form-label" for="txtTelefono">Numero de telefono:</label>
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="auto-style3" placeholder="1512345678" TextMode="Phone"></asp:TextBox>
                    </div>
                </div>
            </section>
        </main>
        <footer>
        </footer>
    </form>
</body>
</html>