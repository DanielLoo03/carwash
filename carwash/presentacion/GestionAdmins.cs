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
        private Button btnConfirmarVenta;
        private Button btnBajaEmpleado;

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
            btnBajaEmpleado = new Button();
            btnConfirmarVenta = new Button();
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
            pnlCabecera.Margin = new Padding(2);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1274, 60);
            pnlCabecera.TabIndex = 3;
            // 
            // lblGestionDe
            // 
            lblGestionDe.AutoSize = true;
            lblGestionDe.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDe.ForeColor = Color.White;
            lblGestionDe.Location = new Point(11, 16);
            lblGestionDe.Margin = new Padding(2, 0, 2, 0);
            lblGestionDe.Name = "lblGestionDe";
            lblGestionDe.Size = new Size(163, 31);
            lblGestionDe.TabIndex = 2;
            lblGestionDe.Text = "Gestión de ";
            // 
            // lblAdmins
            // 
            lblAdmins.AutoSize = true;
            lblAdmins.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmins.ForeColor = Color.FromArgb(63, 114, 175);
            lblAdmins.Location = new Point(173, 17);
            lblAdmins.Margin = new Padding(2, 0, 2, 0);
            lblAdmins.Name = "lblAdmins";
            lblAdmins.Size = new Size(225, 31);
            lblAdmins.TabIndex = 1;
            lblAdmins.Text = "Administradores";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = SystemColors.Window;
            pnlContenido.BorderStyle = BorderStyle.FixedSingle;
            pnlContenido.Controls.Add(pnlBorde);
            pnlContenido.Location = new Point(0, 60);
            pnlContenido.Margin = new Padding(2);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1274, 329);
            pnlContenido.TabIndex = 4;
            // 
            // pnlBorde
            // 
            pnlBorde.BorderStyle = BorderStyle.FixedSingle;
            pnlBorde.Controls.Add(btnBajaEmpleado);
            pnlBorde.Controls.Add(btnConfirmarVenta);
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
            pnlBorde.Location = new Point(53, 28);
            pnlBorde.Margin = new Padding(2);
            pnlBorde.Name = "pnlBorde";
            pnlBorde.Size = new Size(1165, 288);
            pnlBorde.TabIndex = 13;
            // 
            // btnBajaEmpleado
            // 
            btnBajaEmpleado.BackColor = Color.FromArgb(63, 114, 175);
            btnBajaEmpleado.FlatStyle = FlatStyle.Popup;
            btnBajaEmpleado.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBajaEmpleado.ForeColor = Color.White;
            btnBajaEmpleado.Image = (Image)resources.GetObject("btnBajaEmpleado.Image");
            btnBajaEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnBajaEmpleado.Location = new Point(49, 241);
            btnBajaEmpleado.Margin = new Padding(2);
            btnBajaEmpleado.Name = "btnBajaEmpleado";
            btnBajaEmpleado.Size = new Size(144, 23);
            btnBajaEmpleado.TabIndex = 46;
            btnBajaEmpleado.Text = "Cancelar Registro";
            btnBajaEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnBajaEmpleado.UseVisualStyleBackColor = false;
            btnBajaEmpleado.Click += btnBajaEmpleado_Click;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirmarVenta.FlatStyle = FlatStyle.Flat;
            btnConfirmarVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmarVenta.ForeColor = SystemColors.Window;
            btnConfirmarVenta.Image = (Image)resources.GetObject("btnConfirmarVenta.Image");
            btnConfirmarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmarVenta.Location = new Point(295, 241);
            btnConfirmarVenta.Margin = new Padding(2);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(145, 26);
            btnConfirmarVenta.TabIndex = 45;
            btnConfirmarVenta.Text = "Confirmar Alta";
            btnConfirmarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmarVenta.UseVisualStyleBackColor = false;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // camposOblig
            // 
            camposOblig.AutoSize = true;
            camposOblig.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camposOblig.ForeColor = SystemColors.Desktop;
            camposOblig.Location = new Point(306, 51);
            camposOblig.Margin = new Padding(2, 0, 2, 0);
            camposOblig.Name = "camposOblig";
            camposOblig.Size = new Size(130, 15);
            camposOblig.TabIndex = 24;
            camposOblig.Text = "* Campos Obligatorios";
            // 
            // txtConfCont
            // 
            txtConfCont.Location = new Point(49, 193);
            txtConfCont.Margin = new Padding(2);
            txtConfCont.Name = "txtConfCont";
            txtConfCont.Size = new Size(390, 23);
            txtConfCont.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(174, 177);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 22;
            label1.Text = "*";
            // 
            // lblConfCont
            // 
            lblConfCont.AutoSize = true;
            lblConfCont.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfCont.Location = new Point(50, 176);
            lblConfCont.Margin = new Padding(2, 0, 2, 0);
            lblConfCont.Name = "lblConfCont";
            lblConfCont.Size = new Size(127, 15);
            lblConfCont.TabIndex = 21;
            lblConfCont.Text = "Confirmar Contraseña";
            // 
            // txtCont
            // 
            txtCont.Location = new Point(50, 137);
            txtCont.Margin = new Padding(2);
            txtCont.Name = "txtCont";
            txtCont.Size = new Size(390, 23);
            txtCont.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(114, 119);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 19;
            label2.Text = "*";
            // 
            // lblCont
            // 
            lblCont.AutoSize = true;
            lblCont.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCont.Location = new Point(49, 118);
            lblCont.Margin = new Padding(2, 0, 2, 0);
            lblCont.Name = "lblCont";
            lblCont.Size = new Size(70, 15);
            lblCont.TabIndex = 18;
            lblCont.Text = "Contraseña";
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.Location = new Point(50, 80);
            txtNomUsuario.Margin = new Padding(2);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(390, 23);
            txtNomUsuario.TabIndex = 17;
            // 
            // obligatorio
            // 
            obligatorio.AutoSize = true;
            obligatorio.ForeColor = Color.Red;
            obligatorio.Location = new Point(160, 64);
            obligatorio.Margin = new Padding(2, 0, 2, 0);
            obligatorio.Name = "obligatorio";
            obligatorio.Size = new Size(12, 15);
            obligatorio.TabIndex = 16;
            obligatorio.Text = "*";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(50, 63);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre de usuario";
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosUsuario.Location = new Point(103, 10);
            lblDatosUsuario.Margin = new Padding(2, 0, 2, 0);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(284, 31);
            lblDatosUsuario.TabIndex = 1;
            lblDatosUsuario.Text = "Alta Administradores";
            // 
            // tblAdmins
            // 
            tblAdmins.BackgroundColor = Color.White;
            tblAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAdmins.Location = new Point(614, -1);
            tblAdmins.Margin = new Padding(2);
            tblAdmins.MultiSelect = false;
            tblAdmins.Name = "tblAdmins";
            tblAdmins.ReadOnly = true;
            tblAdmins.RowHeadersWidth = 62;
            tblAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblAdmins.Size = new Size(547, 288);
            tblAdmins.TabIndex = 0;
            tblAdmins.Visible = false;
            // 
            // GestionAdmins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 388);
            Controls.Add(pnlContenido);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.None;
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

        }

        private void pnlCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnBajaEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
