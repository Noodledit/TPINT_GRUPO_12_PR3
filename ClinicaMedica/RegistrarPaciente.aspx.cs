using Entidades;
using Servicios;
using System;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class RegistrarPaciente : System.Web.UI.Page
    {
        private GestionRegistros registros = new GestionRegistros();
        private GestionDdl gestorDdl = new GestionDdl();
        private string DNI = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gestorDdl.CargarProvincias(ddlProvincias);
                gestorDdl.CargarLocalidades(ddlLocalidades, 0);

                if (Session["UsuarioActivo"] != null)
                {
                    Usuario usuario = (Usuario)Session["UsuarioActivo"];
                    lblBienvenidoUsuario.Text = usuario.NombreUsuario + " " + usuario.ApellidoUsuario;
                }
                else
                {
                    Response.Redirect("ListadoTurnos.aspx");
                }
            }
        }

        protected void ddlProvincias_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvincia = int.Parse(ddlProvincias.SelectedValue);

            if (idProvincia != 0)
            {
                gestorDdl.CargarLocalidades(ddlLocalidades, idProvincia);
            }
            else
            {
                ddlLocalidades.Items.Clear();
                ddlLocalidades.Items.Insert(0, new ListItem("-- Seleccione una provincia primero --", "0"));
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Turno turno = Session["TurnoPendiente"] as Turno;

            if (CamposNoComletados())
            {
                lblMensaje.Text = "Se deben rellenar todos los datos.";
                lblMensaje.Visible = true;
                return;
            }

            // Validación de fecha de nacimiento
            DateTime fechaNacimiento;
            if (!DateTime.TryParse(txtFechaNacimiento.Text, out fechaNacimiento))
            {
                lblMensaje.Text = "La fecha de nacimiento no es válida.";
                lblMensaje.Visible = true;
                return;
            }
            if (fechaNacimiento < new DateTime(1930, 1, 1) || fechaNacimiento > new DateTime(2025, 12, 31))
            {
                lblMensaje.Text = "La fecha de nacimiento es inválida. Debe estar entre 1930 y 2025.";
                lblMensaje.Visible = true;
                return;
            }

            DNI = turno.DniPaciente;

            Paciente NuevoPaciente = new Paciente(DNI, 
                txtNombre.Text.Trim(), 
                txtApellido.Text.Trim(), 
                Convert.ToString(ddlSexo.SelectedValue), 
                txtNacionalidad.Text.Trim(), 
                Convert.ToDateTime(txtFechaNacimiento.Text.Trim()), 
                txtDireccion.Text.Trim(), 
                Convert.ToInt32(ddlProvincias.SelectedValue), 
                Convert.ToInt32(ddlLocalidades.SelectedValue), 
                txtCorreoElectronico.Text.Trim(), 
                txtNumeroTelefono.Text.Trim());
            /* Paciente NuevoPaciente = new Paciente(//Datos de prueba
             "97632321",                     
             "Ramon",                       
             "Valdez",                
             "Maculino",                   
             "Mexicano",                  
             Convert.ToDateTime("1985-11-10"), 
             "La Vecindad", 
             2,         
             1,                     
             "ramon.valdez@mail.com",         
             "1134567890"                   
             );*/

            if (registros.RegistrarPaciente(NuevoPaciente)==true)
            {
                lblMensaje.Text = "Se registro correctamente al paciente";
                lblMensaje.Visible = true;
                LimpiarTxtBox();
                Response.Redirect("AsignacionTurnos.aspx");
            }
            else
            {
                lblMensaje.Text = "Error al registrar el paciente";
                lblMensaje.Visible = true;
            }
        }

        private void LimpiarTxtBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtNumeroTelefono.Text = string.Empty;

            ddlProvincias.SelectedIndex = 0;
            ddlLocalidades.SelectedIndex = 0;
            ddlSexo.SelectedIndex = 0;
        }

        private bool CamposNoComletados()
        {
            return string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   string.IsNullOrWhiteSpace(txtApellido.Text) ||
                   string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                   string.IsNullOrWhiteSpace(txtFechaNacimiento.Text) ||
                   string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
                   ddlProvincias.SelectedValue == "0" ||
                   ddlLocalidades.SelectedValue == "0" ||
                   string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                   string.IsNullOrWhiteSpace(txtNumeroTelefono.Text);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;
            LimpiarTxtBox();
            Response.Redirect("AsignacionTurnos.aspx");
        }

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            Response.Redirect("ListadoTurnos.aspx");
        }
    }
}