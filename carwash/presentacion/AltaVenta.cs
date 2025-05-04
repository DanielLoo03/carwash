using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using negocios;

namespace presentacion
{
    public partial class AltaVenta : Form
    {

        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();

        public AltaVenta()
        {
            InitializeComponent();
        }

        private void AltaVenta_Load(object sender, EventArgs e)
        {

            cbNomEmpleado.DataSource = logicaNegocios.ConsNomEmpleados();
            cbNumEmpleado.DataSource = logicaNegocios.GetNumsEmpleado();

        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {

            //Inicio de validaciones
            Boolean errorCapturado = false; //Bandera para decidir si registrar la venta

            //Validación de caracteres especiales en campo color de carro
            if (validacionesUI.EvalCharsColor(txtColorCarro.Text))
            {

                Toast toast = new Toast("error", "El campo color de carro solo puede incluir letras");
                toast.Show();
                errorCapturado = true;

            }

            //Validación de solo números
            string[] posiblesNums = { txtPrecioCarro.Text, txtGanancia.Text, txtCorresp.Text };
            if (validacionesUI.EvalSoloNums(posiblesNums))
            {

                Toast toast = new Toast("error", "Los campos precio del carro, ganancia y correspondencia deben contener valores númericos.");
                toast.Show();
                errorCapturado = true;
                return;

            }

            //Validación de campos obligatorios
            //Si falla una transformación de string a float, se asigna a la variable respectiva el valor 0.0 (el validador marcará error)
            float precio;
            float.TryParse(txtPrecioCarro.Text, out precio);
            float gan;
            float.TryParse(txtGanancia.Text, out gan);
            float corresp;
            float.TryParse(txtCorresp.Text, out corresp);
            string nomCompleto = cbNomEmpleado.Text;
            int numEmp = int.Parse(cbNumEmpleado.Text);
            if (validacionesUI.EvalCamposObligatoriosVenta(precio, gan, corresp, nomCompleto, numEmp))
            {

                Toast toast = new Toast("error", "Los campos obligatorios deben ser llenados (los que tienen el *)");
                toast.Show();
                errorCapturado = true;

            }

            //Validaciones de precios inválidos
            if (validacionesUI.EvalMontos(precio))
            {

                Toast toast = new Toast("error", "El precio no puede ser igual a 0 o negativo.");
                toast.Show();
                errorCapturado = true;

            }
            if (validacionesUI.EvalMontos(gan))
            {

                Toast toast = new Toast("error", "La ganancia no puede ser igual a 0 o negativo.");
                toast.Show();
                errorCapturado = true;

            }
            if (validacionesUI.EvalMontos(corresp))
            {

                Toast toast = new Toast("error", "La correspondencia no puede ser igual a 0 o negativo.");
                toast.Show();
                errorCapturado = true;

            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecioCarro_TextChanged(object sender, EventArgs e)
        {
            int[] porcentajes = logicaNegocios.ConsPor();
            //Porcentajes[0] = % ganancia
            //Porcentajes[1] = % correspondencia
            float ganCalculada = logicaNegocios.CalcGan(float.Parse(txtGanancia.Text), porcentajes[0]);
            float correspCalculada = logicaNegocios.CalcCorresp(float.Parse(txtCorresp.Text), porcentajes[1]);
            txtGanancia.Text = ganCalculada.ToString();
            txtCorresp.Text = correspCalculada.ToString();

        }

        private void txtPrecioCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            //Si el caracter no es dígito ni un punto o un backspace, asumelo como manejado y no permitas que se escriba en el textBox
            if (!char.IsDigit(caracter) && caracter != '.' && !char.IsControl(caracter))
            {

                e.Handled = true;

            }

            //Solo permitir que se escriba un punto decimal
            if (caracter == '.' && ((sender as TextBox).Text.Contains(".")))
            {

                e.Handled = true;

            }

        }

        private void txtGanancia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            //Si el caracter no es dígito ni un punto o un backspace, asumelo como manejado y no permitas que se escriba en el textBox
            if (!char.IsDigit(caracter) && caracter != '.' && !char.IsControl(caracter))
            {

                e.Handled = true;

            }

            //Solo permitir que se escriba un punto decimal
            if (caracter == '.' && ((sender as TextBox).Text.Contains(".")))
            {

                e.Handled = true;

            }
        }

        private void txtCorresp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            //Si el caracter no es dígito ni un punto o un backspace, asumelo como manejado y no permitas que se escriba en el textBox
            if (!char.IsDigit(caracter) && caracter != '.' && !char.IsControl(caracter))
            {

                e.Handled = true;

            }

            //Solo permitir que se escriba un punto decimal
            if (caracter == '.' && ((sender as TextBox).Text.Contains(".")))
            {

                e.Handled = true;

            }
        }

        private void cbNomEmpleado_SelectedValueChanged(object sender, EventArgs e)
        {
            //Se divide el nombre completo por espacios
            string[] nomCompleto = cbNomEmpleado.Text.Split(' ');
            string nom;
            string apellidoPaterno;
            string apellidoMaterno;
            //Si el nombre completo contiene un nombre
            if (nomCompleto.Length == 3)
            {

                nom = nomCompleto[0];
                apellidoPaterno = nomCompleto[1];
                apellidoMaterno = nomCompleto[2];

            }
            //Si el nombre completo contiene dos nombres
            else
            {

                nom = nomCompleto[0] + " " + nomCompleto[1];
                apellidoPaterno = nomCompleto[2];
                apellidoMaterno = nomCompleto[3];

            }
            cbNumEmpleado.SelectedValue = logicaNegocios.ConsNumEmp(nom, apellidoPaterno, apellidoMaterno);

        }

        private void cbNumEmpleado_SelectedValueChanged(object sender, EventArgs e)
        {

            int numSeleccionado = int.Parse(cbNumEmpleado.Text);
            cbNomEmpleado.SelectedValue = logicaNegocios.ConsNomEmp(numSeleccionado);

        }
    }
}
