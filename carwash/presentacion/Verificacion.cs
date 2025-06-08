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
    public partial class Verificacion : Form
    {
        private string usuarioActual;
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        public bool VerificacionExitosa { get; private set; } = false;
        public event EventHandler verificar;
        public Verificacion(String usuarioAct)
        {
            InitializeComponent();
            verificar?.Invoke(this, EventArgs.Empty);
            this.usuarioActual = usuarioAct;
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string pwdIngresada = txtCont.Text.Trim();

            if (string.IsNullOrEmpty(pwdIngresada))
            {
                new Toast("error", "Debe de ingresar su contraseña para la verificacion").MostrarToast();
                return;
            }

            DataTable admins = logicaNegocios.GetAdmins();

            foreach (DataRow admin in admins.Rows)
            {
                if (admin["nombreUsuario"].ToString().Equals(usuarioActual, StringComparison.OrdinalIgnoreCase))
                {
                    string pwdReal = admin["contrasena"].ToString();

                    if (pwdIngresada == pwdReal)
                    {
                        VerificacionExitosa = true;
                        this.Close();
                        return;
                    }
                    else
                    {
                        new Toast("error", "La contraseña ingresada es incorrecta").MostrarToast();
                        return;
                    }
                }
            }

            new Toast("error", "No se encontro al usuario").MostrarToast();
        }

        private void btnMostrarPwd1_Click(object sender, EventArgs e)
        {
            if (txtCont.UseSystemPasswordChar == true)
            {
                txtCont.UseSystemPasswordChar = false;
                btnMostrarPwd1.Image = Image.FromFile("../../../recursos/imagenes/esconderContrasena.png");
            }
            else
            {
                txtCont.UseSystemPasswordChar = true;
                btnMostrarPwd1.Image = Image.FromFile("../../../recursos/imagenes/mostrarContrasena.png");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            new Toast("error","Se cancelo la verificacion").MostrarToast();
            this.Close();
        }

        private void Verificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Toast("error", "Se cancelo la verificacion").MostrarToast();
            this.Close();
        }

    }
}

