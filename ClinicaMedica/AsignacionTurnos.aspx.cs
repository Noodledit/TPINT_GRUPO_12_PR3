using Entidades;
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
        private GestionRegistros GestorReg = new GestionRegistros();
        private GestionDdl gestorDdl = new GestionDdl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gestorDdl.CargarEspecialidades(ddlEspecialidades);

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

        protected void btnUn_Login_Click(object sender, EventArgs e)
        {

        }

        protected void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            Session["DniSeleccionado"] = txtDni.Text.Trim();

            bool existe = GestorReg.VerificarSiExiste(txtDni.Text.Trim());


            Response.Redirect("RegistrarPaciente.aspx");
        }

        protected void ddlEspecilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si no hay Doctor marcado se cargan todas las especialidades
            int idEspecialidadSeleccionada = int.Parse(ddlEspecialidades.SelectedValue);

            if (idEspecialidadSeleccionada != 0)
            {
                ddlMedicos.Enabled = true;
                ddlFechas.Enabled = true;
                ddlHoras.Enabled = true;
                gestorDdl.CargarMedicos(ddlMedicos, idEspecialidadSeleccionada);

                gestorDdl.CargarFechas(ddlFechas, idEspecialidadSeleccionada);
                if (ddlFechas.Items.Count == 0)
                {
                    ddlFechas.Enabled = false;
                }

                gestorDdl.CargarHoras(ddlHoras, idEspecialidadSeleccionada);
                if (ddlHoras.Items.Count == 0)
                {
                    ddlHoras.Enabled = false;
                }
            }
            else
            {
                ddlMedicos.Enabled = false;
                ddlFechas.Enabled = false;
                ddlHoras.Enabled = false;
                ddlMedicos.Items.Clear();
            }
        }

        protected void ddlFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            // si no hay especialidad marcada no deberia saltar nada
            int idFechaSeleccionada = int.Parse(ddlFechas.SelectedValue);
            int idEspecialidadSeleccionada = int.Parse(ddlEspecialidades.SelectedValue);
            int LegajoSeleccionado = int.Parse(ddlMedicos.SelectedValue);

            if (idFechaSeleccionada != 0)
            {
                gestorDdl.CargarHoras(ddlHoras, idEspecialidadSeleccionada, idFechaSeleccionada, LegajoSeleccionado);
                if (LegajoSeleccionado == 0) 
                {
                    gestorDdl.CargarMedicos(ddlMedicos, idEspecialidadSeleccionada, idFechaSeleccionada); 
                }
            }
        }

        protected void ddlMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            int LegajoSeleccionado = int.Parse(ddlMedicos.SelectedValue);
            int idFechaSeleccionada = int.Parse(ddlFechas.SelectedValue);
            int idEspecialidadSeleccionada = int.Parse(ddlEspecialidades.SelectedValue);

            if (LegajoSeleccionado != 0)
            {
                if (idFechaSeleccionada == 0)
                {
                    gestorDdl.CargarFechas(ddlFechas, idEspecialidadSeleccionada, idFechaSeleccionada);
                }
                gestorDdl.CargarHoras(ddlHoras, idEspecialidadSeleccionada, idFechaSeleccionada, LegajoSeleccionado);
            }
        }

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            Response.Redirect("ListadoTurnos.aspx");

        }
    }
}