using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion
{
    public class InfoEmpleado
    {

        //Son propiedades: crean las variables junto con sus getters y setters en una línea
        public string Nombres { get; set; } 
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumTelefono { get; set; }
        public int NumEmpleado { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string NumInterior { get; set; }
        public string NumExterior { get; set; }
        public string CodigoPostal { get; set; }

    }
}
