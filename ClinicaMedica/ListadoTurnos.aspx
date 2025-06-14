﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoTurnos.aspx.cs" Inherits="ClinicaMedica.ListadoTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Clinica Medica</title>
    <style type="text/css">
    </style>
    </head>
<body style="margin: 0; background-color: #BDC4D4;">
    <form id="form1" runat="server">
        <div class="header">
            <section>
                <asp:Button ID="btnUn_Login" runat="server" Style="float: right; margin-right: 10px;" Text="Ingresar" CssClass="boton-hover"/>
                <asp:Label ID="lblBienvenidoUsuario" Style="float: right; margin-right: 10px;" runat="server"></asp:Label>
                <asp:TextBox ID="txtContrasenia" runat="server" Style="float: right; margin-right: 1px;" TextMode="Password"></asp:TextBox>
                <asp:Label ID="lblContrasenia" runat="server" Style="float: right; margin-right: 1px;" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="txtUsuario" Style="float: right; margin-right: 10px;" runat="server"></asp:TextBox>
                <asp:Label ID="lblNombreUsuario" runat="server" Style="float: right; margin-right: 1px;" Text="Nombre de usuario:"></asp:Label>
            </section>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica"/>
                <div class="header-links">
                    <asp:HyperLink ID="hlInicio" runat="server" CssClass="header-link" NavigateUrl="#" Text="Inicio"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarPaciente" runat="server" CssClass="header-link" NavigateUrl="#" Text="Agregar Paciente"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="#" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="#" Text="Listar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="#" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
            <div class="contenido" style="display: flex; flex-direction: column; align-items: center; gap: 20px;">
                <div class="caja" style="width: 250px; height: 50px; text-align: center; align-items: center; justify-content: center; font-size: 20px; font-weight: bolder; color: white;">
                    Turnos Asignados
                </div>
                <div class="caja">
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
                </div>
            </div>
    </form>
</body>
</html>
