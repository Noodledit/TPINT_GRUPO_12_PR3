using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class GestionPaciente
    {
        DaoPacientes dpaciente = new DaoPacientes();

        public int RegistrarPaciente(Paciente paciente)
        {
            return dpaciente.registroPaciente(paciente);
        }
    }
}
