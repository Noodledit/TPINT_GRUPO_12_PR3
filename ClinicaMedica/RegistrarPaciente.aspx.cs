using Entidades;
using Servicios;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class RegistrarPaciente : System.Web.UI.Page
    {
        private GestionRegistros registros = new GestionRegistros();
        private GestionDdl gestorDdl = new GestionDdl();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btnUserImg.Visible = true;

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
        protected void Menu_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (e.Item.Value == "cerrarSesion")
            {
                Session["UsuarioActivo"] = null;
                Response.Redirect("ListadoTurnos.aspx");
            }
        }
        private void HabilitacionDeBotones()
        {
            if (btnConfirmar.Visible)
            {
                btnConfirmar.Visible = false;
                btnCancelar.Visible = false;

                btnAceptar.Visible = true;
            }
            else
            {
                btnConfirmar.Visible = true;
                btnCancelar.Visible = true;

                btnAceptar.Visible = false;
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
        protected void btnConfirmar_Click(object sender, EventArgs e)
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
                lblMensaje.Text = "La fecha ingresada no es válida.";
                lblMensaje.Visible = true;
                return;
            }
            DateTime fechaActual = DateTime.Now;
            if (fechaNacimiento < new DateTime(1930, 1, 1) || fechaNacimiento > fechaActual)
            {
                lblMensaje.Text = "La fecha de nacimiento es inválida. Debe ser de 1930 a la actualidad.";
                lblMensaje.Visible = true;
                return;
            }

            Paciente NuevoPaciente = new Paciente(turno.DniPaciente, 
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

            if (registros.RegistrarPaciente(NuevoPaciente)==true)
            {
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                ddlSexo.Enabled = false;
                txtNacionalidad.Enabled = false;
                txtFechaNacimiento.Enabled = false;

                txtDireccion.Enabled = false;
                ddlProvincias.Enabled = false;
                ddlLocalidades.Enabled = false;
                txtCorreoElectronico.Enabled = false;
                txtNumeroTelefono.Enabled = false;

                lblMensaje.Text = "Paciente " + txtNombre.Text.Trim() + " " + txtApellido.Text.Trim() + " registrado correctamente" ;
                lblMensaje.Visible = true;
                LimpiarTxtBox();

                HabilitacionDeBotones();

                int resultado = registros.RegistrarTurno(Session["TurnoPendiente"] as Turno);

                if (resultado == 1)
                {
                    lbl2doMensaje.Text += "Turno asignado";
                    lbl2doMensaje.ForeColor = System.Drawing.Color.White;
                }
                else
                {
                    lbl2doMensaje.Text = "No se pudo asignar el turno";
                    lbl2doMensaje.ForeColor = System.Drawing.Color.Red;
                }
                Session.Remove("TurnoPendiente");
            }
            else
            {
                lblMensaje.Text = "Error al registrar el paciente";
                lblMensaje.Visible = true;
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;
            LimpiarTxtBox();
            Response.Redirect("AsignacionTurnos.aspx");
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AsignacionTurnos.aspx");
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
    }
}