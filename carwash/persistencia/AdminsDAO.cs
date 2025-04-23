using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace persistencia
{
    public class AdminsDAO
    {

        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;
        private DataTable tabla;
        private MySqlCommand comando;

        public DataTable GetAdmins()
        {
            tabla = new DataTable();
            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerAdministradores";
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

    }
}
