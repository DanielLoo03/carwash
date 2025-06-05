using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;


namespace presentacion
{
    public partial class ReapCaja : Form
    {

        private InfoReapCaja infoReapCaja;
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        public event EventHandler reapConfirm;
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private string nomUsuario;
        private System.Windows.Forms.Timer timer;
        public ReapCaja(InfoReapCaja infoReapCaja, string nomUsuario)
        {

            this.infoReapCaja = infoReapCaja;
            this.nomUsuario = nomUsuario;
            InitializeComponent();
            this.KeyPreview = true;
            // Configura el temporizador
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Cada segundo
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            this.Close();
        }

        private void GuardarDatos()
        {

            infoReapCaja.Descripcion = txtDesc.Text;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //Para pasarlo como parámetro a EvalTxtVacios()
            TextBox[] txtDescParam = { txtDesc };

            //Condición: Si el campo de descripción se encuentra vacío
            if (validacionesUI.EvalTxtVacios(txtDescParam))
            {

                Toast tstError = new Toast("error", "Los campos obligatorios deben ser llenados (los que tienen el *)");
                tstError.Show();

            }
            //Condición: Si el campo de descripción se encuentra lleno
            else
            {

                MessageBoxConfirmar msgBox = new MessageBoxConfirmar("¿Está seguro de realizar la reapertura de caja?\nSolo puede realizar una reapertura por día.");
                //Si se presiona el botón de Confirmar, se ejecuta el siguiente código
                msgBox.ConfirmarPresionado += (s, ev) =>
                {
                    int idAdmin = (int)logicaNegocios.ObtenerIdAdmin(nomUsuario).Rows[0]["id"];
                    logicaNegocios.AltaBitacora(idAdmin, DateTime.Now, txtDesc.Text);
                    //Se reabre caja
                    logicaNegocios.ModEstadoCaja(true);
                    Toast tstExito = new Toast("exito", "Reapertura de caja realizada con éxito");
                    tstExito.Show();
                    reapConfirm?.Invoke(this, EventArgs.Empty);
                    this.Close();

                };
                msgBox.mostrarMessageBox();

            }

        }

        private void ReapCaja_Load(object sender, EventArgs e)
        {

            txtAdmin.Text = nomUsuario;
            txtFechaHora.Text = DateTime.Now.ToString();

        }

        private void ReapCaja_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Alt)
            {

                if (e.KeyCode == Keys.C)
                {

                    btnConfirmar.PerformClick();

                }

            }

        }

        //Convertimos todo lo ingresado al campo de texto Descripción a mayúsculas
        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

            // Registra la posición actual del cursor
            int cursor = txtDesc.SelectionStart;

            txtDesc.Text = txtDesc.Text.ToUpper();

            // Restaura la posición del cursor
            txtDesc.SelectionStart = cursor;

        }

        //Cada segundo se dispara el evento para actualizar la fecha y hora
        private void Timer_Tick(object sender, EventArgs e)
        {
            txtFechaHora.Text = DateTime.Now.ToString();
        }
    }
}
