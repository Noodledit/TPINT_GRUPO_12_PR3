<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeguimientosPacientes.aspx.cs" Inherits="ClinicaMedica.SeguimientosPacientes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
    <style type="text/css">
        #TextArea1 {
            width: 750px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="header">
            <section>
                <asp:HyperLink ID="hlCambiarContrasenia" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Cambiar contraseña" ValidationGroup="GrupoInicioSesion" Visible="True" ForeColor="White" Font-Underline="True" NavigateUrl="~/CambiarContraseña.aspx" TabIndex="3" />
                <asp:Button ID="btnUnlogin" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Cerrar Sesion" CssClass="button" ValidationGroup="GrupoInicioSesion" OnClick="btnUnlogin_Click" />
                <asp:Label ID="lblBienvenidoUsuario" runat="server" Style="float: right; margin-right: 10px;" Font-Bold="True"></asp:Label>
</section>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica"/>
            </div>
        </div>
        <div class="contenido">
            <div class="caja-informe">
                <h2 class="titulo-informe">Comentario</h2>

            <div class="caja-informe" style="background: #f1f7ff; margin-bottom: 20px;">
                <!-- aca -->
                <div style="text-align: center; margin-bottom: 10px;">
    <asp:Label ID="lblIdTurno" runat="server" Text="ID Turno: -" Font-Bold="true" Style="margin-right: 15px;" />
    <asp:Label ID="lblNombrePaciente" runat="server" Text="Paciente: -" Font-Bold="true" Style="margin-right: 15px;" />
    <asp:Label ID="lblFechaTurno" runat="server" Text="Fecha: -" Font-Bold="true" />
</div>
              <div style="text-align: center;">
                <textarea id="txtComentario" runat="server" name="S1" rows="2" style="width: 750px;"></textarea>
              </div>
              
              <div style="text-align: right; margin-top: 10px;">
                <asp:Button ID="Button1" runat="server" 
                    Style="margin-right: 5px; height: 28px;" 
                    Text="Finalizar comentario" 
                    OnClick="btnFinalizarComentario_Click" />
              </div>

              <div style="text-align: right; margin-top: 5px;">
                 <asp:Label ID="lblMensaje" runat="server" Font-Bold="true" />
              </div>


                <br />
            </div>
         </div>
    </form>
</body>
</html>