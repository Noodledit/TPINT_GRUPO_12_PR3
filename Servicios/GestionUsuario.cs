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
        private DaoUsuario dao;
        public Usuario Loguear(string User, string Pass)
        {
            DataTable DatosDeUsuario = new DataTable();

            dao = new DaoUsuario();
            DatosDeUsuario = dao.SolicitudLogin(User, Pass);
            
            Usuario usuarioLogueado = null;
            if (DatosDeUsuario != null)
            {
                DataRow row = DatosDeUsuario.Rows[0];
                //Usuario(user, pass, IdUsuario, int tipoUsuario, string nombreUsuario, string apellidoUsuario)
                usuarioLogueado = new Usuario(
                    User, 
                    Pass, 
                    Convert.ToInt32(row["IdUsuario"]), 
                    Convert.ToInt32(row["TipoUsuario"]), 
                    row["Nombre_DP"].ToString(), 
                    row["Apellido_DP"].ToString());

                return usuarioLogueado;
            }
            else
            {
                return null;
            }
        }
    }
}
