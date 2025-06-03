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
    public partial class GestionEmpleado : Form
    {
        private InfoEmpleado infoEmpleadoAlta = new InfoEmpleado();
        private InfoEmpleado infoEmpleadoMod = new InfoEmpleado();
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        int numPagina = 1;
        int numIndice = 0;
        int numFilas = 10;
        int paginaFinal;
        private DataTable dtCompleto;

        public GestionEmpleado()
        {
            infoEmpleadoAlta.FechaNacimiento = DateTime.Today;
            infoEmpleadoMod.FechaNacimiento = DateTime.Today;
            InitializeComponent();
            this.KeyPreview = true;

            this.Load += GestionEmpleado_Load;
            cbPagina.SelectedIndexChanged += cbPagina_SelectedIndexChanged;
        }

        private void btnModEmpleado_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = tblEmpleados.CurrentRow;
            if (filaSeleccionada != null)
            {
                infoEmpleadoMod.Nombres = (string)filaSeleccionada.Cells["nombres"].Value;
                infoEmpleadoMod.ApellidoPaterno = (string)filaSeleccionada.Cells["apellidoPaterno"].Value;
                infoEmpleadoMod.ApellidoMaterno = (string)filaSeleccionada.Cells["apellidoMaterno"].Value;
                infoEmpleadoMod.NumTelefono = (string)filaSeleccionada.Cells["numTelefono"].Value;
                infoEmpleadoMod.NumEmpleado = (int)filaSeleccionada.Cells["numEmpleado"].Value;
                infoEmpleadoMod.FechaNacimiento = (DateTime)filaSeleccionada.Cells["fechaNacimiento"].Value;
                infoEmpleadoMod.Calle = (string)filaSeleccionada.Cells["calle"].Value;
                infoEmpleadoMod.Colonia = (string)filaSeleccionada.Cells["colonia"].Value;
                infoEmpleadoMod.NumExterior = (string)filaSeleccionada.Cells["numExterior"].Value;
                infoEmpleadoMod.NumInterior = (string)filaSeleccionada.Cells["numInterior"].Value;
                infoEmpleadoMod.CodigoPostal = (string)filaSeleccionada.Cells["codigoPostal"].Value;

                DatosPersonales vtnDatosPersonales = new DatosPersonales(infoEmpleadoMod, "modificar");
                vtnDatosPersonales.EmpleadoAgregado += (s, ev) =>
                {
                    // Mismos pasos que en Agregar:
                    dtCompleto = logicaNegocios.ConsultDatosEmpleados();
                    int total = dtCompleto.Rows.Count;
                    txtNumregistros.Text = total.ToString();

                    paginaFinal = (int)Math.Ceiling(total / (double)numFilas);
                    txtPaginaFinal.Text = paginaFinal.ToString();

                    cbPagina.Items.Clear();
                    for (int i = 1; i <= paginaFinal; i++)
                        cbPagina.Items.Add(i);

                    if (numPagina > paginaFinal)
                        numPagina = paginaFinal;
                    if (paginaFinal > 0)
                        cbPagina.SelectedItem = numPagina;
                    else
                    {
                        lblNoEmpleados.Visible = true;
                        tblEmpleados.Visible = false;
                    }
                };
                vtnDatosPersonales.ShowDialog();
            }
            else
            {
                new Toast("error", "No has seleccionado ningún empleado").MostrarToast();
            }
        }

        private void btnElimEmpleado_Click(object sender, EventArgs e)
        {
            if (tblEmpleados.CurrentRow == null || dtCompleto.Rows.Count == 0)
            {
                new Toast("error", "No hay empleados para eliminar.").MostrarToast();
                return;
            }
            DataGridViewRow filaSeleccionada = tblEmpleados.CurrentRow;
            int numEmpSeleccionado = (int)filaSeleccionada.Cells["numEmpleado"].Value;
            string nombreCompleto = $"{filaSeleccionada.Cells["nombres"].Value} " +
                                    $"{filaSeleccionada.Cells["apellidoPaterno"].Value} " +
                                    $"{filaSeleccionada.Cells["apellidoMaterno"].Value}";

            if (filaSeleccionada != null)
            {
                MessageBoxConfirmar messageBoxConfirmar = new MessageBoxConfirmar(
                    "¿Está seguro de eliminar al empleado " +
                    (int)filaSeleccionada.Cells["numEmpleado"].Value + " | " +
                    (string)filaSeleccionada.Cells["nombres"].Value + " " +
                    (string)filaSeleccionada.Cells["apellidoPaterno"].Value + " " +
                    (string)filaSeleccionada.Cells["apellidoMaterno"].Value + "?"
                );
                messageBoxConfirmar.ConfirmarPresionado += (s, ev) =>
                {
                    logicaNegocios.ElimEmpleados(numEmpSeleccionado);
                    new Toast("exito", "Empleado eliminado con éxito.").MostrarToast();

                    // → 3) Recargar dtCompleto CON los empleados que quedan:
                    dtCompleto = logicaNegocios.ConsultDatosEmpleados();
                    int total = dtCompleto.Rows.Count;
                    txtNumregistros.Text = total.ToString();

                    // → 4) Recalcular total de páginas (páginas de 10 registros):
                    paginaFinal = (int)Math.Ceiling(total / (double)numFilas);
                    txtPaginaFinal.Text = paginaFinal.ToString();

                    // → 5) Volver a poblar el ComboBox de páginas:
                    cbPagina.Items.Clear();
                    for (int i = 1; i <= paginaFinal; i++)
                        cbPagina.Items.Add(i);

                    // → 6) Caso “ya no quedan registros”:
                    if (total == 0)
                    {
                        // Limpia el DataGridView por completo:
                        tblEmpleados.DataSource = null;
                        lblNoEmpleados.Visible = true;
                        tblEmpleados.Visible = false;
                        return;
                    }

                    // → 7) Si todavía hay páginas, ajustar páginaActual:
                    if (numPagina > paginaFinal)
                        numPagina = paginaFinal;
                    if (numPagina < 1)
                        numPagina = 1;

                    // → 8) Forzar recarga de la página actual:
                    cbPagina.SelectedItem = numPagina;
                    // Esto dispara cbPagina_SelectedIndexChanged → MostrarPagina(numPagina)
                };
                messageBoxConfirmar.mostrarMessageBox();
            }
            else
            {
                new Toast("error", "No has seleccionado ningún empleado.").MostrarToast();
            }

        }

        private void btnAddEmpleado_Click(object sender, EventArgs e)
        {
            DatosPersonales vtnDatosPersonales = new DatosPersonales(infoEmpleadoAlta, "agregar");
            vtnDatosPersonales.EmpleadoAgregado += (s, ev) =>
            {
                dtCompleto = logicaNegocios.ConsultDatosEmpleados();
                int total = dtCompleto.Rows.Count;
                txtNumregistros.Text = total.ToString();

                // Si ya hay al menos 1 empleado, aseguro que se muestre la tabla:
                if (total > 0)
                {

                    lblNoEmpleados.Visible = false;
                    tblEmpleados.Visible = true;
                }

                // 2) Recalcular total de páginas
                paginaFinal = (int)Math.Ceiling(total / (double)numFilas);
                txtPaginaFinal.Text = paginaFinal.ToString();

                // 3) Actualizar ComboBox (vacío o con páginas anteriores)  
                cbPagina.Items.Clear();
                for (int i = 1; i <= paginaFinal; i++)
                    cbPagina.Items.Add(i);

                // 4) Ajustar página actual dentro del rango (1..paginaFinal)
                if (numPagina > paginaFinal)
                    numPagina = paginaFinal;
                if (numPagina < 1 && paginaFinal > 0)
                    numPagina = 1;

                // 5) Si hay páginas, seleccionar la actual para disparar MostrarPagina
                if (paginaFinal > 0)
                    cbPagina.SelectedItem = numPagina;
                else
                {
                    // Si después de agregar (muy improbable) quedara 0 registros: ocultar
                    lblNoEmpleados.Visible = true;
                    tblEmpleados.Visible = false;
                }

            };
            vtnDatosPersonales.ShowDialog();

        }

        private void GestionEmpleado_Load(object sender, EventArgs e)
        {
            // 1) Traer TODOS los empleados
            dtCompleto = logicaNegocios.ConsultDatosEmpleados();

            int totalRegistros = dtCompleto.Rows.Count;
            txtNumregistros.Text = totalRegistros.ToString();

            // 2) Calcular páginas necesarias (10 filas por página)
            paginaFinal = (int)Math.Ceiling(totalRegistros / (double)numFilas);
            txtPaginaFinal.Text = paginaFinal.ToString();

            // 3) Llenar ComboBox de páginas
            cbPagina.Items.Clear();
            for (int i = 1; i <= paginaFinal; i++)
                cbPagina.Items.Add(i);

            // 4) Mostrar tabla o etiqueta “no hay” según corresponda
            if (totalRegistros > 0 && cbPagina.Items.Count > 0)
            {
                lblNoEmpleados.Visible = false;
                tblEmpleados.Visible = true;
                cbPagina.SelectedIndex = 0; // dispara cbPagina_SelectedIndexChanged → MostrarPagina(1)
            }
            else
            {
                // No hay empleados: mostrar mensaje y ocultar la grilla
                lblNoEmpleados.Visible = true;
                tblEmpleados.Visible = false;
            }

            this.ActiveControl = pnlContenido;

            // 5) Desactivar en Load el ajuste automático del ancho de columnas;
            //    el ancho se fijará en MostrarPagina, luego de asignar DataSource.
            tblEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn col in tblEmpleados.Columns)
                col.Width = 175;
        }

        private void MostrarPagina(int pagina)
        {
            // 1) Obtener filas de la página:
            var filas = dtCompleto.AsEnumerable()
                .Skip((pagina - 1) * numFilas)
                .Take(numFilas);

            // 2) Copiar a nuevo DataTable o clonar si no hay filas
            DataTable dtPagina = filas.Any()
                ? filas.CopyToDataTable()
                : dtCompleto.Clone();

            // 3) Asignar DataSource
            tblEmpleados.DataSource = dtPagina;

            // 4) Ahora que sí existen las columnas, renombrar encabezados:
            if (tblEmpleados.Columns.Contains("nombres"))
                tblEmpleados.Columns["nombres"].HeaderText = "Nombres";
            if (tblEmpleados.Columns.Contains("apellidoPaterno"))
                tblEmpleados.Columns["apellidoPaterno"].HeaderText = "Apellido Paterno";
            if (tblEmpleados.Columns.Contains("apellidoMaterno"))
                tblEmpleados.Columns["apellidoMaterno"].HeaderText = "Apellido Materno";
            if (tblEmpleados.Columns.Contains("numTelefono"))
                tblEmpleados.Columns["numTelefono"].HeaderText = "Número de Teléfono";
            if (tblEmpleados.Columns.Contains("numEmpleado"))
                tblEmpleados.Columns["numEmpleado"].HeaderText = "Número de Empleado";
            if (tblEmpleados.Columns.Contains("fechaNacimiento"))
                tblEmpleados.Columns["fechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            if (tblEmpleados.Columns.Contains("calle"))
                tblEmpleados.Columns["calle"].HeaderText = "Calle";
            if (tblEmpleados.Columns.Contains("colonia"))
                tblEmpleados.Columns["colonia"].HeaderText = "Colonia";
            if (tblEmpleados.Columns.Contains("numExterior"))
                tblEmpleados.Columns["numExterior"].HeaderText = "Número Exterior";
            if (tblEmpleados.Columns.Contains("numInterior"))
                tblEmpleados.Columns["numInterior"].HeaderText = "Número Interior";
            if (tblEmpleados.Columns.Contains("codigoPostal"))
                tblEmpleados.Columns["codigoPostal"].HeaderText = "Código postal";

            // 5) Ajustar ancho de columnas de forma proporcional
            tblEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn col in tblEmpleados.Columns)
                col.Width = tblEmpleados.Width / tblEmpleados.Columns.Count;
        }

        private void cbPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbPagina.SelectedItem.ToString(), out int pagina))
            {
                numPagina = pagina;
                MostrarPagina(numPagina);
            }
        }


        private void GestionEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {

                switch (e.KeyCode)
                {

                    case Keys.A:
                        btnAltaEmpleado.PerformClick();
                        break;

                    case Keys.E:
                        btnBajaEmpleado.PerformClick();
                        break;

                    case Keys.M:
                        btnModEmpleado.PerformClick();
                        break;

                }

            }

        }

    }
}
