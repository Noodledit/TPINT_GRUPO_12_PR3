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

        public int RegistrarPaciente(Paciente paciente)
        {
            return dpaciente.registroPaciente(paciente);
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
    }
}
