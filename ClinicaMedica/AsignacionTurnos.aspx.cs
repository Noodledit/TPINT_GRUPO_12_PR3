using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class AsignacionTurnos : System.Web.UI.Page
    {
        private GestionRegistros GestorReg = new GestionRegistros();
        private GestionDdl gestorDdl = new GestionDdl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gestorDdl.CargarEspecialidades(ddlEspecialidades);

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

        protected void btnUn_Login_Click(object sender, EventArgs e)
        {

        }

        protected void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            // Validaciones previas
            string dniPaciente = txtDni.Text.Trim();
            if (string.IsNullOrEmpty(dniPaciente))
            {
                lblMensaje.Text = "Debe ingresar el DNI del paciente.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
                return;
            }

            if (ddlEspecialidades.SelectedValue == "0" ||
                ddlMedicos.SelectedValue == "0" ||
                ddlFechas.SelectedValue == "0" ||
                ddlHoras.SelectedValue == "0")
            {
                lblMensaje.Text = "Debe seleccionar especialidad, médico, fecha y hora.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
                return;
            }

            // Verificar existencia del paciente
            bool existe = GestorReg.VerificarSiExiste(dniPaciente);
            if (!existe)
            {
                Response.Redirect("RegistrarPaciente.aspx");
                return;
            }

            // Mostrar panel de confirmación
            pnlConfirmacion.Visible = true;
            btnAsignarTurno.Visible = false;
            lblMensaje.Visible = false;

            // Guardar datos en sesión para usarlos en la confirmación
            Session["TurnoPendiente"] = new Turno(
                dniPaciente,
                1, 
                int.Parse(ddlFechas.SelectedValue),
                int.Parse(ddlEspecialidades.SelectedValue),
                int.Parse(ddlMedicos.SelectedValue),
                TimeSpan.Parse(ddlHoras.SelectedValue)
            );
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Recuperar el turno pendiente de la sesión
            Turno nuevoTurno = Session["TurnoPendiente"] as Turno;
            if (nuevoTurno == null)
            {
                lblMensaje.Text = "Error interno. Vuelva a intentarlo.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
                pnlConfirmacion.Visible = false;
                btnAsignarTurno.Visible = true;
                return;
            }

            bool resultado = GestorReg.RegistrarTurno(nuevoTurno);

            lblMensaje.Visible = true;
            if (resultado)
            {
                lblMensaje.Text = "Se agregó correctamente en la base de datos";
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMensaje.Text = "No se pudo asignar el turno. Intente nuevamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
            pnlConfirmacion.Visible = false;
            btnAsignarTurno.Visible = true;
            Session.Remove("TurnoPendiente");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlConfirmacion.Visible = false;
            btnAsignarTurno.Visible = true;
            lblMensaje.Visible = false;
            Session.Remove("TurnoPendiente");
        }

        protected void ddlEspecilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si no hay Doctor marcado se cargan todas las especialidades
            int idEspecialidadSeleccionada = int.Parse(ddlEspecialidades.SelectedValue);

            if (idEspecialidadSeleccionada != 0)
            {
                ddlMedicos.Enabled = true;
                ddlFechas.Enabled = true;
                ddlHoras.Enabled = true;

               /* gestorDdl.CargarFechas(ddlFechas, idEspecialidadSeleccionada);
                if (ddlFechas.Items.Count == 0) 
                {
                    ddlFechas.Enabled = false;
                }*///Es necesario llamar dos veces?

                gestorDdl.CargarMedicos(ddlMedicos, idEspecialidadSeleccionada);

                gestorDdl.CargarFechas(ddlFechas, idEspecialidadSeleccionada);
                if (ddlFechas.Items.Count == 0)
                {
                    ddlFechas.Enabled = false;
                }

                gestorDdl.CargarHoras(ddlHoras, idEspecialidadSeleccionada);
                if (ddlHoras.Items.Count == 0)
                {
                    ddlHoras.Enabled = false;
                }
            }
            else
            {
                ddlMedicos.Enabled = false;
                ddlFechas.Enabled = false;
                ddlHoras.Enabled = false;
                ddlMedicos.Items.Clear();
            }
        }

        protected void ddlFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si no hay especialidad marcada no deberia saltar nada
            int idFechaSeleccionada = int.Parse(ddlFechas.SelectedValue);
            int idEspecialidadSeleccionada = int.Parse(ddlEspecialidades.SelectedValue);
            int LegajoSeleccionado = int.Parse(ddlMedicos.SelectedValue);

            if (idFechaSeleccionada != 0)
            {
                gestorDdl.CargarHoras(ddlHoras, idEspecialidadSeleccionada, idFechaSeleccionada, LegajoSeleccionado);
                if (LegajoSeleccionado == 0) 
                {
                    gestorDdl.CargarMedicos(ddlMedicos, idEspecialidadSeleccionada, idFechaSeleccionada);
                }
            }
        }

        protected void ddlMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            int LegajoSeleccionado = int.Parse(ddlMedicos.SelectedValue);
            int idFechaSeleccionada = int.Parse(ddlFechas.SelectedValue);
            int idEspecialidadSeleccionada = int.Parse(ddlEspecialidades.SelectedValue);

            if (LegajoSeleccionado != 0)
            {
                if (idFechaSeleccionada == 0)
                {
                    gestorDdl.CargarFechas(ddlFechas, idEspecialidadSeleccionada, /*idFechaSeleccionada*/ LegajoSeleccionado);
                }
                gestorDdl.CargarHoras(ddlHoras, idEspecialidadSeleccionada, idFechaSeleccionada, LegajoSeleccionado);
            }
        }

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            Response.Redirect("ListadoTurnos.aspx");

        }
    }
}