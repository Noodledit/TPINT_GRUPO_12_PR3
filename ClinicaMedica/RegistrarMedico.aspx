<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarMedico.aspx.cs" Inherits="ClinicaMedica.RegistrarMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar Médico</title>
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
                    <asp:HyperLink ID="hlAgregarPaciente" runat="server" CssClass="header-link" NavigateUrl="RegistrarPaciente.aspx" Text="Agregar Paciente"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarMedico" runat="server" CssClass="header-link" NavigateUrl="RegistrarMedico.aspx" Text="Agregar Medico"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
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
                    <div class="form-col" style="display:inline;">
                        <div class="form-group">
                            <label class="form-label" for="txtNombre">Nombre:</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="auto-style3" placeholder="Claudio"></asp:TextBox>

                            <label class="form-label" for="txtApellido">Apellido:</label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="auto-style3" placeholder="Fernandez"></asp:TextBox>

                            <label class="form-label" for="ddlSexo">Sexo:</label>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style3">
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

                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

