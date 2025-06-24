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
    public partial class RegistrarPaciente : System.Web.UI.Page
    {
        GestionRegistros registros = new GestionRegistros();

        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {



        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string DNI = null;
            if (Session["DniSeleccionado"] != null) { 
            
                 DNI = Session["DniSeleccionado"].ToString();
            }


            Paciente NuevoPaciente = new Paciente(DNI,txtNombre.Text.Trim(), txtApellido.Text.Trim(), Convert.ToString(ddlSexo.SelectedValue), txtNacionalidad.Text.Trim(), Convert.ToDateTime(txtFechaNacimiento.Text.Trim()), txtDireccion.Text.Trim(), Convert.ToInt32(ddlProvincia.SelectedValue), Convert.ToInt32(ddlLocalidad.SelectedValue), txtCorreoElectronico.Text.Trim(), txtNumeroTelefono.Text.Trim());
            int filas = registros.RegistrarPaciente(NuevoPaciente);

            if (filas == 0)
            {
                ///Funciona

            }
        }

        
    }
}