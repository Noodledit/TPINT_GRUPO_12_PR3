using Entidades;
using Servicios;
using System;
using System.Drawing;

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

            if (CamposIncompletas())
            {
                lblMensaje.Text = "Por favor, rellene todos los campos.";
                lblMensaje.Visible = true;
                
                return;
            }


            string DNI = null;
            if (Session["DniSeleccionado"] != null) {

                DNI = Session["DniSeleccionado"].ToString();
            }


            //Paciente NuevoPaciente = new Paciente(DNI, txtNombre.Text.Trim(), txtApellido.Text.Trim(), Convert.ToString(ddlSexo.SelectedValue), txtNacionalidad.Text.Trim(), Convert.ToDateTime(txtFechaNacimiento.Text.Trim()), txtDireccion.Text.Trim(), Convert.ToInt32(ddlProvincias.SelectedValue), Convert.ToInt32(ddlLocalidades.SelectedValue), txtCorreoElectronico.Text.Trim(), txtNumeroTelefono.Text.Trim());
             Paciente NuevoPaciente = new Paciente(//Datos de prueba
             "97632321",                     
             "Leopoldo",                       
             "Valdez",                
             "Maculino",                   
             "Mexicano",                  
             Convert.ToDateTime("1985-11-10"), 
             "La Vecindad", 
             2,         
             1,                     
             "ramon.valdez@mail.com",         
             "1134567890"                   
             );

            


            if (registros.RegistrarPaciente(NuevoPaciente)==true)
            {
                lblMensaje.Text = "Se registro correctamente al paciente";
                lblMensaje.Visible = true;
    
            }
            else
            {
                lblMensaje.Text = "Error al registrar el paciente";
                lblMensaje.Visible = true;
               
            }



            LimpiarTxtBox();
        }

        private void LimpiarTxtBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtNumeroTelefono.Text = string.Empty;

            ddlProvincias.SelectedIndex = 0;
            ddlLocalidades.SelectedIndex = 0;
            ddlSexo.SelectedIndex = 0;

           
        }

        private bool CamposIncompletas()
        {
            return string.IsNullOrWhiteSpace(txtNombre.Text) ||
                   string.IsNullOrWhiteSpace(txtApellido.Text) ||
                   string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                   string.IsNullOrWhiteSpace(txtFechaNacimiento.Text) ||
                   string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
                   ddlProvincias.SelectedValue == "0" ||
                   ddlLocalidades.SelectedValue == "0" ||
                   string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                   string.IsNullOrWhiteSpace(txtNumeroTelefono.Text);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;
            LimpiarTxtBox();
            Response.Redirect("AsignacionTurnos.aspx");

        }
    }
}