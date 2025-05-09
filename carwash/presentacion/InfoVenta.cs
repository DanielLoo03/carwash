using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion
{
    public class InfoVenta
    {

        //Son propiedades: crean las variables junto con sus getters y setters en una línea

        public string ModeloCarro {  get; set; }
        public string MarcaCarro {  get; set; }
        public string ColorCarro { get; set; }
        public int Precio { get; set; }
        public int Gan { get; set; }
        public int Corresp { get; set; }
        public int NumEmp { get; set; }
        public DateTime FechaVenta { get; set; }

    }
}
