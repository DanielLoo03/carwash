namespace presentacion
{
    partial class Autenticacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autenticacion));
            labelCarWash = new Label();
            labelLeo = new Label();
            labelInicioDeSesion = new Label();
            pictureBoxAdministrador = new PictureBox();
            textBoxNombreUsuario = new TextBox();
            pictureBoxContrasena = new PictureBox();
            textBoxContrasena = new TextBox();
            buttonIniciarSesion = new Button();
            panelDecorativoAzulOscuro = new Panel();
            buttonMostrarEsconderContrasena = new Button();
            labelCredencialesInvalidas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdministrador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContrasena).BeginInit();
            SuspendLayout();
            // 
            // labelCarWash
            // 
            labelCarWash.AutoSize = true;
            labelCarWash.Font = new Font("Inter", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarWash.ForeColor = Color.FromArgb(27, 38, 44);
            labelCarWash.Location = new Point(633, 144);
            labelCarWash.Name = "labelCarWash";
            labelCarWash.Size = new Size(444, 103);
            labelCarWash.TabIndex = 0;
            labelCarWash.Text = "Car Wash";
            // 
            // labelLeo
            // 
            labelLeo.AutoSize = true;
            labelLeo.Font = new Font("Inter", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLeo.ForeColor = Color.FromArgb(50, 130, 184);
            labelLeo.Location = new Point(1053, 144);
            labelLeo.Name = "labelLeo";
            labelLeo.Size = new Size(195, 103);
            labelLeo.TabIndex = 1;
            labelLeo.Text = "Leo";
            // 
            // labelInicioDeSesion
            // 
            labelInicioDeSesion.AutoSize = true;
            labelInicioDeSesion.Font = new Font("Nacelle", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInicioDeSesion.Location = new Point(778, 420);
            labelInicioDeSesion.Name = "labelInicioDeSesion";
            labelInicioDeSesion.Size = new Size(362, 58);
            labelInicioDeSesion.TabIndex = 2;
            labelInicioDeSesion.Text = "Inicio de Sesión";
            // 
            // pictureBoxAdministrador
            // 
            pictureBoxAdministrador.Image = (Image)resources.GetObject("pictureBoxAdministrador.Image");
            pictureBoxAdministrador.Location = new Point(657, 552);
            pictureBoxAdministrador.Name = "pictureBoxAdministrador";
            pictureBoxAdministrador.Size = new Size(72, 72);
            pictureBoxAdministrador.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAdministrador.TabIndex = 3;
            pictureBoxAdministrador.TabStop = false;
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.Font = new Font("Nacelle", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombreUsuario.Location = new Point(740, 568);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(447, 22);
            textBoxNombreUsuario.TabIndex = 4;
            textBoxNombreUsuario.Text = "Nombre de usuario";
            // 
            // pictureBoxContrasena
            // 
            pictureBoxContrasena.Image = (Image)resources.GetObject("pictureBoxContrasena.Image");
            pictureBoxContrasena.Location = new Point(669, 661);
            pictureBoxContrasena.Name = "pictureBoxContrasena";
            pictureBoxContrasena.Size = new Size(48, 48);
            pictureBoxContrasena.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxContrasena.TabIndex = 5;
            pictureBoxContrasena.TabStop = false;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Font = new Font("Nacelle", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContrasena.Location = new Point(740, 673);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.Size = new Size(447, 22);
            textBoxContrasena.TabIndex = 6;
            textBoxContrasena.Text = "Contraseña";
            textBoxContrasena.UseSystemPasswordChar = true;
            // 
            // buttonIniciarSesion
            // 
            buttonIniciarSesion.BackColor = Color.FromArgb(15, 76, 117);
            buttonIniciarSesion.FlatStyle = FlatStyle.Flat;
            buttonIniciarSesion.Font = new Font("Nacelle", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonIniciarSesion.ForeColor = SystemColors.Window;
            buttonIniciarSesion.Location = new Point(740, 761);
            buttonIniciarSesion.Name = "buttonIniciarSesion";
            buttonIniciarSesion.Size = new Size(447, 32);
            buttonIniciarSesion.TabIndex = 7;
            buttonIniciarSesion.Text = "Iniciar Sesión";
            buttonIniciarSesion.UseVisualStyleBackColor = false;
            buttonIniciarSesion.Click += buttonIniciarSesion_Click;
            // 
            // panelDecorativoAzulOscuro
            // 
            panelDecorativoAzulOscuro.BackColor = Color.FromArgb(15, 76, 117);
            panelDecorativoAzulOscuro.Location = new Point(0, 986);
            panelDecorativoAzulOscuro.Name = "panelDecorativoAzulOscuro";
            panelDecorativoAzulOscuro.Size = new Size(1920, 55);
            panelDecorativoAzulOscuro.TabIndex = 8;
            // 
            // buttonMostrarEsconderContrasena
            // 
            buttonMostrarEsconderContrasena.FlatStyle = FlatStyle.Flat;
            buttonMostrarEsconderContrasena.ForeColor = Color.White;
            buttonMostrarEsconderContrasena.Image = (Image)resources.GetObject("buttonMostrarEsconderContrasena.Image");
            buttonMostrarEsconderContrasena.Location = new Point(1199, 664);
            buttonMostrarEsconderContrasena.Name = "buttonMostrarEsconderContrasena";
            buttonMostrarEsconderContrasena.Size = new Size(40, 40);
            buttonMostrarEsconderContrasena.TabIndex = 9;
            buttonMostrarEsconderContrasena.UseVisualStyleBackColor = true;
            buttonMostrarEsconderContrasena.Click += buttonMostrarEsconderContrasena_Click;
            // 
            // labelCredencialesInvalidas
            // 
            labelCredencialesInvalidas.AutoSize = true;
            labelCredencialesInvalidas.Font = new Font("Nacelle", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCredencialesInvalidas.ForeColor = Color.Red;
            labelCredencialesInvalidas.Location = new Point(789, 708);
            labelCredencialesInvalidas.Name = "labelCredencialesInvalidas";
            labelCredencialesInvalidas.Size = new Size(331, 19);
            labelCredencialesInvalidas.TabIndex = 10;
            labelCredencialesInvalidas.Text = "Nombre de usuario o contraseña incorrecta.";
            labelCredencialesInvalidas.Visible = false;
            // 
            // Autenticacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelCredencialesInvalidas);
            Controls.Add(buttonMostrarEsconderContrasena);
            Controls.Add(panelDecorativoAzulOscuro);
            Controls.Add(buttonIniciarSesion);
            Controls.Add(textBoxContrasena);
            Controls.Add(pictureBoxContrasena);
            Controls.Add(textBoxNombreUsuario);
            Controls.Add(pictureBoxAdministrador);
            Controls.Add(labelInicioDeSesion);
            Controls.Add(labelLeo);
            Controls.Add(labelCarWash);
            ForeColor = Color.FromArgb(27, 38, 44);
            Name = "Autenticacion";
            Text = "Autenticacion";
            Load += Autenticacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdministrador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxContrasena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCarWash;
        private Label labelLeo;
        private Label labelInicioDeSesion;
        private PictureBox pictureBoxAdministrador;
        private TextBox textBoxNombreUsuario;
        private PictureBox pictureBoxContrasena;
        private TextBox textBoxContrasena;
        private Button buttonIniciarSesion;
        private Panel panelDecorativoAzulOscuro;
        private Button buttonMostrarEsconderContrasena;
        private Label labelCredencialesInvalidas;
    }
}