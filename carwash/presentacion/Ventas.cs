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

namespace presentacion
{
    public partial class Ventas : Form
    {
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private DateTime dtFechaActual = DateTime.Today.Date;

        private InfoVenta infoVentaAlta = new InfoVenta();

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
            AltaVenta vtnAltaVenta = new AltaVenta(infoVentaAlta);
            vtnAltaVenta.ShowDialog();
            vtnAltaVenta.ventaAgregada += (s, e) =>
            {
                if (logicaNegocios.ConsVentas(tblVentas, dtFechaActual))
                {
                    RenombrarEncabezados(tblVentas);

                    //Se calculan los montos totales del día
                    lblPrecioMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "precio").ToString("F2");
                    lblGanMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "ganancia").ToString("F2");
                    lblCorrespMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "correspondencia").ToString("F2");

                    lblNoVentas.Visible = false;
                    tblVentas.Visible = true;
                }
            };
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

            this.ActiveControl = pnlContenido;

            //Condicion si hay ventas del día se muestran
            if (logicaNegocios.ConsVentas(tblVentas, dtFechaActual))
            {
                RenombrarEncabezados(tblVentas);

                //Se calculan los montos totales del día
                lblPrecioMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "precio").ToString("F2");
                lblGanMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "ganancia").ToString("F2");
                lblCorrespMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "correspondencia").ToString("F2");

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

        private void dtFechaVenta_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtFechaVenta.Value.Date;

            //Condicion si hay ventas del dia se muestran
            if (logicaNegocios.ConsVentas(tblVentas, fechaSeleccionada))
            {
                RenombrarEncabezados(tblVentas);

                //Se calculan los montos totales del día
                lblPrecioMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "precio").ToString("F2");
                lblGanMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "ganancia").ToString("F2");
                lblCorrespMonto.Text = "$" + logicaNegocios.CalcMontosTotal(tblVentas, "correspondencia").ToString("F2");

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

                }

            }
        }

    }
}
