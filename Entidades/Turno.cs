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
        public int SemanaID { get; set; }
        public int idDia { get; set; }
        public int IDEspecialidad { get; set; }
        public int legajoMed { get; set; }
       // public DateTime Fecha { get; set; }
        public TimeSpan Horas { get; set; }


        public Turno(string dnipaciente,int semanaid,int iddia, int iDEspecialidad, int legajoMed, TimeSpan horas)
        {
            DniPaciente = dnipaciente;
            SemanaID = semanaid;
            idDia = iddia;
            IDEspecialidad = iDEspecialidad;
            this.legajoMed = legajoMed;
            Horas = horas;
        }
    }
}
