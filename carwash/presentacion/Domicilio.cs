using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;

namespace presentacion
{
    public partial class Domicilio : Form
    {

        private InfoEmpleado infoEmpleado;
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        public event EventHandler EmpleadoAgregado; //Es público por que debe ser visible para el Form DatosPersonales
        private string accion;
        private int numEmpleadoActual;

        public Domicilio(InfoEmpleado infoEmpleado, string accion, int numEmpleadoActual)
        {
            this.infoEmpleado = infoEmpleado;
            this.accion = accion;
            InitializeComponent();
            this.KeyPreview = true;
            this.numEmpleadoActual = numEmpleadoActual;
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void Domicilio_Load(object sender, EventArgs e)
        {

            txtCalle.Text = infoEmpleado.Calle;
            txtColonia.Text = infoEmpleado.Colonia;
            txtNumInterior.Text = infoEmpleado.NumInterior;
            txtNumExterior.Text = infoEmpleado.NumExterior;
            txtCodigoPostal.Text = infoEmpleado.CodigoPostal;

        }

        private void guardarDatos() {

            infoEmpleado.Calle = txtCalle.Text.ToUpper();
            infoEmpleado.Colonia = txtColonia.Text.ToUpper();
            infoEmpleado.NumInterior = txtNumInterior.Text;
            infoEmpleado.NumExterior = txtNumExterior.Text;
            infoEmpleado.CodigoPostal = txtCodigoPostal.Text;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //Se guardan datos introducidos en objeto infoEmpleado
            guardarDatos();

            //Inicio de evaluaciones
            Boolean errorCapturado = false; //Bandera para decidir si pasar al siguiente formulario o no permitir el paso. 

            TextBox[] textBoxesCalle = { txtCalle};
            if (validacionesUI.EvalTxtVacios(textBoxesCalle))
            {

                Toast toast = new Toast("error", "El campo de calle es obligatorio y debe ser llenado");
                toast.Show();
                errorCapturado = true;
                return;

            }
            if (validacionesUI.EvalTxtChars(textBoxesCalle, 50))
            {

                Toast toast = new Toast("error", "El campo de calle no pueden exceder los 50 caracteres.");
                toast.Show();
                errorCapturado = true;
                return;

            }


            TextBox[] textBoxesCol = {txtColonia };
            if (validacionesUI.EvalTxtVacios(textBoxesCol))
            {

                Toast toast = new Toast("error", "El campo de colonia es obligatorio y debe ser llenado");
                toast.Show();
                errorCapturado = true;
                return;

            }
            if (validacionesUI.EvalTxtChars(textBoxesCol, 50))
            {

                Toast toast = new Toast("error", "El campo de colonia no pueden exceder los 50 caracteres.");
                toast.Show();
                errorCapturado = true;
                return;

            }


            TextBox[] textBoxNumE = { txtNumExterior };
            if (validacionesUI.EvalTxtChars(textBoxNumE, 4))
            {

                Toast toast = new Toast("error", "El campo de número exterior no pueden exceder los 4 caracteres.");
                toast.Show();
                errorCapturado = true;
                return;
            }
            TextBox[] textBoxesNums = {txtNumExterior};
            foreach (TextBox textBox in textBoxesNums)
            {

                //El segundo parámetro es una expresión regular que considera todos los caracteres que no sean dígitos
                if (Regex.IsMatch(textBox.Text, @"[^0-9]"))
                {

                    Toast toast = new Toast("error", "El campo número exterior solo debe consistir de dígitos.");
                    toast.Show();
                    errorCapturado = true;
                    return;

                }

            }


            TextBox[] textBoxNumI = { txtNumExterior, txtNumInterior };
            if (validacionesUI.EvalTxtChars(textBoxNumI, 4))
            {

                Toast toast = new Toast("error", "El campo de número interior no pueden exceder los 4 caracteres.");
                toast.Show();
                errorCapturado = true;
                return;
            }
            TextBox[] textBoxesNumI = {txtNumInterior };
            foreach (TextBox textBox in textBoxesNumI)
            {

                //El segundo parámetro es una expresión regular que considera todos los caracteres que no sean dígitos
                if (Regex.IsMatch(textBox.Text, @"[^0-9]"))
                {

                    Toast toast = new Toast("error", "El campo número interior solo debe consistir de dígitos.");
                    toast.Show();
                    errorCapturado = true;
                    return;

                }

            }


            TextBox[] textBoxesNumP = { txtCodigoPostal };
            if (validacionesUI.EvalTxtVacios(textBoxesNumP))
            {

                Toast toast = new Toast("error", "El campo de codigo postal es obligatorio y debe ser llenado");
                toast.Show();
                errorCapturado = true;
                return;

            }
            TextBox[] textBoxesNumPo = { txtCodigoPostal};
            foreach (TextBox textBox in textBoxesNumPo)
            {

                if (Regex.IsMatch(textBox.Text, @"[^0-9]"))
                {

                    Toast toast = new Toast("error", "El campo código postal solo debe consistir de dígitos.");
                    toast.Show();
                    errorCapturado = true;
                    return;

                }

            }
            //Evaluación de código postal
            if (validacionesUI.EvalCodigoPostal(txtCodigoPostal.Text))
            {

                Toast toast = new Toast("error", "El código postal debe consistir de 5 dígitos.");
                toast.Show();
                errorCapturado = true;
                return;

            }


            //Fin validaciones

            //Si no se ha capturaro ningún error, entonces podemos agregar/modificar al empleado
            if (!errorCapturado)
            {

                switch (accion)
                {
                    case "agregar":
                        logicaNegocios.AltaEmpleado(
                            infoEmpleado.Nombres,
                            infoEmpleado.ApellidoPaterno,
                            infoEmpleado.ApellidoMaterno,
                            infoEmpleado.NumTelefono,
                            infoEmpleado.NumEmpleado,
                            infoEmpleado.FechaNacimiento,
                            infoEmpleado.Calle,
                            infoEmpleado.Colonia,
                            infoEmpleado.NumExterior,
                            infoEmpleado.NumInterior,
                            infoEmpleado.CodigoPostal
                        );
                        Toast toastAgregar = new Toast("exito", "Empleado agregado con éxito.");
                        toastAgregar.Show();
                        break;

                    case "modificar":
                        logicaNegocios.ModEmpleados(
                            infoEmpleado.Nombres,
                            infoEmpleado.ApellidoPaterno,
                            infoEmpleado.ApellidoMaterno,
                            infoEmpleado.NumTelefono,
                            infoEmpleado.NumEmpleado,
                            infoEmpleado.FechaNacimiento,
                            infoEmpleado.Calle,
                            infoEmpleado.Colonia,
                            infoEmpleado.NumExterior,
                            infoEmpleado.NumInterior,
                            infoEmpleado.CodigoPostal
                        );
                        Toast toastModificar = new Toast("exito", "Empleado modificado con éxito.");
                        toastModificar.Show();
                        break;

                }
                //Se invoca el evento para avisar a GestionEmpleados que se registró un empleado
                EmpleadoAgregado?.Invoke(this, EventArgs.Empty);
                this.Close();

                //Se limpian campos
                infoEmpleado.Nombres = "";
                infoEmpleado.ApellidoPaterno = "";
                infoEmpleado.ApellidoMaterno = "";
                infoEmpleado.NumTelefono = "";
                infoEmpleado.NumEmpleado = 0;
                infoEmpleado.FechaNacimiento = DateTime.Today;
                infoEmpleado.Calle = "";
                infoEmpleado.Colonia = "";
                infoEmpleado.NumExterior = "";
                infoEmpleado.NumInterior = "";
                infoEmpleado.CodigoPostal = "";

            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Se guardan datos introducidos en objeto infoEmpleado
            guardarDatos();
            
            this.Hide();
            DatosPersonales vtnDatosPersonales = new DatosPersonales(infoEmpleado, accion);
            vtnDatosPersonales.ShowDialog();

        }

        private void Domicilio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C)
            {

                btnConfirmar.PerformClick();

            }
        }

        private void Domicilio_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Se guardan datos introducidos en objeto infoEmpleado
            guardarDatos();

        }
    }
}
