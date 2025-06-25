using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            comand.Parameters.AddWithValue("@IdLocalidadPaciente", paciente.GetLocalidad());
            comand.Parameters.AddWithValue("@IdProvinciaPaciente", paciente.GetProvincia());
            comand.Parameters.AddWithValue("@CorreoElectronicoPaciente", paciente.GetCorreo());
            comand.Parameters.AddWithValue("@TelefonoPaciente", paciente.GetTelefono());

            
            //deberia devolver las filas cambiadas
            return ds.EjecutarProcedimientoAlmacenado(comand, "SP_RegistrarPaciente");

        }

        public bool verificarSiExistePaciente(string DNI)
        {
            SqlCommand comand = new SqlCommand();
            comand.Parameters.AddWithValue("@DniPaciente", DNI);

            bool Result = Convert.ToBoolean(ds.EjecutarProcedimientoAlmacenado(comand, "SP_RevisionDniPaciente"));

             
            return Result;
        }


    }
}
