using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DaoTurnos
    {
        AccesoDatos accesoDatos = new AccesoDatos();
            //tablaEstados.Rows.Add(1, "Disponibles");
            //tablaEstados.Rows.Add(2, "Tomados");
            //tablaEstados.Rows.Add(0, "Deshabilitados");
        public DataTable ListadoTurnos(string ProcedimientoAlmacenado, Turno ConfiguracionTurno, bool? Estado = true)
        {
                SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@DniPaciente", ConfiguracionTurno.DniPaciente),
                new SqlParameter("@Fecha", ConfiguracionTurno.Fecha),
                new SqlParameter("@IDEspecialidad", ConfiguracionTurno.IDEspecialidad),
                new SqlParameter("@LegajoDoctor", ConfiguracionTurno.LegajoMed),
                new SqlParameter("@Estado", Estado)
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
            command.Parameters.AddWithValue("@Fecha", turno.Fecha);
            command.Parameters.AddWithValue("@IDEspecialidad", turno.IDEspecialidad);
            command.Parameters.AddWithValue("@LegajoDoctor", turno.LegajoMed);
            command.Parameters.AddWithValue("@Horario", turno.Hora);

            return accesoDatos.EjecutarProcedimientoAlmacenado(command, "SP_AsignarTurno");
        }
    }
}
