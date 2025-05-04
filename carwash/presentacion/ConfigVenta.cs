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

            string porCompleto = txtPorGan.Text.Insert(txtPorGan.SelectionStart, e.KeyChar.ToString());

            if (validacionesUI.EvalPorDistribucion(int.Parse(porCompleto)))
            {
                Toast toast = new Toast("error", "El porcentaje no puede ser menor de 0% ni mayor de 100%");
                toast.Show();
                e.Handled = true;
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

            string porCompleto = txtPorCorresp.Text.Insert(txtPorCorresp.SelectionStart, e.KeyChar.ToString());

            if (validacionesUI.EvalPorDistribucion(int.Parse(porCompleto)))
            {
                Toast toast = new Toast("error", "El porcentaje no puede ser menor de 0% ni mayor de 100%");
                toast.Show();
                e.Handled = true;
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

            }
            else {

                logicaNegocios.ModPorGan(int.Parse(txtPorGan.Text));
                logicaNegocios.ModPorCorresp(int.Parse(txtPorCorresp.Text));
                Toast toast = new Toast("exito", "Porcentajes modificados con éxito.");
                toast.Show();

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
    }
}
