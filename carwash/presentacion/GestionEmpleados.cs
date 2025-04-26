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
    public partial class GestionEmpleados : Form
    {
        private Autenticacion vtnAutenticacion;
        private InfoEmpleado infoEmpleado = new InfoEmpleado();
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();

        public GestionEmpleados(Autenticacion vtnAutenticacion)
        {
            this.vtnAutenticacion = vtnAutenticacion;
            infoEmpleado.FechaNacimiento = DateTime.Today;
            InitializeComponent();
        }

        private void imgGestionEmpleados_Click(object sender, EventArgs e)
        {
            //No se debe hacer nada, ya nos encontramos en el módulo correspondiente.
        }

        private void imgVentas_Click(object sender, EventArgs e)
        {

            //Ventas vtnVentas = new Ventas();
            //vtnVentas.Show();
            //this.Hide();

        }

        private void imgCorteCaja_Click(object sender, EventArgs e)
        {

            //CorteCaja vtnCorteCaja = new CorteCaja();
            //vtnCorteCaja.Show();
            //this.Hide();

        }

        private void imgGestionInventario_Click(object sender, EventArgs e)
        {

            //GestionInventario vtnGestionInventario = new GestionInventario();
            //vtnGestionInventario.Show();
            //this.Hide();

        }

        private void imgGestionAdmins_Click(object sender, EventArgs e)
        {
            //GestionAdmins vtnGestionAdmins = new GestionAdmins();
            //vtnGestionAdmins.Show();
            //this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            vtnAutenticacion.Show();
            this.Hide();
        }

        private void btnAddEmpleado_Click(object sender, EventArgs e)
        {
            //Parámetro infoEmpleado: Se almacena la info introducida en el formulario para recuperarla después
            DatosPersonales vtnDatosPersonales = new DatosPersonales(infoEmpleado);
            vtnDatosPersonales.EmpleadoAgregado += (s, ev) => {
                logicaNegocios.ConsultEmpleados(tblEmpleados);
                if (lblNoEmpleados.Visible == true) {

                    lblNoEmpleados.Visible = false;

                }
            };
            vtnDatosPersonales.ShowDialog();

        }

        private void GestionEmpleados_KeyDown(object sender, KeyEventArgs e)
        {
            //No hay para la tecla F1 ya que te redirige donde mismo, módulo de gestión de empleados

            switch (e.KeyCode)
            {

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

        private void GestionEmpleados_Load(object sender, EventArgs e)
        {
            //Condición: Si no hay empleados dados de alta en la base de datos 
            if (!logicaNegocios.ConsultEmpleados(tblEmpleados))
            {

                lblNoEmpleados.Visible = true;

            }

        }
    }
}
