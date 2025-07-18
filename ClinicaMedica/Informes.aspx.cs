using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private GestionRegistros GestorRegistros = new GestionRegistros();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
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

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            Response.Redirect("ListadoTurnos.aspx");

        }

        protected void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFechaDesde.Text) && !string.IsNullOrWhiteSpace(txtFechaHasta.Text))
            {
                DateTime Desde = Convert.ToDateTime(txtFechaDesde.Text);
                DateTime Hasta = Convert.ToDateTime(txtFechaHasta.Text);
                bool Informa = GestorRegistros.InformeDeAsistencia(Desde, Hasta);

            }
        }
    }
}