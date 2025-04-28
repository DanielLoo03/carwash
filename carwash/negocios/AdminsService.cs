using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistencia;

namespace negocios
{
    public class AdminsService
    {
        //Proviene de la capa de persistencia
        private AdminsDAO adminsDAO = new AdminsDAO();

        public DataTable GetAdmins()
        {
            return adminsDAO.GetAdmins();
        }
    }
}
