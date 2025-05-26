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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace presentacion
{
    public partial class AltaCorte : Form
    {

        private InfoCorteCaja infoCorte = new InfoCorteCaja();
        private Boolean cambioConTeclado = false;
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private decimal calculado;
        private string nomUsuario;

        public AltaCorte(InfoCorteCaja infoCorte, string nomUsuario)
        {

            this.infoCorte = infoCorte;
            this.nomUsuario = nomUsuario;
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void AltaCorte_Load(object sender, EventArgs e)
        {

            //Se obtiene el valor del campo calculado (lo que se debe tener en caja según el sistema)
            calculado = logicaNegocios.CalcSistema(logicaNegocios.ConsVentasNoCan(DateTime.Today));
            txtCalculado.Text = LimitarDecimales(calculado.ToString());

            //Si hay dato cargado (no 0) en infoCorte, se carga el monto en el campo correspondiente
            if (infoCorte.Contado != 0)
            {

                txtContado.Text = infoCorte.Contado.ToString();
                ManejarDiferencia(infoCorte.Contado);
                //txtDiferencia.Text = logicaNegocios.CalcDif(decimal.Parse(txtContado.Text), calculado).ToString();

            }
            //Si el dato cargado es 0, no cargues nada en el campo correspondiente
            else
            {

                txtContado.Text = "";

            }

        }

        private void txtContado_KeyPress(object sender, KeyPressEventArgs e)
        {

            char caracter = e.KeyChar;

            if (!char.IsDigit(caracter) && !char.IsControl(caracter) && caracter != '.')
            {
                e.Handled = true;
                return;
            }

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;
            string textoActual = txt.Text;
            int posCursor = txt.SelectionStart;
            int selLength = txt.SelectionLength;
            string resultado = "";

            // Si es Backspace, simular eliminación
            if (caracter == (char)Keys.Back)
            {
                if (posCursor > 0 && textoActual.Length > 0)
                {
                    resultado = textoActual.Remove(posCursor - 1, 1);
                }
                else
                {
                    resultado = textoActual;
                }
            }
            else
            {
                // Si es punto y ya hay un punto, bloquear
                if (caracter == '.' && textoActual.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                // Insertar o reemplazar texto simulado
                if (selLength > 0)
                {
                    resultado = textoActual.Remove(posCursor, selLength).Insert(posCursor, caracter.ToString());
                }
                else
                {
                    resultado = textoActual.Insert(posCursor, caracter.ToString());
                }

                // Validar que no haya más de dos dígitos después del punto
                int indicePunto = resultado.IndexOf('.');
                if (indicePunto >= 0 && resultado.Length - indicePunto - 1 > 2)
                {
                    e.Handled = true;
                    return;
                }

            }

        }

        private void txtContado_TextChanged(object sender, EventArgs e)
        {

            decimal contado;

            if (decimal.TryParse(txtContado.Text, out contado) && cambioConTeclado)
            {
                cambioConTeclado = false;
                ManejarDiferencia(contado);
            }
            else if (txtContado.Text.Equals("") && cambioConTeclado)
            {

                cambioConTeclado = false;
                txtDiferencia.Text = "";

            }

        }

        private string LimitarDecimales(string monto)
        {
            // Verifica si la cadena contiene un punto decimal
            if (monto.Contains("."))
            {
                // Divide la cadena en la parte entera y la decimal
                string[] partes = monto.Split('.');

                // Si hay más de dos decimales, recorta a dos
                if (partes.Length > 1 && partes[1].Length > 2)
                {
                    monto = partes[0] + "." + partes[1].Substring(0, 2);
                }
            }

            return monto;
        }

        private void txtContado_KeyDown(object sender, KeyEventArgs e)
        {
            cambioConTeclado = true;
        }

        private void AltaCorte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {

                if (e.KeyCode == Keys.C)
                {

                    btnConfirmar.PerformClick();

                }

            }
        }

        private void txtDiferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDiferencia_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete ||
                (e.Control && (e.KeyCode == Keys.V || e.KeyCode == Keys.X)))
            {
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            GuardarDatos();

            MessageBoxConfirmar messageBoxConfirmar = new MessageBoxConfirmar("¿Está seguro de realizar el corte de caja?");
            //Evento que se dispara si se presiona el botón confirmar en la ventana emergente MessageBoxConfirmar
            messageBoxConfirmar.ConfirmarPresionado += (s, ev) =>
            {

                System.Windows.Forms.TextBox[] campoContado = { txtContado };
                if (validacionesUI.EvalTxtVacios(campoContado))
                {

                    Toast toastError = new Toast("error", "Los campos obligatorios deben ser llenados (los que tienen el *)");
                    toastError.Show();

                }
                else
                {

                    //Para obtener el id del administrador que realiza el corte de caja
                    int idAdmin = (int)logicaNegocios.ObtenerIdAdmin(nomUsuario).Rows[0]["id"];
                    logicaNegocios.AltaCorte(DateTime.Today, idAdmin, decimal.Parse(txtContado.Text), decimal.Parse(txtCalculado.Text), decimal.Parse(txtDiferencia.Text));
                    Toast toastExito = new Toast("exito", "Corte de caja realizado con éxito");
                    toastExito.Show();
                    this.Close();
                    infoCorte.Contado = 0;

                }

            };
            messageBoxConfirmar.mostrarMessageBox();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            this.Close();
        }

        private void AltaCorte_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
        {

            decimal temp;
            decimal.TryParse(txtContado.Text, out temp);
            infoCorte.Contado = temp;

        }

        private void ManejarDiferencia(decimal contado)
        {

            decimal diferencia = logicaNegocios.CalcDif(contado, calculado);
            txtDiferencia.Text = LimitarDecimales(diferencia.ToString());
            //Cambiar el color de la diferencia según el estado (cuadrado, faltante, sobrante)
            string estadoDif = logicaNegocios.EstadoDif(diferencia);
            switch (estadoDif)
            {

                case "cuadrada":
                    txtDiferencia.ForeColor = Color.Black;
                    break;

                case "faltante":
                    txtDiferencia.ForeColor = Color.Red;
                    break;

                case "sobrante":
                    txtDiferencia.ForeColor = Color.Green;
                    break;

                default:
                    MessageBox.Show("Valor inesperado");
                    break;

            }

        }

    }

}
