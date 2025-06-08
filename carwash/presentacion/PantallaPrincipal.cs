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
        private String nomUsuario;

        public PantallaPrincipal(Autenticacion vtnAutenticacion, String nomUsuario)
        {
            this.vtnAutenticacion = vtnAutenticacion;
            this.nomUsuario = nomUsuario;
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            lblGestionEmpleados.Font = new Font(btnGestionEmpleados.Font, FontStyle.Underline);

        }

        private void imgGestionEmpleados_Click(object sender, EventArgs e)
        {
            CargarForm(new GestionEmpleado(this.nomUsuario));
            lblGestionEmpleados.Font = new Font(btnGestionEmpleados.Font, FontStyle.Underline);
            lblVentas.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblCorteCaja.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGastos.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGestionAdmins.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
        }

        private void imgVentas_Click(object sender, EventArgs e)
        {

            CargarForm(new Ventas(this.nomUsuario));
            lblGestionEmpleados.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblVentas.Font = new Font(btnGestionEmpleados.Font, FontStyle.Underline);
            lblCorteCaja.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGastos.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGestionAdmins.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);

        }

        private void imgCorteCaja_Click(object sender, EventArgs e)
        {

            CargarForm(new CorteCaja(nomUsuario));
            lblGestionEmpleados.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblVentas.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblCorteCaja.Font = new Font(btnGestionEmpleados.Font, FontStyle.Underline);
            lblGastos.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGestionAdmins.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);

        }

        private void imgGestionInventario_Click(object sender, EventArgs e)
        {
            /*
            CargarForm(new GestionInventario());
            lblGestionEmpleados.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblVentas.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblCorteCaja.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGastos.Font = new Font(btnGestionEmpleados.Font, FontStyle.Underline);
            lblGestionAdmins.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            */
        }

        private void imgGestionAdmins_Click(object sender, EventArgs e)
        {
            CargarForm(new GestionAdmin(this.nomUsuario));
            lblGestionEmpleados.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblVentas.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblCorteCaja.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGastos.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGestionAdmins.Font = new Font(btnGestionEmpleados.Font, FontStyle.Underline);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            CargarForm(new GestionGasto(nomUsuario));
            lblGestionEmpleados.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblVentas.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblCorteCaja.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
            lblGastos.Font = new Font(btnGestionEmpleados.Font, FontStyle.Underline);
            lblGestionAdmins.Font = new Font(btnGestionEmpleados.Font, FontStyle.Regular);
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
                    btnGastos.PerformClick();
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
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarForm(new GestionEmpleado(this.nomUsuario));
            this.lblAdminActual.Text = this.nomUsuario;

            this.FormBorderStyle = FormBorderStyle.None;      // Quita los bordes de la ventana
            this.WindowState = FormWindowState.Maximized;     // Maximiza la ventana
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
