using System.Data;
using Datos;
using System.Web.UI.WebControls;
using Entidades;
using System;

namespace Servicios
{
    public class GestionTablas
    {
        private DaoTurnos daoTurnos = new DaoTurnos();
        private DaoMedicos daoMedicos = new DaoMedicos();
        public GestionTablas() { 

        }
        public DataTable ObtenerTablaTurnos(Turno ConfiguracionTurno, int? ValorEstado = 1) {

            bool? Estado;

            switch (ValorEstado)
            {
                case 1:
                    Estado = true; // Disponibles
                    break;
                case 2:
                    Estado = null; // Tomados
                    break;
                case 0:
                    Estado = false; // Deshabilitados
                    break;

                default:
                    Estado = true; // Por si llega un valor inesperado
                    break;
            }
            return daoTurnos.ListadoTurnos(ConfiguracionTurno, Estado);
        }

        public DataTable ObtenerTablaMedicos()
        {
            return daoMedicos.ListarMedicos();
        }
        public DataTable ObtenerTablaMedicosPorLegajo(string legajo)
        {
            return daoMedicos.ListarMedicos(legajo);
        }
        public DataTable ObtenerTablaMedicosPorNombre(string nombre)
        {
            return daoMedicos.ListarMedicos(null,nombre);
        }
        public DataTable ObtenerTablaMedicosPorIdEspecialidad(string idEspecialidad)
        {
            return daoMedicos.ListarMedicos(null, null, Convert.ToInt32(idEspecialidad));
        }


        public class GestionMedicos 
        {
            DaoMedicos dao = new DaoMedicos();

            public bool DarDeBajaMedico(int legajo)
            {
                return dao.DarDeBajaMedicoPorLegajo(legajo);
            }
        }

    }
}
