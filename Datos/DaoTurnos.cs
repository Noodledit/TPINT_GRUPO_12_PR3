using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class DaoTurnos
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable ListadoTurnos()
        {
            string consulta = @" 
                SELECT
                    DatosPersonales.Nombre_DP + ' ' + DatosPersonales.Apellido_DP AS NombreDoctor,
                    TurnosDisponibles.Dia AS Fecha,
                    Especialidades.Nombre_Esp AS Especialidad,
                    TurnosDisponibles.Estado,
                    Paciente.Nombre_DP + ' ' + Paciente.Apellido_DP AS Paciente,
                    DatosPersonales.Telefono_DP AS ContactoMedico
                FROM
                    TurnosDisponibles
                INNER JOIN Medicos ON TurnosDisponibles.LegajoDoctor = Medicos.Legajo_Me
                INNER JOIN DatosPersonales ON Medicos.Dni_Me = DatosPersonales.Dni_DP
                INNER JOIN Especialidades ON Medicos.IdEspecialidad_Me = Especialidades.Id_Esp
                LEFT JOIN DatosPersonales AS Paciente ON TurnosDisponibles.DniPaciente = Paciente.Dni_DP
                ";

            return ds.EjecutarConsultaDataAdapter(consulta);
        }
    }
}
