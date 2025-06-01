using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistencia
{
    public class GastoDAO
    {
        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;
        private DataTable tabla = new DataTable();
        private MySqlCommand comando = new MySqlCommand();

        public void AltaGasto(DateTime fechaGasto, decimal monto, string tipoGasto, string descripcion, int idAdmin)
        {

            comando = new MySqlCommand();


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaGasto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaGasto", fechaGasto);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@tipoGasto", tipoGasto);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@idAdmin", idAdmin);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
    }
}
