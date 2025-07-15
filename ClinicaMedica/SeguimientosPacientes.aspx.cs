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
    public partial class SeguimientosPacientes : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["TurnoSeleccionado"] != null)
            {
                dynamic turno = Session["TurnoSeleccionado"];
                lblIdTurno.Text = turno.Id;
                lblNombrePaciente.Text = turno.Paciente;
                lblFechaTurno.Text = turno.Fecha;
               
            }
        }

        protected void btnFinalizarComentario_Click(object sender, EventArgs e)
        {
            if (Session["TurnoSeleccionado"] != null)
            {
                Turno turno = (Turno)Session["TurnoSeleccionado"];
                int idTurno = turno;
                string comentario = txtComentario.Value;

                GuardarComentarioEnBD(idTurno, comentario); // Tu método que guarda en base de datos

                Session["TurnoSeleccionado"] = null;

                lblMensaje.Text = "Comentario guardado correctamente.";
            }
            else
            {
                lblMensaje.Text = "Error: no hay turno seleccionado.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}