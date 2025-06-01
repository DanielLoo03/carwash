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

            infoEmpleado.Nombres = txtNombre.Text.ToUpper();
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
            TextBox[] textBoxesNom = { txtNombre};
            if (validacionesUI.EvalTxtVacios(textBoxesNom) || string.IsNullOrWhiteSpace(mtxtNumTelefono.Text))
            {

                Toast toast = new Toast("error", "El nombre del empleado es obligatorio y debe ser llenado");
                toast.Show();
                errorCapturado = true;
                return;
            }
            //Los textBoxes que su limite de caracteres es de 50
            if (validacionesUI.EvalTxtChars(textBoxesNom, 50))
            {

                Toast toast = new Toast("error", "El campos nombres de empleado no admiten más de 50 caracteres");
                toast.Show();
                errorCapturado = true;
                return;
            }
            if (validacionesUI.EvalTxtCharsEspecial(textBoxesNom))
            {

                Toast toast = new Toast("error", "El campos nombre de empleado no deben incluir caracteres especiales ni dígitos (!, @, #, 0, 1 etc.)");
                toast.Show();
                errorCapturado = true;
                return;
            }


            TextBox[] textBoxesAP = {txtApellidoPaterno};
            if (validacionesUI.EvalTxtVacios(textBoxesAP) || string.IsNullOrWhiteSpace(mtxtNumTelefono.Text))
            {

                Toast toast = new Toast("error", "El apellido paterno del empleado es obligatorio y debe ser llenado");
                toast.Show();
                errorCapturado = true;
                return;
            }
            //Los textBoxes que su limite de caracteres es de 50
            if (validacionesUI.EvalTxtChars(textBoxesAP, 50))
            {

                Toast toast = new Toast("error", "El campos apellido paterno no admiten más de 50 caracteres");
                toast.Show();
                errorCapturado = true;
                return;
            }
            if (validacionesUI.EvalTxtCharsEspecial(textBoxesAP))
            {

                Toast toast = new Toast("error", "El campo de apellido paterno no deben incluir caracteres especiales ni dígitos (!, @, #, 0, 1 etc.)");
                toast.Show();
                errorCapturado = true;
                return;
            }


            TextBox[] textBoxesAM = { txtApellidoMaterno };
            if (validacionesUI.EvalTxtVacios(textBoxesAM) || string.IsNullOrWhiteSpace(mtxtNumTelefono.Text))
            {

                Toast toast = new Toast("error", "El apellido materno del empleado es obligatorio y debe ser llenado");
                toast.Show();
                errorCapturado = true;
                return;
            }
            //Los textBoxes que su limite de caracteres es de 50
            if (validacionesUI.EvalTxtChars(textBoxesAM, 50))
            {

                Toast toast = new Toast("error", "El campos apellido materno no admiten más de 50 caracteres");
                toast.Show();
                errorCapturado = true;
                return;
            }
            if (validacionesUI.EvalTxtCharsEspecial(textBoxesAM))
            {

                Toast toast = new Toast("error", "El campos apellido materno no deben incluir caracteres especiales ni dígitos (!, @, #, 0, 1 etc.)");
                toast.Show();
                errorCapturado = true;
                return;
            }


            //No se puede utilizar el validador de exceso de caracteres ya que necesitamos validar si el tamaño es de un valor exacto, no si excede cierto número.
            if (mtxtNumTelefono.Text.Length != 12)
            {

                Toast toast = new Toast("error", "El número de teléfono debe ser de 10 dígitos.");
                toast.Show();
                errorCapturado = true;
                return;
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
                    return;
                }

            }
            //Evaluación de mayoría de edad
            if (validacionesUI.EvalMayorEdad(dtFechaNacimiento.Value))
            {

                Toast toast = new Toast("error", "El empleado es menor de edad.");
                toast.Show();
                errorCapturado = true;
                return;
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
            dtFechaNacimiento.MaxDate = DateTime.Today.AddYears(-18); 

            dtFechaNacimiento.MinDate = DateTime.Today.AddYears(-100);

            
            DateTime nacimiento = infoEmpleado.FechaNacimiento;
            if (nacimiento >= dtFechaNacimiento.MinDate && nacimiento <= dtFechaNacimiento.MaxDate)
            {
                dtFechaNacimiento.Value = nacimiento; 
            }
            else
            {
                dtFechaNacimiento.Value = dtFechaNacimiento.MaxDate; 
            }

            txtNombre.Text = infoEmpleado.Nombres;
            txtApellidoPaterno.Text = infoEmpleado.ApellidoPaterno;
            txtApellidoMaterno.Text = infoEmpleado.ApellidoMaterno;

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
