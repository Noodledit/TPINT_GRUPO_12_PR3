using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class GestionUsuario
    {
       /* AccesoDatos accesoDatos = new AccesoDatos();
        public bool Loguear(Usuario usuario)
        {
            
            SqlConnection conexion = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=ClinicaMedica;Integrated Security=True");
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SP_LoginUsuario", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@User", usuario.User);
                cmd.Parameters.AddWithValue("@Pass", usuario.Password);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    usuario.Id = Convert.ToInt32(reader["IdUsuario"]);
                    usuario.TipoUsuario = Convert.ToInt32(reader["TipoUsuario"]) == 1 ? TipoUsuario.ADMIN : TipoUsuario.MEDICO;
                    usuario.NombreUsuario = reader["Nombre_DP"].ToString();
                   usuario.ApellidoUsuario = reader["Apellido_DP"].ToString();


                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            { conexion.Close(); }
        }*/

    }
}
