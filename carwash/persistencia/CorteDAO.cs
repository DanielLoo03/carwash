using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Mysqlx.Cursor;

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
            comando.Parameters.AddWithValue("@fechaCorteParam", fechaCorte);
            comando.Parameters.AddWithValue("@idAdminParam", idAdmin);
            comando.Parameters.AddWithValue("@contadoParam", contado);
            comando.Parameters.AddWithValue("@calculadoParam", calculado);
            comando.Parameters.AddWithValue("@diferenciaParam", diferencia);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable ObtenerIdAdmin(string nombreUsuario)
        {

            tabla = new DataTable();
            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerIdAdmin";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreUsuarioParam", nombreUsuario);
            MySqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;

        }

        public DataTable ConsCorte(DateTime fechaCorte) {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consCorte",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@fechaCorteParam", fechaCorte);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void ModCorte(int id, DateTime fechaCorte, int idAdmin, decimal contado, decimal calculado, decimal diferencia)
        {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modCorte";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idParam", id);
            comando.Parameters.AddWithValue("@fechaCorteParam", fechaCorte);
            comando.Parameters.AddWithValue("@idAdminParam", idAdmin);
            comando.Parameters.AddWithValue("@contadoParam", contado);
            comando.Parameters.AddWithValue("@calculadoParam", calculado);
            comando.Parameters.AddWithValue("@diferenciaParam", diferencia);

            comando.ExecuteNonQuery(); //Es NonQuery ya que un UPDATE no regresa valores como lo haría un SELECT
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable ObtNomUsuario(int id) {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "obtenerNomUsuario",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@idParam", id);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable ConsCaja() {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consCaja",
                CommandType = CommandType.StoredProcedure
            };

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable ConsCajaPen()
        {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consCajaPen",
                CommandType = CommandType.StoredProcedure
            };

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable ConsFechaCorte()
        {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consFechaCorte",
                CommandType = CommandType.StoredProcedure
            };

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void ModEstadoCaja(bool estado)
        {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modEstadoCaja";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@estadoParam", estado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable ConsEstadoCaja() {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consEstadoCaja",
                CommandType = CommandType.StoredProcedure
            };

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void ModContado(decimal contado)
        {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modContado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@contadoParam", contado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void AltaBitacora(int idAdmin, DateTime fechaHora, string descripcion) {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaBitacora";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAdminParam", idAdmin);
            comando.Parameters.AddWithValue("@fechaHoraParam", fechaHora);
            comando.Parameters.AddWithValue("@descripcionParam", descripcion);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable ConsReap() {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consReap",
                CommandType = CommandType.StoredProcedure
            };

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable ConsBit(DateTime fecha)
        {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consBit",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@fechaParam", fecha);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable ConsNomAdmin(int id) {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consNomAdmin",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@idAdminParam", id);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

    }
}
