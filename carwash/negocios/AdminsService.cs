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

        public void AltaAdmin(string nombreUsuario, string contrasena)
        {
            adminsDAO.AltaAdmin(nombreUsuario, contrasena);
        }

        public DataTable ConsAdmins()
        {
            return adminsDAO.ConsAdmins();
        }

        public void ModAdmin(int idAdmin, string nombreUsuario, string contrasena)
        {
            adminsDAO.ModAdmin(idAdmin, nombreUsuario, contrasena);
        }
    }
}
