using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DaoUsuario
    {
        AccesoDatos accesoDatos;
        public DataTable SolicitudLogin(string user, string pass) {

            DataTable DatosDeUsuario = new DataTable();
            
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@User", user),
                new SqlParameter("@Pass", pass)
            };

            DatosDeUsuario = accesoDatos.EjecutarConsultaSelectDataAdapter("SP_LoginUsuario", parametros);

            return DatosDeUsuario;
        }
    }
}
