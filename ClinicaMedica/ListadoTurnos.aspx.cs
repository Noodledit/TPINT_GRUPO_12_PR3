using Entidades;
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
            if (Session["UsuarioActivo"] == null)
            {
                string user = txtUsuario.Text;
                string pass = txtContrasenia.Text;

                GestionUsuario gestionUsuario = new GestionUsuario();

                Usuario usuario = gestionUsuario.Loguear(user, pass);

                if (usuario != null)
                {
                    Session["UsuarioActivo"] = usuario;
                    ComprobacionDeSesion();
                }
                else
                {
                    lblBienvenidoUsuario.ForeColor = System.Drawing.Color.Red;
                    lblBienvenidoUsuario.Text = "Usuario o contraseña incorrectos";
                }
            }
            else
            {
                Session["UsuarioActivo"] = null;
                ComprobacionDeSesion();
            }
        }

        protected void ComprobacionDeSesion()
        {
            if (Session["UsuarioActivo"] != null)
            {
                txtContrasenia.Visible = false;
                txtUsuario.Visible = false;
                lblContrasenia.Visible = false;
                lblNombreUsuario.Visible = false;
                lblBienvenidoUsuario.ForeColor = System.Drawing.Color.Black;
                lblBienvenidoUsuario.Text = ((Usuario)Session["UsuarioActivo"]).NombreUsuario + " " + ((Usuario)Session["UsuarioActivo"]).ApellidoUsuario;
                btnUn_Login.Text = "Cerrar sesion";
            }
            else
            {
                txtContrasenia.Visible = true;
                txtUsuario.Visible = true;
                lblContrasenia.Visible = true;
                lblNombreUsuario.Visible = true;
                lblBienvenidoUsuario.Text = string.Empty;
                btnUn_Login.Text = "Ingresar";
            }
        }
    }
}