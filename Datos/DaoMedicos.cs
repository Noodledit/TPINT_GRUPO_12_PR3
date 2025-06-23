using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoMedicos
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable ListarMedicos(string SP_ListarMedicos)
        {
            return ds.EjecutarConsultaSelectDataAdapter(SP_ListarMedicos);
        }

        public int registroMedico(Medico medico)
        {
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@Dni", medico.Dni);
            command.Parameters.AddWithValue("@Nombre", medico.Nombre);
            command.Parameters.AddWithValue("@Apellido", medico.Apellido);
            command.Parameters.AddWithValue("@Sexo", medico.Sexo);
            command.Parameters.AddWithValue("@Nacionalidad", medico.Nacionalidad);
            command.Parameters.AddWithValue("@FechaNacimiento", medico.FechaNacimiento);
            command.Parameters.AddWithValue("@Direccion", medico.Direccion);
            command.Parameters.AddWithValue("@IdLocalidad", medico.IdLocalidad);
            command.Parameters.AddWithValue("@IdProvincia", medico.IdProvincia);
            command.Parameters.AddWithValue("@Correo", medico.Correo);
            command.Parameters.AddWithValue("@Telefono", medico.Telefono);
            command.Parameters.AddWithValue("@IdEspecialidad", medico.IdEspecialidad);


            return ds.EjecutarProcedimientoAlmacenado(command, "SP_RegistrarMedico");

        }
        public string ObtenerProxLegajo()
        {
            DataTable dt = ds.EjecutarConsultaSelectDataAdapter("SP_ObtenerProxLegajo", null);

            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0]["ProximoLegajo"] != DBNull.Value)
            {
                return dt.Rows[0]["ProximoLegajo"].ToString();
            }
            else
            {
                return "1";
            }
        }
    }
}
