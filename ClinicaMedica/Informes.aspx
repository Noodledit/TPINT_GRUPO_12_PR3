<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informes.aspx.cs" Inherits="ClinicaMedica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
    <title></title>
</head>
<body>
    <div id="form1" runat="server">
        <div class="header">
            <asp:Label ID="lblUsuario" runat="server" CssClass="header-userLabel" Text="Usuario: lblUsuario"></asp:Label>
            <div class="titulo-header">
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica"/>
                <h1>Clinica Medica</h1>
                <div class="header-links">
                    <asp:HyperLink ID="hlInicio" runat="server" CssClass="header-link" NavigateUrl="#" Text="Se Agregan.."></asp:HyperLink>
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
        </div>
    </div>
</body>
</html>
