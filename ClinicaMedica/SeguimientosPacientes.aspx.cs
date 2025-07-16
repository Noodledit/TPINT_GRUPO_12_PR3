using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ClinicaMedica.ListadoTurnos;

namespace ClinicaMedica
{
    public partial class SeguimientosPacientes : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["TurnoSeleccionado"] != null)
            {
                if (Session["UsuarioActivo"] != null)
                {
                    Usuario usuario = (Usuario)Session["UsuarioActivo"];
                    lblBienvenidoUsuario.Text = usuario.NombreUsuario + " " + usuario.ApellidoUsuario;
                }
                else
                {
                    Response.Redirect("ListadoTurnos.aspx");
                }
                var turno = (Turno)Session["TurnoSeleccionado"];
                lblNombrePaciente1.Text = turno.NombrePaciente;
               // lblFechaTurno.Text = turno.Fecha;
            }

        }

        protected void btnFinalizarComentario_Click(object sender, EventArgs e)
        {
                Turno turno = (Turno)Session["TurnoSeleccionado"];
                string comentario = txtComentario.Value;

                // Obtener DNI del paciente desde el turno
                string dniPaciente = turno.DniPaciente;

                // Obtener legajo del doctor desde sesión (si existe)
                int? legajoDoctor = null;
                if (Session["LegajoDoctor"] != null)
                {
                    legajoDoctor = Convert.ToInt32(Session["LegajoDoctor"]);
                }

                GestionRegistros gestion = new GestionRegistros();
                bool comentarioRegistrado = gestion.RegistrarSeguimiento(dniPaciente, comentario, legajoDoctor);

                Session["TurnoSeleccionado"] = null;

                if (comentarioRegistrado)
                {
                    lblMensaje.Text = "Comentario registrado correctamente.";
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMensaje.Text = "Error al guardar el comentario.";
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                }
        }

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            Response.Redirect("ListadoTurnos.aspx");
        }
    }
}