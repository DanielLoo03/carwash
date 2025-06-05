using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion
{
    public class InfoCorteCaja
    {

        //Son propiedades: crean las variables junto con sus getters y setters en una línea
        public int Id { get; set; }
        public DateTime FechaCorte { get; set; }
        public int IdAdmin { get; set; }
        public decimal Contado { get; set; }
        public decimal Calculado { get; set; }
        public decimal Diferencia { get; set; }

    }
}
