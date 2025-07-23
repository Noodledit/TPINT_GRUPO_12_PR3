using Entidades;
using Servicios;
using System;
using System.Linq;
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
                HabilitacionDeAcceso();

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

        protected void HabilitacionControlCrearCuentasAdmin()
        {
            MenuItem menuUsuario = MenuUsuario.Items[0];

            bool ExistenciaDeOpcion = menuUsuario.ChildItems
                .Cast<MenuItem>()
                .Any(item => item.Value == "CreacionCuentaAdmin");

            if (!ExistenciaDeOpcion && ((Session["UsuarioActivo"]) as Usuario).TipoUsuario == 2)
            {
                MenuItem OpcionCrearCuenta = new MenuItem("Crear cuenta de administrador", "CreacionCuentaAdmin");
                OpcionCrearCuenta.NavigateUrl = "~/CreacionCuentaAdmin.aspx"; // Opcional

                menuUsuario.ChildItems.Add(OpcionCrearCuenta);
            }
            else
            {
                MenuItem OpcionCrearCuenta = menuUsuario.ChildItems
                    .Cast<MenuItem>()
                    .FirstOrDefault(mi => mi.Value == "CreacionCuentaAdmin");
                if (ExistenciaDeOpcion && OpcionCrearCuenta != null)
                {
                    menuUsuario.ChildItems.Remove(OpcionCrearCuenta);
                }
            }
        }
        protected void HabilitacionDeAcceso()
        {
            if (Session["UsuarioActivo"] != null)
            {
                HabilitacionControlCrearCuentasAdmin();

                if (((Usuario)Session["UsuarioActivo"]).TipoUsuario > 1)
                {
                    hlAgregarMedico.Visible = true;

                    hlAsignarTurnos.Visible = true;
                    hlInformes.Visible = true;
                    hlListarMedicos.Visible = true;
                    HlListarPacientes.Visible = true;
                    hlCrearCuentaAdmin.Visible = true;
                }

                if (((Usuario)Session["UsuarioActivo"]).TipoUsuario >= 1)
                {
                    btnUserImg.Visible = true;
                    MenuUsuario.Visible = true;
                    hlListarTurnos.Visible = true;
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