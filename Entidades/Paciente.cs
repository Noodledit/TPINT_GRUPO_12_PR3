using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        //Me gustaria hacer esto privado mas adelante, para que este mejor encapsulado, aunque habria que hacer los respectivos getters y setters
        //Lo dejo asi por tiempo Att: Miguel
        public string Dni; 
        public string Nombre;
        public string Apellido;
        public string Sexo;
        public string Nacionalidad;
        public DateTime Fecha;//No sabia que existia este tipo de variable, lo busque por la del sql, ya que en la bd esta como datetime, capaz se modifica despues
        public string Direccion;
        public string Provincia;
        public string Localidad;
        public string Correo;
        public string Telefono;


        public Paciente(string dni, string nombre, string apellido, string sexo, string nacionalidad, DateTime fecha, string direccion, string provincia, string localidad, string correo, string telefono)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Nacionalidad = nacionalidad;
            Fecha = fecha;
            Direccion = direccion;
            Provincia = provincia;
            Localidad = localidad;
            Correo = correo;
            Telefono = telefono;
        }

    }
}
