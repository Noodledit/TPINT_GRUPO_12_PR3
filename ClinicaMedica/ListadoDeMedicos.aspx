﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoDeMedicos.aspx.cs" Inherits="ClinicaMedica.ListadoDeMedicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listado de Medicos</title>
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
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hListarMedicos" runat="server" CssClass="header-link-active" NavigateUrl="ListadoDeMedicos.aspx" Text="Listar Medicos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido">
            <div class="solapa">
                Listado de Medicos
            </div>
            <div class="caja">
                <div style="display: flex; align-items: center; gap: 20px;">
                    <asp:Button ID="btnBuscarMeds" runat="server" CssClass="button" Text="Buscar Médicos" Width="210" Height="40" OnClick="btnBuscarMeds_Click" />
                    <asp:TextBox ID="txtBuscadorMeds" runat="server" CssClass="txtBox-caja" placeholder="Ingrese Legajo" Style=" margin-top: 18px;"></asp:TextBox>
                    <asp:TextBox ID="txtBuscadorNombre" runat="server" CssClass="txtBox-caja" placeholder="Ingrese Nombre" Style=" margin-top: 18px;"></asp:TextBox>
                    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>

                </div>
                <div style="display: flex; align-items: center; gap: 20px;">
                    <asp:Button ID="btnFiltrarEspecialidad" runat="server" CssClass="button" Text="Filtrar por Especialidad" Width="210" Height="40" OnClick="btnFiltrarEspecialidad_Click" />
                    <asp:DropDownList ID="ddlEspecialidades" runat="server" CssClass="txtBox-caja" Style="margin-top: 18px;">
                    </asp:DropDownList>
                </div>

                <asp:GridView ID="gvMedicos" runat="server" AutoGenerateColumns="False" CssClass="tabla-turnos"
                            OnRowCommand="gvMedicos_RowCommand"
                            AllowPaging="True"
                            OnPageIndexChanging="gvMedicos_PageIndexChanging"
                            PageSize="5"
                            OnRowEditing="gvMedicos_RowEditing"
                            OnRowUpdating="gvMedicos_RowUpdating"
                            OnRowCancelingEdit="gvMedicos_RowCancelingEdit">
                            <Columns>
                                <asp:TemplateField HeaderText="Legajo">
                                    <ItemTemplate>
                                        <asp:Label ID="lblLegajo" runat="server" Text='<%# Bind("Legajo") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Nombre">
                                    <ItemTemplate>
                                        <asp:Label ID="lblNombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtNombre" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Apellido">
                                    <ItemTemplate>
                                        <asp:Label ID="lblApellido" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtApellido" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="DNI">
                                    <ItemTemplate>
                                        <asp:Label ID="lblDni" runat="server" Text='<%# Bind("DNI") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Especialidad">
                                    <ItemTemplate>
                                        <asp:Label ID="lblEspecialidad" runat="server" Text='<%# Bind("Especialidad") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Telefono">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTelefono" runat="server" Text='<%# Bind("Telefono") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtTelefono" runat="server" Text='<%# Bind("Telefono") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Correo Electronico">
                                    <ItemTemplate>
                                        <asp:Label ID="lblCorreo" runat="server" Text='<%# Bind("Correo") %>'></asp:Label>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtCorreo" runat="server" Text='<%# Bind("Correo") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Estado">
                                    <ItemTemplate>
                                        <asp:Label ID="lblEstado" runat="server" Text='<%# Bind("Estado") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Dar de Baja">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEliminar" runat="server" CommandName="Eliminar" CommandArgument='<%# Eval("Legajo") %>' 
                                            Text="Eliminar" OnClientClick="return confirm('¿Seguro que desea eliminar el médico?');" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:CommandField ShowEditButton="True" />
                            </Columns>
                        </asp:GridView>
                    <div style="margin: 25px 10px 5px 0px;">
                        <asp:Button ID="btnMostrarTodo" runat="server" CssClass="button" Text="Mostrar Todo" Width="202px" OnClick="btnMostrarTodo_Click" />
                </div>

            </div>
        </div>
    </form>
</body>
</html>

