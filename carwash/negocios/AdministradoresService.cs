using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistencia;

namespace negocios
{
    public class AdministradoresService
    {
        //Proviene de la capa de persistencia
        private AdministradoresDAO administradoresDAO = new AdministradoresDAO();

        public DataTable ObtenerAdministradores()
        {
            return administradoresDAO.ObtenerAdministradores();
        }
    }
}
