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
    public partial class ConfigVenta : Form
    {

        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        public ConfigVenta()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPorGan_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsDigit(caracter) && !char.IsControl(caracter))
            {
                e.Handled = true;
                return;
            }

            string porCompleto = ""; // Variable para construir lo que sería el nuevo porcentaje, necesario para validarlo antes de dejar que se introduzca en el textBox
            int posCursor = txtPorGan.SelectionStart;
            string textoActual = txtPorGan.Text;

            // Si el caracter introducido es un backspace, necesitamos construir el nuevo porcentaje de una distinta manera
            if (caracter == (char)Keys.Back)
            {

                // Si el cursor no está al inicio y hay texto, simular eliminación con Backspace
                if (posCursor > 0 && textoActual.Length > 0)
                {
                    porCompleto = textoActual.Remove(posCursor - 1, 1);
                }
                else
                {

                    porCompleto = textoActual;

                }
            }
            else
            {
                // Si no es un Backspace, se inserta el caracter en la posición del cursor
                int selLength = txtPorGan.SelectionLength;

                // Si hay texto seleccionado, se remplaza por el nuevo carácter
                if (selLength > 0)
                {
                    porCompleto = textoActual.Remove(posCursor, selLength).Insert(posCursor, caracter.ToString());
                }
                else
                {
                    porCompleto = textoActual.Insert(posCursor, caracter.ToString());
                }
            }

            // Evaluar si el valor ingresado es un número válido
            if (int.TryParse(porCompleto, out int valor))
            {
                // Evitar números con ceros a la izquierda
                if (porCompleto.Length > 1 && porCompleto.StartsWith("0"))
                {
                    e.Handled = true;
                    return;
                }

                // Validar si el porcentaje es válido
                if (validacionesUI.EvalPorDistribucion(valor))
                {
                    Toast toast = new Toast("error", "El porcentaje no puede ser menor de 0% ni mayor de 100%");
                    toast.Show();
                    e.Handled = true;
                }
            }
        }
        private void txtPorCorresp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsDigit(caracter) && !char.IsControl(caracter))
            {
                e.Handled = true;
                return;
            }

            string porCompleto = ""; // Variable para construir lo que sería el nuevo porcentaje, necesario para validarlo antes de dejar que se introduzca en el textBox
            int posCursor = txtPorCorresp.SelectionStart;
            string textoActual = txtPorCorresp.Text;

            // Si el caracter introducido es un backspace, necesitamos construir el nuevo porcentaje de una distinta manera
            if (caracter == (char)Keys.Back)
            {
                // Si el cursor no está al inicio y hay texto, simular eliminación con Backspace
                if (posCursor > 0 && textoActual.Length > 0)
                {
                    porCompleto = textoActual.Remove(posCursor - 1, 1);
                }
                else
                {
                    porCompleto = textoActual;
                }
            }
            else
            {
                // Si no es un Backspace, se inserta el caracter en la posición del cursor
                int selLength = txtPorCorresp.SelectionLength;

                // Si hay texto seleccionado, se remplaza por el nuevo carácter
                if (selLength > 0)
                {
                    porCompleto = textoActual.Remove(posCursor, selLength).Insert(posCursor, caracter.ToString());
                }
                else
                {
                    porCompleto = textoActual.Insert(posCursor, caracter.ToString());
                }
            }

            // Evaluar si el valor ingresado es un número válido
            if (int.TryParse(porCompleto, out int valor))
            {
                // Evitar números con ceros a la izquierda
                if (porCompleto.Length > 1 && porCompleto.StartsWith("0"))
                {
                    e.Handled = true;
                    return;
                }

                // Validar si el porcentaje es válido
                if (validacionesUI.EvalPorDistribucion(valor))
                {
                    Toast toast = new Toast("error", "El porcentaje no puede ser menor de 0% ni mayor de 100%");
                    toast.Show();
                    e.Handled = true;
                }
            }
        }

        private void ConfigVenta_Load(object sender, EventArgs e)
        {

            int[] porcentajes = logicaNegocios.ConsPor();
            //Rows [0] es el porcentaje de ganancia, Rows[1] es el porcentaje de correspondencia
            txtPorGan.Text = porcentajes[0].ToString();
            txtPorCorresp.Text = porcentajes[1].ToString();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxes = { txtPorGan, txtPorCorresp };
            if (validacionesUI.EvalTxtVacios(textBoxes))
            {

                Toast toast = new Toast("error", "Los campos obligatorios deben ser llenados (los que tienen el *)");
                toast.Show();

            }
            else
            {

                logicaNegocios.ModPorGan(int.Parse(txtPorGan.Text));
                logicaNegocios.ModPorCorresp(int.Parse(txtPorCorresp.Text));
                Toast toast = new Toast("exito", "Porcentajes modificados con éxito.");
                toast.Show();
                this.Close();

            }

        }

        private void txtPorCorresp_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtPorCorresp.Text, out int por))
            {
                txtPorGan.Text = logicaNegocios.CalcPor(por, "ganancia").ToString();
            }

        }

        private void txtPorGan_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtPorGan.Text, out int por))
            {
                txtPorCorresp.Text = logicaNegocios.CalcPor(por, "correspondencia").ToString();
            }

        }

        private void ConfigVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C)
            {

                btnConfirmar.PerformClick();

            }
        }
    }
}
