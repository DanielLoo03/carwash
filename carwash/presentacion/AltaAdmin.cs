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
    public partial class AltaAdmin : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();
        private InfoAdministrador infoAdmin = new InfoAdministrador();
        public event EventHandler AdminAgregado;
        private string accion;
        private int idActual = 0;

        public AltaAdmin(InfoAdministrador infoAdmin, string accion)
        {
            this.infoAdmin = infoAdmin;
            this.accion = accion;
            InitializeComponent();
            this.FormClosing += AltaAdmin_FormClosing;
            this.KeyPreview = true;

            if (accion == "modificar")
            {
                txtNomUsuario.Text = infoAdmin.NombreUsuario;
                txtCont.Text = infoAdmin.Contrasena;
            }
        }

        private void guardarDatos()
        {
            infoAdmin.NombreUsuario = txtNomUsuario.Text.Trim();
            infoAdmin.Contrasena = txtCont.Text;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = txtNomUsuario.Text.Trim();
            string contrasena = txtCont.Text;
            string confirm = txtConfCont.Text;


            //Si los campos obligatorios estan vacios, marca error
            TextBox[] nomUsuario = { txtNomUsuario };
            if (validacionesUI.EvalTxtVacios(nomUsuario))
            {
                new Toast("error", " El campo de nombre de usuario es obligatorio (debe ser llenado).").MostrarToast();
                return;
            }

            TextBox[] cont = { txtCont };
            if (validacionesUI.EvalTxtVacios(cont))
            {
                new Toast("error", "El campo de contraseña es obligatorio (debe ser llenado).").MostrarToast();
                return;
            }

            TextBox[] contConfir = { txtNomUsuario, txtCont, txtConfCont };
            if (validacionesUI.EvalTxtVacios(contConfir))
            {
                new Toast("error", "El campo de confirmacion de contraseña es obligatorio (debe ser llenado).").MostrarToast();
                return;
            }


            if (validacionesUI.EvalCamposCharEsp(new object[] { txtNomUsuario }, "[^a-zA-Z.\\-_]"))
            {
                new Toast("error", "El nombre de usuario solo permite letras, punto (.), guión medio (-) y guión bajo (_).").MostrarToast();
                return;
            }

            //Si la contraseña ingresada en confirmacion no coincide, marca error
            if (!contrasena.Equals(confirm))
            {
                new Toast("error", "Las contraseñas no coinciden.").MostrarToast();
                return;
            }

            // si se ingresan mas de 50 caracteres en la contrasena
            TextBox[] passBoxes = { txtCont };
            if (validacionesUI.EvalTxtChars(passBoxes, 50))
            {
                new Toast("error", "La contraseña no puede exceder 50 caracteres.").MostrarToast();
                return;
            }

            //Se valida que el nombre ingresado ya esta en uso
            if (accion == "alta" && new ValidacionesUI().EvalUsuarioExistente(usuario))
            {
                new Toast("error", "El nombre de usuario ya existe.").MostrarToast();
                return;
            }

            //Se valida que el nombre ingresado ya esta en uso
            if (accion == "modificar" && new ValidacionesUI().EvalUsuarioExistente(usuario))
            {
                new Toast("error", "El nombre de usuario ya existe.").MostrarToast();
                return;
            }

            //Si todo esta ingresado de forma correcta, se agrega a administrador
            infoAdmin.NombreUsuario = usuario;
            infoAdmin.Contrasena = contrasena;

            //Se indica si la accion a realizar es una alta o modificacion
            if (accion == "alta")
            {
                logicaNegocios.AltaAdmin(usuario, contrasena);
                new Toast("exito", "Administrador creado exitosamente.").MostrarToast();
            }
            else if (accion == "modificar")
            {
                logicaNegocios.ModAdmin(infoAdmin.Id, usuario, contrasena);
                new Toast("exito", "Administrador modificado exitosamente.").MostrarToast();
            }

            txtNomUsuario.Clear();
            txtCont.Clear();
            txtConfCont.Clear();

            AdminAgregado?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void AltaAdmin_Load(object sender, EventArgs e)
        {
            txtNomUsuario.Text = infoAdmin.NombreUsuario;
            txtCont.Text = infoAdmin.Contrasena;
            idActual = infoAdmin.Id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomUsuario.Clear();
            txtCont.Clear();
            txtConfCont.Clear();
            this.Close();
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

        private void btnMostrarPwd2_Click(object sender, EventArgs e)
        {
            if (txtConfCont.UseSystemPasswordChar == true)
            {
                txtConfCont.UseSystemPasswordChar = false;
                btnMostrarPwd2.Image = Image.FromFile("../../../recursos/imagenes/esconderContrasena.png");
            }
            else
            {
                txtConfCont.UseSystemPasswordChar = true;
                btnMostrarPwd2.Image = Image.FromFile("../../../recursos/imagenes/mostrarContrasena.png");
            }
        }

        private void AltaAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            guardarDatos();
            this.Close();
        }

        private void AltaAdmin_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
