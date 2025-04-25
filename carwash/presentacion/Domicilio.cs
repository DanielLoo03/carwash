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

        public Domicilio(InfoEmpleado infoEmpleado)
        {
            this.infoEmpleado = infoEmpleado;
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
            //Evaluación de código postal
            if (validacionesUI.EvalCodigoPostal(txtCodigoPostal.Text))
            {

                Toast toast = new Toast("Código postal inválido.");
                return;

            }

            //Evaluación de campos obligatorios
            TextBox[] textBoxes = { txtCalle, txtCodigoPostal, txtColonia, txtNumExterior };
            if (validacionesUI.EvalTxtVacios(textBoxes)) {

                Toast toast = new Toast("Los campos obligatorios deben ser llenados (los que tienen el *)");
                return;
            
            }

            //Evaluación de exceso de caracteres
            TextBox[] textBoxes50 = { txtCalle, txtColonia }; //Campos que su límite de caracteres es de 50
            if (validacionesUI.EvalTxtChars(textBoxes50, 50)) {

                Toast toast = new Toast("Los campos calle y colonia no pueden exceder los 50 caracteres.");
                return;

            }
            TextBox[] textBox4 = { txtNumExterior }; //Solo un campo tiene un límite de 4 caracteres
            if(validacionesUI.EvalTxtChars(textBox4, 4)){

                Toast toast = new Toast("El campo número exterior no puede exceder los 4 caracteres.");
                return;

            }
            //No se utiliza el validador de exceso de caracteres ya que se evalua una desigualdad, no un exceso.
            if(txtCodigoPostal.Text.Length != 5){

                Toast toast = new Toast("El código postal debe consistir de 5 dígitos.");
                return;

            }

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
            this.Close();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Hide();
            DatosPersonales vtnDatosPersonales = new DatosPersonales(infoEmpleado);
            vtnDatosPersonales.ShowDialog();

        }
    }
}
