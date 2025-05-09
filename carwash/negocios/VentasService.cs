using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistencia;

namespace negocios
{
    public class VentasService
    {

        private VentasDAO ventasDAO = new VentasDAO();

        public void AltaVenta(string marcaCarro, string modeloCarro, string colorCarro, decimal precio, decimal gan, decimal corresp, int numEmp, DateTime fechaVenta) {

            ventasDAO.AltaVenta(marcaCarro, modeloCarro, colorCarro, precio, gan, corresp, numEmp, fechaVenta);
        
        }

        public DataTable ConsNumEmp(string nom, string apellidoPaterno, string apellidoMaterno) {

            return ventasDAO.ConsNumEmp(nom, apellidoPaterno, apellidoMaterno);
        
        }

        public DataTable ConsNomEmp(int numEmp) {

            return ventasDAO.ConsNomEmp(numEmp);

        }

        public void ModPorGan(int por) {

            ventasDAO.ModPorGan(por);
        
        }

        public void ModPorCorresp(int por) {

            ventasDAO.ModPorCorresp(por);

        }

        public DataTable ConsPor()
        {

            return ventasDAO.ConstPor();

        }

        public DataTable ConsNomCompletos() {

            return ventasDAO.ConsNomCompletos();
        
        }

    }
}
