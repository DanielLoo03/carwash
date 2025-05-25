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

        //Para saber si ya se realizó un corte en el día seleccionado
        public Boolean YaHayCorte(TextBox contado)
        {

            //Condición: Si el campo de contado (en la consulta de corte) se encuentra vacío, entonces todavía no se ha realizado corte
            if (string.IsNullOrEmpty(contado.Text))
            {

                return false;

            }
            //Condición: Si el campo de contado (en la consulta de corte) se encuentra lleno, entonces ya se realizó un corte
            else
            {

                return true;

            }

        }

    }
}
