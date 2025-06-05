using negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class CorrespEmp : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        DateTime fechaSelec;
        public CorrespEmp(DateTime fechaSelec)
        {
            InitializeComponent();
            this.fechaSelec = fechaSelec;
        }

        private void lblGanEmp_Click(object sender, EventArgs e)
        {
        }

        private void CorrespEmp_Load(object sender, EventArgs e)
        {
            //Limpia el cb empleados para cada dia seleccionado
            cbEmp.Items.Clear();
            lblCorrespEmp.Text = "---";

            if (logicaNegocios.GetEmpPorFecha(fechaSelec).Count > 0)
            {
                lblNoGan.Visible = false;
                List<String> emps = new List<String>();

                List<int> numsEmp = logicaNegocios.GetEmpPorFecha(fechaSelec);
                foreach (int numEmp in numsEmp)
                {
                    string nom = logicaNegocios.GetNomEmp(numEmp);
                    emps.Add(nom);
                }

                cbEmp.Items.AddRange(emps.ToArray()); // Agrega la lista de nombres al ComboBox
                cbEmp.SelectedIndex = 0;
            }
            else
            {
                lblNoGan.Visible = true;
            }
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
                    decimal monto = logicaNegocios.ConsCorrespTotal(fechaSelec, numEmp.Value);
                    lblCorrespEmp.Text = monto.ToString("C");
                }
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
