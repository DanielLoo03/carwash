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

            Ventas vtnVentas = new Ventas();
            vtnVentas.Show();
            this.Hide();

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
            DatosPersonales vtnDatosPersonales = new DatosPersonales(infoEmpleado, "agregar");
            vtnDatosPersonales.EmpleadoAgregado += (s, ev) =>
            {

                logicaNegocios.ConsultEmpleados(tblEmpleados);
                if (lblNoEmpleados.Visible == true)
                {

                    lblNoEmpleados.Visible = false;
                    tblEmpleados.Visible = true;

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
                tblEmpleados.Visible = false;

            }

        }

        private void btnModEmpleado_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = tblEmpleados.CurrentRow; //El empleado seleccionado para modificar
            //Condición: Si seleccionó a un empleado/fila de la tabla
            if (filaSeleccionada != null)
            {

                //Se cargan propiedades para pasarlos a los formularios y se cargen los datos del empleado seleccionado
                infoEmpleado.Nombre = (string)filaSeleccionada.Cells["nombre"].Value;
                infoEmpleado.ApellidoPaterno = (string)filaSeleccionada.Cells["apellidoPaterno"].Value;
                infoEmpleado.ApellidoMaterno = (string)filaSeleccionada.Cells["apellidoMaterno"].Value;
                infoEmpleado.NumTelefono = (string)filaSeleccionada.Cells["numTelefono"].Value;
                infoEmpleado.NumEmpleado = (int)filaSeleccionada.Cells["numEmpleado"].Value;
                infoEmpleado.FechaNacimiento = (DateTime)filaSeleccionada.Cells["fechaNacimiento"].Value;
                infoEmpleado.Calle = (string)filaSeleccionada.Cells["calle"].Value;
                infoEmpleado.Colonia = (string)filaSeleccionada.Cells["colonia"].Value;
                infoEmpleado.NumExterior = (string)filaSeleccionada.Cells["numExterior"].Value;
                infoEmpleado.NumInterior = (string)filaSeleccionada.Cells["numInterior"].Value;
                infoEmpleado.CodigoPostal = (string)filaSeleccionada.Cells["codigoPostal"].Value;

                DatosPersonales vtnDatosPersonales = new DatosPersonales(infoEmpleado, "modificar");
                vtnDatosPersonales.EmpleadoAgregado += (s, ev) =>
                {
                    logicaNegocios.ConsultEmpleados(tblEmpleados);
                };
                vtnDatosPersonales.ShowDialog();

            }
            else
            {

                Toast toast = new Toast("error", "No has seleccionado ningún empleado");

            }

        }

        private void btnElimEmpleado_Click(object sender, EventArgs e)
        {

            DataGridViewRow filaSeleccionada = tblEmpleados.CurrentRow;//El empleado seleccionado para eliminar
            //Condición: Si seleccionó a un empleado/fila de la tabla
            if (filaSeleccionada != null)
            {

                MessageBoxConfirmar messageBoxConfirmar = new MessageBoxConfirmar("¿Está seguro de eliminar al empleado " + (int)filaSeleccionada.Cells["numEmpleado"].Value + " | " + (string)filaSeleccionada.Cells["nombre"].Value + " " + (string)filaSeleccionada.Cells["apellidoPaterno"].Value + " " + (string)filaSeleccionada.Cells["apellidoMaterno"].Value + "?");
                messageBoxConfirmar.ConfirmarPresionado += (s, ev) =>
                {

                    logicaNegocios.ElimEmpleados((int)filaSeleccionada.Cells["numEmpleado"].Value);
                    Toast toast = new Toast("exito", "Empleado eliminado con éxito.");
                    toast.MostrarToast();
                    //Si hay 0 empleados disponibles actualmente (regresa false), mostrar label informativo
                    if (!logicaNegocios.ConsultEmpleados(tblEmpleados))
                    {

                        lblNoEmpleados.Visible = true;
                        tblEmpleados.Visible = false;

                    }

                };
                messageBoxConfirmar.mostrarMessageBox();

            }
            else
            {

                Toast toast = new Toast("error", "No has seleccionado ningún empleado.");

            }

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

            Ventas vtnVentas = new Ventas();
            vtnVentas.Show();
            this.Hide();

        }
    }
}
