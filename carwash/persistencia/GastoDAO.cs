using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Design.AxImporter;

namespace persistencia
{
    public class GastoDAO
    {
        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;
        private DataTable tabla = new DataTable();
        private MySqlCommand comando = new MySqlCommand();

        public void AltaGasto(DateTime fechaGasto,DateTime fechaReg, decimal monto, string tipoGasto, string descripcion, int idAdmin)
        {

            comando = new MySqlCommand();


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaGasto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaGasto", fechaGasto);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaReg);
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

        public List<int> GetEmpPorFecha(DateTime fecha)
        {
            List<int> empleados = new List<int>();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerEmpPorFecha";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@fecha", fecha);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                empleados.Add(reader.GetInt32("numEmpleado"));
            }

            reader.Close();
            conexion.CerrarConexion();

            return empleados;
        }

        public string GetNomEmp(int numEmp)
        {
            string nombreCompleto = string.Empty;

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerNombreEmpleado"; 
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@numEmpleadoParam", numEmp);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                nombreCompleto = reader.GetString("nombreCompleto");
            }

            reader.Close();
            conexion.CerrarConexion();

            return nombreCompleto;
        }

        public int? ObtenerNumEmpleado(string noms, string apellidoPat, string apellidoMat)
        {
            int? numEmpleado = null;

            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerNumEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nombresParam", noms);
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

        public List<decimal> GetPreciosPorFecha(DateTime fecha)
        {
            List<decimal> precios = new List<decimal>();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerPreciosPorFecha";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@fechaBusqueda", fecha);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                precios.Add(reader.GetDecimal("precio"));
            }

            reader.Close();
            conexion.CerrarConexion();

            return precios;
        }

        public List <decimal> GetMontPorFecha(DateTime fecha)
        {
            List<decimal> monts = new List<decimal>();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerMontosPorFecha";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@fechaBusqueda", fecha);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                monts.Add(reader.GetDecimal("monto"));
            }

            reader.Close();
            conexion.CerrarConexion();

            return monts;
        }

        public List<decimal> GetMontGan(DateTime fecha)
        {
            List<decimal> monts = new List<decimal>();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerMontosGanancia";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("p_fechaRegistro", fecha);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                monts.Add(reader.GetDecimal("monto"));
            }

            reader.Close();
            conexion.CerrarConexion();

            return monts;
        }

        public DataTable ConsGas(DateTime fecha)
        {
            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consGastos",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@fechaBuscada", fecha);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            comando.Parameters.Clear();

            return tabla;
        }

        public void ModGasto(int idGasto, DateTime fechaGas, string tipoGasto, string descripcion, int idAdmin)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modGasto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@p_id", idGasto);
            comando.Parameters.AddWithValue("@p_fechaGasto", fechaGas);
            comando.Parameters.AddWithValue("@p_tipoGasto", tipoGasto);
            comando.Parameters.AddWithValue("@p_descripcion", descripcion);
            comando.Parameters.AddWithValue("@p_idAdmin", idAdmin);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
