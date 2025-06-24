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
                <img src="Estilo/user.png" class="user-image"/>
                <asp:Label ID="lblBienvenidoUsuario" runat="server" Style="float: right; font-size:15px ; margin-right: 8px; letter-spacing: 2px; font-weight: bold; transform: translateY(+5px);" Text="Peter Lanzani"></asp:Label>
            </section>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica"/>
                <div class="header-links">
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="ListadoTurnos.aspx" Text="Listado de Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarPaciente" runat="server" CssClass="header-link-active" NavigateUrl="RegistrarPaciente.aspx" Text="Agregar Paciente"></asp:HyperLink>
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

                            &nbsp;<asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" ForeColor="Red">Debe ingresar nombre</asp:RequiredFieldValidator>

                            <label class="form-label" for="txtApellido">Apellido:</label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="txtBox-caja" placeholder="Fernandez"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtNombre" ForeColor="Red">Debe ingresar apellido</asp:RequiredFieldValidator>

                            <label class="form-label" for="ddlSexo">Sexo:</label>
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="txtBox-caja">
                                <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                                <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                                <asp:ListItem Text="Otro" Value="O"></asp:ListItem>
                            </asp:DropDownList>

                            <label class="form-label" for="txtNacionalidad">Nacionalidad:</label>
                            <asp:TextBox ID="txtNacionalidad" runat="server" CssClass="txtBox-caja" placeholder="Argentina"></asp:TextBox>

                            <asp:RequiredFieldValidator ID="rfvNombrePaciente" runat="server" ControlToValidate="txtNombre" ForeColor="Red">Ingrese una nacionalidad</asp:RequiredFieldValidator>

                            <label class="form-label" for="txtFechaNacimiento">Fecha de nacimiento:</label>
                            <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="txtBox-caja" placeholder="1/1/1992"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvApellidoPaciente" runat="server" ControlToValidate="txtApellido" ForeColor="Red">Ingrese una fecha</asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-col" style="display:inline;">
                        <label class="form-label" for="txtDireccion">Direccion:</label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="txtBox-caja" placeholder="Hipólito Yrigoyen 288"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="rfvDireccionPaciente" runat="server" ControlToValidate="txtDireccion" ForeColor="Red">Ingrese una dirección</asp:RequiredFieldValidator>

                        <label class="form-label" for="txtProvincia">Provincia:</label>
                        <asp:DropDownList ID="ddlProvincia" runat="server" CssClass="txtBox-caja">
                            <asp:ListItem Text="Seleccione Provincia" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Provincia 1" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Provincia 2" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Provincia 3" Value="3"></asp:ListItem>
                        </asp:DropDownList>

                        <label class="form-label" for="txtLocalidad">Localidad:</label>
                        <asp:DropDownList ID="ddlLocalidad" runat="server" CssClass="txtBox-caja">
                            <asp:ListItem Text="Seleccione Localidad" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Localidad 1" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Localidad 2" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Localidad 3" Value="3"></asp:ListItem>
                        </asp:DropDownList>

                        <label class="form-label" for="txtCorreo">Correo electrónico:</label>
                        <asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="txtBox-caja" placeholder="ejemplo@correo.com" TextMode="Email"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="rfvCorreoPaciente" runat="server" ControlToValidate="txtCorreoElectronico" ForeColor="Red">Ingrese un correo</asp:RequiredFieldValidator>

                        <label class="form-label" for="txtTelefono">Numero de telefono:</label>
                        <asp:TextBox ID="txtNumeroTelefono" runat="server" CssClass="txtBox-caja" placeholder="1512345678" TextMode="Phone"></asp:TextBox>
                    </div>
                </div>
                <!-- Botones de acción -->
                <div class="form-actions">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn-aceptar" OnClick="btnAceptar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn-cancelar" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

