using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using System.Web.UI.WebControls;

namespace Servicios
{
    public class GestionDdl
    {
        public void CargarProvincias(DropDownList ddlProvincias)
        {
            AccesoDatos acceso = new AccesoDatos();
            DataTable dt = acceso.EjecutarConsultaSelectDataAdapter("SP_ObtenerProvincias");

            if (dt != null)
            {
                ddlProvincias.DataSource = dt;
                ddlProvincias.DataTextField = "NombreProvincia";
                ddlProvincias.DataValueField = "IdProvincia";
                ddlProvincias.DataBind();
                ddlProvincias.Items.Insert(0, new ListItem("Seleccione Provincia", "0"));
            }
        }
        public void CargarLocalidades(DropDownList ddlLocalidades, int idProvincia)
        {
            AccesoDatos acceso = new AccesoDatos();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdProvincia", idProvincia)
            };
            DataTable dt = acceso.EjecutarConsultaSelectDataAdapter("SP_ObtenerLocalidadesPorProvincia", parametros);

            if (dt != null)
            {
                ddlLocalidades.DataSource = dt;
                ddlLocalidades.DataTextField = "NombreLocalidad";
                ddlLocalidades.DataValueField = "IdLocalidad";
                ddlLocalidades.DataBind();
                ddlLocalidades.Items.Insert(0, new ListItem("Seleccione Localidad", "0"));
            }
        }
        public void CargarEspecialidades(DropDownList ddlEspecialidades)
        {
            AccesoDatos acceso = new AccesoDatos();
            DataTable dt = acceso.EjecutarConsultaSelectDataAdapter("SP_ObtenerEspecialidad");

            if (dt != null)
            {
                ddlEspecialidades.DataSource = dt;
                ddlEspecialidades.DataTextField = "Nombre_Esp";
                ddlEspecialidades.DataValueField = "Id_Esp";
                ddlEspecialidades.DataBind();
                ddlEspecialidades.Items.Insert(0, new ListItem("Seleccione Especialidad", "0"));
            }
        }
    }
}
