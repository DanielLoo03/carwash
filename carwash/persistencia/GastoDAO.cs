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

        public List<string> GetTiposGasto()
        {
            List<string> tiposGasto = new List<string>();

            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerTiposGasto";
            comando.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                // Obtiene: enum('ganancia','otros',...)
                string enumDef = reader.GetString(0);

                // Limpieza y separación
                enumDef = enumDef.Replace("enum(", "").Replace(")", "").Replace("'", "");
                string[] tipos = enumDef.Split(',');

                foreach (string tipo in tipos)
                {
                    tiposGasto.Add(tipo.Trim());
                }
            }

            reader.Close();
            conexion.CerrarConexion();

            return tiposGasto;
        }

    }
}
