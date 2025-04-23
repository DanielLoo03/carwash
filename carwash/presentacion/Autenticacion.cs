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

        public Autenticacion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String nombreUsr = txtNombreUsr.Text;
            String pwd = txtPwd.Text;
            TextBox[] textBoxesEvaluar = { txtNombreUsr, txtPwd };

            if (validacionesUI.EvalTxtVacios(textBoxesEvaluar) == true)
            {
                Toast toast = new Toast("Los campos de nombre de usuario y contraseña deben ser llenados.");
                toast.Show();
            }

            if (txtNombreUsr.Text.Length > 50)
            {
                Toast toast = new Toast("El nombre de usuario no puede exceder 50 caracteres.");
                toast.Show();
            }

            if (txtPwd.Text.Length > 50)
            {
                Toast toast = new Toast("La contraseña no puede exceder 50 caracteres.");
                toast.Show();
            }

            if (logicaNegocios.Login(nombreUsr, pwd))
            {
                return;
            }
            else
            {
                Toast toast = new Toast("Credenciales inválidas.");
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
        }
    }
}
