using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace persistencia
{
    public class EmpleadosDAO
    {

        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;
        private DataTable tabla = new DataTable();
        private MySqlCommand comando = new MySqlCommand();

        //Se maneja el tipo de dato DateTime en vez de DateOnly ya que MySQL no soporta DateOnly. Cuando se pasa un tipo DateTime a un campo Date, MySQL recorta la hora automáticamente.
        //Los campos numTelefono, numExterior, numInterior y codigoPostal son string para evitar que se elimine el 0 inicial en alguno de los campos. 
        public void InsertEmpleado(string nombres, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal) {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombres", nombres);
            comando.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno);
            comando.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno);
            comando.Parameters.AddWithValue("@numTelefono", numTelefono);
            comando.Parameters.AddWithValue("@numEmpleado", numEmpleado);
            comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
            comando.Parameters.AddWithValue("@calle", calle);
            comando.Parameters.AddWithValue("@colonia", colonia);
            comando.Parameters.AddWithValue("@numExterior", numExterior);
            comando.Parameters.AddWithValue("@numInterior", numInterior);
            comando.Parameters.AddWithValue("@codigoPostal", codigoPostal);

            comando.ExecuteNonQuery(); //Es NonQuery ya que un INSERT no regresa valores como lo haría un SELECT
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable GetNumsEmpleado() {

            tabla = new DataTable();
            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerNumsEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;

        }
        public DataTable ConsultEmpleados(){

            tabla = new DataTable();
            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "consultarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            MySqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            return tabla;

        }

        public void ModEmpleados(string nombres, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal) {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modificarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombresParam", nombres);
            comando.Parameters.AddWithValue("@apellidoPaternoParam", apellidoPaterno);
            comando.Parameters.AddWithValue("@apellidoMaternoParam", apellidoMaterno);
            comando.Parameters.AddWithValue("@numTelefonoParam", numTelefono);
            comando.Parameters.AddWithValue("@numEmpleadoParam", numEmpleado);
            comando.Parameters.AddWithValue("@fechaNacimientoParam", fechaNacimiento);
            comando.Parameters.AddWithValue("@calleParam", calle);
            comando.Parameters.AddWithValue("@coloniaParam", colonia);
            comando.Parameters.AddWithValue("@numExteriorParam", numExterior);
            comando.Parameters.AddWithValue("@numInteriorParam", numInterior);
            comando.Parameters.AddWithValue("@codigoPostalParam", codigoPostal);

            comando.ExecuteNonQuery(); //Es NonQuery ya que un UPDATE no regresa valores como lo haría un SELECT
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void ElimEmpleado(int numEmpleado) {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@numEmpleadoParam", numEmpleado);

            comando.ExecuteNonQuery(); //Es NonQuery ya que un DELETE no regresa valores como lo haría un SELECT
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

    }

}
