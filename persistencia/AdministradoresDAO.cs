using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia
{
    internal class AdministradoresDAO
    {
        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;
        private DataTable tabla = new DataTable();
        private MySqlCommand comando = new MySqlCommand();
        public DataTable obtenerAdministradores() {
            tabla = new DataTable();
            comando = new MySqlCommand();
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "obtenerAdministradores";
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.cerrarConexion();
            return tabla;
        }
    }
}
