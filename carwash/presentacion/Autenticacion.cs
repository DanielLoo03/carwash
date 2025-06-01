using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;

namespace presentacion
{
    public partial class Autenticacion : Form
    {
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private ValidacionesUI validacionesUI = new ValidacionesUI();

        public Autenticacion()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String nombreUsr = txtNombreUsr.Text;
            String pwd = txtPwd.Text;
            TextBox[] textBoxesEvaluar = { txtNombreUsr, txtPwd };

            if (validacionesUI.EvalTxtVacios(textBoxesEvaluar) == true)
            {
                Toast toast = new Toast("error", "Los campos de nombre de usuario y contraseña deben ser llenados.");
                toast.Show();
            }

            if (txtNombreUsr.Text.Length > 50)
            {
                Toast toast = new Toast("error", "El nombre de usuario no puede exceder 50 caracteres.");
                toast.Show();
            }

            if (txtPwd.Text.Length > 50)
            {
                Toast toast = new Toast("error", "La contraseña no puede exceder 50 caracteres.");
                toast.Show();
            }

            if (logicaNegocios.Login(nombreUsr, pwd))
            {

                PantallaPrincipal vtnGestionEmpleados = new PantallaPrincipal(this, nombreUsr);
                vtnGestionEmpleados.Show();
                this.Hide();

            }
            else
            {
                Toast toast = new Toast("error", "Credenciales inválidas.");
                toast.Show();
            }
        }

        private void btnMostrarPwd_Click(object sender, EventArgs e)
        {
            if (txtPwd.UseSystemPasswordChar == true)
            {
                txtPwd.UseSystemPasswordChar = false;
                btnMostrarPwd.Image = Image.FromFile("../../../recursos/imagenes/esconderContrasena.png");
            }
            else
            {
                txtPwd.UseSystemPasswordChar = true;
                btnMostrarPwd.Image = Image.FromFile("../../../recursos/imagenes/mostrarContrasena.png");
            }
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {
            //Redondeo de pnlLogin
            int radioEsquinas = 20; //Redondeo de las esquinas
            Rectangle areaPanel = pnlLogin.ClientRectangle; // área del panel

            using (GraphicsPath rutaRedondeada = PanelAndBotonRedondeado(areaPanel, radioEsquinas))
            {
                pnlLogin.Region = new Region(rutaRedondeada); // recorta visualmente el panel con esquinas redondeadas
            }

            //Redondeo de btnLogin
            int radio = 10;
            Rectangle areaBoton = btnLogin.ClientRectangle;
            btnLogin.Region = new Region(PanelAndBotonRedondeado(areaBoton, radio));

        }

        public GraphicsPath PanelAndBotonRedondeado(Rectangle area, int radio)
        {
            GraphicsPath ruta = new GraphicsPath();
            int diametro = radio * 2;

            ruta.AddArc(area.X, area.Y, diametro, diametro, 180, 90); // esquina superior izquierda
            ruta.AddArc(area.Right - diametro, area.Y, diametro, diametro, 270, 90); // esquina superior derecha
            ruta.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90); // esquina inferior derecha
            ruta.AddArc(area.X, area.Bottom - diametro, diametro, diametro, 90, 90); // esquina inferior izquierda
            ruta.CloseFigure();

            return ruta;
        }

        private void Autenticacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                btnLogin.PerformClick();

            }
            else if (e.Shift && e.KeyCode == Keys.C){ 
            
                btnMostrarPwd.PerformClick();  
            
            }
        }
    }
}
