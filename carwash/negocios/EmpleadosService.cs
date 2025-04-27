using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace negocios
{
    public class EmpleadosService
    {

        //Proviene de la capa de persistencia
        private EmpleadosDAO empleadosDAO = new EmpleadosDAO();

        public void InsertEmpleado(string nombre, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal)
        {
            empleadosDAO.InsertEmpleado(nombre, apellidoPaterno, apellidoMaterno, numTelefono, numEmpleado, fechaNacimiento, calle, colonia, numExterior, numInterior, codigoPostal);
        }

        public DataTable GetNumsEmpleado() {

            return empleadosDAO.GetNumsEmpleado();

        }

        public DataTable ConsultEmpleados() {

            return empleadosDAO.ConsultEmpleados();
        }
        public void modEmpleados(string nombre, string apellidoPaterno, string apellidoMaterno, string numTelefono, int numEmpleado, DateTime fechaNacimiento, string calle, string colonia, string numExterior, string numInterior, string codigoPostal) {

            empleadosDAO.modEmpleados(nombre, apellidoPaterno, apellidoMaterno, numTelefono, numEmpleado, fechaNacimiento, calle, colonia, numExterior, numInterior, codigoPostal);

        }

    }
}
