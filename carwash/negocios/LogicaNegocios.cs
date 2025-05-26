using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negocios
{
    public class LogicaNegocios
    {
        private AdminsService adminsService = new AdminsService();
        private EmpleadosService empleadosService = new EmpleadosService();
        private VentasService ventasService = new VentasService();
        private CorteService corteService = new CorteService();

        //Valor de retorno: booleano que determina si el login fue exitoso o no exitoso
        public Boolean Login(String nombreUsuario, String contrasena)
        {

            DataTable administradores = adminsService.GetAdmins();

            foreach (DataRow administrador in administradores.Rows)
            {
                //Revisa si el nombre de usuario y la contraseña introducidos pertenecen a un registro de la base de datos. 
                if (nombreUsuario.Equals(administrador["nombreUsuario"]) && contrasena.Equals(administrador["contrasena"]))
                {
                    return true;
                }// Fin if 
            }// Fin foreach
            return false;

        }
        public DataTable GetAdmins()
        {
            return adminsService.GetAdmins();
        }

        //Convertir datos a mayúsculas
        public string[] Mayusculas(params string[] datos) {

            string[] resultado = new string[datos.Length];

            int i = 0;
            foreach (string dato in datos)
            {
                resultado[i] = dato.ToUpper();
                i++;
            }

            return resultado;
        
        } 

        public Boolean AltaEmpleado(string nombres, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal) {

            string[] datosMayus = Mayusculas(nombres, apellidoPaterno, apellidoMaterno, numTelefono, calle, colonia, numExterior, numInterior, codigoPostal);

            empleadosService.InsertEmpleado(datosMayus[0], datosMayus[1], datosMayus[2], datosMayus[3], numEmpleado, fechaNacimiento, datosMayus[4], datosMayus[5], datosMayus[6], datosMayus[7], datosMayus[8]);
            return true;
        
        }

        public DataTable GetNumsEmpleado() {

            return empleadosService.GetNumsEmpleado();
        
        }

        public Boolean ConsultEmpleados(DataGridView tblEmpleados) {

            //Condición: Si la tabla resultante que contiene los empleados no está vacía
            //ConsultEmpleados() regresa un DataTable
            DataTable empleados = empleadosService.ConsultEmpleados();
            tblEmpleados.DataSource = empleados;
            if (empleados.Rows.Count != 0) {

                return true;

            }
            //Si la tabla está vacía
            else {

                return false;

            }

        }

        public Boolean ModEmpleados(string nombres, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal) {

            string[] datosMayus = Mayusculas(nombres, apellidoPaterno, apellidoMaterno, numTelefono, calle, colonia, numExterior, numInterior, codigoPostal);

            empleadosService.ModEmpleados(datosMayus[0], datosMayus[1], datosMayus[2], datosMayus[3], numEmpleado, fechaNacimiento, datosMayus[4], datosMayus[5], datosMayus[6], datosMayus[7], datosMayus[8]);
            return true;

        }

        public void ElimEmpleados(int numEmpleado)
        {

            empleadosService.ElimEmpleado(numEmpleado);

        }

        public Boolean AltaVenta(string marcaCarro, string modeloCarro, string colorCarro, decimal precio, decimal gan, decimal corresp, int numEmp, DateTime fechaVenta) {

            string[] datosMayus = Mayusculas(marcaCarro, modeloCarro, colorCarro);

            ventasService.AltaVenta(datosMayus[0], datosMayus[1], datosMayus[2], precio, gan, corresp, numEmp, fechaVenta);
            return true;

        }

        //por = porcentaje que ya se tiene calculado
        //tipoPor = si es el porcentaje de ganancia o de correspondencia
        public int CalcPor(int por, string tipoPor) {

            //otroPor = se calcula el porcentaje de ganancia/correspondencia
            int otroPor = 100 - por; 

            return otroPor;
        
        }

        //Calcula la ganancia según el porcentaje de ganancia
        public decimal CalcGan(decimal precio, decimal porGan) {

            decimal gan = precio * (porGan / 100);
            return gan;
        
        }

        //Calcula la correspondencia según el porcentaje de correspondencia
        public decimal CalcCorresp(decimal precio, decimal porCorresp)
        {

            decimal corresp = precio * (porCorresp / 100);
            return corresp;

        }

        //Consulta el número de empleado
        public int ConsNumEmp(string nom, string apellidoPaterno, string apellidoMaterno) {

            //resultCons almacena el nombre de empleado en forma de DataTable, ya que viene de hacerse una consulta de MySQL
            DataTable resultCons = ventasService.ConsNumEmp(nom, apellidoPaterno, apellidoMaterno);
            int numEmp = (int)resultCons.Rows[0]["numEmpleado"];
            return numEmp;
        
        }

        //Consulta el nombre de empleado
        public string ConsNomEmp(int numEmpleado)
        {

            //resultCons almacena el número de empleado en forma de DataTable, ya que viene de hacerse una consulta de MySQL
            DataTable resultCons = ventasService.ConsNomEmp(numEmpleado);
            string nomEmp = (string)resultCons.Rows[0]["nombreCompleto"];
            return nomEmp;

        }

        //Modifica el porcentaje de ganancia
        public Boolean ModPorGan(int por)
        {

            ventasService.ModPorGan(por);
            return true;

        }

        //Modifica el porcentaje de correspondencia
        public Boolean ModPorCorresp(int por)
        {

            ventasService.ModPorCorresp(por);
            return true;

        }

        //Consulta los porcentajes de ganancia y correspondencia actuales
        public int[] ConsPor() {

            DataTable resultQuery = ventasService.ConsPor();

            int[] porcentajes = new int[2];

            foreach (DataRow row in resultQuery.Rows)
            {
                string tipoConfig = row["tipoConfig"].ToString();

                //Se asegura que porcentajes[0] siempre contenga la ganancia
                if (tipoConfig == "ganancia")
                    porcentajes[0] = Convert.ToInt32(row["porcentaje"]);
                //Se asegura que porcentajes[0] siempre contenga la correspondencia
                else if (tipoConfig == "correspondencia")
                    porcentajes[1] = Convert.ToInt32(row["porcentaje"]);
            }

            return porcentajes;

        }

        //Consulta todos los números de empleados
        public DataTable ConsNomEmpleados() { 
        
            return ventasService.ConsNomCompletos();

        }

        public Boolean ConsVentas(DataGridView tblVentas, DateTime fecha)
        {
            DataTable ventas = ventasService.ConsVentas(fecha);
            tblVentas.DataSource = ventas;
            if (ventas.Rows.Count != 0)
            {
                //Esconde el Id y el estado de cancelado para que no lo vea el administrador
                tblVentas.Columns["id"].Visible = false;
                tblVentas.Columns["cancelado"].Visible = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean ConsVentasNoCan(DataGridView tblVentas, DateTime fecha)
        {
            DataTable ventas = ventasService.ConsVentasNoCan(fecha);
            tblVentas.DataSource = ventas;
            if (ventas.Rows.Count != 0)
            {
                //Esconde el Id y el estado de cancelado para que no lo vea el administrador
                tblVentas.Columns["id"].Visible = false;
                tblVentas.Columns["cancelado"].Visible = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ConsVentasNoCan(DateTime fecha)
        {
            return ventasService.ConsVentasNoCan(fecha);
        }

        public bool DecidirConsVenta(DataGridView tblVentas, DateTime fecha, bool canceladas) {

            //Si se quiere mostrar las ventas incluidas las canceladas
            if (canceladas) {

                return ConsVentas(tblVentas, fecha);

            }
            //Si se quieren mostrar las ventas salvo las canceladas
            else {

                return ConsVentasNoCan(tblVentas, fecha);

            }
        
        }

        public decimal CalcMontosTotal(DataGridView tblVentas, string col)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in tblVentas.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[col].Value != null && !(bool)row.Cells["cancelado"].Value &&
                    decimal.TryParse(row.Cells[col].Value.ToString(), out decimal valor))
                {
                    total += valor;
                }
            }

            return total;
        }

        //Formatea el número de teléfono con guiones
        public string FormatNumTelefono(string numTelefono) {

            string primeraParte = numTelefono.Substring(0, 3);
            string segundaParte = numTelefono.Substring(3, 3);
            string terceraParte = numTelefono.Substring(6, 4);
            string numTelefonoNuevo = primeraParte + "-" + segundaParte + "-" + terceraParte;

            return numTelefonoNuevo;

        }

        //Se quitan los guiones del número de teléfono antes de cargarlo en los formularios de empleados
        public string QuitarGuiones(string numTelefono) {

            return numTelefono.Replace("-", "");
        
        }

        public void modVenta(int id, string marcaCarro, string modeloCarro, string colorCarro, int numEmp) {

            string[] datosMayus = Mayusculas(marcaCarro, modeloCarro, colorCarro);

            ventasService.ModVenta(id, datosMayus[0], datosMayus[1], datosMayus[2], numEmp);

        }

        public void CanVenta(int id) {

            ventasService.CanVenta(id);
        
        }

        //Consultar si una venta ya se encuentra cancelada
        public Boolean VentaEsCan(DataGridViewRow fila) {

            if ((bool)fila.Cells["cancelado"].Value) {

                return true;

            }
            else {

                return false;
            
            }
        
        }

        public void AltaCorte(DateTime fechaCorte, int idAdmin, decimal contado, decimal calculado, decimal diferencia)
        {

            corteService.AltaCorte(fechaCorte, idAdmin, contado, calculado, diferencia);

        }

        //Obtener Id del admin que realiza el corte de caja
        public DataTable ObtenerIdAdmin(string nombreUsuario) {

            return corteService.ObtenerIdAdmin(nombreUsuario);
        
        }

        //Calcular el monto total de ventas en el día
        public decimal CalcSistema(DataTable ventasNoCan) {

            decimal totalVentas = 0;

            //Si no hubo ventas en el día
            if (ventasNoCan.Rows.Count == 0) {

                return totalVentas;

            }
            //Si hubo al menos una venta en el día
            else {

                //Cicla por cada venta del día
                foreach (DataRow venta in ventasNoCan.Rows)
                {

                    if (decimal.TryParse(venta["precio"].ToString(), out decimal precio))
                    {
                        totalVentas += precio;
                    }

                }

            }

            return totalVentas;
        
        }

        //Calcular la diferencia entre el monto contado por el admin y el monto calculado por el sistema
        public decimal CalcDif(decimal contado, decimal calculado) {

            decimal diferencia = contado - calculado;
            return diferencia;
        
        }

        //Determina el estado de la diferencia, es decir, 
        //NOTA: No se usa switch porque no se pueden usar operadores relacionales en los casos
        public string EstadoDif(decimal diferencia) {


            if (diferencia == 0)
            {

                return "cuadrada";

            }
            else if (diferencia < 0) {

                return "faltante";

            }
            else if (diferencia > 0) {

                return "sobrante";

            }
            else {

                return "Valor inesperado";

            }
                

        }

        //Para saber si ya se realizó un corte en el día seleccionado
        public Boolean YaHayCorte(TextBox contado)
        {

            //Condición: Si el campo de contado (en la consulta de corte) se encuentra vacío, entonces todavía no se ha realizado corte
            if (string.IsNullOrEmpty(contado.Text))
            {

                return false;

            }
            //Condición: Si el campo de contado (en la consulta de corte) se encuentra lleno, entonces ya se realizó un corte
            else
            {

                return true;

            }

        }

        public Boolean AltaAdmin(string nombreUsuario, string contrasena)
        {
            adminsService.AltaAdmin(nombreUsuario, contrasena);
            return true;
        }

        public DataTable ConsAdmins()
        {
            return adminsService.ConsAdmins();
        }
    }
}
