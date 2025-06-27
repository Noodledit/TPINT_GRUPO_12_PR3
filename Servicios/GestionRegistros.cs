using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class GestionRegistros
    {
        DaoPacientes dpaciente = new DaoPacientes();
        DaoMedicos dmedico = new DaoMedicos();
        DaoTurnos dTurnos = new DaoTurnos();

        public bool RegistrarPaciente(Paciente paciente)
        {
            int retorno = dpaciente.registroPaciente(paciente);
            if (retorno == 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool RegistarMedico(Medico medico)
        {
            int filas = dmedico.registroMedico(medico);
            return filas > 0;
        }

        public string ObtenerProxLegajo()
        {
            return dmedico.ObtenerProxLegajo();
        }

        public bool VerificarSiExiste(string DNI)
        {
           return dpaciente.verificarSiExistePaciente(DNI);

        }

        public bool RegistrarTurno(Turno turno)
        {
            
            int retorno = dTurnos.registrarTurno(turno);
            if (retorno > 0)
            {
                return true;
            }
            else { return false; }

        }
    }
}
