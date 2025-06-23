using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoPacientes
    {
        AccesoDatos ds = new AccesoDatos();

        public int registroPaciente(Paciente paciente)
        {
            SqlCommand comand = new SqlCommand();

            comand.Parameters.AddWithValue("@DniPaciente", paciente.GetDni());
            comand.Parameters.AddWithValue("@NombrePaciente", paciente.GetNombre());
            comand.Parameters.AddWithValue("@ApellidoPaciente", paciente.GetApellido());
            comand.Parameters.AddWithValue("@SexoPaciente", paciente.GetSexo());
            comand.Parameters.AddWithValue("@NacionalidadPaciente", paciente.GetNacionalidad());
            comand.Parameters.AddWithValue("@FechaNacimientoPaciente", paciente.GetFecha());
            comand.Parameters.AddWithValue("@DireccionPaciente", paciente.GetDireccion());
            comand.Parameters.AddWithValue("@LocalidadPaciente", paciente.GetLocalidad());
            comand.Parameters.AddWithValue("@IdProvinciaPaciente", paciente.GetProvincia());
            comand.Parameters.AddWithValue("@CorreoElectronicoPaciente", paciente.GetCorreo());
            comand.Parameters.AddWithValue("@TelefonoPaciente", paciente.GetTelefono());

            
            //deberia devolver las filas cambiadas
            return ds.EjecutarProcedimientoAlmacenado(comand, "SP_RegistrarPaciente");

        }
    }
}
