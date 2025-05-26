using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;

namespace presentacion
{
    public partial class CorteCaja : Form
    {

        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private InfoCorteCaja infoCorte = new InfoCorteCaja();
        private string nomUsuario;

        public CorteCaja(string nomUsuario)
        {
            this.nomUsuario = nomUsuario;
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnRealizarCorte_Click(object sender, EventArgs e)
        {

            //Si ya hay corte de caja en el día, no permitas realizarlo
            if (logicaNegocios.YaHayCorte(txtContado))
            {

                MessageBox.Show("Ya existe un corte de caja realizado el día" + DateTime.Today);

            }
            //Si no hay corte de caja en el día, permite realizarlo 
            else
            {

                AltaCorte vtnAltaCorte = new AltaCorte(infoCorte, nomUsuario);
                vtnAltaCorte.ShowDialog();

            }

        }

        private void CorteCaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {

                if (e.KeyCode == Keys.R)
                {

                    btnRealizarCorte.PerformClick();

                }

            }
        }

        private void CorteCaja_Load(object sender, EventArgs e)
        {
            //Pone el foco en CorteCaja para que funcionen los atajos con el teclado
            this.Activate(); 
            this.Focus();
        }
    }
}
