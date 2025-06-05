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
    public partial class CorteCaja : Form
    {

        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private InfoCorteCaja infoCorte = new InfoCorteCaja();
        private DateTime fecha = DateTime.Today.Date;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private string nomUsuario;

        public CorteCaja(string nomUsuario)
        {
            this.nomUsuario = nomUsuario;
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnRealizarCorte_Click(object sender, EventArgs e)
        {

            //Si ya hay corte de caja en el día de hoy, no permitas realizarlo
            if (logicaNegocios.ConsFechaCorte() == DateTime.Today)
            {

                MessageBox.Show("Ya existe un corte de caja realizado el día de hoy.");

            }
            //Si no hay corte de caja en el día de hoy, permite realizarlo 
            else
            {

                AltaCorte vtnAltaCorte = new AltaCorte(infoCorte, nomUsuario);
                //Se asocia evento a ventana de alta de corte
                vtnAltaCorte.corteRealizado += (s, e) =>
                {

                    //Muestra los datos registrados 
                    dtFecha.Value = DateTime.Today;
                    dtFecha_ValueChanged(sender, e);

                };
                vtnAltaCorte.ShowDialog();

            }

        }

        private void CorteCaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {

                if (e.KeyCode == Keys.R)
                {

                    btnRealizarCorte.PerformClick();

                }

            }
        }

        private void CorteCaja_Load(object sender, EventArgs e)
        {

            //Pone el foco en CorteCaja para que funcionen los atajos con el teclado
            this.Activate();
            this.Focus();

            //Se realiza consulta respecto al día actual 
            dtFecha_ValueChanged(sender, e);

            //Se establece que la fecha máximo a elegir es el día actual
            dtFecha.MaxDate = DateTime.Today;

            //Cada minuto se actualiza la fecha máxima
            timer.Interval = 60000; //60 segundos
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void Timer_Tick(object sender, EventArgs e) {

            dtFecha.MaxDate = DateTime.Today;

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

            fecha = dtFecha.Value.Date;

            //Condición: si hay corte el día seleccionado, se muestra 
            if (logicaNegocios.ConsCorte(tblCorte, fecha))
            {
                //Se esconde el mensaje "No se ha realizado corte..."
                lblNoCorte.Visible = false;
                //Se muestran los campos con los valores cargados (y sus etiquetas)
                txtContado.Visible = true;
                txtCalculado.Visible = true;
                txtDiferencia.Visible = true;
                txtAdmin.Visible = true;
                lblContado.Visible = true;
                lblCalculado.Visible = true;
                lblDiferencia.Visible = true;
                lblAdmin.Visible = true;
                //Se cargan los datos correspondientes en cada campo
                txtContado.Text = tblCorte.Rows[0].Cells["contado"].Value.ToString();
                txtCalculado.Text = tblCorte.Rows[0].Cells["calculado"].Value.ToString();
                txtDiferencia.Text = tblCorte.Rows[0].Cells["diferencia"].Value.ToString();
                txtAdmin.Text = logicaNegocios.ObtNomUsuario((int)tblCorte.Rows[0].Cells["idAdmin"].Value);
                //Se formatean montos
                TextBox[] camposMontos = { txtContado, txtCalculado, txtDiferencia };
                FormatDiferencia(txtDiferencia);
                FormatMontos(camposMontos);

            }
            //Si no hay corte el día seleccionado, se muestra mensaje que avisa
            else
            {

                //Se muestra el mensaje "No se ha realizado corte..."
                lblNoCorte.Visible = true;
                //Se limpia txtContado para representar que no hay corte realizado
                txtContado.Text = "";
                //Se esconden los campos (y sus etiquetas)
                txtContado.Visible = false;
                txtCalculado.Visible = false;
                txtDiferencia.Visible = false;
                txtAdmin.Visible = false;
                lblContado.Visible = false;
                lblCalculado.Visible = false;
                lblDiferencia.Visible = false;
                lblAdmin.Visible = false;

            }

        }

        private void FormatMontos(TextBox[] montos)
        {

            foreach (TextBox txt in montos)
            {

                if (decimal.TryParse(txt.Text, out decimal monto))
                {

                    txt.Text = monto.ToString("C2");

                }

            }

        }

        //Se formatea el campo Diferencia para que se pinte de color dependiendo del estado
        private void FormatDiferencia(TextBox txtDiferencia)
        {

            //Si el valor en el campo de texto Diferencia es decimal
            if (decimal.TryParse(txtDiferencia.Text, out decimal diferencia))
            {

                //Sobrante
                if (diferencia > 0)
                {

                    txtDiferencia.ForeColor = Color.Green;

                }
                //Faltante
                else if (diferencia < 0)
                {

                    txtDiferencia.ForeColor = Color.Red;

                }
                //Cuadrado
                else
                {

                    txtDiferencia.ForeColor = Color.Black;

                }

            }

        }

        private void txtDiferencia_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete ||
                (e.Control && (e.KeyCode == Keys.V || e.KeyCode == Keys.X)))
            {
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true;
            }

        }

        private void txtDiferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
