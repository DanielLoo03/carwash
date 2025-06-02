using negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace presentacion
{
    public partial class AltaModGasto : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private InfoGasto infoGasto;
        private string tipo;
        private int idAdmin = 0;
        private string nomUsuario;
        public AltaModGasto(InfoGasto infoGastoAlta, string tipo, string nomUsuario)
        {
            this.tipo = tipo;
            this.nomUsuario = nomUsuario;
            this.infoGasto = infoGastoAlta;

            InitializeComponent();

            if (tipo.Equals("mod"))
            {
                lblRegistroGasto.Text = "Modificación de Gasto";
            }
            else if (tipo.Equals("alta"))
            {
                lblRegistroGasto.Text = "Registro de Gasto";
            }
        }

        private void guardarDatos()
        {
            infoGasto.Monto = decimal.Parse(txtMont.Text.Trim());
            infoGasto.TipoGasto = cbTipoGas.SelectedItem.ToString();
            infoGasto.Descripcion = txtDesc.Text;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            decimal mont = decimal.Parse(txtMont.Text.Trim());
            string tipoGas = cbTipoGas.SelectedItem.ToString();
            string desc = txtDesc.Text.Trim();

            TextBox[] descripcion = { txtDesc };
            if (validacionesUI.EvalTxtVacios(descripcion))
            {
                new Toast("error", " El campo de descripcion de usuario es obligatorio (debe ser llenado).").MostrarToast();
                return;
            }

            if (validacionesUI.EvalCampoLimite(descripcion, 50))
            {
                new Toast("error", " El campo de descripcion no puede exceder los 100 caracteres.").MostrarToast();
                return;
            }

            if (tipo == "alta")
            {
                DateTime fechaGasto = DateTime.Today;
                int idAdmin = (int)logicaNegocios.ObtenerIdAdmin(nomUsuario).Rows[0]["id"];

                logicaNegocios.AltaGasto(fechaGasto, mont, tipoGas, desc, idAdmin);
                new Toast("exito", "Registro de gasto realizado con exito.").MostrarToast();

                txtMont.Text = "0.00";
                txtDesc.Clear();
                cbTipoGas.SelectedIndex = 0;
                this.Close();
            }
            else if (tipo == "mod")
            {

            }
        }

        private void AltaModGasto_Load(object sender, EventArgs e)
        {
            cbTipoGas.DataSource = logicaNegocios.GetTiposGasto();

            if (tipo == "alta")
            {

                //Si se trata de una alta el cbTipoGas estara seleccionado en la primera opcion
                if (cbTipoGas.Items.Count > 0)
                {
                    cbTipoGas.SelectedIndex = 0;
                }
            }

            //Si se trata de una modificacion o ya se modificaron los otros campos el cbTipoGas se cargaran con los que se eligieron
            if (tipo == "mod" || !string.IsNullOrEmpty(txtDesc.Text) || decimal.TryParse(txtMont.Text, out decimal valor) && valor > 0)
            {
                cbTipoGas.SelectedItem = infoGasto.TipoGasto;
            }

            txtMont.Text = "0";
            txtMont_TextChanged(txtMont, EventArgs.Empty);

            txtMont.Text = infoGasto.Monto.ToString();
            txtDesc.Text = infoGasto.Descripcion;
        }

        private void txtMont_TextChanged(object sender, EventArgs e)
        {
            // Guardar la posición original del cursor
            int cursorPos = txtMont.SelectionStart;

            // Limpiar caracteres no numéricos (por si el usuario pegó texto)
            string soloNumeros = new string(txtMont.Text.Where(char.IsDigit).ToArray());

            // Si no hay números, mostrar "0.00"
            if (soloNumeros.Length == 0)
            {
                txtMont.Text = "0.00";
                txtMont.SelectionStart = 1; // Justo después del primer 0
                return;
            }

            // Limitar a 7 dígitos como máximo (DECIMAL(7,2))
            if (soloNumeros.Length > 7)
            {
                soloNumeros = soloNumeros.Substring(0, 7);
            }

            // Asegurar al menos 3 dígitos para los centavos
            soloNumeros = soloNumeros.PadLeft(3, '0');
            decimal valor = Convert.ToDecimal(soloNumeros) / 100;

            if (valor > 99999.99m)
            {
                valor = 99999.99m;
            }

            // Aplicar formato con dos decimales
            string nuevoTexto = valor.ToString("N2");

            // Solo actualizar el texto si cambió
            if (txtMont.Text != nuevoTexto)
            {
                txtMont.Text = nuevoTexto;

                // Restaurar el cursor (ajustar si se sale del rango)
                txtMont.SelectionStart = Math.Min(cursorPos, txtMont.Text.Length);
            }
        }

        private void txtMont_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (0-9) y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Bloquear el signo negativo
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }

        private void AltaModGasto_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            guardarDatos();
            this.Close();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            // Guarda la posición actual del cursor
            int pos = txtDesc.SelectionStart;

            // Convierte todo el texto a mayúsculas
            txtDesc.Text = txtDesc.Text.ToUpper();

            // Restaura la posición del cursor
            txtDesc.SelectionStart = pos;
        }
    }
}
