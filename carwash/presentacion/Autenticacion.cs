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
    public partial class Autenticacion : Form
    {
        private LogicaNegocios logicaNegocios = new LogicaNegocios();

        public Autenticacion()
        {
            InitializeComponent();
            //Se cargan fuentes para Form desde los recursos de la capa (resources.resx)
            labelCarWash.Font = Fuentes.obtenerFuente(64, FontStyle.Bold, "Inter");
            labelLeo.Font = Fuentes.obtenerFuente(64, FontStyle.Bold, "Inter");
            labelInicioDeSesion.Font = Fuentes.obtenerFuente(36, FontStyle.Regular, "Nacelle");
        }

        private void Autenticacion_Load(object sender, EventArgs e)
        {

        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            String nombreUsuario = textBoxNombreUsuario.Text;
            String contrasena = textBoxContrasena.Text;

            if (logicaNegocios.login(nombreUsuario, contrasena))
            {
                MenuPrincipal ventanaMenuPrincipal = new MenuPrincipal();
                ventanaMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                labelCredencialesInvalidas.Visible = true;
            }
        }

        private void buttonMostrarEsconderContrasena_Click(object sender, EventArgs e)
        {
            if (textBoxContrasena.UseSystemPasswordChar == true)
            {
                textBoxContrasena.UseSystemPasswordChar = false;
                buttonMostrarEsconderContrasena.Image = Image.FromFile("../../../recursos/imagenes/esconderContrasena.png");
            }
            else {
                textBoxContrasena.UseSystemPasswordChar = true;
                buttonMostrarEsconderContrasena.Image = Image.FromFile("../../../recursos/imagenes/mostrarContrasena.png");
            }
        }
    }
}
