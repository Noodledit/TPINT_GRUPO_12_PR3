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
        public int registrarTurno(Turno turno)
        {
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "SP_AsignarTurno"
            };
                command.Parameters.AddWithValue("@DniPaciente", turno.DniPaciente);
                command.Parameters.AddWithValue("@Fecha", turno.Fecha);
                command.Parameters.AddWithValue("@IDEspecialidad", turno.IDEspecialidad);
                command.Parameters.AddWithValue("@LegajoDoctor", turno.LegajoMed);
                command.Parameters.AddWithValue("@Horario", turno.Hora);
                if (turno.Estado == 0) 
                {
                    command.Parameters.AddWithValue("@Estado", 0);
                }
            return accesoDatos.EjecutarProcedimientoAlmacenado(command, "SP_AsignarTurno");
        }
        public DataTable InformeAsistencia(DateTime Desde, DateTime Hasta, string Tipo)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Desde",Desde),
                new SqlParameter("@Hasta", Hasta),
                new SqlParameter("@Tipo", Tipo) // Presentes Ausentes Total
            };
            return accesoDatos.EjecutarConsultaSelectDataAdapter( "SP_InformeAsistencia", parametros);
        }
    }
}
