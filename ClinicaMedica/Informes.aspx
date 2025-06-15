<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informes.aspx.cs" Inherits="ClinicaMedica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
</head>
<body>
    <form id="form2" runat="server">
    <div id="form1" runat="server">
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
        <div class="contenido">
            <div class="caja">

            </div>
            <div class="caja" style="height: 400px" >

            </div>
            <div class="caja">

            </div>
        </div>
    </div>
    </form>
</body>
</html>
