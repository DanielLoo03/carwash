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
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private MenuPrincipal ventanaMenuPrincipal;

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
            TextBox[] textBoxesEvaluar = {textBoxNombreUsuario, textBoxContrasena};

            if (ventanaMenuPrincipal == null) {
                ventanaMenuPrincipal = new MenuPrincipal(this);
            }

            if (validacionesUI.validarSiCamposVacios(textBoxesEvaluar) == true) {
                if (labelCredencialesInvalidas.Visible == true || labelContrasenaExcedeCaracteres.Visible == true) { labelCredencialesInvalidas.Visible = false; labelContrasenaExcedeCaracteres.Visible = false; }
                labelCampoVacio.Visible = true;
                return;
            }

            if (textBoxNombreUsuario.Text.Length > 50) {
                labelNombreUsuarioExcedeCaracteres.Visible = true;
            }
            if (textBoxContrasena.Text.Length > 50) {
                if (labelCampoVacio.Visible == true || labelCredencialesInvalidas.Visible == true) { labelCampoVacio.Visible = false; labelCredencialesInvalidas.Visible = false; }
                labelContrasenaExcedeCaracteres.Visible = true;
                return;
            }

            if (logicaNegocios.login(nombreUsuario, contrasena))
            {
                ventanaMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                if (labelCampoVacio.Visible == true || labelContrasenaExcedeCaracteres.Visible == true) { labelCampoVacio.Visible = false; labelContrasenaExcedeCaracteres.Visible = false; }
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
