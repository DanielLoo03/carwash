using persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocios
{
    public class GastoService
    {
        //Proviene de la capa de persistencia
        private GastoDAO gastoDAO = new GastoDAO();

        public void AltaGasto(DateTime fechaGasto, DateTime fechaReg, decimal monto, string tipoGasto, string descripcion, int idAdmin)
        {
            gastoDAO.AltaGasto(fechaGasto, fechaReg, monto, tipoGasto, descripcion, idAdmin);
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

        public List<int> GetEmpPorFecha(DateTime fecha)
        {
            return gastoDAO.GetEmpPorFecha(fecha);
        }

        public string GetNomEmp(int numEmp)
        {
            return gastoDAO.GetNomEmp(numEmp);
        }

        public int? ObtenerNumEmpleado(string noms, string apellidoPat, string apellidoMat)
        {
            return gastoDAO.ObtenerNumEmpleado(noms, apellidoPat, apellidoMat);
        }

        public List<decimal> GetPreciosPorFecha(DateTime fecha)
        {
            return gastoDAO.GetPreciosPorFecha(fecha);
        }

        public List<decimal> GetMontPorFecha(DateTime fecha)
        {
            return gastoDAO.GetMontPorFecha(fecha);
        }

        public DataTable ConsGas(DateTime fecha)
        {
            return gastoDAO.ConsGas(fecha);
        }

        public void ModGasto(int idGasto, DateTime fechaGas, decimal monto, string tipoGasto, string descripcion, int idAdmin)
        {
            gastoDAO.ModGasto(idGasto, fechaGas, monto, tipoGasto, descripcion, idAdmin);
        }

        public List<decimal> GetMontGan(DateTime fecha)
        {
            return gastoDAO.GetMontGan(fecha);
        }

        public void CanGasto(int id)
        {
            gastoDAO.CanGasto(id);
        }

        public DataTable ConsGasAct(DateTime fecha)
        {
            return gastoDAO.ConsGasAct(fecha);
        }
    }
}
