﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            return ds.EjecutarProcedimientoAlmacenado(comand, "SP_RegistrarPaciente");
        }

        public bool verificarSiExistePaciente(string DNI)
        {
            using (SqlConnection conexion = ds.connection())
            {
                SqlCommand comando = new SqlCommand("SP_RevisionDniPaciente", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetro de entrada
                comando.Parameters.AddWithValue("@DniPaciente", DNI);

                // Parámetro de retorno
                SqlParameter retorno = new SqlParameter();
                retorno.Direction = ParameterDirection.ReturnValue;
                comando.Parameters.Add(retorno);

                comando.ExecuteNonQuery();

                int valorRetornado = Convert.ToInt32(retorno.Value);
                return valorRetornado == 1;
            }
        }

        public int RegistrarSeguimiento(Turno TurnoConcluido, string observacion)
        {
            using (SqlConnection conexion = ds.connection())
            {
                SqlCommand cmd = new SqlCommand("SP_RegistrarConsulta", conexion);
                cmd.CommandType = CommandType.StoredProcedure;               

                cmd.Parameters.AddWithValue("@DniPaciente", TurnoConcluido.DniPaciente);
                cmd.Parameters.AddWithValue("@LegajoDoctor", TurnoConcluido.LegajoMed);
                cmd.Parameters.AddWithValue("@IdEspecialidad", TurnoConcluido.IDEspecialidad);
                cmd.Parameters.AddWithValue("@Observacion", observacion);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
