﻿using System;
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
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnConfigVentas_Click(object sender, EventArgs e)
        {
            ConfigVenta vtnConfigVenta = new ConfigVenta();
            vtnConfigVenta.ShowDialog();
        }

        private void btnAddVenta_Click(object sender, EventArgs e)
        {
            AltaVenta vtnAltaVenta = new AltaVenta();
            vtnAltaVenta.ShowDialog();
        }
    }
}
