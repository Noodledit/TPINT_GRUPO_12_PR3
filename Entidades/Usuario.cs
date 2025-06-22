using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entidades
{
    public enum TipoUsuario
    {
        ADMIN = 1,
        MEDICO= 2
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }

        public Usuario(string user, string pass, int IdUsuario, TipoUsuario tipoUsuario, string nombreUsuario, string apellidoUsuario)
        {
            User = user;
            Password = pass;
            Id = IdUsuario;
            TipoUsuario = tipoUsuario;
            NombreUsuario = nombreUsuario;
            ApellidoUsuario = apellidoUsuario;

        }
    }
}
