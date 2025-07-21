using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class CambiarContrasenia : System.Web.UI.Page
    {
        private GestionUsuario GestorUsuario = new GestionUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UsuarioActivo"] != null)
                {
                    btnUserImg.Visible = true;

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
        protected void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {
            string nuevaClave = txtContraseniaNueva.Text;
            string confirmarClave = txtConfirmarContraseniaNueva.Text;
            
                Usuario usuario = (Usuario)Session["UsuarioActivo"];
                if (usuario != null)
                {
                   GestionUsuario gestionUsuario = new GestionUsuario();
                    bool resultado = gestionUsuario.CambiarContrasenia(usuario, nuevaClave);
                    if (resultado)
                    {
                        lblMensaje.Text = "Contraseña cambiada exitosamente.";
                        txtContraseniaNueva.Text = string.Empty;
                        txtConfirmarContraseniaNueva.Text = string.Empty;
                    }
                    else
                    {
                        lblMensaje.Text = "Error al cambiar la contraseña";
                    }
                }
                else
                {
                    lblMensaje.Text = "error...";
                }
            
        }
    }
}