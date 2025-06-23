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
