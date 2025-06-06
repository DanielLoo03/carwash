using negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Ventas : Form
    {
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private DateTime dtFechaActual = DateTime.Today.Date;
        private InfoVenta infoVentaAlta = new InfoVenta();
        private InfoVenta infoVentaMod = new InfoVenta();
        private Boolean verVentasCan = false;
        private Boolean cajaAbierta = false;
        private string usuarioAct;


        public Ventas(string usuarioActual)
        {
            InitializeComponent();
            this.KeyPreview = true;
            usuarioAct = usuarioActual;

        }

        private void btnConfigVentas_Click(object sender, EventArgs e)
        {
            ConfigVenta vtnConfigVenta = new ConfigVenta();
            vtnConfigVenta.ShowDialog();
        }

        private void btnAddVenta_Click(object sender, EventArgs e)
        {
            AltaVenta vtnAltaVenta = new AltaVenta(infoVentaAlta, "alta");
            vtnAltaVenta.ventaAgregada += (s, e) =>
            {

                logicaNegocios.DecidirConsVenta(tblVentas, dtFechaActual, verVentasCan);
                RecargarTbl();


                if (lblNoVentas.Visible == true) 
                {

                    lblNoVentas.Visible = false;
                    tblVentas.Visible = true;

                }

            };
            vtnAltaVenta.ShowDialog();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

            //Si todavía no se ha abierto caja, validar si se debe abrir
            if (!cajaAbierta) {

                ConsEstadoCaja();

            }

            //Condición: si hay ventas del día se muestran
            if (logicaNegocios.DecidirConsVenta(tblVentas, dtFechaActual, verVentasCan))
            {

                RecargarTbl();
                lblNoVentas.Visible = false;
                tblVentas.Visible = true;

            }
            else
            {

                limpiarTotales();
                lblNoVentas.Visible = true;
                tblVentas.Visible = false;

            }

            //Habilitar o deshabilitar alta, mod, cancelación de ventas dependiendo del estado de caja
            //Condición: Estado de caja abierta 
            if (logicaNegocios.ConsEstadoCaja())
            {

                AbrirModulos();
                cajaAbierta = true;

            }
            //Condición: Estado de caja cerrada
            else {

                BloqModulos();
                cajaAbierta = false;

            }

            this.ActiveControl = pnlContenido;

        }

        private void dtFechaVenta_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtFechaVenta.Value.Date;

            //Condicion si hay ventas el día seleccionado, se muestran
            if (logicaNegocios.DecidirConsVenta(tblVentas, fechaSeleccionada, verVentasCan))
            {

                RecargarTbl();

                DataTable dt = (DataTable)tblVentas.DataSource;
                if (!dt.Columns.Contains("Estado de venta"))
                    dt.Columns.Add("Estado de venta", typeof(string));

                foreach (DataRow fila in dt.Rows)
                {
                    bool fueCancelada = false;
                    if (fila.Table.Columns.Contains("cancelado") && fila["cancelado"] != DBNull.Value)
                        fueCancelada = (bool)fila["cancelado"];

                    fila["Estado de venta"] = fueCancelada ? "Cancelada" : "No cancelada";
                }
                RenombrarEncabezados(tblVentas);

                lblNoVentas.Visible = false;
                tblVentas.Visible = true;
            }
            else
            {
                limpiarTotales();
                lblNoVentas.Visible = true;
                tblVentas.Visible = false;
            }

        }

        private void RenombrarEncabezados(DataGridView tblVentas)
        {

            //Nombres de encabezados
            tblVentas.Columns["marcaCarro"].HeaderText = "Marca";
            tblVentas.Columns["modeloCarro"].HeaderText = "Modelo";
            tblVentas.Columns["colorCarro"].HeaderText = "Color";
            tblVentas.Columns["precio"].HeaderText = "Precio";
            tblVentas.Columns["ganancia"].HeaderText = "Ganancia";
            tblVentas.Columns["correspondencia"].HeaderText = "Correspondencia";
            tblVentas.Columns["nomCompleto"].HeaderText = "Empleado Encargado";

            if (tblVentas.Columns.Contains("Estado de venta"))
            {
                tblVentas.Columns["Estado de venta"].HeaderText = "Estado de venta";
                tblVentas.Columns["Estado de venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Estilo de encabezados
            tblVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            tblVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblVentas.EnableHeadersVisualStyles = false;

            //Formato a montos
            tblVentas.Columns["precio"].DefaultCellStyle.Format = "C2";
            tblVentas.Columns["ganancia"].DefaultCellStyle.Format = "C2";
            tblVentas.Columns["correspondencia"].DefaultCellStyle.Format = "C2";

            // Ajuste automático del ancho de columnas
            tblVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void limpiarTotales()
        {
            lblPrecioMonto.Text = "---";
            lblGanMonto.Text = "---";
            lblCorrespMonto.Text = "---";
        }

        private void Ventas_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnModVenta_Click(object sender, EventArgs e)
        {

            DataGridViewRow filaSeleccionada = tblVentas.CurrentRow; //La venta seleccionada para modificar
            //Condición: Si se seleccionó una venta/fila de la tabla
            if (filaSeleccionada != null)
            {

                //Se cargan propiedades para pasarlos a los formularios y se cargen los datos de la venta seleccionada
                infoVentaMod.Id = (int)filaSeleccionada.Cells["id"].Value;
                infoVentaMod.ModeloCarro = (string)filaSeleccionada.Cells["modeloCarro"].Value;
                infoVentaMod.MarcaCarro = (string)filaSeleccionada.Cells["marcaCarro"].Value;
                infoVentaMod.ColorCarro = (string)filaSeleccionada.Cells["colorCarro"].Value;
                infoVentaMod.Precio = (decimal)filaSeleccionada.Cells["precio"].Value;
                infoVentaMod.Gan = (decimal)filaSeleccionada.Cells["ganancia"].Value;
                infoVentaMod.Corresp = (decimal)filaSeleccionada.Cells["correspondencia"].Value;
                //Se consulta el numEmpleado según el nombre completo obtenido de la fila seleccionada
                string nomCompleto = (string)filaSeleccionada.Cells["nomCompleto"].Value;
                string[] nomCompletoSplit = nomCompleto.Split(" ");

                string nom = "", apellidoPaterno = "", apellidoMaterno = "";
                if (nomCompletoSplit.Length >= 3)
                {

                    if (nomCompletoSplit.Length == 3)
                    {
                        nom = nomCompletoSplit[0];
                        apellidoPaterno = nomCompletoSplit[1];
                        apellidoMaterno = nomCompletoSplit[2];
                    }
                    else
                    {
                        nom = nomCompletoSplit[0] + " " + nomCompletoSplit[1];
                        apellidoPaterno = nomCompletoSplit[2];
                        apellidoMaterno = nomCompletoSplit[3];
                    }

                }

                infoVentaMod.NumEmp = logicaNegocios.ConsNumEmp(nom, apellidoPaterno, apellidoMaterno);

                AltaVenta vtnModVenta = new AltaVenta(infoVentaMod, "mod");
                vtnModVenta.ventaAgregada += (s, ev) =>
                {
                    logicaNegocios.DecidirConsVenta(tblVentas, dtFechaActual, verVentasCan);
                };
                vtnModVenta.ShowDialog();

            }
            else
            {

                Toast toast = new Toast("error", "No has seleccionado ningún empleado");
                return;

            }

        }

        private void btnCanVenta_Click(object sender, EventArgs e)
        {

            DataGridViewRow filaSeleccionada = tblVentas.CurrentRow;//La venta seleccionada para cancelar
            //Condición: Si seleccionó una venta/fila de la tabla
            if (filaSeleccionada != null)
            {

                //Condición: Si la venta ya se encuentra cancelada
                if (logicaNegocios.VentaEsCan(filaSeleccionada))
                {

                    MessageBox.Show("La venta seleccionada ya se encuentra cancelada");

                }
                //Condición: Si la venta todavía no se encuentra cancelada, entonces cancela la venta
                else
                {
                    var verificacion = new Verificacion(usuarioAct);
                    verificacion.ShowDialog();

                    if (!verificacion.VerificacionExitosa)
                    {
                        return;
                    }
                    MessageBoxConfirmar messageBoxConfirmar = new MessageBoxConfirmar("¿Está seguro de cancelar la venta seleccionada?\n\n" +
                        "Información de venta\n" +
                        "Marca de carro: " + filaSeleccionada.Cells["marcaCarro"].Value + "\n" +
                        "Modelo de carro: " + filaSeleccionada.Cells["modeloCarro"].Value + "\n" +
                        "Color de carro: " + filaSeleccionada.Cells["colorCarro"].Value + "\n" +
                        "Precio: $" + filaSeleccionada.Cells["precio"].Value + "\n" +
                        "Ganancia: $" + filaSeleccionada.Cells["ganancia"].Value + "\n" +
                        "Correspondencia: $" + filaSeleccionada.Cells["correspondencia"].Value + "\n" +
                        "Empleado encargado: " + filaSeleccionada.Cells["nomCompleto"].Value
                        );
                    //Codigo que se ejecuta si se dispara el evento al presionar el botón confirmar
                    messageBoxConfirmar.ConfirmarPresionado += (s, ev) =>
                    {

                        logicaNegocios.CanVenta((int)filaSeleccionada.Cells["id"].Value);
                        Toast toast = new Toast("exito", "Venta cancelada con éxito.");
                        toast.MostrarToast();
                        if (!logicaNegocios.DecidirConsVenta(tblVentas, dtFechaVenta.Value.Date, verVentasCan))
                        {

                            limpiarTotales();
                            lblNoVentas.Visible = true;
                            tblVentas.Visible = false;

                        }
                        else
                        {

                            RecargarTbl();
                            lblNoVentas.Visible = false;
                            tblVentas.Visible = true;

                        }

                    };
                    messageBoxConfirmar.mostrarMessageBox();

                }

            }
            else
            {

                Toast toast = new Toast("error", "No has seleccionado ninguna venta.");

            }

        }

        private void btnVerVentasCan_Click(object sender, EventArgs e)
        {

            verVentasCan = !verVentasCan;

            if (verVentasCan)
            {
                btnVerVentasCan.Image = Image.FromFile("../../../recursos/imagenes/esconderContrasena.png");
                btnVerVentasCan.Text = "Esconder ventas canceladas";
            }
            else
            {
                btnVerVentasCan.Image = Image.FromFile("../../../recursos/imagenes/mostrarContrasena.png");
                btnVerVentasCan.Text = "Mostrar ventas canceladas";
            }

            bool hayVentas = logicaNegocios.DecidirConsVenta(tblVentas, dtFechaVenta.Value.Date, verVentasCan);

            if (hayVentas)
            {
                RecargarTbl();

                DataTable dt = (DataTable)tblVentas.DataSource;
                if (!dt.Columns.Contains("Estado de venta"))
                    dt.Columns.Add("Estado de venta", typeof(string));

                foreach (DataRow fila in dt.Rows)
                {
                    bool fueCancelada = false;
                    if (fila.Table.Columns.Contains("cancelado") && fila["cancelado"] != DBNull.Value)
                        fueCancelada = (bool)fila["cancelado"];
                    fila["Estado de venta"] = fueCancelada ? "Cancelada" : "No cancelada";
                }

                lblNoVentas.Visible = false;
                tblVentas.Visible = true;
            }
            else
            {
                limpiarTotales();
                lblNoVentas.Visible = true;
                tblVentas.Visible = false;
            }

        }

        private void RecargarTbl()
        {

            RenombrarEncabezados(tblVentas);

            //Se calculan los montos totales del día
            lblPrecioMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "precio").ToString("F2");
            lblGanMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "ganancia").ToString("F2");
            lblCorrespMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "correspondencia").ToString("F2");

        }

        //Habilitar opciones de alta/mod/baja/cancelación al reabrir corte / iniciar nuevo día
        public void AbrirModulos() {

            Button[] btns = { btnAltaVenta, btnModVenta, btnCanVenta };
            ToolTip toolTip = new ToolTip();

            foreach (Button btn in btns)
            {

                btn.Enabled = true;
                //Se "elimina" el tooltip
                toolTip.SetToolTip(btn, null);

            }

        }

        //Bloquear opciones de alta/mod/baja/cancelación al realizar corte
        public void BloqModulos()
        {
            Button[] btns = { btnAltaVenta, btnModVenta, btnCanVenta };
            ToolTip toolTip = new ToolTip();

            foreach (Button btn in btns)
            {

                btn.Enabled = false;
                toolTip.SetToolTip(btn, "Para habilitar la opción, debe reabrir caja.");

            }

        }

        //Revisa si caja se encuentra abierta
        private void ConsEstadoCaja()
        {

            DateTime fechaCorte = logicaNegocios.ConsFechaCorte();

            if (fechaCorte != DateTime.MinValue)
            {

                if (DateTime.Today > fechaCorte)
                {

                    logicaNegocios.ModEstadoCaja(true);
                    cajaAbierta = true;

                }

            }

        }

        private void Ventas_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.Shift)
            {

                switch (e.KeyCode)
                {

                    case Keys.A:
                        btnAltaVenta.PerformClick();
                        break;

                    case Keys.C:
                        btnConfigVentas.PerformClick();
                        break;

                    case Keys.M:
                        btnModVenta.PerformClick();
                        break;

                    case Keys.V:
                        btnVerVentasCan.PerformClick();
                        break;

                }

            }
            else if (e.Alt)
            {

                if (e.KeyCode == Keys.C)
                {

                    btnCanVenta.PerformClick();

                }

            }

        }
    }
}
