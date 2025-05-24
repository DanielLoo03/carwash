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
            this.FormBorderStyle = FormBorderStyle.None; //Se quita el borde por default
            this.StartPosition = FormStartPosition.CenterScreen;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(63, 114, 175);
            //Al hacer clic en los botones, se disparan ciertos eventos.
            btnConfirmar.Click += (sender, e) => Confirmar();
            btnCancelar.Click += (sender, e) => Cancelar();
            ConfigLayoutDinamico(mensaje);

        }

        //Para especificar un tamaño del Form
        public MessageBoxConfirmar(string mensaje, int ancho, int largo)
        {

            InitializeComponent();
            this.Width = ancho;
            this.Height = largo;
            this.mensaje = mensaje;
            lblMensaje.Text = mensaje;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(63, 114, 175);
            this.FormBorderStyle = FormBorderStyle.None; //Se quita el borde por default
            //Al hacer clic en los botones, se disparan ciertos eventos.
            btnConfirmar.Click += (sender, e) => Confirmar();
            btnCancelar.Click += (sender, e) => Cancelar();
            this.StartPosition = FormStartPosition.CenterScreen;

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

        private void ConfigLayoutDinamico(string mensaje)
        {

            int margenExterior = 20;
            int espacioInterno = 20;
            int anchoMaximoTexto = 350;

            lblMensaje.AutoSize = false;
            lblMensaje.Text = mensaje;

            // Posicionamiento del PictureBox (esquina superior izquierda)
            imgAdvertencia.Location = new Point(margenExterior, margenExterior);
            int iconoAncho = imgAdvertencia.Width + espacioInterno;

            // Se mide el tamaño del texto dentro del ancho máximo disponible
            Size textoSize = TextRenderer.MeasureText(mensaje, lblMensaje.Font, new Size(anchoMaximoTexto, 0), TextFormatFlags.WordBreak);

            // Se ajusta el label para que esté a la derecha del icono
            lblMensaje.Size = textoSize;
            lblMensaje.Location = new Point(imgAdvertencia.Right + espacioInterno, margenExterior);

            // Se determina el ancho total del contenido (texto + icono)
            int anchoContenido = Math.Max(lblMensaje.Right, imgAdvertencia.Right) + margenExterior;

            // Se calcula el alto total hasta los botones
            int botonesY = Math.Max(lblMensaje.Bottom, imgAdvertencia.Bottom) + espacioInterno + 10;

            // Posicionamiento de botones
            btnConfirmar.Location = new Point(lblMensaje.Left, botonesY);
            btnCancelar.Location = new Point(btnConfirmar.Right + 10, botonesY);

            // Ancho total del formulario
            int anchoTotal = Math.Max(anchoContenido, btnCancelar.Right + margenExterior);

            // Alto total del formulario
            int altoTotal = btnConfirmar.Bottom + margenExterior;

            // Se aplica tamaño al formulario
            this.ClientSize = new Size(anchoTotal, altoTotal);

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
