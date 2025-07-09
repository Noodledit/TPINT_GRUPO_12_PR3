using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DaoTurnos
    {
        AccesoDatos accesoDatos = new AccesoDatos();

        public DataTable ListadoTurnos(string ProcedimientoAlmacenado, Turno ConfiguracionTurno)
        {
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@DniPaciente", ConfiguracionTurno.DniPaciente),
                new SqlParameter("@Fecha", ConfiguracionTurno.Fecha),
                new SqlParameter("@IDEspecialidad", ConfiguracionTurno.IDEspecialidad),
                new SqlParameter("@LegajoDoctor", ConfiguracionTurno.LegajoMed)
                };
            return accesoDatos.EjecutarConsultaSelectDataAdapter(ProcedimientoAlmacenado, parametros);
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
            command.Parameters.AddWithValue("@IdDia", turno.IdDia);
            command.Parameters.AddWithValue("@IDEspecialidad", turno.IDEspecialidad);
            command.Parameters.AddWithValue("@LegajoDoctor", turno.LegajoMed);
            command.Parameters.AddWithValue("@Horario", turno.Horas);

            return accesoDatos.EjecutarProcedimientoAlmacenado(command, "SP_AsignarTurno");
        }
        public DataTable ListarTurnosPorDni(string dni)
        {
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@DniPaciente", dni) };
            return accesoDatos.EjecutarConsultaSelectDataAdapter("SP_RetornarListaTurnos", parametros);
        }
    }
}
