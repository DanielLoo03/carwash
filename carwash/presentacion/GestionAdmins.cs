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
    public partial class GestionAdmins : Form
    {
        private ValidacionesUI validacionesUI = new ValidacionesUI();
        private InfoAdministrador infoAdminAlta = new InfoAdministrador();
        private LogicaNegocios logicaNegocios = new LogicaNegocios();

        private Label lblDatosUsuario;
        private Label lblNombre;
        private Label obligatorio;
        private TextBox txtNomUsuario;
        private TextBox txtConfCont;
        private Label label1;
        private Label lblConfCont;
        private TextBox txtCont;
        private Label label2;
        private Label lblCont;
        private Label camposOblig;
        private Button btnConfirAlta;
        private Button btnMostrarPwd1;
        private Button btnMostrarPwd2;
        private Button btnCanAlta;

        public GestionAdmins()
        {
            InitializeComponent();
            this.Load += GestionAdmins_Load;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(GestionAdmins));
            pnlCabecera = new Panel();
            lblGestionDe = new Label();
            lblAdmins = new Label();
            pnlContenido = new Panel();
            pnlBorde = new Panel();
            btnMostrarPwd2 = new Button();
            btnMostrarPwd1 = new Button();
            btnCanAlta = new Button();
            btnConfirAlta = new Button();
            camposOblig = new Label();
            txtConfCont = new TextBox();
            label1 = new Label();
            lblConfCont = new Label();
            txtCont = new TextBox();
            label2 = new Label();
            lblCont = new Label();
            txtNomUsuario = new TextBox();
            obligatorio = new Label();
            lblNombre = new Label();
            lblDatosUsuario = new Label();
            tblAdmins = new DataGridView();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlBorde.SuspendLayout();
            ((ISupportInitialize)tblAdmins).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(lblGestionDe);
            pnlCabecera.Controls.Add(lblAdmins);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 3;
            // 
            // lblGestionDe
            // 
            lblGestionDe.AutoSize = true;
            lblGestionDe.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDe.ForeColor = Color.White;
            lblGestionDe.Location = new Point(16, 27);
            lblGestionDe.Name = "lblGestionDe";
            lblGestionDe.Size = new Size(235, 46);
            lblGestionDe.TabIndex = 2;
            lblGestionDe.Text = "Gestión de ";
            // 
            // lblAdmins
            // 
            lblAdmins.AutoSize = true;
            lblAdmins.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmins.ForeColor = Color.FromArgb(63, 114, 175);
            lblAdmins.Location = new Point(247, 28);
            lblAdmins.Name = "lblAdmins";
            lblAdmins.Size = new Size(323, 46);
            lblAdmins.TabIndex = 1;
            lblAdmins.Text = "Administradores";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = SystemColors.Window;
            pnlContenido.BorderStyle = BorderStyle.FixedSingle;
            pnlContenido.Controls.Add(pnlBorde);
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1819, 547);
            pnlContenido.TabIndex = 4;
            // 
            // pnlBorde
            // 
            pnlBorde.BorderStyle = BorderStyle.FixedSingle;
            pnlBorde.Controls.Add(btnMostrarPwd2);
            pnlBorde.Controls.Add(btnMostrarPwd1);
            pnlBorde.Controls.Add(btnCanAlta);
            pnlBorde.Controls.Add(btnConfirAlta);
            pnlBorde.Controls.Add(camposOblig);
            pnlBorde.Controls.Add(txtConfCont);
            pnlBorde.Controls.Add(label1);
            pnlBorde.Controls.Add(lblConfCont);
            pnlBorde.Controls.Add(txtCont);
            pnlBorde.Controls.Add(label2);
            pnlBorde.Controls.Add(lblCont);
            pnlBorde.Controls.Add(txtNomUsuario);
            pnlBorde.Controls.Add(obligatorio);
            pnlBorde.Controls.Add(lblNombre);
            pnlBorde.Controls.Add(lblDatosUsuario);
            pnlBorde.Controls.Add(tblAdmins);
            pnlBorde.Location = new Point(76, 47);
            pnlBorde.Name = "pnlBorde";
            pnlBorde.Size = new Size(1663, 479);
            pnlBorde.TabIndex = 13;
            // 
            // btnMostrarPwd2
            // 
            btnMostrarPwd2.FlatStyle = FlatStyle.Flat;
            btnMostrarPwd2.ForeColor = SystemColors.Window;
            btnMostrarPwd2.Image = (Image)resources.GetObject("btnMostrarPwd2.Image");
            btnMostrarPwd2.Location = new Point(647, 328);
            btnMostrarPwd2.Name = "btnMostrarPwd2";
            btnMostrarPwd2.Size = new Size(37, 27);
            btnMostrarPwd2.TabIndex = 48;
            btnMostrarPwd2.UseVisualStyleBackColor = true;
            btnMostrarPwd2.Click += btnMostrarPwd2_Click;
            // 
            // btnMostrarPwd1
            // 
            btnMostrarPwd1.FlatStyle = FlatStyle.Flat;
            btnMostrarPwd1.ForeColor = SystemColors.Window;
            btnMostrarPwd1.Image = (Image)resources.GetObject("btnMostrarPwd1.Image");
            btnMostrarPwd1.Location = new Point(647, 232);
            btnMostrarPwd1.Name = "btnMostrarPwd1";
            btnMostrarPwd1.Size = new Size(37, 27);
            btnMostrarPwd1.TabIndex = 47;
            btnMostrarPwd1.UseVisualStyleBackColor = true;
            btnMostrarPwd1.Click += btnMostrarPwd1_Click;
            // 
            // btnCanAlta
            // 
            btnCanAlta.BackColor = Color.FromArgb(63, 114, 175);
            btnCanAlta.FlatStyle = FlatStyle.Popup;
            btnCanAlta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCanAlta.ForeColor = Color.White;
            btnCanAlta.Image = (Image)resources.GetObject("btnCanAlta.Image");
            btnCanAlta.ImageAlign = ContentAlignment.MiddleLeft;
            btnCanAlta.Location = new Point(70, 402);
            btnCanAlta.Name = "btnCanAlta";
            btnCanAlta.Size = new Size(206, 38);
            btnCanAlta.TabIndex = 46;
            btnCanAlta.Text = "Cancelar Registro";
            btnCanAlta.TextAlign = ContentAlignment.MiddleRight;
            btnCanAlta.UseVisualStyleBackColor = false;
            btnCanAlta.Click += btnCanAlta_Click;
            // 
            // btnConfirAlta
            // 
            btnConfirAlta.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirAlta.FlatStyle = FlatStyle.Flat;
            btnConfirAlta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirAlta.ForeColor = SystemColors.Window;
            btnConfirAlta.Image = (Image)resources.GetObject("btnConfirAlta.Image");
            btnConfirAlta.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirAlta.Location = new Point(421, 402);
            btnConfirAlta.Name = "btnConfirAlta";
            btnConfirAlta.Size = new Size(207, 43);
            btnConfirAlta.TabIndex = 45;
            btnConfirAlta.Text = "Confirmar Alta";
            btnConfirAlta.TextAlign = ContentAlignment.MiddleRight;
            btnConfirAlta.UseVisualStyleBackColor = false;
            btnConfirAlta.Click += btnConfirAlta_Click;
            // 
            // camposOblig
            // 
            camposOblig.AutoSize = true;
            camposOblig.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camposOblig.ForeColor = SystemColors.Desktop;
            camposOblig.Location = new Point(437, 85);
            camposOblig.Name = "camposOblig";
            camposOblig.Size = new Size(189, 22);
            camposOblig.TabIndex = 24;
            camposOblig.Text = "* Campos Obligatorios";
            // 
            // txtConfCont
            // 
            txtConfCont.Location = new Point(70, 322);
            txtConfCont.Name = "txtConfCont";
            txtConfCont.Size = new Size(555, 31);
            txtConfCont.TabIndex = 23;
            txtConfCont.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(249, 295);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 22;
            label1.Text = "*";
            // 
            // lblConfCont
            // 
            lblConfCont.AutoSize = true;
            lblConfCont.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfCont.Location = new Point(71, 293);
            lblConfCont.Name = "lblConfCont";
            lblConfCont.Size = new Size(186, 22);
            lblConfCont.TabIndex = 21;
            lblConfCont.Text = "Confirmar Contraseña";
            // 
            // txtCont
            // 
            txtCont.Location = new Point(71, 228);
            txtCont.Name = "txtCont";
            txtCont.Size = new Size(555, 31);
            txtCont.TabIndex = 20;
            txtCont.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(163, 198);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 19;
            label2.Text = "*";
            // 
            // lblCont
            // 
            lblCont.AutoSize = true;
            lblCont.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCont.Location = new Point(70, 197);
            lblCont.Name = "lblCont";
            lblCont.Size = new Size(103, 22);
            lblCont.TabIndex = 18;
            lblCont.Text = "Contraseña";
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.Location = new Point(71, 133);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(555, 31);
            txtNomUsuario.TabIndex = 17;
            // 
            // obligatorio
            // 
            obligatorio.AutoSize = true;
            obligatorio.ForeColor = Color.Red;
            obligatorio.Location = new Point(229, 107);
            obligatorio.Name = "obligatorio";
            obligatorio.Size = new Size(20, 25);
            obligatorio.TabIndex = 16;
            obligatorio.Text = "*";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(71, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(162, 22);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre de usuario";
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosUsuario.Location = new Point(147, 17);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(408, 46);
            lblDatosUsuario.TabIndex = 1;
            lblDatosUsuario.Text = "Alta Administradores";
            // 
            // tblAdmins
            // 
            tblAdmins.BackgroundColor = Color.White;
            tblAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAdmins.Location = new Point(830, -2);
            tblAdmins.MultiSelect = false;
            tblAdmins.Name = "tblAdmins";
            tblAdmins.ReadOnly = true;
            tblAdmins.RowHeadersWidth = 62;
            tblAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblAdmins.Size = new Size(832, 480);
            tblAdmins.TabIndex = 0;
            tblAdmins.Visible = false;
            // 
            // GestionAdmins
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 647);
            Controls.Add(pnlContenido);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionAdmins";
            Text = "Administradores";
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlBorde.ResumeLayout(false);
            pnlBorde.PerformLayout();
            ((ISupportInitialize)tblAdmins).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlCabecera;
        private Label lblGestionDe;
        private Panel pnlContenido;
        private Panel pnlBorde;
        private DataGridView tblAdmins;
        private Label lblAdmins;

        private void GestionAdmins_Load(object sender, EventArgs e)
        {
            CargarAdministradores();
        }

        private void CargarAdministradores()
        {
            tblAdmins.DataSource = null;
            tblAdmins.DataSource = logicaNegocios.GetAdmins();
            tblAdmins.Refresh();
            tblAdmins.Visible = true;
            tblAdmins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            foreach (DataGridViewColumn col in tblAdmins.Columns)
                col.Width = 395;
            tblAdmins.Columns["nombreUsuario"].HeaderText = "Nombre de Usuario";
            tblAdmins.Columns["contrasena"].HeaderText = "Contraseña";
        }

        private void pnlCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirAlta_Click(object sender, EventArgs e)
        {
            string usuario = txtNomUsuario.Text.Trim();
            string contrasena = txtCont.Text;
            string confirm = txtConfCont.Text;

            //Si los campos obligatorios estan vacios, marca error
            TextBox[] obligatorios = { txtNomUsuario, txtCont, txtConfCont };
            if (validacionesUI.EvalTxtVacios(obligatorios))
            {
                new Toast("error", "Todos los campos son obligatorios.").MostrarToast();
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

            TextBox[] passBoxes = { txtCont };
            if (validacionesUI.EvalTxtChars(passBoxes, 50))
            {
                new Toast("error", "La contraseña no puede exceder 50 caracteres.").MostrarToast();
                return;
            }

            if (new ValidacionesUI().EvalUsuarioExistente(usuario))
            {
                new Toast("error", "El nombre de usuario ya existe.").MostrarToast();
                return;
            }

            //Si todo esta ingresado de forma correcta, se agrega a administrador
            infoAdminAlta.NombreUsuario = usuario;
            infoAdminAlta.Contrasena = contrasena;

            logicaNegocios.AltaAdmin(usuario, contrasena);
            txtNomUsuario.Clear();
            txtCont.Clear();
            txtConfCont.Clear();
            CargarAdministradores();
            new Toast("exito", "Administrador creado exitosamente.").MostrarToast();
        }

        private void btnCanAlta_Click(object sender, EventArgs e)
        {
            new Toast("error", "Alta de administrador cancelado.").MostrarToast();
            txtNomUsuario.Clear();
            txtCont.Clear();
            txtConfCont.Clear();

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
    }
}
