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

        public int Id { get; set; }
        public string ModeloCarro { get; set; }
        public string MarcaCarro { get; set; }
        public string ColorCarro { get; set; }
        public decimal Precio { get; set; }
        public decimal Gan { get; set; }
        public decimal Corresp { get; set; }
        public int NumEmp { get; set; }
        public DateTime FechaVenta { get; set; }

    }
}
