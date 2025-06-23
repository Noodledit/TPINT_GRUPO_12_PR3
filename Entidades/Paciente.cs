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

        private string Dni;
        private string Nombre;
        private string Apellido;
        private string Sexo;
        private string Nacionalidad;
        private DateTime Fecha;//No sabia que existia este tipo de variable, lo busque por la del sql, ya que en la bd esta como datetime, capaz se modifica despues
        private string Direccion;
        private string Provincia;
        private string Localidad;
        private string Correo;
        private string Telefono;


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

        // => funciona cuando hay solo una linea de código por ejemplo:

        /* void SetDni(string dni){
         
            Dni = dni;

        }*/

        // lo cual genera que se ahorre mucho el código usado
        
        public void SetDni(string dni) => Dni = dni; public string GetDni() => Dni;
        public void SetNombre(string nombre) => Nombre = nombre; public string GetNombre() => Nombre;
        public void SetApellido(string apellido) => Apellido = apellido; public string GetApellido() => Apellido;
        public void SetSexo(string sexo) => Sexo = sexo; public string GetSexo() => Sexo;
        public void SetNacionalidad(string nacionalidad) => Nacionalidad = nacionalidad; public string GetNacionalidad() => Nacionalidad;
        public void SetFecha(DateTime fecha) => Fecha = fecha; public DateTime GetFecha() => Fecha;
        public void SetDireccion(string direccion) => Direccion = direccion; public string GetDireccion() => Direccion;
        public void SetProvincia(string provincia) => Provincia = provincia; public string GetProvincia() => Provincia;
        public void SetLocalidad(string localidad) => Localidad = localidad; public string GetLocalidad() => Localidad;
        public void SetCorreo(string correo) => Correo = correo; public string GetCorreo() => Correo;
        public void SetTelefono(string telefono) => Telefono = telefono; public string GetTelefono() => Telefono;

    }

}
