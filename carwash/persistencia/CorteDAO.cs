using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace persistencia
{
    public class CorteDAO
    {

        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;
        private DataTable tabla = new DataTable();
        private MySqlCommand comando = new MySqlCommand();

        public void AltaCorte(DateTime fechaCorte, int idAdmin, decimal contado, decimal calculado, decimal diferencia)
        {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "realizarCorte";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("fechaCorteParam", fechaCorte);
            comando.Parameters.AddWithValue("@idAdminCarroParam", idAdmin);
            comando.Parameters.AddWithValue("@contadoCarroParam", contado);
            comando.Parameters.AddWithValue("@calculadoParam", calculado);
            comando.Parameters.AddWithValue("@diferenciaParam", diferencia);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

    }
}
