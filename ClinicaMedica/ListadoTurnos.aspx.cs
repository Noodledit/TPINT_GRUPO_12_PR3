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
            HabilitacionDeAcceso();
            gvTurnos.DataSource = gestionTablas.ObtenerTablaTurnos();
            gvTurnos.DataBind();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
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
        }

        protected void ComprobacionDeSesion()
        {
            if (Session["UsuarioActivo"] != null)
            {
                btnLogin.Visible = false;
                btnUnlogin.Visible = true;
                txtContrasenia.Visible = false;
                txtUsuario.Visible = false;
                lblContrasenia.Visible = false;
                lblNombreUsuario.Visible = false;
                lblBienvenidoUsuario.ForeColor = System.Drawing.Color.White;
                lblBienvenidoUsuario.Text = ((Usuario)Session["UsuarioActivo"]).NombreUsuario + " " + ((Usuario)Session["UsuarioActivo"]).ApellidoUsuario;
                HabilitacionDeAcceso();
            }
            else
            {
                btnLogin.Visible = true;
                btnUnlogin.Visible = false;
                txtContrasenia.Visible = true;
                txtUsuario.Visible = true;
                lblContrasenia.Visible = true;
                lblNombreUsuario.Visible = true;
                lblBienvenidoUsuario.Text = string.Empty;
                HabilitacionDeAcceso();
            }
        }

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            ComprobacionDeSesion();
        }

        protected void HabilitacionDeAcceso()
        {
            if (Session["UsuarioActivo"] != null)
            {
                if (((Usuario)Session["UsuarioActivo"]).TipoUsuario > 1)
                {
                    hlAgregarMedico.Visible = true;
              
                    hlAsignarTurnos.Visible = true;
                    hlInformes.Visible = true;
                    hlListarMedicos.Visible = true;
                }
                if (((Usuario)Session["UsuarioActivo"]).TipoUsuario >= 1)
                {
                    hlListarTurnos.Visible = true;
                    hlSeguimientoPaciente.Visible = true;
                    btnFiltroFecha.Visible = true;
                    ddlFechas.Visible = true;
                    btnMostrarTodo.Visible = true;
                    btnConsultarEstado.Visible = true;
                    ddlEstados.Visible = true;
                }
            }
            else
            {
                hlAgregarMedico.Visible = false;
               
                hlAsignarTurnos.Visible = false;
                hlInformes.Visible = false;
                hlListarMedicos.Visible = false;
                hlListarTurnos.Visible = false;
                hlSeguimientoPaciente.Visible = false;
                btnFiltroFecha.Visible = false;
                ddlFechas.Visible = false;
                btnMostrarTodo.Visible = false;
                btnConsultarEstado.Visible = false;
                ddlEstados.Visible = false;
            }
        }
    }
}