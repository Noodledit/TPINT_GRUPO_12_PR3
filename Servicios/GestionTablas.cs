using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using System.Web.UI.WebControls;

namespace Servicios
{
    public class GestionTablas
    {
        private DaoTurnos daoTurnos = new DaoTurnos();
        private DaoMedicos daoMedicos = new DaoMedicos();
        public GestionTablas() { 

        }
        public DataTable ObtenerTablaTurnos() {
            return daoTurnos.ListadoTurnos("SP_RetornarListaTurnos");
        }

        public DataTable ObtenerTablaMedicos()
        {
            return daoMedicos.ListarMedicos();
        }
        public DataTable ObtenerTablaMedicosPorLegajo(string legajo)
        {
            return daoMedicos.ListarMedicosPorLegajo(legajo);
        }
        public DataTable ObtenerTablaMedicosPorNombre(string nombre)
        {
            return daoMedicos.ListarMedicosPorNombre(nombre);
        }
        public DataTable ObtenerTablaTurnosPorDni(string dni)
        {
            return daoTurnos.ListarTurnosPorDni(dni);
        }
        public DataTable ObtenerTablaMedicosPorIdEspecialidad(string idEspecialidad)
        {
            return daoMedicos.ListarMedicosPorIdEspecialidad(idEspecialidad);
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
