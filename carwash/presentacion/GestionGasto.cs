using Mysqlx.Cursor;
using negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class GestionGasto : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private InfoGasto infoGasto = new InfoGasto();
        private string nomUsuario;
        public GestionGasto(string nomUsuario)
        {
            this.nomUsuario = nomUsuario;
            InitializeComponent();
        }

        private void btnAltaGas_Click(object sender, EventArgs e)
        {
            DateTime fechaSelec = dtFechaGas.Value.Date;

            if (logicaNegocios.ConsGanTotal(fechaSelec) > 0)
            {
                AltaModGasto vtnAltaModGasto = new AltaModGasto(infoGasto, "alta", nomUsuario);
                vtnAltaModGasto.GastoAgregado += (s, args) =>
                {
                    DataTable gastos = logicaNegocios.ConsGas(fechaSelec);
                    tblGastos.DataSource = gastos;
                    RenomEncabezadoz(tblGastos);
                    ConfigTablaSoloLectura(tblGastos);
                };
                vtnAltaModGasto.ShowDialog();
            }
            else
            {
                new Toast("error", "No se pueden registrar gastos sin ventas previamente realizadas").MostrarToast();
            }
        }

        private void dtFechaGas_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void GestionGasto_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dtFechaGas.MaxDate = DateTime.Today;
        }

        private void CargarDatos()
        {
            DateTime fechaSelec = dtFechaGas.Value.Date;
            DataTable gastos = logicaNegocios.ConsGas(fechaSelec);
            decimal gan = logicaNegocios.ConsGanTotal(fechaSelec);

            if (gastos != null && gastos.Rows.Count > 0)
            {
                lblNoGas.Visible = false;
                tblGastos.DataSource = gastos;
                RenomEncabezadoz(tblGastos);
                ConfigTablaSoloLectura(tblGastos);
            }
            else
            {
                lblNoGas.Visible = true;
            }

            //En caso de que haya ventas se mostrara la ganancia en el lblGanDia
            if (gan > 0)
            {
                lblGanDia.Text = gan.ToString("C");
                lblNoGan.Visible = false;
            }
            else
            {
                lblNoGan.Visible = true;
                lblGanDia.Text = "---";
            }
        }

        private void btnCorresp_Click(object sender, EventArgs e)
        {
            CorrespEmp vtnCorrespEmp = new CorrespEmp(dtFechaGas.Value.Date);
            vtnCorrespEmp.ShowDialog();
        }

        private void RenomEncabezadoz(DataGridView tblGastos)
        {
            // Renombrar encabezados
            tblGastos.Columns["id"].HeaderText = "ID";
            tblGastos.Columns["nombreAdmin"].HeaderText = "Administrador";
            tblGastos.Columns["tipoGasto"].HeaderText = "Tipo Gasto";
            tblGastos.Columns["monto"].HeaderText = "Monto";
            tblGastos.Columns["descripcion"].HeaderText = "Descripción";

            // Estilo de encabezados
            tblGastos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            tblGastos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblGastos.EnableHeadersVisualStyles = false;

            // Formato a montos
            tblGastos.Columns["monto"].DefaultCellStyle.Format = "C2";

            // Ajuste automático del ancho de columnas
            tblGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajuste automático de altura de filas según contenido
            tblGastos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Permitir que las celdas hagan wrap del texto
            tblGastos.Columns["descripcion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Opcional: alinear texto de la descripción al tope izquierdo
            tblGastos.Columns["descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft; 
        }

        private void ConfigTablaSoloLectura(DataGridView tabla)
        {
            // Hacer la tabla de solo lectura
            tabla.ReadOnly = true;

            // Deshabilitar reordenamiento de columnas con el mouse
            tabla.AllowUserToOrderColumns = false;

            // Deshabilitar redimensionamiento de columnas y filas
            tabla.AllowUserToResizeColumns = false;
            tabla.AllowUserToResizeRows = false;

            // Deshabilitar agregar o eliminar filas manualmente
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;

            // Selección de fila completa, una sola a la vez
            tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla.MultiSelect = false;

            // Opcional: evitar que el usuario seleccione cualquier cosa
            // tabla.Enabled = false; // (Deshabilita completamente la tabla visualmente)
        }

    }
}
