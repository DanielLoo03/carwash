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
    public class VentasDAO
    {
        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;
        private DataTable tabla = new DataTable();
        private MySqlCommand comando = new MySqlCommand();
        DateTime fechaVenta = DateTime.Now;

        public void AltaVenta(string marcaCarro, string modeloCarro, string colorCarro, decimal precio, decimal gan, decimal corresp, int numEmp, DateTime fechaVenta){
             
            comando = new MySqlCommand();


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "registrarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@marcaCarroParam", marcaCarro);
            comando.Parameters.AddWithValue("@modeloCarroParam", modeloCarro);
            comando.Parameters.AddWithValue("@colorCarroParam", colorCarro);
            comando.Parameters.AddWithValue("@precioParam", precio);
            comando.Parameters.AddWithValue("@gananciaParam", gan);
            comando.Parameters.AddWithValue("@correspondenciaParam", corresp);
            comando.Parameters.AddWithValue("@numEmpleadoParam", numEmp);
            comando.Parameters.AddWithValue("@fechaVentaParam", fechaVenta);

            comando.ExecuteNonQuery(); 
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public DataTable ConsNumEmp(string nom, string apellidoPaterno, string apellidoMaterno)
        {
            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "obtenerNumEmpleado",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@nombresParam", nom);
            comando.Parameters.AddWithValue("@apellidoPaternoParam",apellidoPaterno);
            comando.Parameters.AddWithValue("@apellidoMaternoParam",apellidoMaterno);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsNomEmp(int numEmp)
        {
            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "obtenerNombreEmpleado",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@numEmpleadoParam", numEmp);

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void ModPorGan(int por)
        {
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "setPorcentajeGanancia",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@porcentajeParam", por);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void ModPorCorresp(int por)
        {
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "setPorcentajeCorrespondencia",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@porcentajeParam", por);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable ConstPor()
        {
            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "obtenerPorcentajes",
                CommandType = CommandType.StoredProcedure
            };

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsNomCompletos() {

            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consNomCompletos",
                CommandType = CommandType.StoredProcedure
            };

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable ConsVentas(DateTime fecha)
        {
            tabla = new DataTable();
            comando = new MySqlCommand
            {
                Connection = conexion.AbrirConexion(),
                CommandText = "consVentas",
                CommandType = CommandType.StoredProcedure
            };
            comando.Parameters.AddWithValue("@fechaParam", fecha); 

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            comando.Parameters.Clear();

            return tabla;
        }

        public void ModVenta(int id, string marcaCarro, string modeloCarro,  string colorCarro, int numEmp) {

            comando = new MySqlCommand();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "modVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idParam", id);
            comando.Parameters.AddWithValue("@marcaCarroParam", marcaCarro);
            comando.Parameters.AddWithValue("@modeloCarroParam", modeloCarro);
            comando.Parameters.AddWithValue("@colorCarroParam", colorCarro);
            comando.Parameters.AddWithValue("@numEmpParam", numEmp);

            comando.ExecuteNonQuery(); //Es NonQuery ya que un UPDATE no regresa valores como lo haría un SELECT
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

    }
}
