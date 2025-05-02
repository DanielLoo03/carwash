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
    public partial class MessageBoxConfirmar : Form
    {

        private String mensaje;
        public event EventHandler ConfirmarPresionado;

        public MessageBoxConfirmar(string mensaje)
        {

            InitializeComponent();
            this.mensaje = mensaje;
            lblMensaje.Text = mensaje;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(63, 114, 175);
            this.FormBorderStyle = FormBorderStyle.None; //Se quita el borde por default
            EstablecerPosicion(0);
            //Al hacer clic en los botones, se disparan ciertos eventos.
            btnConfirmar.Click += (sender, e) => Confirmar();
            btnCancelar.Click += (sender, e) => Cancelar();

        }

        private void EstablecerPosicion(int y)
        {
            var pantalla = Screen.PrimaryScreen.WorkingArea;
            int margenDerecho = 30;
            int margenSuperior = 60;

            Location = new Point(pantalla.Right - Width - margenDerecho, pantalla.Top + y + margenSuperior);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pincel = new Pen(Color.FromArgb(190, 223, 255), 4)) //Primer parámetro es el color en RGB, segundo parámetro es el grosor en píxeles
            {
                //Pinta el borde manualmente, iniciando en la coordenada 300, 300 y de tamaño relativo al form
                e.Graphics.DrawRectangle(pincel, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            }
        }

        public void mostrarMessageBox()
        {

            ShowDialog();

        }

        public void Confirmar()
        {

            ConfirmarPresionado?.Invoke(this, EventArgs.Empty);
            Close();

        }

        public void Cancelar()
        {

            Close();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }

}
