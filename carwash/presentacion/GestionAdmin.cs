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
    public partial class GestionAdmin : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private InfoAdministrador infoAdminAlta = new InfoAdministrador();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        int numPagina = 1;
        int numIndice = 0;
        int numFilas = 12;
        int paginaFinal;
        private DataTable dtCompleto;

        public GestionAdmin()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.Load += GestionAdmin_Load;
            cbPagina.SelectedIndexChanged += cbPagina_SelectedIndexChanged;
        }

        private void GestionAdmin_Load(object sender, EventArgs e)
        {
            dtCompleto = logicaNegocios.ConsAdmins();

            // Se cuenta el total de registros y luego se muestra
            int totalRegistros = dtCompleto.Rows.Count;
            txtNumregistros.Text = totalRegistros.ToString();

            // Se calcula la cantidad total de páginas necesarias y se muestra numero de pagina final
            paginaFinal = (int)Math.Ceiling(totalRegistros / (double)numFilas);
            txtPaginaFinal.Text = paginaFinal.ToString();

            // Se llena el ComboBox con los números de página disponibles
            cbPagina.Items.Clear();
            for (int i = 1; i <= paginaFinal; i++)
                cbPagina.Items.Add(i);

            // Se selecciona la primera página por defecto si hay elementos
            if (cbPagina.Items.Count > 0)
                cbPagina.SelectedIndex = 0;
        }

        private void MostrarPagina(int pagina)
        {
            // Se obtienen las filas correspondientes a la página actual
            var filas = dtCompleto.AsEnumerable()
                .Skip((pagina - 1) * numFilas)
                .Take(numFilas);

            // Se copian las filas a una nueva tabla, o se crea una vacía si no hay filas
            DataTable dtPagina = filas.Any()
                ? filas.CopyToDataTable()
                : dtCompleto.Clone();

            // Se filtran las columnas visibles en la tabla 
            DataTable dtFiltrado = dtPagina.DefaultView
                .ToTable(false, "nombreUsuario", "contrasena");

            // Ajusta el ancho de columnas según el número de columnas
            tblAdmins.DataSource = dtFiltrado;
            tblAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn col in tblAdmins.Columns)
                col.Width = tblAdmins.Width / tblAdmins.Columns.Count;

            // Se cambian los encabezados de columna a texto más amigable
            if (tblAdmins.Columns.Contains("nombreUsuario"))
                tblAdmins.Columns["nombreUsuario"].HeaderText = "Nombre de Usuario";
            if (tblAdmins.Columns.Contains("contrasena"))
                tblAdmins.Columns["contrasena"].HeaderText = "Contraseña";
        }

        // Evento que se ejecuta al cambiar el número de página en el ComboBox
        private void cbPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbPagina.SelectedItem.ToString(), out int pagina))
            {
                numPagina = pagina;
                MostrarPagina(numPagina);
            }
        }

        private void btnAltaAdmin_Click(object sender, EventArgs e)
        {
            var ventanaAlta = new AltaAdmin(infoAdminAlta, "alta");
            ventanaAlta.AdminAgregado += (s, args) =>
            {
                // Se actualizan los datos después de agregar un administrador
                dtCompleto = logicaNegocios.ConsAdmins();

                // Se obtiene el nuevo total de registros
                int total = dtCompleto.Rows.Count;
                txtNumregistros.Text = total.ToString();

                // Se recalculan las páginas necesarias
                paginaFinal = (int)Math.Ceiling(total / (double)numFilas);
                txtPaginaFinal.Text = paginaFinal.ToString();

                // Se actualiza el ComboBox si hay una nueva página
                if (cbPagina.Items.Count < paginaFinal)
                    cbPagina.Items.Add(paginaFinal);

                // Se ajusta la página actual si es necesario
                if (numPagina > paginaFinal)
                    numPagina = paginaFinal;

                cbPagina.SelectedItem = numPagina;
                MostrarPagina(numPagina);
            };
            ventanaAlta.ShowDialog();
        }

        private void btnModAdmin_Click(object sender, EventArgs e)
        {
            if (tblAdmins.CurrentRow != null)
            {
                // se Leen los valores visibles
                string nombreUsuario = tblAdmins.CurrentRow.Cells["nombreUsuario"].Value.ToString()!;
                string contrasena = tblAdmins.CurrentRow.Cells["contrasena"].Value.ToString()!;

                // se buscar el DataRow completo (que incluye el "id")
                DataRow? row = dtCompleto.AsEnumerable().FirstOrDefault(r => r.Field<string>("nombreUsuario") == nombreUsuario
                     && r.Field<string>("contrasena") == contrasena);

                if (row is not null)
                {
                    // se cargar el InfoAdministrador con el id y datos
                    infoAdminAlta.Id = row.Field<int>("id");
                    infoAdminAlta.NombreUsuario = nombreUsuario;
                    infoAdminAlta.Contrasena = contrasena;

                    // se abre la ventana de modificación
                    var ventanaModificar = new AltaAdmin(infoAdminAlta, "modificar");
                    ventanaModificar.AdminAgregado += (s, args) =>
                    {
                        // refrescar todo 
                        dtCompleto = logicaNegocios.ConsAdmins();
                        // se actualizan txtNumregistros, cbPagina, txtPaginaFinal, MostrarPagina(numPagina)
                        MostrarPagina(numPagina);
                        int total = dtCompleto.Rows.Count;
                        txtNumregistros.Text = total.ToString();

                        // se actualizar número de páginas
                        paginaFinal = (int)Math.Ceiling((double)total / numFilas);
                        txtPaginaFinal.Text = paginaFinal.ToString();

                        cbPagina.Items.Clear();
                        for (int i = 1; i <= paginaFinal; i++)
                            cbPagina.Items.Add(i);
                    };
                    ventanaModificar.ShowDialog();
                }
                else
                {
                    new Toast("error", "No se encontró el registro completo del administrador.").MostrarToast();
                }
            }
            else
            {
                new Toast("error", "Debes seleccionar un administrador.").MostrarToast();
            }
        }

        private void GestionAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {

                switch (e.KeyCode)
                {

                    case Keys.A:
                        btnAltaAdmin.PerformClick();
                        break;
                    case Keys.M:
                        btnModAdmin.PerformClick();
                        break;
                }

            }
        }
    }
}

