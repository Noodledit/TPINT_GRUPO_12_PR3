<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="ClinicaMedica.RegistrarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="ListadoTurnos.aspx" Text="Mis Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarPaciente" runat="server" CssClass="header-link" NavigateUrl="RegistrarPaciente.aspx" Text="Agregar Paciente"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido" style="display: flex; flex-direction: column; align-items: center; gap: 20px;">
            <div class="caja" style="width: 250px; height: 50px; text-align: center; align-items: center; justify-content: center; font-size: 20px; font-weight: bolder; color: white;">
                Agregar Nuevo Paciente
            </div>
            <div class="caja">
<div class="form-row">
    <div class="form-col" style="display:inline;">
        <div class="form-group">
            <label class="form-label" for="txtNombre">Nombre:</label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" placeholder="Claudio"></asp:TextBox>

            <label class="form-label" for="txtApellido">Apellido:</label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3" placeholder="Fernandez"></asp:TextBox>

            <label class="form-label" for="ddlSexo">Sexo:</label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style3">
                <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                <asp:ListItem Text="Otro" Value="O"></asp:ListItem>
            </asp:DropDownList>

            <label class="form-label" for="txtNacionalidad">Nacionalidad:</label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style3" placeholder="Argentina"></asp:TextBox>

            <label class="form-label" for="txtFechaNacimiento">Fecha de nacimiento:</label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style3" placeholder="1/1/1992"></asp:TextBox>
        </div>
    </div>
    <div class="form-col" style="display:inline;">
            <label class="form-label" for="txtDireccion">Direccion:</label>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style3" placeholder="Hipólito Yrigoyen 288"></asp:TextBox>

            <label class="form-label" for="txtProvincia">Provincia:</label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style3">
                <asp:ListItem Text="Seleccione Provincia" Value="0"></asp:ListItem>
                <asp:ListItem Text="Provincia 1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Provincia 2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Provincia 3" Value="3"></asp:ListItem>
            </asp:DropDownList>

            <label class="form-label" for="txtLocalidad">Localidad:</label>
            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="auto-style3">
                <asp:ListItem Text="Seleccione Localidad" Value="0"></asp:ListItem>
                <asp:ListItem Text="Localidad 1" Value="1"></asp:ListItem>
                <asp:ListItem Text="Localidad 2" Value="2"></asp:ListItem>
                <asp:ListItem Text="Localidad 3" Value="3"></asp:ListItem>
            </asp:DropDownList>

            <label class="form-label" for="txtCorreo">Correo electrónico:</label>
            <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style3" placeholder="ejemplo@correo.com" TextMode="Email"></asp:TextBox>

            <label class="form-label" for="txtTelefono">Numero de telefono:</label>
            <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style3" placeholder="1512345678" TextMode="Phone"></asp:TextBox>
    </div>
</div>
                </div>
            </div>
        </form>
    </body>
</html>
