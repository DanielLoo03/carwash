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
    public partial class Domicilio : Form
    {

        private InfoEmpleado infoEmpleado;
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        public event EventHandler EmpleadoAgregado; //Es público por que debe ser visible para el Form DatosPersonales
        public event EventHandler EmpleadoModificado; //Es público por que debe ser visible para el Form DatosPersonales
        private string accion;

        public Domicilio(InfoEmpleado infoEmpleado, string accion)
        {
            this.infoEmpleado = infoEmpleado;
            this.accion = accion;
            InitializeComponent();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            infoEmpleado.Calle = txtCalle.Text;
            infoEmpleado.Colonia = txtColonia.Text;
            infoEmpleado.NumInterior = txtNumInterior.Text;
            infoEmpleado.NumExterior = txtNumExterior.Text;
            infoEmpleado.CodigoPostal = txtCodigoPostal.Text;

            //Inicio de evaluaciones
            Boolean errorCapturado = false; //Bandera para decidir si pasar al siguiente formulario o no permitir el paso. 

            //Evaluación de código postal
            if (validacionesUI.EvalCodigoPostal(txtCodigoPostal.Text))
            {

                Toast toast = new Toast("error", "Código postal inválido.");
                toast.Show();
                errorCapturado = true;

            }

            //Evaluación de campos obligatorios
            TextBox[] textBoxes = { txtCalle, txtCodigoPostal, txtColonia, txtNumExterior };
            if (validacionesUI.EvalTxtVacios(textBoxes)) {

                Toast toast = new Toast("error", "Los campos obligatorios deben ser llenados (los que tienen el *)");
                toast.Show();
                errorCapturado = true;

            }

            //Evaluación de exceso de caracteres
            TextBox[] textBoxes50 = { txtCalle, txtColonia }; //Campos que su límite de caracteres es de 50
            if (validacionesUI.EvalTxtChars(textBoxes50, 50)) {

                Toast toast = new Toast("error", "Los campos calle y colonia no pueden exceder los 50 caracteres.");
                toast.Show();
                errorCapturado = true;

            }
            TextBox[] textBox4 = { txtNumExterior }; //Solo un campo tiene un límite de 4 caracteres
            if(validacionesUI.EvalTxtChars(textBox4, 4)){

                Toast toast = new Toast("error", "El campo número exterior no puede exceder los 4 caracteres.");
                toast.Show();
                errorCapturado = true;

            }
            //No se utiliza el validador de exceso de caracteres ya que se evalua una desigualdad, no un exceso.
            if(txtCodigoPostal.Text.Length != 5){

                Toast toast = new Toast("error", "El código postal debe consistir de 5 dígitos.");
                toast.Show();
                errorCapturado = true;

            }
            //Fin validaciones

            //Si no se ha capturaro ningún error, entonces podemos agregar al empleado
            if (!errorCapturado)
            {

                switch (accion)
                {
                    case "agregar":
                        logicaNegocios.AltaEmpleado(
                            infoEmpleado.Nombre,
                            infoEmpleado.ApellidoPaterno,
                            infoEmpleado.ApellidoMaterno,
                            infoEmpleado.NumTelefono,
                            infoEmpleado.NumEmpleado,
                            infoEmpleado.FechaNacimiento,
                            infoEmpleado.Calle,
                            infoEmpleado.Colonia,
                            infoEmpleado.NumInterior,
                            infoEmpleado.NumExterior,
                            infoEmpleado.CodigoPostal
                        );
                        Toast toastAgregar = new Toast("exito", "Empleado agregado con éxito.");
                        toastAgregar.Show();
                        break;

                    case "modificar":
                        logicaNegocios.ModEmpleados(
                            infoEmpleado.Nombre,
                            infoEmpleado.ApellidoPaterno,
                            infoEmpleado.ApellidoMaterno,
                            infoEmpleado.NumTelefono,
                            infoEmpleado.NumEmpleado,
                            infoEmpleado.FechaNacimiento,
                            infoEmpleado.Calle,
                            infoEmpleado.Colonia,
                            infoEmpleado.NumInterior,
                            infoEmpleado.NumExterior,
                            infoEmpleado.CodigoPostal
                        );
                        Toast toastModificar = new Toast("exito", "Empleado modificado con éxito.");
                        toastModificar.Show();
                        break;

                }
                //Se invoca el evento para avisar a GestionEmpleados que se registró un empleado
                EmpleadoAgregado?.Invoke(this, EventArgs.Empty);
                this.Close();

            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Hide();
            DatosPersonales vtnDatosPersonales = new DatosPersonales(infoEmpleado, accion);
            vtnDatosPersonales.ShowDialog();

        }
    }
}
