<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="ClinicaMedica.CambiarContraseña" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
</head>
<body>
    <form id="form2" runat="server">
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
                     <asp:HyperLink ID="hListarMedicos" runat="server" CssClass="header-link" NavigateUrl="ListadoDeMedicos.aspx" Text="Listar Medicos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido">
            <div class="caja-informe">
                <h2 class="titulo-informe">Cambiar Contraseña</h2>
                <div style="margin-bottom: 25px; display: flex; align-items: center; justify-content: center;">
                    <asp:TextBox ID="txtContraseniaNueva" runat="server" CssClass="input-fecha" TextMode="Password" Width="500px" placeholder="Contraseña nueva" />
                    <br />
                </div>

                <div style="margin-bottom: 25px; display: flex; flex-direction: column; justify-content: flex-start;">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" Text="Seguridad de la contraseña:" Font-Overline="False" Font-Underline="True"></asp:Label>
                    <asp:Label ID="lblCondicion1" runat="server" Text="• minimo 8 y máximo 20 caracteres" CssClass="label" style="margin-top: 5px; color: white;" />
                    <asp:Label ID="lblCondicion2" runat="server" Text="• debe poseer al menos un caracter en mayuscula y minuscula" CssClass="label" style="margin-top: 5px; color: white;" />
                    <asp:Label ID="lblCondicion3" runat="server" Text="• no debe coincidir con alguno de sus datos registrados" CssClass="label" style="margin-top: 5px; color: white;" />
                </div>

                <div style="margin-bottom: 25px; display: flex; align-items: center; justify-content: center;">
                    <asp:TextBox ID="txtConfirmarContraseniaNueva" runat="server" CssClass="input-fecha" TextMode="Password" Width="500px" placeholder="Confirma la nueva contraseña"/>
                </div>

                <div style="margin-bottom: 25px; display: flex; align-items: center; justify-content: center;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CompareValidator ID="cvContrasenias" runat="server" ControlToCompare="txtContraseniaNueva" ControlToValidate="txtConfirmarContraseniaNueva" ErrorMessage="Las contraseñas no coinciden"></asp:CompareValidator>
                </div>

                <div style="margin-bottom: 25px; display: flex; justify-content: flex-end;">
                    <asp:Button ID="Button2" runat="server" Text="Cambiar contraseña" CssClass="boton-hover" />
                </div>
            </div>

         </div>
    </form>
</body>
</html>