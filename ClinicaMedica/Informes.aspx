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
    <asp:Button ID="btnUnlogin" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Cerrar Sesion" CssClass="button" ValidationGroup="GrupoInicioSesion" OnClick="btnUnlogin_Click" />
    <asp:Label ID="lblBienvenidoUsuario" runat="server" Style="float: right; font-size:15px ; margin-right: 8px; letter-spacing: 2px; font-weight: bold; transform: translateY(+5px);"></asp:Label>
</section>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica"/>
                <div class="header-links">
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="~/ListadoTurnos.aspx" Text="Listado de Turnos"></asp:HyperLink>
                    
                    <asp:HyperLink ID="hlAgregarMedico" runat="server" CssClass="header-link" NavigateUrl="RegistrarMedico.aspx" Text="Agregar Medico"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                     <asp:HyperLink ID="hListarMedicos" runat="server" CssClass="header-link" NavigateUrl="ListadoDeMedicos.aspx" Text="Listar Medicos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link-active" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
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
                Los presentes este mes alcanzan el porcentaje de:<asp:Label ID="lblInformePresentismo" runat="server" CssClass="form-label" />
                Los ausentes este mes alcanzan el porcentaje de:<asp:Label ID="lblInformeAusentismo" runat="server" CssClass="form-label" />
                con respecto al mes anterior se ve una diferencia en atencion del: <asp:Label ID="lblInformeComparacionMesAnterior" runat="server" CssClass="form-label" />
                </div>

            </div>
         </div>
    </form>
</body>
</html>