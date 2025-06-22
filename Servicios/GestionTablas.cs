using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Servicios
{
    public class GestionTablas
    {
        private DaoTurnos daoTurnos = new DaoTurnos();
        public GestionTablas() { 

        }
        public DataTable ObtenerTablaTurnos() {
            return daoTurnos.ListadoTurnos("SP_RetornarListaTurnos");
        }
        public DataTable ObtenerTablaMedicos()
        {
            DaoMedicos daoMedicos = new DaoMedicos();
            return daoMedicos.ListarMedicos("SP_ListarMedicos");
        }
    }
}
