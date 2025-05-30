namespace presentacion
{
    partial class AltaAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAdmin));
            lblDatosUsuario = new Label();
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
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosUsuario.Location = new Point(114, 36);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(503, 46);
            lblDatosUsuario.TabIndex = 50;
            lblDatosUsuario.Text = "Datos de Administradores";
            // 
            // btnMostrarPwd2
            // 
            btnMostrarPwd2.FlatStyle = FlatStyle.Flat;
            btnMostrarPwd2.ForeColor = SystemColors.Window;
            btnMostrarPwd2.Image = (Image)resources.GetObject("btnMostrarPwd2.Image");
            btnMostrarPwd2.Location = new Point(656, 351);
            btnMostrarPwd2.Name = "btnMostrarPwd2";
            btnMostrarPwd2.Size = new Size(37, 27);
            btnMostrarPwd2.TabIndex = 77;
            btnMostrarPwd2.UseVisualStyleBackColor = true;
            btnMostrarPwd2.Click += btnMostrarPwd2_Click;
            // 
            // btnMostrarPwd1
            // 
            btnMostrarPwd1.FlatStyle = FlatStyle.Flat;
            btnMostrarPwd1.ForeColor = SystemColors.Window;
            btnMostrarPwd1.Image = (Image)resources.GetObject("btnMostrarPwd1.Image");
            btnMostrarPwd1.Location = new Point(656, 255);
            btnMostrarPwd1.Name = "btnMostrarPwd1";
            btnMostrarPwd1.Size = new Size(37, 27);
            btnMostrarPwd1.TabIndex = 76;
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
            btnCanAlta.Location = new Point(72, 425);
            btnCanAlta.Name = "btnCanAlta";
            btnCanAlta.Size = new Size(206, 38);
            btnCanAlta.TabIndex = 75;
            btnCanAlta.Text = "Cancelar";
            btnCanAlta.UseVisualStyleBackColor = false;
            btnCanAlta.Click += btnCancelar_Click;
            // 
            // btnConfirAlta
            // 
            btnConfirAlta.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirAlta.FlatStyle = FlatStyle.Flat;
            btnConfirAlta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirAlta.ForeColor = SystemColors.Window;
            btnConfirAlta.Image = (Image)resources.GetObject("btnConfirAlta.Image");
            btnConfirAlta.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirAlta.Location = new Point(430, 425);
            btnConfirAlta.Name = "btnConfirAlta";
            btnConfirAlta.Size = new Size(204, 43);
            btnConfirAlta.TabIndex = 74;
            btnConfirAlta.Text = "Confirmar";
            btnConfirAlta.UseVisualStyleBackColor = false;
            btnConfirAlta.Click += btnConfirmar_Click;
            // 
            // camposOblig
            // 
            camposOblig.AutoSize = true;
            camposOblig.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            camposOblig.ForeColor = SystemColors.Desktop;
            camposOblig.Location = new Point(446, 108);
            camposOblig.Name = "camposOblig";
            camposOblig.Size = new Size(189, 22);
            camposOblig.TabIndex = 73;
            camposOblig.Text = "* Campos Obligatorios";
            // 
            // txtConfCont
            // 
            txtConfCont.Location = new Point(79, 345);
            txtConfCont.Name = "txtConfCont";
            txtConfCont.Size = new Size(555, 31);
            txtConfCont.TabIndex = 72;
            txtConfCont.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(258, 318);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 71;
            label1.Text = "*";
            // 
            // lblConfCont
            // 
            lblConfCont.AutoSize = true;
            lblConfCont.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfCont.Location = new Point(80, 316);
            lblConfCont.Name = "lblConfCont";
            lblConfCont.Size = new Size(186, 22);
            lblConfCont.TabIndex = 70;
            lblConfCont.Text = "Confirmar Contraseña";
            // 
            // txtCont
            // 
            txtCont.Location = new Point(80, 251);
            txtCont.Name = "txtCont";
            txtCont.Size = new Size(555, 31);
            txtCont.TabIndex = 69;
            txtCont.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(172, 221);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 68;
            label2.Text = "*";
            // 
            // lblCont
            // 
            lblCont.AutoSize = true;
            lblCont.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCont.Location = new Point(79, 220);
            lblCont.Name = "lblCont";
            lblCont.Size = new Size(103, 22);
            lblCont.TabIndex = 67;
            lblCont.Text = "Contraseña";
            // 
            // txtNomUsuario
            // 
            txtNomUsuario.Location = new Point(80, 156);
            txtNomUsuario.Name = "txtNomUsuario";
            txtNomUsuario.Size = new Size(555, 31);
            txtNomUsuario.TabIndex = 66;
            // 
            // obligatorio
            // 
            obligatorio.AutoSize = true;
            obligatorio.ForeColor = Color.Red;
            obligatorio.Location = new Point(238, 130);
            obligatorio.Name = "obligatorio";
            obligatorio.Size = new Size(20, 25);
            obligatorio.TabIndex = 65;
            obligatorio.Text = "*";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(80, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(162, 22);
            lblNombre.TabIndex = 64;
            lblNombre.Text = "Nombre de usuario";
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(23, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 78;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // AltaAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(738, 534);
            Controls.Add(btnRegresar);
            Controls.Add(btnMostrarPwd2);
            Controls.Add(btnMostrarPwd1);
            Controls.Add(btnCanAlta);
            Controls.Add(btnConfirAlta);
            Controls.Add(camposOblig);
            Controls.Add(txtConfCont);
            Controls.Add(label1);
            Controls.Add(lblConfCont);
            Controls.Add(txtCont);
            Controls.Add(label2);
            Controls.Add(lblCont);
            Controls.Add(txtNomUsuario);
            Controls.Add(obligatorio);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosUsuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AltaAdmin";
            Text = "Car Wash Leo";
            FormClosing += AltaAdmin_FormClosing;
            Load += AltaAdmin_Load;
            KeyDown += AltaAdmin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosUsuario;
        private Button btnMostrarPwd2;
        private Button btnMostrarPwd1;
        private Button btnCanAlta;
        private Button btnConfirAlta;
        private Label camposOblig;
        private TextBox txtConfCont;
        private Label label1;
        private Label lblConfCont;
        private TextBox txtCont;
        private Label label2;
        private Label lblCont;
        private TextBox txtNomUsuario;
        private Label obligatorio;
        private Label lblNombre;
        private Button btnRegresar;
    }
}