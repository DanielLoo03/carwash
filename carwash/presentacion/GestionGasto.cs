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
    public partial class GestionGasto : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
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

        }
    }
}
