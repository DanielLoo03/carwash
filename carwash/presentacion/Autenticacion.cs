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
    public partial class Autenticacion : Form
    {
        public Autenticacion()
        {
            InitializeComponent();
            //Se cargan fuentes para Form desde los recursos de la capa (resources.resx)
            labelCarWash.Font = Fuentes.obtenerFuente(64, FontStyle.Bold, "Inter");
            labelLeo.Font = Fuentes.obtenerFuente(64, FontStyle.Bold, "Inter");
            labelInicioDeSesion.Font = Fuentes.obtenerFuente(36, FontStyle.Regular, "Nacelle");
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {

        }

    }
}
