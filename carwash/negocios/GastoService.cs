using persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocios
{
    public class GastoService
    {
        //Proviene de la capa de persistencia
        private GastoDAO gastoDAO = new GastoDAO();

        public void AltaGasto(DateTime fechaGasto, decimal monto, string tipoGasto, string descripcion, int idAdmin)
        {
            gastoDAO.AltaGasto(fechaGasto, monto, tipoGasto, descripcion, idAdmin);
        }

        public List<string> GetTiposGasto()
        {
            return gastoDAO.GetTiposGasto();
        }
    }
}
