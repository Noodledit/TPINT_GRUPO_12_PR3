﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsignacionTurnos.aspx.cs" Inherits="ClinicaMedica.AsignacionTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asignación de Turnos</title>
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
                    <asp:HyperLink ID="hlAgregarMedico" runat="server" CssClass="header-link" NavigateUrl="RegistrarMedico.aspx" Text="Agregar Medico"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link-active" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hListarMedicos" runat="server" CssClass="header-link" NavigateUrl="ListadoDeMedicos.aspx" Text="Listar Medicos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido">
            <div class="solapa">
                Asiganción de Turno
            </div>
            <div class="caja">
                <div style="margin: 15px 10px 20px 20px;">
                    <span style="color: white; font-size: 20px;">DNI paciente:</span>
                    &nbsp;<asp:TextBox ID="txtDni" runat="server" CssClass="txtBox-caja"></asp:TextBox>
                </div>

                <div style="margin: 5px 10px 20px 20px;">
                    <asp:Label ID="lblDatos" runat="server" Text="Datos" Font-Size="20px" ForeColor="White" Font-Underline="True"></asp:Label>
                </div>

                <div style="margin: 15px 10px 20px 20px;" id="ddlEspecialidad">
                    <span style="color: white; font-size: 20px;">Especialidad:</span>
                    <asp:DropDownList ID="ddlEspecialidades" autopostback="true" runat="server" CssClass="txtBox-caja" OnSelectedIndexChanged="ddlEspecilidad_SelectedIndexChanged" >
                    </asp:DropDownList>
                    <br />
                    <span style="color: white; font-size: 20px;">Médico:</span>
                    <asp:DropDownList ID="ddlMedicos" autopostback="true" runat="server" CssClass="txtBox-caja" OnSelectedIndexChanged="ddlMedico_SelectedIndexChanged" Enabled="False" ></asp:DropDownList>
                    <br />
                    <span style="color: white; font-size: 20px;">Fecha:</span>
                    <asp:DropDownList ID="ddlFechas" AutoPostBack="true" runat="server" CssClass="txtBox-caja" OnSelectedIndexChanged="ddlFecha_SelectedIndexChanged" Enabled="False" ></asp:DropDownList>
                    <br />
                    <span style="color: white; font-size: 20px;">Hora:</span>
                    <asp:DropDownList ID="ddlHoras" AutoPostBack="true" runat="server" CssClass="txtBox-caja" Enabled="False" ></asp:DropDownList>                    
                </div>
                <div style="margin: 25px 10px 5px 20px;">
                    <asp:Button ID="btnAsignarTurno" runat="server" CssClass="button" Text="Asignar Turno" Width="210px" Height="40" OnClick="btnAsignarTurno_Click" />

                    <asp:Panel ID="pnlConfirmacion" runat="server" Visible="false" CssClass="panel-confirmacion" style="margin-top:15px;">
                        <asp:Label ID="lblConfirmacion" runat="server" Text="¿Está seguro de que desea asignar este turno?" />
                        <br />
                        <br />
                        <asp:Button ID="btnConfirmar" runat="server" Text="Sí" OnClick="btnConfirmar_Click" CssClass="button" />
                        <asp:Button ID="btnCancelar" runat="server" Text="No" OnClick="btnCancelar_Click" CssClass="button" />
                        <br />
                    </asp:Panel>

                    <asp:Label ID="lblMensaje" runat="server" Visible="False" Font-Bold="True" ForeColor="#94FF6C"></asp:Label>
                </div>


            </div>
        </div>
    </form>
</body>
</html>
