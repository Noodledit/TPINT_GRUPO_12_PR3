using Datos;
using Entidades;

namespace Servicios
{
    public class GestionRegistros
    {
        DaoPacientes dpaciente = new DaoPacientes();
        DaoMedicos dmedico = new DaoMedicos();
        DaoTurnos dTurnos = new DaoTurnos();

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

        public bool RegistrarSeguimiento(Turno TurnoACerrar, string observacion)
        {
            int seguimientosIngresados = dpaciente.RegistrarSeguimiento(TurnoACerrar, observacion);

            if (seguimientosIngresados > 0)
            {
                dTurnos.registrarTurno(TurnoACerrar, true);
            }

            return seguimientosIngresados > 0;
        }
    }
}
