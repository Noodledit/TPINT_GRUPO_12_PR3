using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DaoTurnos
    {
        AccesoDatos accesoDatos = new AccesoDatos();

        public DataTable ListadoTurnos(Turno ConfiguracionTurno, bool? Estado = true)
        {
                SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@DniPaciente", ConfiguracionTurno.DniPaciente),
                new SqlParameter("@Fecha", ConfiguracionTurno.Fecha),
                new SqlParameter("@IDEspecialidad", ConfiguracionTurno.IDEspecialidad),
                new SqlParameter("@LegajoDoctor", ConfiguracionTurno.LegajoMed),
                new SqlParameter("@Estado", Estado)
                };

                return accesoDatos.EjecutarConsultaSelectDataAdapter("SP_RetornarListaTurnos", parametros);
        }

        public int registrarTurno(Turno turno, bool FinalizarTurno = false)
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "SP_AsignarTurno"
            };

            if (!FinalizarTurno)
            {
                command.Parameters.AddWithValue("@DniPaciente", turno.DniPaciente);
                command.Parameters.AddWithValue("@Fecha", turno.Fecha);
                command.Parameters.AddWithValue("@IDEspecialidad", turno.IDEspecialidad);
                command.Parameters.AddWithValue("@LegajoDoctor", turno.LegajoMed);
                command.Parameters.AddWithValue("@Horario", turno.Hora);
            }
            else 
            {
                command.Parameters.AddWithValue("@DniPaciente", turno.DniPaciente);
                command.Parameters.AddWithValue("@Fecha", turno.Fecha);
                command.Parameters.AddWithValue("@IDEspecialidad", turno.IDEspecialidad);
                command.Parameters.AddWithValue("@LegajoDoctor", turno.LegajoMed);
                command.Parameters.AddWithValue("@Horario", turno.Hora);
                command.Parameters.AddWithValue("@Estado", 0);

            }

            return accesoDatos.EjecutarProcedimientoAlmacenado(command, "SP_AsignarTurno");
        }



        public int InformeAsistencia(DateTime Desde, DateTime Hasta )
        {
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@FechaInicial",Desde);
            command.Parameters.AddWithValue("@FechaFinal",Hasta);

            return accesoDatos.EjecutarProcedimientoAlmacenado(command, "SP_InformeAsistencia");
        }


    }
}
