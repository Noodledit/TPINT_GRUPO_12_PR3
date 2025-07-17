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
                 <asp:HyperLink ID="hlCambiarContrasenia" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Cambiar contraseña" ValidationGroup="GrupoInicioSesion" Visible="False" ForeColor="White" Font-Underline="True" NavigateUrl="~/CambiarContraseña.aspx" TabIndex="3" />
                 <asp:Button ID="btnUnlogin" runat="server" Style="float: right; margin-right: 5px; height: 28px; transform: translateY(-2px)" Text="Cerrar Sesion" CssClass="button" OnClick="btnUnlogin_Click" ValidationGroup="GrupoInicioSesion" Visible="False" TabIndex="3" />
                <asp:Label ID="lblBienvenidoUsuario" runat="server" Style="float: right; margin-right: 10px;" Font-Bold="True"></asp:Label>
</section>
            <div class="titulo-header">
                <h1>Clinica Medica</h1>
                <img src="Estilo/logoClinica.png" class="header-image" alt="Logo Clinica"/>
            </div>
        </div>
        <div class="contenido">

            <div class="caja-historial">
             

                <!-- Secciones en paralelo -->
                <div style="display: flex; justify-content: center; gap: 200px; margin-top: 30px;">

                    <!-- HISTORIAL -->
                    <div style="background-color: #f1f7ff; padding: 20px; border-radius: 10px; box-shadow: 0 0 15px rgba(0,0,0,0.2); width: 300px;">
                        <h2 class="titulo-informe" style="text-align: center; color: black;">Historial</h2>
                        <ul style="list-style-type: disc; padding-left: 20px; color: black;">
                            <li>-<asp:ListView ID="lvHistorial" runat="server">
                                </asp:ListView>
                            </li>
                        </ul>
                    </div>



            <div class="caja-informe">
                <h2 class="titulo-informe">Comentario</h2>

            <div class="caja-informe" style="background: #f1f7ff; margin-bottom: 20px;">
                <!-- aca -->
                <div style="text-align: center; margin-bottom: 10px;">
    <asp:Label ID="lblNombre" runat="server" Text="Paciente: " Font-Bold="True" />
    <asp:Label ID="lblNombrePaciente" runat="server"  Font-Bold="True" Style="margin-right: 15px;" />

    <asp:Label ID="lblDNI" runat="server" Text="DNI: " Font-Bold="True" />
    <asp:Label ID="lblDniPaciente" runat="server"  Font-Bold="True" Style="margin-right: 15px;" />

    <asp:Label ID="lblFecha" runat="server" Text="Fecha: " Font-Bold="True" />

    <asp:Label ID="lblFechaTurno" runat="server" Font-Bold="True" />
</div>
              <div style="text-align: center;">
                <textarea id="txtComentario" runat="server" name="S1" rows="2" style="width: 750px;" enableviewstate="True"></textarea>
              </div>
              
              <div style="text-align: right; margin-top: 10px;">
                  <br />
                 <asp:Label ID="lblMensaje" runat="server" Font-Bold="true" />
                  <br />
                  <br />
                  <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Visible="False" OnClick="btnAceptar_Click" />
                  <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" Visible="False" Style="margin-right: 15px;" OnClick="btnConfirmar_Click" />
                  <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Visible="False" OnClick="btnCancelar_Click" />
                <asp:Button ID="btnFinalizarConsulta" runat="server" 
                    Style="margin-right: 5px; height: 28px;" 
                    Text="Finalizar consulta" 
                    OnClick="btnFinalizarConsulta_Click" />
              </div>

              <div style="text-align: right; margin-top: 5px;">
              </div>


                <br />
            </div>
                 </div> </div> </div>
         </div>
    </form>
</body>
</html>