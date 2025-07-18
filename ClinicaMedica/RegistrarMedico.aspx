﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarMedico.aspx.cs" Inherits="ClinicaMedica.RegistrarMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Médico</title>
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <section>
                <asp:HyperLink ID="hlCambiarContrasenia" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Cambiar contraseña" ValidationGroup="GrupoInicioSesion" Visible="True" ForeColor="White" Font-Underline="True" NavigateUrl="~/CambiarContraseña.aspx" TabIndex="3" />
                <asp:Button ID="btnUnlogin" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Cerrar Sesion" CssClass="button" ValidationGroup="GrupoInicioSesion" OnClick="btnUnlogin_Click" />
                <asp:Label ID="lblBienvenidoUsuario" runat="server" Style="float: right; margin-right: 10px;" Font-Bold="True"></asp:Label>
            </section>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica" />
                <div class="header-links">
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="ListadoTurnos.aspx" Text="Listado de Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlSeguimientoPaciente" runat="server" CssClass="header-link" Text="Seguimiento Paciente" TabIndex="4" NavigateUrl="~/SeguimientosPacientes.aspx"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarMedico" runat="server" CssClass="header-link-active" NavigateUrl="RegistrarMedico.aspx" Text="Agregar Medico"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hListarMedicos" runat="server" CssClass="header-link" NavigateUrl="ListadoDeMedicos.aspx" Text="Listar Medicos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido">
            <div class="solapa">
                Agregar Nuevo Médico
            </div>
            <div class="caja">
                <div class="form-row">
                    <div class="form-col" style="display: inline;">
                        <div class="form-group">
                            <label class="form-label">Nombre:</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="txtBox-caja" placeholder="Claudio"></asp:TextBox>

                            <label class="form-label">Apellido:</label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="txtBox-caja" placeholder="Fernandez"></asp:TextBox>

                            <label class="form-label">Sexo:</label>
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="txtBox-caja">
                                <asp:ListItem Text="Seleccione Sexo"></asp:ListItem>
                                <asp:ListItem Text="Masculino" Value="Masculino"></asp:ListItem>
                                <asp:ListItem Text="Femenino" Value="Femenino"></asp:ListItem>
                                <asp:ListItem Text="Otro" Value="Otro"></asp:ListItem>
                            </asp:DropDownList>

                            <label class="form-label">Nacionalidad:</label>
                            <asp:TextBox ID="txtNacionalidad" runat="server" CssClass="txtBox-caja" placeholder="Argentina"></asp:TextBox>

                            <label class="form-label">Fecha de nacimiento:</label>
                            <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="txtBox-caja" TextMode="Date" placeholder="1/1/1992"></asp:TextBox>

                            <label class="form-label">DNI:</label>
                            <asp:TextBox ID="txtDniMedico" runat="server" CssClass="txtBox-caja" placeholder="12345678" MaxLength="10"></asp:TextBox>

                        </div>
                    </div>
                    <div class="form-col" style="display: inline;">

                        <label class="form-label">Provincia:</label>
                        <asp:DropDownList ID="ddlProvincias" AutoPostBack="true" OnSelectedIndexChanged="ddlProvincias_OnSelectedIndexChanged" runat="server" CssClass="txtBox-caja"></asp:DropDownList>

                        <label class="form-label">Localidad:</label>
                        <asp:DropDownList ID="ddlLocalidades" runat="server" CssClass="txtBox-caja"></asp:DropDownList>

                        <label class="form-label">Direccion:</label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="txtBox-caja" placeholder="Hipólito Yrigoyen 288"></asp:TextBox>

                        <label class="form-label">Correo electrónico:</label>
                        <asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="txtBox-caja" placeholder="ejemplo@correo.com" TextMode="Email"></asp:TextBox>

                        <label class="form-label">Numero de telefono:</label>
                        <asp:TextBox ID="txtNumeroTelefono" runat="server" CssClass="txtBox-caja" placeholder="1512345678" TextMode="Phone"></asp:TextBox>

                        <label class="form-label">Especialidad:</label>
                        <asp:DropDownList ID="ddlEspecialidades" runat="server" CssClass="txtBox-caja"></asp:DropDownList>


                    </div>
                </div>
                <div style="display: flex; flex-direction: column; align-items: center;">
                    <label class="form-label">Numero de legajo:</label>
                    <asp:TextBox ID="txtLegajo" runat="server" CssClass="txtBox-caja" Text="0000" ReadOnly="True" Style="color: white; background: transparent; border-width: 2px;"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblMensaje" runat="server" Style="font-weight: 700; font-size: 15px;" Visible="False"></asp:Label>
                </div>
                <div class="form-actions" style="margin-top: 15px;">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn-aceptar" OnClick="btnAceptar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn-cancelar" OnClick="btnCancelar_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

