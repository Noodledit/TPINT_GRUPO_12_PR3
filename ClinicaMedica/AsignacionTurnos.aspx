<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarPaciente.aspx.cs" Inherits="ClinicaMedica.RegistrarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Asignación de Turnos</title>
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
                    <asp:HyperLink ID="hlListarTurnos" runat="server" CssClass="header-link" NavigateUrl="ListadoTurnos.aspx" Text="Listado de Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlAgregarPaciente" runat="server" CssClass="header-link" NavigateUrl="RegistrarPaciente.aspx" Text="Agregar Paciente"></asp:HyperLink>
                    <asp:HyperLink ID="hlAsignarTurnos" runat="server" CssClass="header-link" NavigateUrl="AsignacionTurnos.aspx" Text="Asignar Turnos"></asp:HyperLink>
                    <asp:HyperLink ID="hlInformes" runat="server" CssClass="header-link" NavigateUrl="Informes.aspx" Text="Informes"></asp:HyperLink>
                </div>
            </div>
        </div>
        <div class="contenido">
            <div class="solapa">
                Asiganción de Turno
            </div>
            <div class="caja">
                <div style="margin: 15px 10px 50px 20px;">
                    <span style="color: white;">DNI del paciente:</span>
                    &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                
                <div style="margin: 5px 10px 15px 20px;">
                    <asp:Label ID="Label1" runat="server" Text="Datos del turno" Font-Underline="True" Font-Size="15pt" ForeColor="White"></asp:Label>
                </div>

                <div style="margin: 15px 10px 50px 20px;" id="ddlEspecialidad">
                    <span style="color: white;">Especialidad:</span>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>
                    <br />                     
                    <span style="color: white;">Fecha:</span> 
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>
                    <br />
                    <span style="color: white;">Hora:</span>
                    <asp:DropDownList ID="DropDownList3" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>
                    <br />
                    <span style="color: white;">Médico:</span>
                    <asp:DropDownList ID="DropDownList4" runat="server" Height="20px" Width="120px">
                    </asp:DropDownList>                  
                </div>
            </div>
        </div>
    </form>
</body>
</html>