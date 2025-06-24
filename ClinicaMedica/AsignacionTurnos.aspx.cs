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
        private GestionDdl gestorDdl = new GestionDdl();
        protected void Page_Load(object sender, EventArgs e)
        {
            gestorDdl.CargarEspecialidades(ddlEspecialidades);
            gestorDdl.CargarFechas(ddlFechas);
            gestorDdl.

        }

        protected void btnUn_Login_Click(object sender, EventArgs e)
        {

        }

        protected void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            Session["DniSeleccionado"] = txtDni.Text.Trim();


            Response.Redirect("RegistrarPaciente.aspx");
        }

        protected void ddlEspecilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si no hay Doctor marcado se cargan todas las especialidades
        }

        protected void ddlFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si no hay especialidad marcada no deberia saltar nada
        }

        protected void ddlHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si no hay Fecha marcada no deberia salir nada
        }

        protected void ddlMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}