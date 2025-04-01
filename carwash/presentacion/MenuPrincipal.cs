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
    public partial class MenuPrincipal : Form
    {
        private Form ventanaAutenticacion;

        public MenuPrincipal(Form ventanaAutenticacion)
        {
            InitializeComponent();
            this.ventanaAutenticacion = ventanaAutenticacion;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaAutenticacion.Show();

        }
    }
}
