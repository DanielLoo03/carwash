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
            this.Load += GestionAdmin_Load;
            cbPagina.SelectedIndexChanged += cbPagina_SelectedIndexChanged;
        }



        private void GestionAdmin_Load(object sender, EventArgs e)
        {
            dtCompleto = logicaNegocios.ConsAdmins();

            int totalRegistros = dtCompleto.Rows.Count;
            txtNumregistros.Text = totalRegistros.ToString();

            paginaFinal = (int)Math.Ceiling(totalRegistros / (double)numFilas);
            txtPaginaFinal.Text = paginaFinal.ToString();

            cbPagina.Items.Clear();
            for (int i = 1; i <= paginaFinal; i++)
                cbPagina.Items.Add(i);

            if (cbPagina.Items.Count > 0)
                cbPagina.SelectedIndex = 0;
        }

        private void MostrarPagina(int pagina)
        {
            var filas = dtCompleto.AsEnumerable()
                .Skip((pagina - 1) * numFilas)
                .Take(numFilas);

            DataTable dtPagina = filas.Any()
                ? filas.CopyToDataTable()
                : dtCompleto.Clone();

            DataTable dtFiltrado = dtPagina.DefaultView
                .ToTable(false, "nombreUsuario", "contrasena");


            tblAdmins.DataSource = dtFiltrado;
            tblAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn col in tblAdmins.Columns)
                col.Width = tblAdmins.Width / tblAdmins.Columns.Count;

            if (tblAdmins.Columns.Contains("nombreUsuario"))
                tblAdmins.Columns["nombreUsuario"].HeaderText = "Nombre de Usuario";
            if (tblAdmins.Columns.Contains("contrasena"))
                tblAdmins.Columns["contrasena"].HeaderText = "Contraseña";
        }

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
                dtCompleto = logicaNegocios.ConsAdmins();

                int total = dtCompleto.Rows.Count;
                txtNumregistros.Text = total.ToString();

                paginaFinal = (int)Math.Ceiling(total / (double)numFilas);
                txtPaginaFinal.Text = paginaFinal.ToString();

                if (cbPagina.Items.Count < paginaFinal)
                    cbPagina.Items.Add(paginaFinal);

                if (numPagina > paginaFinal)
                    numPagina = paginaFinal;

                cbPagina.SelectedItem = numPagina;
                MostrarPagina(numPagina);
            };
            ventanaAlta.ShowDialog();
        }

        private void GestionAdmin_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

