<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsignacionTurnos.aspx.cs" Inherits="ClinicaMedica.AsignacionTurnos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20%;
        }
        .auto-style2 {
            width: 80%;
        }
    </style>
    </head>
<body style="margin: 0; background-color: #BDC4D4;">
    <form id="form1" runat="server">
        <header class="auto-style1"
    style="
        background: linear-gradient(90deg,  #2B3D5B, #15253F);
        color: white;
        height: 93px; 
        border-radius: 20px;
        padding: 20px 40px;
        box-shadow: 0 4px 10px rgba(0,0,0,0.1);
        justify-content: space-between;
        align-items: center;"

            class="auto-style1">
            <section>
            <asp:Label ID="lblUsuario" Style="float: right; margin-right: 10px;" runat="server"></asp:Label>
            </section>
            <h1>Clinica Medica 🏥</h1>
            <nav style="align-content: end; justify-content: end;">
                <asp:HyperLink ID="hlListadoTurnos" runat="server" NavigateUrl="~/ListadoTurnos.aspx" Style="color: #7A859D;">Listado de turnos </asp:HyperLink>
                &nbsp;&nbsp;
              
                <asp:HyperLink ID="hlAsignacionTurnos" runat="server">Asignacion de Turnos</asp:HyperLink>
              
    </nav>
        </header>
        <main>
            <section style="
     background: #7A859D;
 margin: 10% auto;
 border-radius: 20px;
 padding: 20px;
 box-shadow: 0 8px 20px rgba(0, 0, 0, 0.5);
// border: 2px solid #5c6a82;" 
 class="auto-style2">

   
                <div style="text-align: center;">
                    <br />
                <asp:Label ID="lblAsignarTurno" runat="server" Font-Bold="True" Font-Size="24pt" Font-Underline="True" style="margin-left: 3%; padding-bottom: 6%;" Text="Asignar Nuevo Turno" ForeColor="White"></asp:Label>
                </div>
                <div style="margin: 5px 10px 15px 20px;">
                    <asp:Label ID="lblDatosPaciente" runat="server" Text="Datos del paciente" Font-Underline="True" Font-Size="15pt" ForeColor="White"></asp:Label>
                </div>

                <div style="margin: 15px 10px 50px 20px;">
                    <span style="color: white;">DNI:</span>
                     &nbsp;<asp:TextBox ID="txtDniPaciente" runat="server"></asp:TextBox>
                </div>
                
                <div style="margin: 5px 10px 15px 20px;">
                    <asp:Label ID="lblEspecialistaPaciente" runat="server" Text="Especialista" Font-Underline="True" Font-Size="15pt" ForeColor="White"></asp:Label>
                </div>

                 <div style="margin: 15px 10px 50px 20px;" id="ddlEspecialidad">
                     <span style="color: white;">Especialidad:</span>
                     <asp:DropDownList ID="ddlEspecialista" runat="server" Height="20px" Width="120px">
                     </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                     <span style="color: white;">Medico:</span>
                     <asp:DropDownList ID="ddlMedico" runat="server" Height="20px" Width="120px">
                     </asp:DropDownList>
                   </div>

                 <div style="margin: 5px 10px 15px 20px;">
                     <asp:Label ID="lblFechaPaciente" runat="server" Text="Fecha y hora" Font-Underline="True" Font-Size="15pt" ForeColor="White"></asp:Label>
                </div>

                <div style="margin: 15px 10px 50px 20px;" id="ddlHora">
                    <span style="color: white;">Dia:</span> 
                    <asp:DropDownList ID="ddlDia" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <span style="color: white;">Hora:</span>
                    <asp:DropDownList ID="ddlHora" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>
                </div>
                
            </section>            
        </main>
        <footer>


        </footer>
    </form>
</body>
</html>