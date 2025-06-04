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

        public List<decimal> ConsCorrespTotal(DateTime fecha, int emp)
        {
            return gastoDAO.ConsCorrespTotal(fecha, emp);
        }

        public List<decimal> ConsGanTotal(DateTime fecha)
        {
            return gastoDAO.ConsGanTotal(fecha);
        }

        public List<string> GetNomsEmp()
        {
            return gastoDAO.GetNomsEmp();
        }

        public int? ObtenerNumEmpleado(string nombres, string apellidoPat, string apellidoMat)
        {
            return gastoDAO.ObtenerNumEmpleado(nombres, apellidoPat, apellidoMat);
        }

    }
}
