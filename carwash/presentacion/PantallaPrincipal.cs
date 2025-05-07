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
    public partial class PantallaPrincipal : Form
    {
        private Autenticacion vtnAutenticacion;

        public PantallaPrincipal(Autenticacion vtnAutenticacion)
        {
            this.vtnAutenticacion = vtnAutenticacion;
            InitializeComponent();

        }

        private void imgGestionEmpleados_Click(object sender, EventArgs e)
        {
            CargarForm(new GestionEmpleado());
        }

        private void imgVentas_Click(object sender, EventArgs e)
        {

            CargarForm(new Ventas());

        }

        private void imgCorteCaja_Click(object sender, EventArgs e)
        {

            //CargarForm(new CorteCaja());

        }

        private void imgGestionInventario_Click(object sender, EventArgs e)
        {

            //CargarForm(new GestionInventario());

        }

        private void imgGestionAdmins_Click(object sender, EventArgs e)
        {
            //CargarForm(new GestionInventario());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            vtnAutenticacion.Show();
            this.Hide();
        }

        private void PantallaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            //No hay para la tecla F1 ya que te redirige donde mismo, módulo de gestión de empleados

            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnGestionEmpleados.PerformClick(); 
                    break;

                case Keys.F2:
                    btnVentas.PerformClick();
                    break;

                case Keys.F3:
                    btnCorteCaja.PerformClick();
                    break;

                case Keys.F4:
                    btnGestionInventario.PerformClick();
                    break;

                case Keys.F5:
                    btnGestionAdmins.PerformClick();
                    break;

                case Keys.F6:
                    btnCerrarSesion.PerformClick();
                    break;

            }

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            this.Close();
            vtnAutenticacion.Show();

        }

        // Funcion para cargar ventana en pantalla principal
        // Recibe como parametro el Form que se quiere cargar
        private void CargarForm(Object formHijo)
        {
            if (this.pnlContenido.Controls.Count > 0)
                this.pnlContenido.Controls.RemoveAt(0);

            Form formNuevo = formHijo as Form;
            formNuevo.TopLevel = false;
            formNuevo.Dock = DockStyle.Fill;

            this.pnlContenido.Controls.Add(formNuevo);
            this.pnlContenido.Tag = formNuevo;

            formNuevo.Show();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            CargarForm(new GestionEmpleado());
        }
    }
}
