using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Datos
{
    public class DaoTurnos
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable ListadoTurnos(string ProcedimientoAlmacenado)
        {
            //string consulta = @" 
            //    SELECT
            //        DatosPersonales.Nombre_DP + ' ' + DatosPersonales.Apellido_DP AS NombreDoctor,
            //        TurnosDisponibles.Dia AS Fecha,
            //        Especialidades.Nombre_Esp AS Especialidad,
            //        TurnosDisponibles.Estado,
            //        Paciente.Nombre_DP + ' ' + Paciente.Apellido_DP AS Paciente,
            //        DatosPersonales.Telefono_DP AS ContactoMedico
            //    FROM
            //        TurnosDisponibles
            //    INNER JOIN Medicos ON TurnosDisponibles.LegajoDoctor = Medicos.Legajo_Me
            //    INNER JOIN DatosPersonales ON Medicos.Dni_Me = DatosPersonales.Dni_DP
            //    INNER JOIN Especialidades ON Medicos.IdEspecialidad_Me = Especialidades.Id_Esp
            //    LEFT JOIN DatosPersonales AS Paciente ON TurnosDisponibles.DniPaciente = Paciente.Dni_DP
            //    ";
            return ds.EjecutarConsultaSelectDataAdapter(ProcedimientoAlmacenado);
        }

        public int registrarTurno(Turno turno)
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "SP_AsignarTurno"
            };

            command.Parameters.AddWithValue("@DniPaciente", turno.DniPaciente);
            command.Parameters.AddWithValue("@Semana", turno.SemanaID);
            command.Parameters.AddWithValue("@IdDia", turno.idDia);
            command.Parameters.AddWithValue("@IDEspecialidad", turno.IDEspecialidad);
            command.Parameters.AddWithValue("@LegajoDoctor", turno.legajoMed);
            command.Parameters.AddWithValue("@Horario", turno.Horas);

            int resultado = ds.EjecutarProcedimientoAlmacenado(command, "SP_AsignarTurno");
            return resultado;
        }
    }
}
