using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion
{
    public class InfoGasto
    {
        //Son propiedades: crean las variables junto con sus getters y setters en una línea
        public DateTime FechaGasto { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int IdAdmin { get; set; }
        public decimal Monto { get; set; }
        public string TipoGasto { get; set; }
        public string Descripcion { get; set; }
    }
}
