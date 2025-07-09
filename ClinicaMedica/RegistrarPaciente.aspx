<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="ClinicaMedica.RegistrarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Paciente</title>
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <section>
                <asp:Button ID="btnUnlogin" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Cerrar Sesion" CssClass="button" ValidationGroup="GrupoInicioSesion" OnClick="btnUnlogin_Click" />
                <asp:Label ID="lblBienvenidoUsuario" runat="server" Style="float: right; margin-right: 10px;" Font-Bold="True"></asp:Label>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica"/>
                <div class="header-links">
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="ListadoTurnos.aspx" Text="Listado de Turnos"></asp:HyperLink>
                    
                    <asp:HyperLink ID="hlAgregarMedico" runat="server" CssClass="header-link" NavigateUrl="RegistrarMedico.aspx" Text="Agregar Medico"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                     <asp:HyperLink ID="hListarMedicos" runat="server" CssClass="header-link" NavigateUrl="ListadoDeMedicos.aspx" Text="Listar Medicos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido">
            <div class="solapa">
                Agregar Nuevo Paciente
            </div>
            <div class="caja">
                <div class="form-row">
                    <div class="form-col" style="display:inline;">
                        <div class="form-group">
                            <label class="form-label" for="txtNombre">Nombre:</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="txtBox-caja" placeholder="Claudio"></asp:TextBox>

                            <label class="form-label" for="txtApellido">Apellido:</label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="txtBox-caja" placeholder="Fernandez"></asp:TextBox>

                            <label class="form-label" for="ddlSexo">Sexo:</label>
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="txtBox-caja">
                                <asp:ListItem Text="Seleccione Sexo"></asp:ListItem>
                                <asp:ListItem Text="Masculino" Value="Masculino"></asp:ListItem>
                                <asp:ListItem Text="Femenino" Value="Femenino"></asp:ListItem>
                                <asp:ListItem Text="Otro" Value="Otro"></asp:ListItem>
                            </asp:DropDownList>

                            <label class="form-label" for="txtNacionalidad">Nacionalidad:</label>
                            <asp:TextBox ID="txtNacionalidad" runat="server" CssClass="txtBox-caja" placeholder="Argentina"></asp:TextBox>

                            <label class="form-label" for="txtFechaNacimiento">Fecha de nacimiento:</label>
                            <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="txtBox-caja" placeholder="1992/1/1" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-col" style="display:inline;">
                        <label class="form-label" for="txtDireccion">Direccion:</label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="txtBox-caja" placeholder="Hipólito Yrigoyen 288"></asp:TextBox>

                        <label class="form-label">Provincia:</label>
                        <asp:DropDownList ID="ddlProvincias" AutoPostBack="true" OnSelectedIndexChanged="ddlProvincias_OnSelectedIndexChanged" runat="server" CssClass="txtBox-caja"></asp:DropDownList>

                        <label class="form-label">Localidad:</label>
                        <asp:DropDownList ID="ddlLocalidades" runat="server" CssClass="txtBox-caja" ></asp:DropDownList>

                        <label class="form-label" for="txtCorreo">Correo electrónico:</label>
                        <asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="txtBox-caja" placeholder="ejemplo@correo.com" TextMode="Email"></asp:TextBox>

                        <label class="form-label" for="txtTelefono">Numero de telefono:</label>
                        <asp:TextBox ID="txtNumeroTelefono" runat="server" CssClass="txtBox-caja" placeholder="1512345678" TextMode="Phone"></asp:TextBox>
                    </div>
                    <br />
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="White" ></asp:Label>
                </div>
                <!-- Botones de acción -->
                <div class="form-actions">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn-aceptar" OnClick="btnAceptar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn-cancelar" OnClick="btnCancelar_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

