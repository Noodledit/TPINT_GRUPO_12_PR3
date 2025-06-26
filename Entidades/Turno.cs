using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        private int IDEspecialidad { get; set; }
        private int legajoMed { get; set; }
        private DateTime Fecha { get; set; }
        private TimeSpan Horas { get; set; }


        public Turno(int iDEspecialidad, int legajoMed, DateTime fecha, TimeSpan horas)
        {
            IDEspecialidad = iDEspecialidad;
            this.legajoMed = legajoMed;
            Fecha = fecha;
            Horas = horas;
        }
    }
}
