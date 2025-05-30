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

        public void AltaAdmin(string nombreUsuario, string contrasena)
        {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaAdministrador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreUsuarioParam", nombreUsuario);
            comando.Parameters.AddWithValue("@contrasenaParam", contrasena);

            comando.ExecuteNonQuery(); 
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
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

        public DataTable ConsAdmins()
        {
            tabla = new DataTable();
            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "consAdmins";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;
        }

        public void ModAdmin(int idAdmin, string nombreUsuario, string contrasena)
        {
            comando = new MySqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modAdmin";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idParam", idAdmin);
            comando.Parameters.AddWithValue("@nombreUsuarioParam", nombreUsuario);
            comando.Parameters.AddWithValue("@contrasenaParam", contrasena);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
