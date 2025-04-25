using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace presentacion
{
    public class Toast : Form
    {
        private Label lblMensaje; 
        private PictureBox imgIcono; // El icono de éxito, error, advertencia...
        private string tipo;

        public Toast(string tipo, string mensaje, int offsetY = 0)
        {
            this.tipo = tipo;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            TopMost = true;
            ForeColor = Color.White;
            Padding = new Padding(10);
            Size = new Size(400, 100);
            Cursor = Cursors.Hand;
            Opacity = 1;

            // Cargar la imagen antes del texto
            imgIcono = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(40, 40),
                Location = new Point(10, (Height - 40) / 2),
                BackColor = Color.Transparent
            };

            //Según el parámetro tipo, cargar imagen de error o éxito
            if (tipo.Equals("error")){
                imgIcono.Image = Image.FromFile("../../../recursos/imagenes/error.png");
            }
            else{
                imgIcono.Image = Image.FromFile("../../../recursos/imagenes/exito.png");
            }


            lblMensaje = new Label()
            {
                Text = mensaje,
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Nacelle", 9),
                BackColor = Color.Transparent,
                Cursor = Cursors.Hand,
                Padding = new Padding(60, 0, 0, 0) // Ajuste del texto para que no se sobreponga con la imagen
            };

            Controls.Add(imgIcono);  
            Controls.Add(lblMensaje);

            EstablecerPosicion(offsetY);

            this.Click += (s, e) => Cerrar();
            lblMensaje.Click += (s, e) => Cerrar();
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

            Color colorInicio = tipo.Equals("error") ? Color.Red : Color.Green;
            Color colorFin = tipo.Equals("error") ? Color.DarkRed : Color.DarkGreen;

            using (LinearGradientBrush pincel = new LinearGradientBrush(ClientRectangle, colorInicio, colorFin, 90F))
            {
                e.Graphics.FillRectangle(pincel, ClientRectangle);
            }
        }


        public void MostrarToast()
        {
            Show();
        }

        private void Cerrar()
        {
            Close();
        }
    }
}
