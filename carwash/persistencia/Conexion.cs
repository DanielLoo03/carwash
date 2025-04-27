using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace persistencia
{
    internal class Conexion
    {

        private MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=carwash;User Id=root;");

        public MySqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al abrir la conexión a la base de datos.", e);
            }

            return conexion;
        }


        public MySqlConnection CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

    }
}
