using negocios;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace presentacion
{
    public partial class AltaModGasto : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();

        public event EventHandler GastoAgregado;
        private InfoGasto infoGasto;
       
        private string tipo;
        private int idAdmin = 0;
        private bool correspAct = true;
        private string nomUsuario;
        private decimal efecCaja = 0;

        private DateTime fechaReg = DateTime.Today.Date;
        private DateTime fechaMod;
        public AltaModGasto(InfoGasto infoGastoAlta, string tipo, string nomUsuario, List<string>TipoGas)
        {
            this.tipo = tipo;
            this.nomUsuario = nomUsuario;
            this.infoGasto = infoGastoAlta;
            
            InitializeComponent();
            cbTipoGas.DataSource = TipoGas;

            if (tipo.Equals("alta"))
            {
                lblGasto.Text = "Registro de Gasto";
            }
        }

        public AltaModGasto(InfoGasto infoGastoAlta, string tipo, string nomUsuario, List<string> TipoGas, DateTime fechaMod)
        {
            this.tipo = tipo;
            this.nomUsuario = nomUsuario;
            this.infoGasto = infoGastoAlta;
            this.fechaMod = fechaMod;

            InitializeComponent();
            cbTipoGas.DataSource = TipoGas;

            if (tipo.Equals("mod"))
            {
                lblGasto.Text = "Modificación de Gasto";
            }

        }

        private void guardarDatos()
        {
            if (cbTipoGas.SelectedItem != null)
            {
                infoGasto.TipoGasto = cbTipoGas.Text;
            }

            infoGasto.Monto = decimal.Parse(txtMont.Text.Trim());
            infoGasto.Descripcion = txtDesc.Text;
            infoGasto.FechaGasto = dtFechaGasto.Value;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idAdmin = (int)logicaNegocios.ObtenerIdAdmin(nomUsuario).Rows[0]["id"];
            DateTime fechaGas = dtFechaGasto.Value.Date;
            decimal mont = decimal.Parse(txtMont.Text.Trim());
            string tipoGas = cbTipoGas.SelectedItem.ToString();
            string desc = txtDesc.Text.Trim();

            //Efectivo teorico en caja

            if (tipo == "alta")
            {
                efecCaja = logicaNegocios.GetPreciosPorFecha(fechaReg)
                            - logicaNegocios.GetMontPorFecha(fechaReg)
                            + logicaNegocios.GetMontGan(fechaReg);
            }
            
            if (tipo == "mod" && infoGasto.TipoGasto != "GANANCIA")
            {
                efecCaja = logicaNegocios.GetPreciosPorFecha(fechaReg)
                            - logicaNegocios.GetMontPorFecha(fechaReg)
                            + logicaNegocios.GetMontGan(fechaReg)
                            + infoGasto.Monto;
            }

            //Solo se valida que el registro no sea mayor al dinero en caja si es una alta y no es una ganancia
            if (mont > efecCaja && tipoGas != "GANANCIA" && mont > efecCaja)
            {
                new Toast("error", " El gasto no puede ser mayor al efectivo teorico en caja").MostrarToast();
                return;
            }

            if (mont == 0)
            {
                new Toast("error", " El campo de monto no puede ser $0.00").MostrarToast();
                return;
            }

            TextBox[] descripcion = { txtDesc };
            if (validacionesUI.EvalTxtVacios(descripcion) && correspAct == false)
            {
                new Toast("error", " El campo de descripcion es obligatorio (debe ser llenado).").MostrarToast();
                return; 
            }

            if (validacionesUI.EvalCampoLimite(descripcion, 100))
            {
                new Toast("error", " El campo de descripcion no puede exceder los 100 caracteres.").MostrarToast();
                return;
            }

            if (tipo == "alta")
            { 
                string descGasto = "";

                if (correspAct && cbEmp.SelectedItem != null)
                {
                    descGasto = "PAGO A EMPLEADO " + cbEmp.SelectedItem.ToString();
                }
                else
                {
                    descGasto = txtDesc.Text;
                }

                logicaNegocios.AltaGasto(fechaGas, fechaReg, mont, tipoGas, descGasto, idAdmin);

                if (tipoGas == "GANANCIA")
                {
                    new Toast("exito", "Registro de ganancia realizada con exito.").MostrarToast();
                }
                else
                {
                    new Toast("exito", "Registro de gasto realizado con exito.").MostrarToast();
                }
               

                txtMont.Text = "0.00";
                txtDesc.Clear();
                cbTipoGas.SelectedIndex = 0;
                this.Close();
                GastoAgregado?.Invoke(this, EventArgs.Empty);
            }

            if (tipo == "mod")
            {
                string descGasto = "";

                if (correspAct && cbEmp.SelectedItem != null)
                {
                    descGasto = "PAGO A EMPLEADO " + cbEmp.SelectedItem.ToString();
                }
                else
                {
                    descGasto = txtDesc.Text;
                }

                logicaNegocios.ModGasto(infoGasto.IdGasto , fechaGas, mont, tipoGas, descGasto, idAdmin);

                if (tipoGas == "GANANCIA") {
                    new Toast("exito", "Modificacion de ganancia realizada con exito.").MostrarToast();
                }
                else
                {
                    new Toast("exito", "Modificacion de gasto realizada con exito.").MostrarToast();
                }

                txtMont.Text = "0.00";
                txtDesc.Clear();
                cbTipoGas.SelectedIndex = 0;
                this.Close();

                GastoAgregado?.Invoke(this, EventArgs.Empty);
            }
        }

        private void AltaModGasto_Load(object sender, EventArgs e)
        {
            //Fecha max del dtPicker
            dtFechaGasto.MaxDate = fechaReg;

            //Efectivo teorico en caja
            if (tipo == "alta")
            {

                efecCaja = logicaNegocios.GetPreciosPorFecha(fechaReg) //Precios de las ventas
                                        - logicaNegocios.GetMontPorFecha(fechaReg) //Gastos del dia
                                        + logicaNegocios.GetMontGan(fechaReg); //Ganancias del dia (registradas)
            }

            //Condifcion: si es mod y Ganancia se toma en cuenta el monto de la mod para el efec en caja
            if (tipo == "mod" && infoGasto.TipoGasto != "GANANCIA")
            {
                    efecCaja = logicaNegocios.GetPreciosPorFecha(fechaReg)
                                - logicaNegocios.GetMontPorFecha(fechaReg)
                                + logicaNegocios.GetMontGan(fechaReg)
                                + infoGasto.Monto;
            }
            else
            {
                efecCaja = logicaNegocios.GetPreciosPorFecha(fechaReg)
                                - logicaNegocios.GetMontPorFecha(fechaReg)
                                + logicaNegocios.GetMontGan(fechaReg);
            }

            lblEfec.Text = efecCaja.ToString("C2"); 

            //Si se trata de una modificacion o ya se modificaron los otros campos el cbTipoGas se cargaran con los que se eligieron
            if (tipo == "mod" )
            {
                cbTipoGas.SelectedItem = infoGasto.TipoGasto;
            }

            txtMont.Text = "0";
            txtMont_TextChanged(txtMont, EventArgs.Empty);

            txtMont.Text = infoGasto.Monto.ToString();
            txtDesc.Text = infoGasto.Descripcion;
            cbTipoGas.Text = infoGasto.TipoGasto;
            dtFechaGasto.Value = infoGasto.FechaGasto;
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

        private void cbTipoGas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoGas.SelectedItem != null)
            {
                string tipoSelec = cbTipoGas.SelectedItem.ToString();

                switch (tipoSelec)
                {
                    case "CORRESPONDENCIA":
                        cbEmp.Items.Clear();
                        correspAct = true;
                        imgEmp.Visible = true;
                        imgCorresp.Visible = true;
                        cbEmp.Visible = true;
                        txtDesc.Visible = false;
                        lblDesc.Text = "Empleado";

                        List<int> numsEmp = new List<int>();

                        if (tipo == "alta")
                        {
                            lblGasto.Text = "Registro de Gasto";
                            btnConfirmar.Text = "Agregar Gasto";

                            //Si es alta llena el cb con los empleados del dia del registro
                            numsEmp = logicaNegocios.GetEmpPorFecha(fechaReg);
                        }

                        if(tipo == "mod")
                        {
                            btnConfirmar.Text = "Modificar Gasto";
                            lblGasto.Text = "Modificación de Gasto";

                            //Si es modificacion llena el cb con los empleados de la fecha de la modificacion
                            numsEmp = logicaNegocios.GetEmpPorFecha(fechaMod);
                        }

                        //Llena el cb con los empleados que han realizado ventas
                        if (numsEmp.Count > 0)
                        {
                            List<string> emps = new List<string>();
                            foreach (int numEmp in numsEmp)
                            {
                                string nom = logicaNegocios.GetNomEmp(numEmp);
                                emps.Add(nom);
                            }

                            cbEmp.Items.AddRange(emps.ToArray());
                            cbEmp.SelectedIndex = 0;
                        }
                        break;

                    case "GANANCIA":
                        correspAct = false;
                        imgEmp.Visible = false;
                        imgCorresp.Visible = false;
                        cbEmp.Visible = false;
                        txtDesc.Visible = true;

                        if (tipo == "alta") {
                            txtMont.Text = "0.00";
                            btnConfirmar.Text = "Agregar Ganancia";
                            lblGasto.Text = "Registro de Ganancia";
                        }

                        if(tipo == "mod")
                        {
                            btnConfirmar.Text = "Modificar Ganancia";
                            lblGasto.Text = "Modificación de Ganancia";
                        }
                        break;

                    default:
                        correspAct = false;
                        imgEmp.Visible = false;
                        imgCorresp.Visible = false;
                        cbEmp.Visible = false;
                        txtDesc.Visible = true;
                        lblDesc.Text = "Descripción";

                        if (tipo == "alta")
                        {
                            txtMont.Text = "0.00";
                            btnConfirmar.Text = "Agregar Gasto";
                            lblGasto.Text = "Registro de Gasto";
                        }   

                        if(tipo == "mod")
                        {
                            btnConfirmar.Text = "Modificar Gasto";
                            lblGasto.Text = "Modificación de Gasto";
                        }
                       
                        break;
                }
            }
        }

        private void cbEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empSelec = "";

            //Condicion: Si el cb no esta vacio y tiene items cargados
            if (cbEmp.SelectedItem != null && cbEmp.Items.Count > 0)
            {
                empSelec = cbEmp.SelectedItem.ToString();

                string[] partes = empSelec.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string apellidoMaterno = "";
                string apellidoPaterno = "";
                string nombre = "";

                if (partes.Length >= 3)
                {
                    apellidoMaterno = partes[^1];       // Último elemento
                    apellidoPaterno = partes[^2];       // Penúltimo
                    nombre = string.Join(" ", partes[..^2]); // Todo lo anterior como nombre
                }

                int? numEmp = logicaNegocios.ObtenerNumEmpleado(nombre, apellidoPaterno, apellidoMaterno);

                //COndicion: Si contiene un valor ( !null )
                if (numEmp.HasValue)
                {
                    if (tipo == "alta")
                    {
                        decimal monto = logicaNegocios.ConsCorrespTotal(fechaReg, numEmp.Value);
                        txtMont.Text = monto.ToString();
                    }
                    else
                    {
                        decimal monto = logicaNegocios.ConsCorrespTotal(fechaMod, numEmp.Value);
                        txtMont.Text = monto.ToString();
                    }
                        
                }
            }
        }
    }
}
