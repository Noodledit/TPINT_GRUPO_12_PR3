using Servicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Servicios;

namespace ClinicaMedica
{
    public partial class RegistrarMedico : System.Web.UI.Page
    {
        private GestionDdl gestorDdl = new GestionDdl();
        GestionRegistros registros = new GestionRegistros();
        private string legajo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gestorDdl.CargarProvincias(ddlProvincias);
                gestorDdl.CargarLocalidades(ddlLocalidades, 0);
                gestorDdl.CargarEspecialidades(ddlEspecialidades);
                CargarProxLegajo();
            }
        }

        protected void ddlProvincias_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvincia = int.Parse(ddlProvincias.SelectedValue);

            if (idProvincia != 0)
            {
                gestorDdl.CargarLocalidades(ddlLocalidades, idProvincia);
            }
            else
            {
                ddlLocalidades.Items.Clear();
                ddlLocalidades.Items.Insert(0, new ListItem("-- Seleccione una provincia primero --", "0"));
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Medico nuevoMedico = new Medico
            {
                Dni = txtDniMedico.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Sexo = ddlSexo.SelectedValue,
                Nacionalidad = txtNacionalidad.Text.Trim(),
                FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                IdProvincia = int.Parse(ddlProvincias.SelectedValue),
                IdLocalidad = int.Parse(ddlLocalidades.SelectedValue),
                Direccion = txtDireccion.Text.Trim(),
                Correo = txtCorreoElectronico.Text.Trim(),
                Telefono = txtNumeroTelefono.Text.Trim(),
                IdEspecialidad = int.Parse(ddlEspecialidades.SelectedValue)
            };

            if (registros.RegistarMedico(nuevoMedico))
            {
                lblMensaje.Text = "Médico registrado correctamente.";
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Green;
            }
            else
            {
                lblMensaje.Text = "Error al registrar médico";
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Red;
            }
            CargarProxLegajo();
        }

        private void CargarProxLegajo()
        {
            legajo = registros.ObtenerProxLegajo();
            txtLegajo.Text = legajo;
        }
    }
}