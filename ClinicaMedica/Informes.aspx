<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informes.aspx.cs" Inherits="ClinicaMedica.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
</head>
<body>
    <form id="form2" runat="server">
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
                    <asp:HyperLink ID="hlAgregarPaciente" runat="server" CssClass="header-link" NavigateUrl="./Informes.aspx" Text="Agregar Paciente"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="#" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="#" Text="Listar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="./Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido">
            <div class="caja-informe">
                <h2 class="titulo-informe">Informe de Asistencia</h2>
                <div style="margin-bottom: 25px; display: flex; align-items: center; justify-content: center;">
                    <asp:Label ID="lblFechaDesde" runat="server" Text="Desde:" CssClass="label-fecha" />
                    <asp:TextBox ID="txtFechaDesde" runat="server" CssClass="input-fecha" TextMode="Date" />
                    <asp:Label ID="lblFechaHasta" runat="server" Text="Hasta:" CssClass="label-fecha" style="margin-left: 20px;" />
                    <asp:TextBox ID="txtFechaHasta" runat="server" CssClass="input-fecha" TextMode="Date" />
                    <asp:Button ID="btnGenerarInforme" runat="server" Text="Generar Informe" CssClass="boton-hover" style="margin-left: 30px;" />
                </div>

            <!-- Estadísticas generales -->
            <div class="caja-informe" style="background: #f1f7ff; margin-bottom: 20px;">
                <h3>Resumen Estadístico</h3>
                Total turnos:<asp:Label ID="lblTotalTurnos" runat="server" CssClass="form-label" />
                Presentes:<asp:Label ID="lblTotalPresentes" runat="server" CssClass="form-label" />
                Ausentes:<asp:Label ID="lblTotalAusentes" runat="server" CssClass="form-label" />
                Presentes:<asp:Label ID="lblPorcentajePresentes" runat="server" CssClass="form-label" />
                Ausentes:<asp:Label ID="lblPorcentajeAusentes" runat="server" CssClass="form-label" />
            </div>

            </div>
         </div>

    </form>
</body>
</html>