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
        private GestionTablas gestor = new GestionTablas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarGrillaMedicos();
            }
        }
        private void llenarGrillaMedicos()
        {
             DataTable tabla = gestor.ObtenerTablaMedicos();
            gvMedicos.DataSource = tabla;
            gvMedicos.DataBind();

        }
    }
}