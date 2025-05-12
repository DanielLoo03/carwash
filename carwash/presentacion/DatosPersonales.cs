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
    public partial class DatosPersonales : Form
    {
        private InfoEmpleado infoEmpleado;
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        public event EventHandler EmpleadoAgregado; //Público por que debe de ser accesible para GestionEmpleados
        private string accion;
        private int numEmpleadoActual = 0;

        //Parametro infoEmpleado: Contiene la información introducida por el administrador. Se almacena para que no se pierdan los datos introducidos. 
        public DatosPersonales(InfoEmpleado infoEmpleado, string accion)
        {
            this.infoEmpleado = infoEmpleado;
            this.accion = accion;
            InitializeComponent();
            this.KeyPreview = true;
            btnContinuar.DialogResult = DialogResult.None;

            //Si vamos a modificar el empleado, no deberia de permitirse modificar el número de empleado
            if (accion.Equals("modificar"))
            {

                nudNumEmpleado.Enabled = false;

            }

        }

        private void guardarDatos() {

            infoEmpleado.Nombre = txtNombre.Text.ToUpper();
            infoEmpleado.ApellidoPaterno = txtApellidoPaterno.Text.ToUpper();
            infoEmpleado.ApellidoMaterno = txtApellidoMaterno.Text.ToUpper();
            infoEmpleado.FechaNacimiento = dtFechaNacimiento.Value;
            infoEmpleado.NumTelefono = mtxtNumTelefono.Text;
            infoEmpleado.NumEmpleado = (int)nudNumEmpleado.Value;

        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {

            //Se guardan datos en objeto infoEmpleado
            guardarDatos();

            //Inicio de evaluaciones
            Boolean errorCapturado = false; //Bandera para decidir si pasar al siguiente formulario o no permitir el paso. 

            //Evaluación de campos obligatorios
            TextBox[] textBoxes = { txtNombre, txtApellidoPaterno, txtApellidoMaterno };
            if (validacionesUI.EvalTxtVacios(textBoxes) || string.IsNullOrWhiteSpace(mtxtNumTelefono.Text))
            {

                Toast toast = new Toast("error", "Los campos obligatorios deben ser llenados (los que tienen el *)");
                toast.Show();
                errorCapturado = true;

            }
            //Evaluación de exceso de caracteres
            TextBox[] textBoxes50 = { txtNombre, txtApellidoPaterno, txtApellidoMaterno }; //Los textBoxes que su limite de caracteres es de 50
            if (validacionesUI.EvalTxtChars(textBoxes, 50))
            {

                Toast toast = new Toast("error", "Los campos nombre, apellido paterno y apellido materno no admiten más de 50 caracteres");
                toast.Show();
                errorCapturado = true;

            }
            //No se puede utilizar el validador de exceso de caracteres ya que necesitamos validar si el tamaño es de un valor exacto, no si excede cierto número.
            if (mtxtNumTelefono.Text.Length != 12)
            {

                Toast toast = new Toast("error", "El número de teléfono debe ser de 10 dígitos.");
                toast.Show();
                errorCapturado = true;

            }
            //Evaluación de caracteres especiales
            //Se pasa el parametro textBoxes50 ya que coincide con los campos que se deben de evaluar con los caracteres especiales.
            if (validacionesUI.EvalTxtCharsEspecial(textBoxes50))
            {

                Toast toast = new Toast("error", "Los campos nombre, apellido paterno y apellido paterno no deben incluir caracteres especiales ni dígitos (!, @, #, 0, 1 etc.)");
                toast.Show();
                errorCapturado = true;

            }
            //Si se modifica el número de empleado, evaluar
            if (numEmpleadoActual != nudNumEmpleado.Value)
            {

                //Evaluación de número de empleado repetido
                if (validacionesUI.EvalNumEmpleado((int)nudNumEmpleado.Value))
                {

                    Toast toast = new Toast("error", "El número de empleado introducido ya se ha usado.");
                    toast.Show();
                    errorCapturado = true;

                }

            }
            //Evaluación de mayoría de edad
            if (validacionesUI.EvalMayorEdad(dtFechaNacimiento.Value))
            {

                Toast toast = new Toast("error", "El empleado es menor de edad.");
                toast.Show();
                errorCapturado = true;

            }
            //Fin validaciones

            //Si no se ha capturaro ningún error, entonces podemos pasar al siguiente formulario
            if (!errorCapturado)
            {

                Domicilio vtnDomicilio = new Domicilio(infoEmpleado, accion, numEmpleadoActual);

                //Cuando Domicilio lanza el evento, DatosPersonales también lo hace
                vtnDomicilio.EmpleadoAgregado += (s, ev) => EmpleadoAgregado?.Invoke(this, ev);
                this.Close();
                vtnDomicilio.TopMost = true;
                vtnDomicilio.Show();
            }

        }

        private void DatosPersonales_Load(object sender, EventArgs e)
        {

            txtNombre.Text = infoEmpleado.Nombre;
            txtApellidoPaterno.Text = infoEmpleado.ApellidoPaterno;
            txtApellidoMaterno.Text = infoEmpleado.ApellidoMaterno;
            dtFechaNacimiento.Text = infoEmpleado.FechaNacimiento.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(infoEmpleado.NumTelefono))
            {

                mtxtNumTelefono.Text = infoEmpleado.NumTelefono;

            }
            else {

                mtxtNumTelefono.Text = logicaNegocios.QuitarGuiones(infoEmpleado.NumTelefono);

            }
            nudNumEmpleado.Text = infoEmpleado.NumEmpleado.ToString();

            numEmpleadoActual = infoEmpleado.NumEmpleado;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            //Se guardan datos en objeto infoEmpleado
            guardarDatos();


            this.Close();
        }

        private void lblApellidoPaterno_Click(object sender, EventArgs e)
        {

        }

        private void DatosPersonales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C)
            {

                btnContinuar.PerformClick();

            }
        }

        private void DatosPersonales_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Se guardan datos en objeto infoEmpleado
            guardarDatos();

        }
    }
}
