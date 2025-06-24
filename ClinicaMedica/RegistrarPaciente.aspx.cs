using Entidades;
using Servicios;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicaMedica
{
    public partial class RegistrarPaciente : System.Web.UI.Page
    {
        GestionRegistros registros = new GestionRegistros();
        private GestionDdl gestorDdl = new GestionDdl();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gestorDdl.CargarProvincias(ddlProvincias);
                gestorDdl.CargarLocalidades(ddlLocalidades, 0);
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
            string DNI = null;
            if (Session["DniSeleccionado"] != null) { 
            
                 DNI = Session["DniSeleccionado"].ToString();
            }


            Paciente NuevoPaciente = new Paciente(DNI,txtNombre.Text.Trim(), txtApellido.Text.Trim(), Convert.ToString(ddlSexo.SelectedValue), txtNacionalidad.Text.Trim(), Convert.ToDateTime(txtFechaNacimiento.Text.Trim()), txtDireccion.Text.Trim(), Convert.ToInt32(ddlProvincias.SelectedValue), Convert.ToInt32(ddlLocalidades.SelectedValue), txtCorreoElectronico.Text.Trim(), txtNumeroTelefono.Text.Trim());
            int filas = registros.RegistrarPaciente(NuevoPaciente);

            if (filas == 0)
            {
                ///Funciona

            }
        }

        
    }
}