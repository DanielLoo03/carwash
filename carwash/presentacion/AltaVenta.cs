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
        public event EventHandler ventaAgregada;
        private InfoVenta infoVenta;
        private Boolean cambioConTeclado = false;
        //Bandera para saber si se está ejecutando el código del método Load
        private bool cargando = true;
        private string tipo = "";

        public AltaVenta(InfoVenta infoVentaAlta, string tipo)
        {
            this.infoVenta = infoVentaAlta;
            this.tipo = tipo;
            InitializeComponent();
            this.KeyPreview = true;

            if (tipo.Equals("mod"))
            {

                txtPrecioCarro.Enabled = false;
                txtGanancia.Enabled = false;
                txtCorresp.Enabled = false;
                lblVenta.Text = "Modificación de venta";

            }
            else if (tipo.Equals("alta")) {

                lblVenta.Text = "Alta de venta";

            }

        }

        private void AltaVenta_Load(object sender, EventArgs e)
        {
            cargando = true;

            //Se preparan comboBoxes cargándolos con los números y nombres de empleados existentes
            cbNomEmpleado.DataSource = logicaNegocios.ConsNomEmpleados();
            cbNomEmpleado.DisplayMember = "nomCompleto";
            cbNomEmpleado.ValueMember = "nomCompleto";
            cbNumEmpleado.DataSource = logicaNegocios.GetNumsEmpleado();
            cbNumEmpleado.DisplayMember = "numEmpleado";
            cbNumEmpleado.ValueMember = "numEmpleado";

            //Se cargan campos con los valores anteriormente introducidos (si se introdujeron datos anteriormente sin completar la alta)
            //Condición: Si se introdujo información y nunca se dió de alta
            if (infoVenta.NumEmp != 0)
            {

                txtMarcaCarro.Text = infoVenta.MarcaCarro;
                txtModeloCarro.Text = infoVenta.ModeloCarro;
                txtColorCarro.Text = infoVenta.ColorCarro;
                if (infoVenta.Precio != 0)
                {

                    txtPrecioCarro.Text = infoVenta.Precio.ToString();

                }
                else {

                    txtPrecioCarro.Text = "";
                
                }
                if (infoVenta.Gan != 0)
                {

                    txtGanancia.Text = infoVenta.Gan.ToString();

                }
                else
                {

                    txtPrecioCarro.Text = "";

                }
                if (infoVenta.Corresp != 0)
                {

                    txtCorresp.Text = infoVenta.Corresp.ToString();

                }
                else
                {

                    txtPrecioCarro.Text = "";

                }
                cbNumEmpleado.SelectedValue = infoVenta.NumEmp;

                //Se carga nombre de empleado según el número de empleado seteado
                int numSeleccionado;
                if (int.TryParse(cbNumEmpleado.Text, out numSeleccionado))
                {
                    cbNomEmpleado.SelectedValue = logicaNegocios.ConsNomEmp(numSeleccionado);
                }

            }
            else {

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

            }

            cargando = false;

        }

        private void guardarDatos()
        {

            //Se guardan valores en infoVentaAlta 
            infoVenta.MarcaCarro = txtMarcaCarro.Text;
            infoVenta.ModeloCarro = txtModeloCarro.Text;
            infoVenta.ColorCarro = txtColorCarro.Text;
            //temp = variable temporal que almacena el resultado del tryParse
            int temp;
            //Condición: Si se puede realizar la conversión del string a int
            if (int.TryParse(txtPrecioCarro.Text, out temp))
            {
                infoVenta.Precio = temp;
            }
            else {

                infoVenta.Precio = 0;
            
            }
            if (int.TryParse(txtGanancia.Text, out temp))
            {
                infoVenta.Gan = temp;
            }
            else {

                infoVenta.Gan = 0;

            }
            if (int.TryParse(txtCorresp.Text, out temp))
            {
                infoVenta.Corresp = temp;
            }
            else {

                infoVenta.Corresp = 0;

            }
            infoVenta.NumEmp = Convert.ToInt32(cbNumEmpleado.SelectedValue);

        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            Boolean errorCapturado = false;
            string marcaCarro = txtMarcaCarro.Text;
            string modeloCarro = txtModeloCarro.Text;
            string colorCarro = txtColorCarro.Text;

            //Se guardan datos introducidos a objeto infoVentaAlta
            guardarDatos();

            //Validaciones para marca del carro
            TextBox[] posibleNumMaxMa = { txtMarcaCarro};
            if (validacionesUI.EvalCampoLimite(posibleNumMaxMa, 50))
            {
                Toast toast = new Toast("error", "El campo de Marca del carro no debe exceder los 50 caracteres.");
                toast.Show();
                errorCapturado = true;
                return;
            }


            //Validaciones para modelo del carro
            TextBox[] posibleNumMaxMo = {txtModeloCarro };
            if (validacionesUI.EvalCampoLimite(posibleNumMaxMo, 50))
            {
                Toast toast = new Toast("error", "El campo Modelo del carro no debe exceder los 50 caracteres.");
                toast.Show();
                errorCapturado = true;
                return;
            }


            //Validaciones para color de carro
            if (validacionesUI.EvalCharsColor(colorCarro))
            {
                Toast toast = new Toast("error", "El campo color de carro solo puede incluir letras");
                toast.Show();
                errorCapturado = true;
                return;
            }
            TextBox[] posibleNumMaxCol = {txtColorCarro };
            if (validacionesUI.EvalCampoLimite(posibleNumMaxCol, 50))
            {
                Toast toast = new Toast("error", "El campo Color del carro no debe exceder los 50 caracteres.");
                toast.Show();
                errorCapturado = true;
                return;
            }


            if (!decimal.TryParse(txtPrecioCarro.Text, out decimal precio))
            {
                Toast toast = new Toast("error", "El campo Precio es obligatorio y debe ser numérico.");
                toast.Show();
                errorCapturado = true;
                return;
            }
            if (validacionesUI.EvalMontos(precio))
            {
                Toast toast = new Toast("error", "El precio no puede ser igual a 0 o negativo.");
                toast.Show();
                errorCapturado = true;
                return;
            }

            // ————— Validaciones y parseo de ganancia —————
            if (!decimal.TryParse(txtGanancia.Text, out decimal gan))
            {
                Toast toast = new Toast("error", "El campo Ganancia es obligatorio y debe ser numérico.");
                toast.Show();
                errorCapturado = true;
                return;
            }
            if (validacionesUI.EvalMontos(gan))
            {
                Toast toast = new Toast("error", "La ganancia no puede ser igual a 0 o negativa.");
                toast.Show();
                errorCapturado = true;
                return;
            }

            // ————— Validaciones y parseo de correspondencia —————
            if (!decimal.TryParse(txtCorresp.Text, out decimal corresp))
            {
                Toast toast = new Toast("error", "El campo Correspondencia es obligatorio y debe ser numérico.");
                toast.Show();
                errorCapturado = true;
                return;
            }
            if (validacionesUI.EvalMontos(corresp))
            {
                Toast toast = new Toast("error", "La correspondencia no puede ser igual a 0 o negativa.");
                toast.Show();
                errorCapturado = true;
                return;
            }

            // ————— Validación de nombre de empleado seleccionado —————
            string nomCompleto = cbNomEmpleado.Text;
            if (validacionesUI.EvalNombreCliente(nomCompleto))
            {
                Toast toast = new Toast("error", "El campo nombre de empleado es obligatorio y debe estar seleccionado.");
                toast.Show();
                errorCapturado = true;
                return;
            }

            
            if (string.IsNullOrWhiteSpace(cbNumEmpleado.Text) ||
                !int.TryParse(cbNumEmpleado.Text, out int numEmp))
            {
                Toast toast = new Toast("error", "Debes seleccionar un número de empleado válido.");
                toast.Show();
                errorCapturado = true;
                return;
            }

            if (!errorCapturado)
            {

                if (tipo.Equals("alta"))
                {

                    DateTime fechaVenta = DateTime.Today;

                    logicaNegocios.AltaVenta(marcaCarro, modeloCarro, colorCarro, precio, gan, corresp, numEmp, fechaVenta);

                }
                //Es una modificación
                else {

                    logicaNegocios.modVenta(infoVenta.Id, marcaCarro, modeloCarro, colorCarro, numEmp);

                }
                ventaAgregada?.Invoke(this, EventArgs.Empty);
                Toast toastExito = new Toast("exito", "Venta registrada con éxito.");
                toastExito.Show();
                this.Close();

                //Se limpian campos de InfoVentaAlta / InfoVentaMod
                infoVenta.MarcaCarro = "";
                infoVenta.ModeloCarro = "";
                infoVenta.ColorCarro = "";
                infoVenta.Precio = 0;
                infoVenta.Gan = 0;
                infoVenta.Corresp = 0;
                infoVenta.NumEmp = 0;

            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            //Se guardan datos introducidos a objeto infoVentaAlta
            guardarDatos();

            this.Close();

        }

        private void manejarKeyPress(object sender, KeyPressEventArgs e) {

            char caracter = e.KeyChar;

            if (!char.IsDigit(caracter) && !char.IsControl(caracter) && caracter != '.')
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

                // Validar que no haya más de dos dígitos después del punto
                int indicePunto = resultado.IndexOf('.');
                if (indicePunto >= 0 && resultado.Length - indicePunto - 1 > 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            // No permite ceros al inicio, a menos que sea solo un 0 o un decimal tipo 0.25
            if (resultado.Length > 1 && resultado.StartsWith("0") && !resultado.StartsWith("0."))
            {
                e.Handled = true;
                return;
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

        private void txtPrecioCarro_TextChanged(object sender, EventArgs e)
        {
            int[] porcentajes = logicaNegocios.ConsPor();
            decimal precio;

            if (decimal.TryParse(txtPrecioCarro.Text, out precio) && cambioConTeclado)
            {
                cambioConTeclado = false;
                decimal ganCalculada = logicaNegocios.CalcGan(precio, porcentajes[0]);
                decimal correspCalculada = logicaNegocios.CalcCorresp(precio, porcentajes[1]);
                txtGanancia.Text = LimitarDecimales(ganCalculada.ToString());
                txtCorresp.Text = LimitarDecimales(correspCalculada.ToString());
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

            manejarKeyPress(sender, e);

        }


        private void txtGanancia_TextChanged(object sender, EventArgs e)
        {
            decimal gan;
            decimal corresp = 0;
            if (decimal.TryParse(txtGanancia.Text, out gan) && decimal.TryParse(txtCorresp.Text, out corresp) && cambioConTeclado)
            {
                cambioConTeclado = false;
                decimal nuevoPrecio = gan + corresp;
                txtPrecioCarro.Text = LimitarDecimales(nuevoPrecio.ToString());
            }
            else if (txtGanancia.Text.Equals(""))
            {
                cambioConTeclado = false;

                decimal.TryParse(txtCorresp.Text, out corresp);

                if (corresp != 0)
                {
                    txtPrecioCarro.Text = LimitarDecimales(corresp.ToString());
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

            manejarKeyPress(sender, e);

        }
        private void txtCorresp_KeyPress(object sender, KeyPressEventArgs e)
        {

            manejarKeyPress(sender, e);

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
            decimal gan = 0;
            decimal corresp;
            if (decimal.TryParse(txtGanancia.Text, out gan) && decimal.TryParse(txtCorresp.Text, out corresp) && cambioConTeclado)
            {
                cambioConTeclado = false;
                decimal nuevoPrecio = gan + corresp;
                txtPrecioCarro.Text = LimitarDecimales(nuevoPrecio.ToString());
            }
            else if (txtCorresp.Text.Equals(""))
            {
                cambioConTeclado = false;

                decimal.TryParse(txtGanancia.Text, out gan);

                if (gan != 0)
                {
                    txtPrecioCarro.Text = LimitarDecimales(gan.ToString());
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

        private void AltaVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.C)
            {

                btnConfirmarVenta.PerformClick();

            }
        }

        private void AltaVenta_FormClosing(object sender, FormClosingEventArgs e)
        {

            //Se guardan datos introducidos a objeto infoVentaAlta
            guardarDatos();

        }
    }
}