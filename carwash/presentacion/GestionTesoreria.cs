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
    public partial class GestionTesoreria : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();

        private InfoGasto infoGastoAlta = new InfoGasto();
        private InfoGasto infoGastoMod = new InfoGasto();
        private InfoGasto infoGastoElim = new InfoGasto();

        private Boolean verGastosAct = false; 
        private string nomUsuario;
        public GestionTesoreria(string nomUsuario)
        {
            infoGastoAlta.FechaGasto = DateTime.Today.Date;
            this.nomUsuario = nomUsuario;
            InitializeComponent();
        }

        private void btnAltaGas_Click(object sender, EventArgs e)
        {
            DateTime fechaSelec = dtFechaGas.Value.Date;

            //Condicion: si hay ganancias en el dia se pueden registrar gastos
            if (logicaNegocios.ConsGanTotal(fechaSelec) > 0)
            {
                List<string> tipoGas = logicaNegocios.GetTiposGasto();
                AltaModGasto vtnAltaModGasto = new AltaModGasto(infoGastoAlta, "alta", nomUsuario, tipoGas);
                vtnAltaModGasto.GastoAgregado += (s, args) =>
                {
                    logicaNegocios.DecidirConsGas(tblGastos, dtFechaGas.Value.Date, verGastosAct);
                    RenomEncabezados(tblGastos);
                    ConfigTablaSoloLectura(tblGastos);
                    CargarEfecTeorico(fechaSelec);

                    if (lblNoGas.Visible == true)
                    {
                        lblNoGas.Visible = false;
                        tblGastos.Visible = true;
                        CargarEfecTeorico(fechaSelec);
                    }
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
            DateTime fechaSelec = dtFechaGas.Value.Date;
            bool hayVentas = logicaNegocios.DecidirConsGas(tblGastos, dtFechaGas.Value.Date, verGastosAct);

            if (hayVentas)
            {
                lblNoGas.Visible = false;
                tblGastos.Visible = true;
                RenomEncabezados(tblGastos);
                ConfigTablaSoloLectura(tblGastos);
            }
            else
            {
                tblGastos.DataSource = null;
                lblNoGas.Visible = true;
            }

            CargarEfecTeorico(fechaSelec);
            dtFechaGas.MaxDate = DateTime.Today;
        }

        private void GestionGasto_Load(object sender, EventArgs e)
        {
            bool hayVentas = logicaNegocios.DecidirConsGas(tblGastos, dtFechaGas.Value.Date, verGastosAct);

            if (hayVentas)
            {
                lblNoGas.Visible = false;
                RenomEncabezados(tblGastos);
                ConfigTablaSoloLectura(tblGastos);
            }
            else
            {
                tblGastos.Visible = false;
                lblNoGas.Visible = true;
            }

            DateTime fechaSelec = dtFechaGas.Value.Date;
            CargarEfecTeorico(fechaSelec);
            dtFechaGas.MaxDate = DateTime.Today;
        }

        private void CargarEfecTeorico(DateTime fechaSelec)
        {
            decimal efecCaja = 0;
            
            efecCaja = logicaNegocios.GetPreciosPorFecha(fechaSelec)
                        - logicaNegocios.GetMontPorFecha(fechaSelec)
                        + logicaNegocios.GetMontGan(fechaSelec);

            //En caso de que haya ventas se mostrara la ganancia en el lblGanDia
            if (efecCaja > 0)
            {
                lblGanDia.Text = efecCaja.ToString("C");
                lblNoGan.Visible = false;
            }
            else
            {
                lblNoGan.Visible = true;
                lblGanDia.Text = "---";
            }
        }

        private void RenomEncabezados(DataGridView tblGastos)
        {
            // Renombrar encabezados
            tblGastos.Columns["cancelado"].HeaderText = ""; // sin texto en encabezado
            tblGastos.Columns["cancelado"].Width = 30;
            tblGastos.Columns["cancelado"].ReadOnly = true;
            tblGastos.Columns["cancelado"].Resizable = DataGridViewTriState.False;
            tblGastos.Columns["cancelado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            tblGastos.Columns["id"].HeaderText = "ID";
            tblGastos.Columns["fechaGasto"].HeaderText = "Fecha del Gasto";
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

            // Ajuste automático de altura para que se muestre toda la descripción
            tblGastos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Wrap del texto para que haga salto de línea
            tblGastos.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tblGastos.Columns["descripcion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tblGastos.Columns["tipoGasto"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //Alinear el texto en la descripción arriba a la izquierda
            tblGastos.Columns["descripcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            //Forzar que aparezca el scrollbar si es necesario
            tblGastos.ScrollBars = ScrollBars.Vertical;
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
        }

        private void btnModGastoGan_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = tblGastos.CurrentRow;
            if (filaSeleccionada != null)
            {
                //Se cargan los datos de la tabla
                infoGastoMod.IdGasto = (int)filaSeleccionada.Cells["id"].Value;
                infoGastoMod.Monto = (decimal)filaSeleccionada.Cells["monto"].Value;
                infoGastoMod.TipoGasto = (string)filaSeleccionada.Cells["tipoGasto"].Value;
                infoGastoMod.Descripcion = (string)filaSeleccionada.Cells["descripcion"].Value;
                infoGastoMod.FechaGasto = (DateTime)filaSeleccionada.Cells["fechaGasto"].Value;

                bool cancelado = Convert.ToBoolean(filaSeleccionada.Cells["cancelado"].Value);
                
                if (!cancelado) {
                    DateTime fechaSelec = dtFechaGas.Value.Date;

                    List<string> tipoGas = logicaNegocios.GetTiposGasto();
                    AltaModGasto vtnAltaModGasto = new AltaModGasto(infoGastoMod, "mod", nomUsuario, tipoGas, fechaSelec);
                    vtnAltaModGasto.GastoAgregado += (s, args) =>
                    {
                        logicaNegocios.DecidirConsGas(tblGastos, dtFechaGas.Value.Date, verGastosAct);
                        tblGastos.Visible = true;
                        RenomEncabezados(tblGastos);
                        ConfigTablaSoloLectura(tblGastos);
                        CargarEfecTeorico(fechaSelec);
                    };
                    vtnAltaModGasto.ShowDialog();
                }
                else
                {
                    new Toast("error", "No se puede modificar un gasto/ganancia cancelado").MostrarToast();
                }
            }
            else
            {
                new Toast("error", "No has seleccionado ningun registro").MostrarToast();
            }
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            if (tblGastos.CurrentRow == null || tblGastos.Rows.Count == 0)
            {
                new Toast("error", "No hay registros para cancelar.").MostrarToast();
                return;
            }

            DataGridViewRow filaSeleccionada = tblGastos.CurrentRow;
            bool cancelado = Convert.ToBoolean(filaSeleccionada.Cells["cancelado"].Value);

            if (!cancelado)
            {
                var verificacion = new Verificacion(nomUsuario);
                verificacion.ShowDialog();

                if (!verificacion.VerificacionExitosa)
                {
                    return;
                }

                infoGastoElim.IdGasto = (int)filaSeleccionada.Cells["id"].Value;
                infoGastoElim.FechaGasto = (DateTime)filaSeleccionada.Cells["fechaGasto"].Value;
                infoGastoElim.Monto = (decimal)filaSeleccionada.Cells["monto"].Value;
                infoGastoElim.TipoGasto = (string)filaSeleccionada.Cells["tipoGasto"].Value;
                infoGastoElim.Descripcion = (string)filaSeleccionada.Cells["descripcion"].Value;

                MessageBoxConfirmar messageBoxConfirmar = new MessageBoxConfirmar(
                    "¿Está seguro de eliminar el registro \n" +
                    "ID: [ " + infoGastoElim.IdGasto + " ] \n" +
                    "Fecha: [ " + infoGastoElim.FechaGasto + " ]\n" +
                    "Monto: [ " + infoGastoElim.Monto.ToString("C2") + " ] \n" +
                    "Tipo: [ " + infoGastoElim.TipoGasto + " ]\n" +
                    "Descripcion [ " + infoGastoElim.Descripcion + " ] ?"
                );
                messageBoxConfirmar.ConfirmarPresionado += (s, ev) =>
                {
                    logicaNegocios.CanGasto(infoGastoElim.IdGasto);
                    new Toast("exito", "Registro cancelado con exito! ").MostrarToast();

                    if (logicaNegocios.DecidirConsGas(tblGastos, dtFechaGas.Value.Date, verGastosAct))
                    {
                        lblNoGas.Visible = false;
                        tblGastos.Visible = true;
                        RenomEncabezados(tblGastos);
                        ConfigTablaSoloLectura(tblGastos);
                    }
                    else
                    {
                        tblGastos.Visible = false;
                        lblNoGas.Visible = true;
                    }
                    CargarEfecTeorico(dtFechaGas.Value.Date);
                };
                messageBoxConfirmar.mostrarMessageBox();
            }
            else
            {
                new Toast("error", "El registro seleccionado ya ha sido cancelado").MostrarToast();
            }
        }

        private void tblGastos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tblGastos.Columns[e.ColumnIndex].Name == "cancelado" && e.Value != null)
            {
                bool cancelado = Convert.ToBoolean(e.Value);

                // Cambia el color de fondo de la celda según su valor
                if (cancelado)
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btnVerVentasCan_Click(object sender, EventArgs e)
        {
            verGastosAct = !verGastosAct;

            if (verGastosAct)
            {
                btnVerGastosCan.Image = Image.FromFile("../../../recursos/imagenes/esconderContrasena.png");
                btnVerGastosCan.Text = "Esconder registros cancelados";
            }
            else
            {
                btnVerGastosCan.Image = Image.FromFile("../../../recursos/imagenes/mostrarContrasena.png");
                btnVerGastosCan.Text = "Mostrar registros cancelados";
            }

            bool hayVentas = logicaNegocios.DecidirConsGas(tblGastos, dtFechaGas.Value.Date, verGastosAct);

            if (hayVentas)
            {
                lblNoGas.Visible = false;
                tblGastos.Visible = true;
                RenomEncabezados(tblGastos);
                ConfigTablaSoloLectura(tblGastos);
            }
            else
            {
                tblGastos.Visible = false;
                lblNoGas.Visible = true;
            }

            CargarEfecTeorico(dtFechaGas.Value.Date);
        }
    }
}
