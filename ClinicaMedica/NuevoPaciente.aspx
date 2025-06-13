<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoPaciente.aspx.cs" Inherits="ClinicaMedica.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,500,700&display=swap" rel="stylesheet" />

    <style type="text/css">
        body {
            font-family: 'Roboto', Arial, sans-serif;
        }
        .auto-style1 {
            height: 20%;
        }
        .auto-style2 {
            width: 600px;
            max-width: 98vw;
        }
        .boton-hover {
            transition: transform 0.3s ease, box-shadow 0.3s ease;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.2);
            border-radius: 6px;
        }
        .boton-hover:hover {
            transform: scale(1.03);
            box-shadow: 0 6px 15px rgba(0, 0, 0, 0.2);
            cursor: pointer;
        }
        .form-label {
            color: white;
            font-weight: 500;
            margin-bottom: 6px;
            display: block;
        }
        .input-form {
            width: 100%;
            margin-bottom: 18px;
            padding: 8px 10px;
            border-radius: 8px;
            border: 1px solid #ccc;
            box-shadow: 0 2px 6px rgba(0,0,0,0.07);
            font-size: 15px;
            box-sizing: border-box;
            font-family: 'Roboto', Arial, sans-serif;
        }
        .input-form:focus {
            border-color: #2B3D5B;
            outline: none;
        }
        .form-group {
            width: 100%;
            margin-bottom: 10px;
        }
        .form-container {
            background: #7A859D;
            margin: 5% auto;
            border-radius: 20px;
            padding: 30px 40px 30px 40px;
            box-shadow: 0 8px 20px rgba(0, 0, 0, 0.5);
            display: flex;
            flex-direction: column;
            align-items: center;
        }
        .form-row {
            display: flex;
            gap: 30px;
            width: 100%;
            justify-content: center;
        }
        .form-col {
            flex: 1;
            min-width: 0;
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
                align-items: center;">
            <h1>Clinica Medica 🏥</h1>
            <nav style="align-content: end; justify-content: end;">
                <asp:HyperLink ID="hlListadoTurnos" runat="server" NavigateUrl="~/ListadoTurnos.aspx" Style="color: #7A859D;">Listado de turnos </asp:HyperLink>
                &nbsp;&nbsp;
                <asp:HyperLink ID="hlAsignacionTurnos" runat="server" NavigateUrl="~/AsignacionTurnos.aspx" Style="color: #7A859D;">Asignacion de Turnos</asp:HyperLink>
            </nav>
        </header>
        <main>
            <section class="form-container auto-style2">
                <asp:Label ID="lblTituloNuevoPaciente" runat="server" Font-Bold="True" Font-Size="24pt" Font-Underline="True" 
                    style="margin-bottom: 30px;" Text="Nuevo Paciente" ForeColor="White"></asp:Label>
                <div class="form-row">
                    <div class="form-col">
                        <div class="form-group">
                            <label class="form-label" for="txtDni">DNI:</label>
                            <asp:TextBox ID="txtDni" runat="server" CssClass="input-form" placeholder="Ingrese DNI"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="form-label" for="txtNombre">Nombre:</label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="input-form" placeholder="Ingrese nombre"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="form-label" for="txtApellido">Apellido:</label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="input-form" placeholder="Ingrese apellido"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="form-label" for="ddlSexo">Sexo:</label>
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="input-form">
                                <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                                <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                                <asp:ListItem Text="Otro" Value="O"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label class="form-label" for="txtNacionalidad">Nacionalidad:</label>
                            <asp:TextBox ID="txtNacionalidad" runat="server" CssClass="input-form" placeholder="Ingrese nacionalidad"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="form-label" for="txtCorreo">Correo electrónico:</label>
                            <asp:TextBox ID="txtCorreo" runat="server" CssClass="input-form" placeholder="ejemplo@correo.com" TextMode="Email"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-col">
                      // Aca irian los datos faltantes
                    </div>
                </div>
            </section>
        </main>
        <footer>
        </footer>
    </form>
</body>
</html>



