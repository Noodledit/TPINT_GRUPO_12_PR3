using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class ListadoDeMedicos : System.Web.UI.Page
    {
        private GestionTablas gestorTablas = new GestionTablas();
        private GestionDdl gestorDdl = new GestionDdl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarGrillaMedicos();
                gestorDdl.CargarEspecialidades(ddlEspecialidades);
            }
        }
        private void llenarGrillaMedicos()
        {
            DataTable tabla = gestorTablas.ObtenerTablaMedicos();
            gvMedicos.DataSource = tabla;
            gvMedicos.DataBind();

        }

        protected void btnBuscarMeds_Click(object sender, EventArgs e)
        {

        }

        protected void btnFiltrarEspecialidad_Click(object sender, EventArgs e)
        {

        }

        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {

        }
    }
}