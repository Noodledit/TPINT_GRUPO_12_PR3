using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Servicios
{
    public class GestionDdl
    {
        AccesoDatos acceso = new AccesoDatos();
        public void CargarProvincias(DropDownList ddlProvincias)
        {
            AccesoDatos acceso = new AccesoDatos();
            DataTable tablaProvincias = acceso.EjecutarConsultaSelectDataAdapter("SP_ObtenerProvincias");

            if (tablaProvincias != null)
            {
                ddlProvincias.DataSource = tablaProvincias;
                ddlProvincias.DataTextField = "NombreProvincia";
                ddlProvincias.DataValueField = "IdProvincia";
                ddlProvincias.DataBind();
                ddlProvincias.Items.Insert(0, new ListItem("Seleccione Provincia", "0"));
            }
        }
        public void CargarLocalidades(DropDownList ddlLocalidades, int idProvincia)
        {
            acceso = new AccesoDatos();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdProvincia", idProvincia)
            };
            DataTable tablaLocalidades = acceso.EjecutarConsultaSelectDataAdapter("SP_ObtenerLocalidadesPorProvincia", parametros);

            if (tablaLocalidades != null)
            {
                ddlLocalidades.DataSource = tablaLocalidades;
                ddlLocalidades.DataTextField = "NombreLocalidad";
                ddlLocalidades.DataValueField = "IdLocalidad";
                ddlLocalidades.DataBind();
                ddlLocalidades.Items.Insert(0, new ListItem("Seleccione Localidad", "0"));
            }
        }
        public void CargarEspecialidades(DropDownList ddlEspecialidades)
        {
            acceso = new AccesoDatos();
            DataTable tablaEspecialidades = acceso.EjecutarConsultaSelectDataAdapter("SP_ObtenerEspecialidad");

            if (tablaEspecialidades != null)
            {
                ddlEspecialidades.DataSource = tablaEspecialidades;
                ddlEspecialidades.DataTextField = "Nombre_Esp";
                ddlEspecialidades.DataValueField = "Id_Esp";
                ddlEspecialidades.DataBind();
                ddlEspecialidades.Items.Insert(0, new ListItem("Seleccione Especialidad", "0"));
            }
        }

        public void CargarMedicos(DropDownList ddlMedicos, int idEspecialidad)
        {
            DataTable tablaMedicos = new DataTable();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdEspecialidad", idEspecialidad)
            };
            tablaMedicos = acceso.EjecutarConsultaSelectDataAdapter("SP_ListarMedicos", parametros);

            if (tablaMedicos != null)
            {
                ddlMedicos.DataSource = tablaMedicos;
                ddlMedicos.DataTextField = "Doctor";
                ddlMedicos.DataValueField = "Legajo";
                ddlMedicos.DataBind();
                ddlMedicos.Items.Insert(0, new ListItem("Seleccione Medico", "0"));
            }
        }
        public void CargarFechas(DropDownList ddlFechas, int idEspecialidad, int LegajoMedico)
        {
            acceso = new AccesoDatos();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdEspecialidad", idEspecialidad),
                new SqlParameter("",LegajoMedico)
            };
            DataTable tablaFechas = acceso.EjecutarConsultaSelectDataAdapter("SP_ObtenerFechasTurnos");
            if (tablaFechas != null)
            {
                ddlFechas.DataSource = tablaFechas;
                ddlFechas.DataTextField = "Fecha";
                ddlFechas.DataValueField = "IdFecha";
                ddlFechas.DataBind();
                ddlFechas.Items.Insert(0, new ListItem("Seleccione Fecha", "0"));
            }
        }

        public void CargarHoras(DropDownList ddlHoras)
        {
            DataTable tablaHoras = new DataTable();
        }
    }
}
