using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class DaoMedicos
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable ListadoMedicos()
        {

            string consulta = @"SELECT DatosPersonales.Nombre_DP + ' ' + DatosPersonales.Apellido_DP AS NombreComp, Especialidades.Nombre_Esp AS EspecialidadMed, DatosPersonales.Telefono_DP AS Telefono, DatosPersonales.Correo_Electronico_DP AS Contacto FROM Medicos INNER JOIN DatosPersonales ON Medicos.Dni_Me = DatosPersonales.Dni_DP INNER JOIN Especialidades ON Medicos.IdEspecialidad_Me = Especialidades.Id_Esp";


            return ds.EjecutarConsultaDataAdapter(consulta);

        }
    }
}
