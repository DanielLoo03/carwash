using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocios
{
    public class LogicaNegocios
    {
        private AdminsService adminsService = new AdminsService();
        private EmpleadosService empleadosService = new EmpleadosService();
        private VentasService ventasService = new VentasService();

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

        public Boolean AltaEmpleado(string nombre, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal) {

            empleadosService.InsertEmpleado(nombre, apellidoPaterno, apellidoMaterno, numTelefono, numEmpleado, fechaNacimiento, calle, colonia, numExterior, numInterior, codigoPostal);
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

        public Boolean ModEmpleados(string nombre, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleadoActual, int numEmpleadoNuevo, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal) {

            empleadosService.ModEmpleados(nombre, apellidoPaterno, apellidoMaterno, numTelefono, numEmpleadoActual, numEmpleadoNuevo, fechaNacimiento, calle, colonia, numExterior, numInterior, codigoPostal);
            return true;

        }

        public void ElimEmpleados(int numEmpleado)
        {

            empleadosService.ElimEmpleado(numEmpleado);

        }

        public Boolean AltaVenta(string marcaCarro, string modeloCarro, string colorCarro, float precio, float gan, float corresp, int numEmp, DateTime fechaVenta) { 
        
            ventasService.AltaVenta(marcaCarro, modeloCarro, colorCarro, precio, gan, corresp, numEmp, fechaVenta);
            return true;

        }

        //por = porcentaje que ya se tiene calculado
        //tipoPor = si es el porcentaje de ganancia o de correspondencia
        public int[] CalcPor(int por, string tipoPor) {

            //Arreglo que contiene el porcentaje de ganancia y el porcentaje de correspondencia
            int[] pors;

            //otroPor = se calcula el porcentaje de ganancia/correspondencia
            int otroPor = 100 - por; 

            //Verifica que siempre el valor en pors[0] sea el porcentaje de ganancia y que siempre el valor en pors[1] sea el porcentaje de conrrespondencia
            if (tipoPor.Equals("ganancia")) {

                pors = new int[] { por , otroPor };
            
            }
            else
            {

                pors = new int[] { otroPor , por };

            }
            return pors;
        
        }

        public float CalcGan(float precio, int porGan) {

            float gan = precio * (porGan / 100f);
            return gan;
        
        }

        public float CalcCorresp(float precio, int porCorresp)
        {

            float corresp = precio * (porCorresp / 100f);
            return corresp;

        }

        public int ConsNumEmp(string nom, string apellidoPaterno, string apellidoMaterno) {

            //resultCons almacena el nombre de empleado en forma de DataTable, ya que viene de hacerse una consulta de MySQL
            DataTable resultCons = ventasService.ConsNumEmp(nom, apellidoPaterno, apellidoMaterno);
            int numEmp = (int)resultCons.Rows[0]["numEmpleado"];
            return numEmp;
        
        }

        public string ConsNomEmp(int numEmpleado)
        {

            //resultCons almacena el número de empleado en forma de DataTable, ya que viene de hacerse una consulta de MySQL
            DataTable resultCons = ventasService.ConsNomEmp(numEmpleado);
            string nomEmp = (string)resultCons.Rows[0]["nombreCompleto"];
            return nomEmp;

        }

        public Boolean ModPorGan(int por)
        {

            ventasService.ModPorGan(por);
            return true;

        }

        public Boolean ModPorCorresp(int por)
        {

            ventasService.ModPorCorresp(por);
            return true;

        }

    }
}
