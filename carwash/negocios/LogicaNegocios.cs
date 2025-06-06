using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using persistencia;

namespace negocios
{
    public class LogicaNegocios
    {
        private AdminsService adminsService = new AdminsService();
        private EmpleadosService empleadosService = new EmpleadosService();
        private VentasService ventasService = new VentasService();
        private CorteService corteService = new CorteService();
        private GastoService gastoService = new GastoService();

        //Valor de retorno: booleano que determina si el login fue exitoso o no exitoso
        public Boolean UsuarioExiste(string nombreUsuario)
        {
            DataTable administradores = adminsService.GetAdmins();
            foreach (DataRow administrador in administradores.Rows)
            {
                if (nombreUsuario.Equals(administrador["nombreUsuario"].ToString(), StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        public Boolean CredencialesValidas(string nombreUsuario, string contrasena)
        {
            DataTable administradores = adminsService.GetAdmins();
            foreach (DataRow administrador in administradores.Rows)
            {
                // Comprobamos en la misma fila que coincidan nombre y contraseña
                if (nombreUsuario.Equals(administrador["nombreUsuario"].ToString(), StringComparison.OrdinalIgnoreCase)
                    && contrasena.Equals(administrador["contrasena"].ToString()))
                {
                    return true;
                }
            }
            return false;
        }


        public DataTable GetAdmins()
        {
            return adminsService.GetAdmins();
        }

        //Convertir datos a mayúsculas
        public string[] Mayusculas(params string[] datos)
        {

            string[] resultado = new string[datos.Length];

            int i = 0;
            foreach (string dato in datos)
            {
                resultado[i] = dato.ToUpper();
                i++;
            }

            return resultado;

        }

        public Boolean AltaEmpleado(string nombres, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal)
        {

            string[] datosMayus = Mayusculas(nombres, apellidoPaterno, apellidoMaterno, numTelefono, calle, colonia, numExterior, numInterior, codigoPostal);

            empleadosService.InsertEmpleado(datosMayus[0], datosMayus[1], datosMayus[2], datosMayus[3], numEmpleado, fechaNacimiento, datosMayus[4], datosMayus[5], datosMayus[6], datosMayus[7], datosMayus[8]);
            return true;

        }

        public DataTable GetNumsEmpleado()
        {

            return empleadosService.GetNumsEmpleado();

        }

        public Boolean ConsultEmpleados(DataGridView tblEmpleados)
        {

            //Condición: Si la tabla resultante que contiene los empleados no está vacía
            //ConsultEmpleados() regresa un DataTable
            DataTable empleados = empleadosService.ConsultEmpleados();
            tblEmpleados.DataSource = empleados;
            if (empleados.Rows.Count != 0)
            {

                return true;

            }
            //Si la tabla está vacía
            else
            {

                return false;

            }

        }

        public Boolean ModEmpleados(string nombres, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal)
        {

            string[] datosMayus = Mayusculas(nombres, apellidoPaterno, apellidoMaterno, numTelefono, calle, colonia, numExterior, numInterior, codigoPostal);

            empleadosService.ModEmpleados(datosMayus[0], datosMayus[1], datosMayus[2], datosMayus[3], numEmpleado, fechaNacimiento, datosMayus[4], datosMayus[5], datosMayus[6], datosMayus[7], datosMayus[8]);
            return true;

        }

        public void ElimEmpleados(int numEmpleado)
        {

            empleadosService.ElimEmpleado(numEmpleado);

        }

        public Boolean AltaVenta(string marcaCarro, string modeloCarro, string colorCarro, decimal precio, decimal gan, decimal corresp, int numEmp, DateTime fechaVenta)
        {

            string[] datosMayus = Mayusculas(marcaCarro, modeloCarro, colorCarro);

            ventasService.AltaVenta(datosMayus[0], datosMayus[1], datosMayus[2], precio, gan, corresp, numEmp, fechaVenta);
            return true;

        }

        //por = porcentaje que ya se tiene calculado
        //tipoPor = si es el porcentaje de ganancia o de correspondencia
        public int CalcPor(int por, string tipoPor)
        {

            //otroPor = se calcula el porcentaje de ganancia/correspondencia
            int otroPor = 100 - por;

            return otroPor;

        }

        //Calcula la ganancia según el porcentaje de ganancia
        public decimal CalcGan(decimal precio, decimal porGan)
        {

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
        public int ConsNumEmp(string nom, string apellidoPaterno, string apellidoMaterno)
        {

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
        public int[] ConsPor()
        {

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
        public DataTable ConsNomEmpleados()
        {

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

        public bool DecidirConsVenta(DataGridView tblVentas, DateTime fecha, bool canceladas)
        {

            //Si se quiere mostrar las ventas incluidas las canceladas
            if (canceladas)
            {

                return ConsVentas(tblVentas, fecha);

            }
            //Si se quieren mostrar las ventas salvo las canceladas
            else
            {

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
        public string FormatNumTelefono(string numTelefono)
        {

            string primeraParte = numTelefono.Substring(0, 3);
            string segundaParte = numTelefono.Substring(3, 3);
            string terceraParte = numTelefono.Substring(6, 4);
            string numTelefonoNuevo = primeraParte + "-" + segundaParte + "-" + terceraParte;

            return numTelefonoNuevo;

        }

        //Se quitan los guiones del número de teléfono antes de cargarlo en los formularios de empleados
        public string QuitarGuiones(string numTelefono)
        {

            return numTelefono.Replace("-", "");

        }

        public void modVenta(int id, string marcaCarro, string modeloCarro, string colorCarro, int numEmp)
        {

            string[] datosMayus = Mayusculas(marcaCarro, modeloCarro, colorCarro);

            ventasService.ModVenta(id, datosMayus[0], datosMayus[1], datosMayus[2], numEmp);

        }

        public void CanVenta(int id)
        {

            ventasService.CanVenta(id);

        }

        //Consultar si una venta ya se encuentra cancelada
        public Boolean VentaEsCan(DataGridViewRow fila)
        {

            if ((bool)fila.Cells["cancelado"].Value)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public void AltaCorte(DateTime fechaCorte, int idAdmin, decimal contado, decimal calculado, decimal diferencia)
        {

            corteService.AltaCorte(fechaCorte, idAdmin, contado, calculado, diferencia);

        }

        //Obtener Id del admin que realiza el corte de caja
        public DataTable ObtenerIdAdmin(string nombreUsuario)
        {

            return corteService.ObtenerIdAdmin(nombreUsuario);

        }

        //Calcular el monto total que debe haber en caja (sumatoria ventas + monto de corte anterior - gastos)
        public decimal CalcSistema(DataTable ventasNoCan)
        {

            decimal total = 0;

            //Si hubo al menos una venta en el día
            if (ventasNoCan.Rows.Count != 0)
            {

                //Cicla por cada venta del día
                foreach (DataRow venta in ventasNoCan.Rows)
                {

                    if (decimal.TryParse(venta["precio"].ToString(), out decimal precio))
                    {
                        total += precio;
                    }

                }

            }

            decimal montoCaja;
            //Considera el monto en caja contado en el último (o penúltimo corte)
            if (ConsReap().Rows.Count == 0)
            {

                montoCaja = ConsCaja();

            }
            else
            {

                montoCaja = ConsCajaPen();

            }
            //Consulta la fecha del último corte de caja
            DateTime fechaUltCorte = ConsFechaCorte();

            //Si hubo un corte de caja anterior en un día anterior
            if (montoCaja != -1 && fechaUltCorte != DateTime.Today)
            {

                total += montoCaja;

            }
            //Si hubo un corte de caja anterior el día de hoy, y se realizó la reapertura de caja
            else if (montoCaja != -1 && fechaUltCorte == DateTime.Today && ConsReap().Rows.Count != 0)
            {
                //Considera el monto en caja contado en el penúltimo corte
                total += montoCaja;

            }

            //PENDIENTE considerar gastos hasta que se haya terminado de realizar módulo

            total = Math.Round(total, 2, MidpointRounding.AwayFromZero);
            return total;

        }

        //Calcular la diferencia entre el monto contado por el admin y el monto calculado por el sistema
        public decimal CalcDif(decimal contado, decimal calculado)
        {

            decimal diferencia = contado - calculado;
            diferencia = Math.Round(diferencia, 2, MidpointRounding.AwayFromZero);
            return diferencia;

        }

        //Determina el estado de la diferencia, es decir, 
        //NOTA: No se usa switch porque no se pueden usar operadores relacionales en los casos
        public string EstadoDif(decimal diferencia)
        {


            if (diferencia == 0)
            {

                return "cuadrada";

            }
            else if (diferencia < 0)
            {

                return "faltante";

            }
            else if (diferencia > 0)
            {

                return "sobrante";

            }
            else
            {

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

        //Consulta del corte de caja según el día seleccionado
        public Boolean ConsCorte(DataGridView tblCorte, DateTime fechaCorte)
        {

            DataTable corte = corteService.ConsCorte(fechaCorte);

            //Si hay corte el día seleccionado
            if (corte.Rows.Count != 0)
            {

                tblCorte.DataSource = corte;
                //Esconde el Id para que no lo vea el administrador
                tblCorte.Columns["idAdmin"].Visible = false;
                return true;

            }
            //No hay corte el día seleccionado
            else
            {

                return false;

            }

        }

        public DataTable ConsCorte(DateTime fechaCorte)
        {

            return corteService.ConsCorte(fechaCorte);

        }

        //Se modifican los datos del corte de caja
        public void ModCorte(int id, DateTime fechaCorte, int idAdmin, decimal contado, decimal calculado, decimal diferencia)
        {

            corteService.ModCorte(id, fechaCorte, idAdmin, contado, calculado, diferencia);

        }

        //Se obtiene el nombre de usuario según el id de administrador
        public string ObtNomUsuario(int id)
        {

            //Se obtiene el resultado del query
            DataTable nomUsuario = corteService.ObtNomUsuario(id);
            //Se convierte resultado de query a string (siempre regresa una sola fila)
            return nomUsuario.Rows[0]["nombreUsuario"].ToString();
            //Nunca regresa nulo, el atributo es NOT NULL en la base de datos

        }

        //Se consulta el dato Contado del último corte de caja realizado
        public decimal ConsCaja()
        {

            //El resultado del query
            DataTable resultado = corteService.ConsCaja();

            //Si no hay ningún corte de caja realizado anteriormente
            if (resultado.Rows.Count == 0)
            {

                return -1;

            }
            //Hay un corte de caja realizado anteriormente
            else
            {

                //Se convierte el resultado al tipo de dato decimal
                decimal contado = (decimal)(resultado.Rows[0]["contado"]);
                return contado;

            }

        }

        //Se consulta el dato Contado del penúltimo corte de caja realizado
        public decimal ConsCajaPen()
        {

            //El resultado del query
            DataTable resultado = corteService.ConsCajaPen();

            //Si no hay ningún corte de caja realizado anteriormente
            if (resultado.Rows.Count == 0)
            {

                return -1;

            }
            //Hay un corte de caja realizado anteriormente
            else
            {

                //Se convierte el resultado al tipo de dato decimal
                decimal contado = (decimal)(resultado.Rows[0]["contado"]);
                return contado;

            }

        }

        //Se consulta la fecha del último corte de caja realizado
        public DateTime ConsFechaCorte()
        {

            //El resultado del query
            DataTable resultado = corteService.ConsFechaCorte();

            //Si no hay ningún corte de caja realizado anteriormente
            if (resultado.Rows.Count == 0)
            {

                return DateTime.MinValue;

            }
            //Hay un corte de caja realizado anteriormente
            else
            {

                //Se convierte el resultado al tipo de dato DateTime
                DateTime fechaCorte = (DateTime)(resultado.Rows[0]["fechaCorte"]);
                return fechaCorte;

            }

        }

        //Bloquear opciones de alta/mod/baja/cancelación en módulos de ventas y gastos al realizar corte
        public void BloqModulos(Button[] btns)
        {
            ToolTip toolTip = new ToolTip();

            foreach (Button btn in btns)
            {

                btn.Enabled = false;
                toolTip.SetToolTip(btn, "Para habilitar la opción, debe reabrir caja.");

            }

        }

        //Rehabilitar opciones de alta/mod/baja/cancelación en módulos de ventas y gastos al reabrir caja
        public void AbrirModulos(Button[] btns)
        {

            ToolTip toolTip = new ToolTip();

            foreach (Button btn in btns)
            {

                btn.Enabled = true;
                //Se "elimina" el tooltip
                toolTip.SetToolTip(btn, null);

            }

        }

        //Se abre o cierra caja
        //Si se encuentra abierta, se cierra. Si se encuentre cerrada, se abre.
        public void ModEstadoCaja(bool estado)
        {

            corteService.ModEstadoCaja(estado);

        }

        //Consulta el estado de caja, abierto o cerrado
        public Boolean ConsEstadoCaja()
        {

            DataTable resultado = corteService.ConsEstadoCaja();

            //Condición: Si caja se encuentra abierta
            if ((bool)resultado.Rows[0]["estado"])
            {

                return true;

            }
            //Condición: Si caja se encuentra cerrada
            else
            {

                return false;

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

        public Boolean ModAdmin(int idAdmin, string nombreUsuario, string contrasena)
        {
            adminsService.ModAdmin(idAdmin, nombreUsuario, contrasena);
            return true;
        }

        //Funciones de Gastos //
        public Boolean AltaGasto(DateTime fechaGasto, DateTime fechaReg, decimal monto, string tipoGasto, string descripcion, int idAdmin)
        {
            gastoService.AltaGasto(fechaGasto,fechaReg,  monto, tipoGasto, descripcion, idAdmin);
            return true;
        }

        public void BajaAdmin(int idAdmin)
        {
            adminsService.BajaAdmin(idAdmin);
        }

        public int CalcularNuevoNumEmpleado()
        {
            DataTable dtNums = GetNumsEmpleado();
            if (dtNums.Rows.Count == 0)
            {
                return 1;
            }
            int maxNum = 0;
            foreach (DataRow row in dtNums.Rows)
            {
                if (int.TryParse(row["numEmpleado"].ToString(), out int actual))
                {
                    if (actual > maxNum)
                        maxNum = actual;
                }
            }
            return maxNum + 1;
        }

        public DataTable ConsultDatosEmpleados()
        {
            return empleadosService.ConsultEmpleados();
        }

        //Modifica el valor del monto contado en el corte de caja reabierto 
        public void ModContado(decimal contado)
        {

            corteService.ModContado(contado);

        }

        //Agrega un registro a la bitácora de reapertura de caja
        public void AltaBitacora(int idAdmin, DateTime fechaHora, string descripcion)
        {

            corteService.AltaBitacora(idAdmin, fechaHora, descripcion);

        }

        //Consulta la reapertura de caja realizada hoy
        public DataTable ConsReap()
        {

            return corteService.ConsReap();

        }

        //Permite o no permite realizar una reapertura de caja dependiendo de si ya se hizo una reapertura anteriormente durante el mismo día
        public bool CanReap()
        {

            DataTable reapHoy = ConsReap();

            //Condición: Si hubo reapertura de caja hoy
            if (reapHoy.Rows.Count != 0)
            {

                return true;

            }
            //Condición: Si no hubo reapertura de caja hoy
            else
            {

                return false;

            }

        }

        //Consulta el registro de la bitácora (que contiene datos de la reapertura) según la fecha
        public DataTable ConsBit(DateTime fecha)
        {

            return corteService.ConsBit(fecha);

        }

        //Consulta el nombre de usuario del administrador según su id
        public DataTable ConsNomAdmin(int id)
        {

            return corteService.ConsNomAdmin(id);

        }

        public List<string> GetTiposGasto()
        {
            return gastoService.GetTiposGasto();
        }

        public decimal ConsCorrespTotal(DateTime fecha, int emp)
        {
            List<decimal> correspEmp = gastoService.ConsCorrespTotal(fecha, emp);
            //Sumatoria de la correspondencia
            return correspEmp.Sum();
        }

        public decimal ConsGanTotal(DateTime fecha)
        {
            List<decimal> ganancias = gastoService.ConsGanTotal(fecha);
            //Sumatoria de las ganancias
            return ganancias.Sum();
        }

        public List<int> GetEmpPorFecha(DateTime fecha)
        {
            return gastoService.GetEmpPorFecha(fecha);
        }

        public string GetNomEmp(int numEmp)
        {
            return gastoService.GetNomEmp(numEmp);
        }

        public int? ObtenerNumEmpleado(string noms, string apellidoPat, string apellidoMat)
        {
            return gastoService.ObtenerNumEmpleado(noms, apellidoPat, apellidoMat);
        }

        public decimal GetPreciosPorFecha(DateTime fecha)
        {
            List<decimal> precios = gastoService.GetPreciosPorFecha(fecha);
            //Sumatoria de los precios
            return precios.Sum();
        }

        public decimal GetMontPorFecha(DateTime fecha)
        {
            List<decimal> monts = gastoService.GetMontPorFecha(fecha);
            //Sumatoria de los montos
            return monts.Sum();
        }

        public DataTable ConsGas(DateTime fecha)
        {
            return gastoService.ConsGas(fecha);
        }
    }
}
