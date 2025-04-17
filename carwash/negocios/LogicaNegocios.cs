using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocios
{
    public class LogicaNegocios
    {
        private AdministradoresService administradoresService = new AdministradoresService();

        //Valor de retorno: booleano que determina si el login fue exitoso o no exitoso
        public Boolean Login(String nombreUsuario, String contrasena)
        {
            DataTable administradores = administradoresService.ObtenerAdministradores();

            foreach (DataRow administrador in administradores.Rows)
            {
                //Revisa si el nombre de usuario y la contraseña introducidos pertenecen a un registro de la base de datos. 
                if (nombreUsuario.Equals(administrador["nombreUsuario"]) && contrasena.Equals(administrador["contrasena"]))
                {
                    return true;
                }// Fin if 
            }// Fin foreach
            return false;
        }
    }
}
