﻿using System;
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

        public Boolean login(String nombreUsuario, String contrasena) {
            DataTable administradores = administradoresService.obtenerAdministradores();

            foreach (DataRow administrador in administradores.Rows) {
                if (nombreUsuario.Equals(administrador["nombreUsuario"]) && contrasena.Equals(administrador["contrasena"])) {
                    return true;
                }
            }
            return false;
        }
    }
}
