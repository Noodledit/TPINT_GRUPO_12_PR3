using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicios;

namespace ClinicaMedica
{
    public partial class RegistrarMedico : System.Web.UI.Page
    {
        private GestionDdl gestor = new GestionDdl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsuarioActivo"] == null)
            {
                Response.Redirect("ListadoTurnos.aspx");
            }

            if (!IsPostBack)
            {
                gestor.CargarProvincias(ddlProvincias);
                gestor.CargarLocalidades(ddlLocalidades, 0);
                gestor.CargarEspecialidades(ddlEspecialidades);

            }
        }

        protected void ddlProvincias_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvincia = int.Parse(ddlProvincias.SelectedValue);

            if (idProvincia != 0)
            {
                gestor.CargarLocalidades(ddlLocalidades, idProvincia);
            }
            else
            {
                ddlLocalidades.Items.Clear();
                ddlLocalidades.Items.Insert(0, new ListItem("-- Seleccione una provincia primero --", "0"));
            }
        }
    }
}