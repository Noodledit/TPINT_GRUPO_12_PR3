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

            comand.Parameters.AddWithValue("@DniPaciente", paciente.Dni);
            comand.Parameters.AddWithValue("@NombrePaciente", paciente.Nombre);
            comand.Parameters.AddWithValue("@ApellidoPaciente", paciente.Apellido);
            comand.Parameters.AddWithValue("@SexoPaciente", paciente.Sexo);
            comand.Parameters.AddWithValue("@NacionalidadPaciente", paciente.Nacionalidad);
            comand.Parameters.AddWithValue("@FechaNacimientoPaciente", paciente.Fecha);
            comand.Parameters.AddWithValue("@DireccionPaciente", paciente.Direccion);
            comand.Parameters.AddWithValue("@LocalidadPaciente", paciente.Localidad);
            comand.Parameters.AddWithValue("@IdProvinciaPaciente", paciente.Provincia);
            comand.Parameters.AddWithValue("@CorreoElectronicoPaciente", paciente.Correo);
            comand.Parameters.AddWithValue("@TelefonoPaciente", paciente.Telefono);

            
            //deberia devolver las filas cambiadas
            return ds.EjecutarProcedimientoAlmacenado(comand, "SP_RegistrarPaciente");

        }
    }
}
