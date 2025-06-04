using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
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

        public List<decimal> ConsCorrespTotal(DateTime fecha, int emp)
        {
            List<decimal> correspondencias = new List<decimal>();

            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "consCorrespTotal";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@empleado", emp);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                correspondencias.Add(reader.GetDecimal("correspondencia"));
            }

            reader.Close();
            conexion.CerrarConexion();

            return correspondencias;
        }

        public List<decimal> ConsGanTotal(DateTime fecha)
        {
            List<decimal> ganancias = new List<decimal>();

            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "consGanTotal";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@fechaCons", fecha);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ganancias.Add(reader.GetDecimal("ganancia"));
            }

            reader.Close();
            conexion.CerrarConexion();

            return ganancias;
        }

        public List<string> GetNomsEmp()
        {
            List<string> nombres = new List<string>();

            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerNombresEmpleados"; 
            comando.CommandType = CommandType.StoredProcedure;

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                nombres.Add(reader.GetString("nomCompleto"));
            }

            reader.Close();
            conexion.CerrarConexion();

            return nombres;
        }

        public int? ObtenerNumEmpleado(string nombres, string apellidoPat, string apellidoMat)
        {
            int? numEmpleado = null;

            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerNumEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombresParam", nombres);
            comando.Parameters.AddWithValue("@apellidoPaternoParam", apellidoPat);
            comando.Parameters.AddWithValue("@apellidoMaternoParam", apellidoMat);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                numEmpleado = reader.GetInt32("numEmpleado");
            }

            reader.Close();
            conexion.CerrarConexion();

            return numEmpleado;
        }

    }
}
