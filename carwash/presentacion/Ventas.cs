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

        public Ventas()
        {
            InitializeComponent();
            this.KeyPreview = true;
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
            this.ActiveControl = pnlContenido;

        }

        private void dtFechaVenta_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtFechaVenta.Value.Date;

            //Condicion si hay ventas del dia se muestran
            if (logicaNegocios.DecidirConsVenta(tblVentas, fechaSeleccionada, verVentasCan))
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
                string nom = nomCompletoSplit[0];
                string apellidoPaterno = nomCompletoSplit[1];
                string apellidoMaterno = nomCompletoSplit[2];
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
                        if (!logicaNegocios.DecidirConsVenta(tblVentas, dtFechaVenta.Value.Date, verVentasCan)) {

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

    }
}
