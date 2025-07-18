using Datos;
using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Servicios
{
    public class GestionRegistros
    {
        DaoPacientes dpaciente = new DaoPacientes();
        DaoMedicos dmedico = new DaoMedicos();
        DaoTurnos dTurnos = new DaoTurnos();
        AccesoDatos AccesoDatos = new AccesoDatos();

        public bool RegistrarPaciente(Paciente paciente)
        {
            int pacientesRegistrados = dpaciente.registroPaciente(paciente);
            return pacientesRegistrados > 0;
        }

        public bool RegistarMedico(Medico medico)
        {
            int medicosRegistrados = dmedico.registroMedico(medico);
            return medicosRegistrados > 0;
        }

        public string ObtenerProxLegajo()
        {
            return dmedico.ObtenerProxLegajo();
        }

        public bool VerificarSiExiste(string DNI)
        {
           return dpaciente.verificarSiExistePaciente(DNI);
        }

        public int RegistrarTurno(Turno turno)
        {
            int turnosRegistrados = dTurnos.registrarTurno(turno);
            return turnosRegistrados;
        }

        public bool InformeDeAsistencia(DateTime Desde, DateTime Hasta)
        {
            int InformeFunciona = dTurnos.InformeAsistencia(Desde,Hasta);
            return InformeFunciona > 0;
        }

        public bool RegistrarSeguimiento(Turno TurnoACerrar, string observacion)
        {
            int seguimientosIngresados = dpaciente.RegistrarSeguimiento(TurnoACerrar, observacion);

            if (seguimientosIngresados > 0)
            {
                dTurnos.registrarTurno(TurnoACerrar, true);
            }

            return seguimientosIngresados > 0;
        }

        public DataTable ObtenerHistorialPorPaciente(string DniPaciente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@DniPaciente", DniPaciente)
            };
            return AccesoDatos.EjecutarConsultaSelectDataAdapter("SP_ObtenerHistorialPorPaciente", parametros);

        }


    }
}
