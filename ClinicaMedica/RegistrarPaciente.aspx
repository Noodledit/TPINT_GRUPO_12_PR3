﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="ClinicaMedica.RegistrarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Paciente</title>
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <section style="display: flex; justify-content: flex-end; padding: 10px;">
                <asp:Menu ID="MenuUsuario" runat="server" CssClass="menu-derecha"
                    Orientation="Horizontal"
                    StaticDisplayLevels="1"
                    DynamicHorizontalOffset="0"
                    Font-Names="Verdana" Font-Size="0.8em"
                    ForeColor="#7C6F57"
                    BackColor="#F7F6F3"
                    StaticSubMenuIndent="10px">
                    <Items>
                        <asp:MenuItem Text="Menú" Value="cuenta">
                            <asp:MenuItem Text="Cambiar contraseña" NavigateUrl="~/CambiarContraseña.aspx" />
                            <asp:MenuItem Text="Cerrar sesión" Value="cerrarSesion" />
                        </asp:MenuItem>
                    </Items>

                    <StaticMenuItemStyle HorizontalPadding="10px" VerticalPadding="5px" />
                    <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                    <DynamicMenuStyle BackColor="#F7F6F3" />
                    <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="10px" VerticalPadding="5px" />
                </asp:Menu>
                <asp:Label ID="lblBienvenidoUsuario" runat="server" Style="float: right; margin-right: 10px;" Font-Bold="True"></asp:Label>
                <asp:ImageButton ID="btnUserImg" runat="server" ImageUrl="Estilo/user.png" CssClass="user-image" Visible="False" Style="transform: translateY(-3px); margin-left: 2px" />
            </section>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica" />
                <div class="header-links">
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="ListadoTurnos.aspx" Text="Listado de Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlCrearCuentaAdmin" runat="server" CssClass="header-link" NavigateUrl="~/CreacionCuentaAdmin.aspx" Text="Crear Cuenta Admin"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link-active" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="HlListarPacientes" runat="server" CssClass="header-link" NavigateUrl="ListadoPacientes.aspx" Text="Listar Pacientes"></asp:HyperLink>
                    <asp:HyperLink ID="hlListarMedicos" runat="server" CssClass="header-link" NavigateUrl="ListadoDeMedicos.aspx" Text="Listar Medicos"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarMedico" runat="server" CssClass="header-link" NavigateUrl="RegistrarMedico.aspx" Text="Agregar Medico"></asp:HyperLink>
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
                    <div class="form-col" style="display: inline;">
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
                    <div class="form-col" style="display: inline;">
                        <label class="form-label" for="txtDireccion">Direccion:</label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="txtBox-caja" placeholder="Hipólito Yrigoyen 288"></asp:TextBox>

                        <label class="form-label">Provincia:</label>
                        <asp:DropDownList ID="ddlProvincias" AutoPostBack="true" OnSelectedIndexChanged="ddlProvincias_OnSelectedIndexChanged" runat="server" CssClass="txtBox-caja"></asp:DropDownList>

                        <label class="form-label">Localidad:</label>
                        <asp:DropDownList ID="ddlLocalidades" runat="server" CssClass="txtBox-caja"></asp:DropDownList>

                        <label class="form-label" for="txtCorreo">Correo electrónico:</label>
                        <asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="txtBox-caja" placeholder="ejemplo@correo.com" TextMode="Email"></asp:TextBox>

                        <label class="form-label" for="txtTelefono">Numero de telefono:</label>
                        <asp:TextBox ID="txtNumeroTelefono" runat="server" CssClass="txtBox-caja" placeholder="1512345678" TextMode="Phone"></asp:TextBox>
                    </div>
                    <br />
                </div>
                <!-- Botones de acción -->
                <div class="form-actions" aria-atomic="False">
                    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True"></asp:Label>
                    <br />
                    <asp:Label ID="lbl2doMensaje" runat="server" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn-aceptar" OnClick="btnAceptar_Click" Visible="False" />
                    <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btn-aceptar" OnClick="btnConfirmar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn-cancelar" OnClick="btnCancelar_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

