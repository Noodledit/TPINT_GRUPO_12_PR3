<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsignacionTurnos.aspx.cs" Inherits="ClinicaMedica.AsignacionTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="Estilo/EstiloClinica.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Clinica Medica</title>
    </head>
<body style="margin: 0; background-color: #BDC4D4;">
    <form id="form1" runat="server">
        <header>
    <section>
    <asp:Button ID="btnUn_Login" runat="server" Style="float: right; margin-right: 10px;" Text="Ingresar" CssClass="boton-hover"/>
    <asp:Label ID="lblBienvenidoUsuario" Style="float: right; margin-right: 10px;" runat="server"></asp:Label>
    </section>
    <h1>Clínica Médica 🏥</h1>
    <nav style="align-content: end; justify-content: end;">
        <asp:HyperLink ID="hlListadoTurnos" runat="server">Listado de turnos </asp:HyperLink>
        <asp:HyperLink ID="hlAsignacionTurnos" runat="server" NavigateUrl="~/AsignacionTurnos.aspx" Style="color: #7A859D;">Asignación de Turnos</asp:HyperLink>
    &nbsp;<asp:HyperLink ID="hlInformes" runat="server" NavigateUrl="~/Informes.aspx" Style="color: #7A859D;">Informes</asp:HyperLink>
    &nbsp;<asp:HyperLink ID="hlNuevoPaciente" runat="server" NavigateUrl="~/RegistrarPaciente.aspx" Style="color: #7A859D;">Provisorio nuevio paciente</asp:HyperLink>
    </nav>
</header>
        <main>
            <section class="Listas">
                <div style="text-align: center;">
                    <br />
                <asp:Label ID="lblAsignarTurno" runat="server" Font-Bold="True" Font-Size="24pt" Font-Underline="True" style="margin-left: 3%; padding-bottom: 6%;" Text="Asignación de Turno" ForeColor="White"></asp:Label>
                </div>

                <div style="margin: 15px 10px 50px 20px;">
                    <span style="color: white;">DNI del paciente:</span>
                     &nbsp;<asp:TextBox ID="txtDniPaciente" runat="server"></asp:TextBox>
                </div>
                
                <div style="margin: 5px 10px 15px 20px;">
                    <asp:Label ID="lblEspecialistaPaciente" runat="server" Text="Datos del turno" Font-Underline="True" Font-Size="15pt" ForeColor="White"></asp:Label>
                </div>

                 <div style="margin: 15px 10px 50px 20px;" id="ddlEspecialidad">
                     <span style="color: white;">Especialidad:</span>
                     <asp:DropDownList ID="ddlEspecialista" runat="server" Height="20px" Width="120px">
                     </asp:DropDownList>
                     <br />                     
                    <span style="color: white;">Fecha:</span> 
                    <asp:DropDownList ID="ddlDia" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>
                    <br />
                    <span style="color: white;">Hora:</span>
                    <asp:DropDownList ID="ddlHora" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>
                    <br />
                    <span style="color: white;">Médico:</span>
                    <asp:DropDownList ID="ddlMedico" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>                  
                </div>
                
            </section>            
        </main>
        <footer>


        </footer>
    </form>
</body>
</html>