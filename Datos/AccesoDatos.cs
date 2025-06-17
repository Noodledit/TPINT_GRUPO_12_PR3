using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
