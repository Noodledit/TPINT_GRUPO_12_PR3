using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatos
    {
        private string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=ClinicaMedica;Integrated Security=True";

        private SqlConnection connection()
        {
            SqlConnection cnxn = null;
            try
            {
                cnxn = new SqlConnection(connectionString);
                cnxn.Open();
                return cnxn;
            }
            catch (Exception ex)
            {
                try
                {
                    string AuxConnectionString = connectionString.Replace("\\sqlexpress", "");
                    cnxn = new SqlConnection(AuxConnectionString);
                    cnxn.Open();
                    return cnxn;
                }
                catch
                {
                    return null;
                }
            }
        }

        private SqlCommand sqlCommand(string query, SqlConnection conexion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                return cmd;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public DataTable EjecutarConsultaDataAdapter(string query, SqlParameter parametro = null)
        {
            try
            {
                using (SqlCommand cmd = sqlCommand(query, connection()))
                {
                    if (cmd == null) return null;
                    if (parametro != null)
                    {
                        cmd.Parameters.Add(parametro);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    return tabla;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String Nombre)
        {
            int FilasCambiadas;
            SqlConnection Conexion = connection();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Nombre;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }
    }
}