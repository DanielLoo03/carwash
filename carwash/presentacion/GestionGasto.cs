using Mysqlx.Cursor;
using negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class GestionGasto : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private InfoGasto infoGasto = new InfoGasto();
        private string nomUsuario;
        public GestionGasto(string nomUsuario)
        {
            this.nomUsuario = nomUsuario;
            InitializeComponent();
        }

        private void btnAltaGas_Click(object sender, EventArgs e)
        {
            AltaModGasto vtnAltaModGasto = new AltaModGasto(infoGasto, "alta", nomUsuario);
            vtnAltaModGasto.Show();
        }

        private void cbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empSelec = "";

            //Condicion: Si el cb no esta vacio y tiene items cargados
            if (cbEmp.SelectedItem != null && cbEmp.Items.Count > 0)
            {
                empSelec = cbEmp.SelectedItem.ToString();

                string[] partes = empSelec.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string apellidoMaterno = "";
                string apellidoPaterno = "";
                string nombre = "";

                if (partes.Length >= 3)
                {
                    apellidoMaterno = partes[^1];       // Último elemento
                    apellidoPaterno = partes[^2];       // Penúltimo
                    nombre = string.Join(" ", partes[..^2]); // Todo lo anterior como nombre
                }

                int? numEmp = logicaNegocios.ObtenerNumEmpleado(nombre, apellidoPaterno, apellidoMaterno);
                
                //COndicion: Si contiene un valor ( !null )
                if (numEmp.HasValue)
                {
                    DateTime fechaSelec = dtFechaGas.Value.Date;
                    decimal monto = logicaNegocios.ConsCorrespTotal(fechaSelec, numEmp.Value);
                    lblCorrespEmp.Text = monto.ToString("C");
                }

            }
        }

        private void dtFechaGas_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void GestionGasto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            //Limpia el cb empleados para cada dia seleccionado
            cbEmp.Items.Clear();
            lblCorrespEmp.Text = "---";

            DateTime fechaSelec = dtFechaGas.Value.Date;

            decimal gan = logicaNegocios.ConsGanTotal(fechaSelec);

            //En caso de que haya ventas se mostrara la ganancia en el lblGanDia
            if (gan > 0)
            {
                lblGanDia.Text = gan.ToString("C");
                lblNoGan.Visible = false;
            }
            else
            {
                lblNoGan.Visible = true;
                lblGanDia.Text = "---";
            }


            if (logicaNegocios.GetEmpPorFecha(fechaSelec).Count > 0)
            {
                List<String> emps = new List<String>();

                List<int> numsEmp = logicaNegocios.GetEmpPorFecha(fechaSelec);
                foreach (int numEmp in numsEmp)
                {
                    string nombre = logicaNegocios.GetNomEmp(numEmp);
                    emps.Add(nombre);
                }

                cbEmp.Items.AddRange(emps.ToArray()); // Agrega la lista de nombres al ComboBox
                cbEmp.SelectedIndex = 0;
            }
        }
    }
}
