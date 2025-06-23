using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ClinicaMedica
{
    public partial class AsignacionTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioActivo"] == null)
            {
                Response.Redirect("ListadoTurnos.aspx");
            }

        }

        protected void btnUn_Login_Click(object sender, EventArgs e)
        {

        }

        protected void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            Session["DniSeleccionado"] = txtDni1.Text.Trim();
            Response.Redirect("RegistrarPaciente.aspx");
        }
    }
}