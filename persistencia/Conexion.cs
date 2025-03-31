using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia
{
    internal class Conexion
    {
        private MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=carwash;User Id=root;Password=root;");

        public MySqlConnection abrirConexion() {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public MySqlConnection cerrarConexion() {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
