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
    public partial class ListadoTurnos : System.Web.UI.Page
    {
        bool estado = false;
        private GestionTablas gestionTablas = new GestionTablas();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos();
            gvTurnos.DataBind();
        }

        protected void btnUn_Login_Click(object sender, EventArgs e)
        {
            if (!estado)
            {
                btnUn_Login.Text = "Cerrar sesión";
                lblBienvenidoUsuario.Text = "Bienvenido, " + txtUsuario.Text;
                lblNombreUsuario.Visible = false;
                lblContrasenia.Visible = false;
                txtUsuario.Visible = false;
                txtContrasenia.Visible = false;
                estado = true;
            }
        }

       
    }
}