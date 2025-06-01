using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistencia;
using MySql.Data.MySqlClient;
using System.Data;

namespace negocios
{
    public class CorteService
    {

        private CorteDAO corteDAO = new CorteDAO();

        public void AltaCorte(DateTime fechaCorte, int idAdmin, decimal contado, decimal calculado, decimal diferencia) {

            corteDAO.AltaCorte(fechaCorte, idAdmin, contado, calculado, diferencia);
        
        }

        public DataTable ObtenerIdAdmin(string nombreUsuario)
        {

            return corteDAO.ObtenerIdAdmin(nombreUsuario);

        }

        public DataTable ConsCorte(DateTime fechaCorte) {

            return corteDAO.ConsCorte(fechaCorte);
        
        }

        public DataTable ObtNomUsuario(int id) {

            return corteDAO.ObtNomUsuario(id);
        
        }

        public DataTable ConsCaja() {

            return corteDAO.ConsCaja();
        
        }

    }
}
