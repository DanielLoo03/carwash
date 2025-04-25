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
    public partial class DatosPersonales : Form
    {
        private InfoEmpleado infoEmpleado;
        private ValidacionesUI validacionesUI = new ValidacionesUI();

        //Parametro infoEmpleado: Contiene la información introducida por el administrador. Se almacena para que no se pierdan los datos introducidos. 
        public DatosPersonales(InfoEmpleado infoEmpleado)
        {
            this.infoEmpleado = infoEmpleado;
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

            infoEmpleado.Nombre = txtNombre.Text;
            infoEmpleado.ApellidoPaterno = txtApellidoPaterno.Text;
            infoEmpleado.ApellidoMaterno = txtApellidoMaterno.Text;
            infoEmpleado.FechaNacimiento = dtFechaNacimiento.Value;
            infoEmpleado.NumTelefono = txtNumTelefono.Text;
            infoEmpleado.NumEmpleado = (int)nudNumEmpleado.Value;

            //Inicio de evaluaciones
            Boolean errorCapturado = false; //Bandera para decidir si pasar al siguiente formulario o no permitir el paso. 

            //Evaluación de campos obligatorios
            TextBox[] textBoxes = { txtNombre, txtApellidoPaterno, txtApellidoMaterno, txtNumTelefono };
            if (validacionesUI.EvalTxtVacios(textBoxes))
            {

                Toast toast = new Toast("error", "Los campos obligatorios deben ser llenados (los que tienen el *)");
                toast.Show();
                errorCapturado = true;

            }
            //Evaluación de exceso de caracteres
            TextBox[] textBoxes50 = { txtNombre, txtApellidoPaterno, txtApellidoMaterno }; //Los textBoxes que su limite de caracteres es de 50
            if (validacionesUI.EvalTxtChars(textBoxes, 50)) {

                Toast toast = new Toast("error", "Los campos nombre, apellido paterno y apellido materno no admiten más de 50 caracteres");
                toast.Show();
                errorCapturado = true;

            }
            //No se puede utilizar el validador de exceso de caracteres ya que necesitamos validar si el tamaño es de un valor exacto, no si excede cierto número.
            if (txtNumTelefono.Text.Length != 10) {

                Toast toast = new Toast("error", "El número de teléfono debe ser de 10 dígitos.");
                toast.Show();
                errorCapturado = true;

            }
            //Evaluación de caracteres especiales
            //Se pasa el parametro textBoxes50 ya que coincide con los campos que se deben de evaluar con los caracteres especiales.
            if (validacionesUI.EvalTxtCharsEspecial(textBoxes50)) {

                Toast toast = new Toast("error", "Los campos nombre, apellido paterno y apellido paterno no deben incluir caracteres especiales ni dígitos (!, @, #, 0, 1 etc.)");
                toast.Show();
                errorCapturado = true;

            }
            //Evaluación de número de empleado repetido
            if (validacionesUI.EvalNumEmpleado((int)nudNumEmpleado.Value)) {

                Toast toast = new Toast("error", "El número de empleado introducido ya se ha usado.");
                toast.Show();
                errorCapturado = true;

            }
            //Evaluación de mayoría de edad
            if (validacionesUI.EvalMayorEdad(dtFechaNacimiento.Value)) {

                Toast toast = new Toast("error", "El empleado es menor de edad.");
                toast.Show();
                errorCapturado = true;

            }
            //Fin validaciones

            //Si no se ha capturaro ningún error, entonces podemos pasar al siguiente formulario
            if (!errorCapturado) {

                Domicilio vtnDomicilio = new Domicilio(infoEmpleado);
                this.Hide();
                vtnDomicilio.ShowDialog();

            }

        }

        private void DatosPersonales_Load(object sender, EventArgs e)
        {

            txtNombre.Text = infoEmpleado.Nombre;
            txtApellidoPaterno.Text = infoEmpleado.ApellidoPaterno;
            txtApellidoMaterno.Text = infoEmpleado.ApellidoMaterno;
            dtFechaNacimiento.Text = infoEmpleado.FechaNacimiento.ToString("yyyy-MM-dd");
            txtNumTelefono.Text = infoEmpleado.NumTelefono;
            nudNumEmpleado.Text = infoEmpleado.NumEmpleado.ToString();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblApellidoPaterno_Click(object sender, EventArgs e)
        {

        }
    }
}
