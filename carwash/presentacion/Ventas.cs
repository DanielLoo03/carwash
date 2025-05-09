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
    public partial class Ventas : Form
    {

        private InfoVenta infoVentaAlta = new InfoVenta();

        public Ventas()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnConfigVentas_Click(object sender, EventArgs e)
        {
            ConfigVenta vtnConfigVenta = new ConfigVenta();
            vtnConfigVenta.ShowDialog();
        }

        private void btnAddVenta_Click(object sender, EventArgs e)
        {
            AltaVenta vtnAltaVenta = new AltaVenta(infoVentaAlta);
            vtnAltaVenta.ShowDialog();
        }

        private void Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {

                switch (e.KeyCode)
                {

                    case Keys.A:
                        btnAltaVenta.PerformClick();
                        break;

                    case Keys.C:
                       btnConfigVentas.PerformClick();
                        break;


                }

            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pnlContenido;
        }
    }
}
