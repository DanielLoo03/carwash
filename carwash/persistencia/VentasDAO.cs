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
    internal class VentasDAO
    {
        private Conexion conexion = new Conexion();
        private MySqlDataReader leer;
        private DataTable tabla = new DataTable();
        private MySqlCommand comando = new MySqlCommand();
        DateTime fechaVenta = DateTime.Now;

        public void AltaVenta(string marcaCarro, string modeloCarro, string colorCarro, float precio, float gan, float corresp, int numEmp, DateTime fechaVenta){
             
            comando = new MySqlCommand();


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "altaEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@marcaCarro", marcaCarro);
            comando.Parameters.AddWithValue("@modeloCarro", modeloCarro);
            comando.Parameters.AddWithValue("@colorCarro", colorCarro);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@ganancia", gan);
            comando.Parameters.AddWithValue("@correspondencia", corresp);
            comando.Parameters.AddWithValue("@numEmpleado", numEmp);
            comando.Parameters.AddWithValue("@fechaVenta", fechaVenta);

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
            comando.Parameters.AddWithValue("@nombreEmpleadoParam", nom);
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

    }
}
