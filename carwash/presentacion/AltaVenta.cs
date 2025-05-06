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
        private Boolean cambioConTeclado = false;
        private bool cargando = true;

        public AltaVenta()
        {
            InitializeComponent();
        }

        private void AltaVenta_Load(object sender, EventArgs e)
        {
            cargando = true;

            cbNomEmpleado.DataSource = logicaNegocios.ConsNomEmpleados();
            cbNomEmpleado.DisplayMember = "nomCompleto";
            cbNomEmpleado.ValueMember = "nomCompleto";
            cbNumEmpleado.DataSource = logicaNegocios.GetNumsEmpleado();
            cbNumEmpleado.DisplayMember = "numEmpleado";
            cbNumEmpleado.ValueMember = "numEmpleado";

            // Forzar sincronización inicial
            if (cbNomEmpleado.Items.Count > 0)
            {
                cbNomEmpleado.SelectedIndex = 0;

                if (!string.IsNullOrWhiteSpace(cbNomEmpleado.Text))
                {
                    string[] nomCompleto = cbNomEmpleado.Text.Split(' ');

                    if (nomCompleto.Length >= 3)
                    {
                        string nom, apellidoPaterno, apellidoMaterno;

                        if (nomCompleto.Length == 3)
                        {
                            nom = nomCompleto[0];
                            apellidoPaterno = nomCompleto[1];
                            apellidoMaterno = nomCompleto[2];
                        }
                        else
                        {
                            nom = nomCompleto[0] + " " + nomCompleto[1];
                            apellidoPaterno = nomCompleto[2];
                            apellidoMaterno = nomCompleto[3];
                        }

                        cbNumEmpleado.SelectedValue = logicaNegocios.ConsNumEmp(nom, apellidoPaterno, apellidoMaterno);
                    }
                }
            }

            cargando = false;
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            Boolean errorCapturado = false;
            string marcaCarro = txtMarcaCarro.Text;
            string modeloCarro = txtModeloCarro.Text;
            string colorCarro = txtColorCarro.Text;

            if (validacionesUI.EvalCharsColor(colorCarro))
            {
                Toast toast = new Toast("error", "El campo color de carro solo puede incluir letras");
                toast.Show();
                errorCapturado = true;
            }

            string[] posiblesNums = { txtPrecioCarro.Text, txtGanancia.Text, txtCorresp.Text };
            if (validacionesUI.EvalSoloNums(posiblesNums))
            {
                Toast toast = new Toast("error", "Los campos precio del carro, ganancia y correspondencia deben contener valores númericos.");
                toast.Show();
                errorCapturado = true;
                return;
            }

            int precio;
            int.TryParse(txtPrecioCarro.Text, out precio);
            int gan;
            int.TryParse(txtGanancia.Text, out gan);
            int corresp;
            int.TryParse(txtCorresp.Text, out corresp);
            string nomCompleto = cbNomEmpleado.Text;
            int numEmp = int.Parse(cbNumEmpleado.Text);
            if (validacionesUI.EvalCamposObligatoriosVenta(precio, gan, corresp, nomCompleto, numEmp))
            {
                Toast toast = new Toast("error", "Los campos obligatorios deben ser llenados (los que tienen el *)");
                toast.Show();
                errorCapturado = true;
            }

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

            if (!errorCapturado) {

                DateTime fechaVenta = DateTime.Today;

                logicaNegocios.AltaVenta(marcaCarro, modeloCarro, colorCarro, precio, gan, corresp, numEmp, fechaVenta);
                Toast toast = new Toast("exito", "Venta registrada con éxito.");
                toast.Show();
                this.Close();

            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecioCarro_TextChanged(object sender, EventArgs e)
        {
            int[] porcentajes = logicaNegocios.ConsPor();
            int precio;

            if (int.TryParse(txtPrecioCarro.Text, out precio) && cambioConTeclado)
            {
                cambioConTeclado = false;
                int ganCalculada = logicaNegocios.CalcGan(precio, porcentajes[0]);
                int correspCalculada = logicaNegocios.CalcCorresp(precio, porcentajes[1]);
                txtGanancia.Text = ganCalculada.ToString();
                txtCorresp.Text = correspCalculada.ToString();
            }
            else if (txtPrecioCarro.Text.Equals("") && cambioConTeclado)
            {
                cambioConTeclado = false;

                if (!txtPrecioCarro.Text.Equals("")) txtPrecioCarro.Text = "";
                if (!txtGanancia.Text.Equals("")) txtGanancia.Text = "";
                if (!txtCorresp.Text.Equals("")) txtCorresp.Text = "";
            }
        }

        private void txtPrecioCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsDigit(caracter) && caracter != '.' && !char.IsControl(caracter))
            {
                e.Handled = true;
                return;
            }

            TextBox txt = sender as TextBox;
            string textoActual = txt.Text;
            int posCursor = txt.SelectionStart;
            int selLength = txt.SelectionLength;
            string resultado = "";

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
                if (caracter == '.' && textoActual.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                if (selLength > 0)
                {
                    resultado = textoActual.Remove(posCursor, selLength).Insert(posCursor, caracter.ToString());
                }
                else
                {
                    resultado = textoActual.Insert(posCursor, caracter.ToString());
                }
            }

            if (resultado.Length > 1 && resultado.StartsWith("0") && !resultado.StartsWith("0."))
            {
                e.Handled = true;
                return;
            }
        }


        private void txtGanancia_TextChanged(object sender, EventArgs e)
        {
            int gan;
            int corresp = 0;
            if (int.TryParse(txtGanancia.Text, out gan) && int.TryParse(txtCorresp.Text, out corresp) && cambioConTeclado)
            {
                cambioConTeclado = false;
                int nuevoPrecio = gan + corresp;
                txtPrecioCarro.Text = nuevoPrecio.ToString();
            }
            else if (txtGanancia.Text.Equals(""))
            {
                cambioConTeclado = false;

                int.TryParse(txtCorresp.Text, out corresp);

                if (corresp != 0)
                {
                    txtPrecioCarro.Text = corresp.ToString();
                }
                else
                {
                    if (!txtPrecioCarro.Text.Equals(""))
                    {
                        txtPrecioCarro.Text = "";
                    }
                }

            }//fin else-if
        }

        private void txtGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsDigit(caracter) && caracter != '.' && !char.IsControl(caracter))
            {
                e.Handled = true;
                return;
            }

            TextBox txt = sender as TextBox;
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
            }

            // No permite ceros al inicio, a menos que sea solo un 0 o un decimal tipo 0.25
            if (resultado.Length > 1 && resultado.StartsWith("0") && !resultado.StartsWith("0."))
            {
                e.Handled = true;
                return;
            }

        }
        private void txtCorresp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;

            if (!char.IsDigit(caracter) && caracter != '.' && !char.IsControl(caracter))
            {
                e.Handled = true;
                return;
            }

            TextBox txt = sender as TextBox;
            string textoActual = txt.Text;
            int posCursor = txt.SelectionStart;
            int selLength = txt.SelectionLength;
            string resultado = "";

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
                if (caracter == '.' && textoActual.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                if (selLength > 0)
                {
                    resultado = textoActual.Remove(posCursor, selLength).Insert(posCursor, caracter.ToString());
                }
                else
                {
                    resultado = textoActual.Insert(posCursor, caracter.ToString());
                }
            }

            if (resultado.Length > 1 && resultado.StartsWith("0") && !resultado.StartsWith("0."))
            {
                e.Handled = true;
                return;
            }
        }


        private void cbNomEmpleado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cargando) return;

            if (string.IsNullOrWhiteSpace(cbNomEmpleado.Text)) return;

            string[] nomCompleto = cbNomEmpleado.Text.Trim().Split(' ');

            if (nomCompleto.Length < 3) return;

            string nom;
            string apellidoPaterno;
            string apellidoMaterno;

            if (nomCompleto.Length == 3)
            {
                nom = nomCompleto[0];
                apellidoPaterno = nomCompleto[1];
                apellidoMaterno = nomCompleto[2];
            }
            else if (nomCompleto.Length >= 4)
            {
                nom = nomCompleto[0] + " " + nomCompleto[1];
                apellidoPaterno = nomCompleto[2];
                apellidoMaterno = nomCompleto[3];
            }
            else
            {
                return;
            }

            cbNumEmpleado.SelectedValue = logicaNegocios.ConsNumEmp(nom, apellidoPaterno, apellidoMaterno);
        }

        private void cbNumEmpleado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cargando) return;

            int numSeleccionado;
            if (int.TryParse(cbNumEmpleado.Text, out numSeleccionado))
            {
                cbNomEmpleado.SelectedValue = logicaNegocios.ConsNomEmp(numSeleccionado);
            }
        }

        private void txtCorresp_TextChanged(object sender, EventArgs e)
        {
            int gan = 0;
            int corresp;
            if (int.TryParse(txtGanancia.Text, out gan) && int.TryParse(txtCorresp.Text, out corresp) && cambioConTeclado)
            {
                cambioConTeclado = false;
                int nuevoPrecio = gan + corresp;
                txtPrecioCarro.Text = nuevoPrecio.ToString();
            }
            else if (txtCorresp.Text.Equals(""))
            {
                cambioConTeclado = false;

                int.TryParse(txtGanancia.Text, out gan);

                if (gan != 0)
                {
                    txtPrecioCarro.Text = gan.ToString();
                }
                else
                {
                    if (!txtPrecioCarro.Text.Equals(""))
                    {
                        txtPrecioCarro.Text = "";
                    }
                }
            }
        }

        private void txtPrecioCarro_KeyDown(object sender, KeyEventArgs e)
        {
            cambioConTeclado = true;
        }

        private void txtGanancia_KeyDown(object sender, KeyEventArgs e)
        {
            cambioConTeclado = true;
        }

        private void txtCorresp_KeyDown(object sender, KeyEventArgs e)
        {
            cambioConTeclado = true;
        }
    }
}