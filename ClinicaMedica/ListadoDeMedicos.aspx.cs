using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Servicios.GestionTablas;

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
        private void llenarGrillaMedicos(DataTable tabla = null)
        {
            if (tabla == null)
            {
               tabla = gestorTablas.ObtenerTablaMedicos();
            }
            gvMedicos.DataSource = tabla;
            gvMedicos.DataBind();
        }

        protected void btnBuscarMeds_Click(object sender, EventArgs e)
        {
            string legajo = txtBuscadorMeds.Text.Trim();
            string nombre = txtBuscadorNombre.Text.Trim();
            DataTable tablaFiltrada = null;

            // Validación: solo uno de los campos debe estar completo
            if (!string.IsNullOrEmpty(legajo) && !string.IsNullOrEmpty(nombre))
            {
                lblMensaje.Text = "Por favor, complete solo uno de los campos de búsqueda.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                llenarGrillaMedicos();
                return;
            }
            // si el campo de legajo está completo, filtramos por legajo
            if (!string.IsNullOrEmpty(legajo))
            {
                tablaFiltrada = gestorTablas.ObtenerTablaMedicosPorLegajo(legajo);
            }
            // si el campo de nombre está completo, filtramos por nombre
            else if (!string.IsNullOrEmpty(nombre))
            {
                tablaFiltrada = gestorTablas.ObtenerTablaMedicosPorNombre(nombre);
            }
            // si ninguno de los campos está completo, mostramos todos los médicos
            if (tablaFiltrada != null && tablaFiltrada.Rows.Count > 0)
            {
                llenarGrillaMedicos(tablaFiltrada);
                lblMensaje.Text = "";
            }
            else
            {
                lblMensaje.Text = "No se encontraron médicos con esos criterios.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                llenarGrillaMedicos();
            }
        }

        protected void btnFiltrarEspecialidad_Click(object sender, EventArgs e)
        {
            string idEspecialidad = ddlEspecialidades.SelectedValue;
            DataTable tablaFiltrada = gestorTablas.ObtenerTablaMedicosPorIdEspecialidad(idEspecialidad);
            if (tablaFiltrada.Rows.Count > 0)
            {
                llenarGrillaMedicos(tablaFiltrada);
            }
            else
            {
                lblMensaje.Text = "No se encontraron médicos con esa Especialidad.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                llenarGrillaMedicos();
            }
        }

        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            llenarGrillaMedicos(null);
        }
        protected void gvMedicos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int legajo = Convert.ToInt32(e.CommandArgument);

                var gestorMedicos = new GestionTablas.GestionMedicos();
                bool exito = gestorMedicos.DarDeBajaMedico(legajo);

                if (exito)
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    lblMensaje.Text = "Médico dado de baja exitosamente.";
                    llenarGrillaMedicos();
                }
                else
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    lblMensaje.Text = "No se pudo dar de baja al médico.";
                }
            }
        }

        protected void btnUnlogin_Click(object sender, EventArgs e)
        {
            Session["UsuarioActivo"] = null;
            Response.Redirect("ListadoTurnos.aspx");

        }

        protected void gvMedicos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMedicos.PageIndex = e.NewPageIndex;
            llenarGrillaMedicos();
        }
    }
}