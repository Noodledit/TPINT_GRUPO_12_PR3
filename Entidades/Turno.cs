using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        public string DniPaciente { get; set; }
        public int? IDEspecialidad { get; set; }
        public int? LegajoMed { get; set; }        
        public DateTime? Fecha { get; set; }
        public TimeSpan? Horas { get; set; }

        public Turno(string dnipaciente = null, int? iDEspecialidad = null, int? legajoMed = null, DateTime? fecha = null, TimeSpan? horas = null)
        {
            DniPaciente = dnipaciente;
            IDEspecialidad = iDEspecialidad;
            LegajoMed = legajoMed;
            Fecha = fecha;
            Horas = horas;
        }
    }
}
