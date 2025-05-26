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

            txtContado.Text = infoCorte.Contado.ToString();
            txtDiferencia.Text = infoCorte.Diferencia.ToString();

            //Si hay dato cargado (no 0) en infoCorte, se carga el monto en el campo correspondiente
            if (infoCorte.Contado != 0)
            {

                txtContado.Text = infoCorte.Contado.ToString();

            }
            //Si el dato cargado es 0, no cargues nada en el campo correspondiente
            else
            {

                txtContado.Text = "";

            }

        }

        private void txtContado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtContado_TextChanged(object sender, EventArgs e)
        {

            decimal contado;

            if (decimal.TryParse(txtContado.Text, out contado) && cambioConTeclado)
            {
                cambioConTeclado = false;

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
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
