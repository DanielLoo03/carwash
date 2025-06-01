namespace presentacion
{
    partial class DatosPersonales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosPersonales));
            lblDatosPersonales = new Label();
            btnRegresar = new Button();
            lblNombre = new Label();
            lblApellidoPaterno = new Label();
            lblApellidoMaterno = new Label();
            lblFechaNacimiento = new Label();
            lblNumTelefono = new Label();
            numEmpleado = new Label();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            dtFechaNacimiento = new DateTimePicker();
            nudNumEmpleado = new NumericUpDown();
            btnContinuar = new Button();
            obligatorio = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            mtxtNumTelefono = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)nudNumEmpleado).BeginInit();
            SuspendLayout();
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosPersonales.Location = new Point(192, 70);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(352, 46);
            lblDatosPersonales.TabIndex = 0;
            lblDatosPersonales.Text = "Datos Personales";
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(55, 75);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 1;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(100, 208);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 22);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombres";
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaterno.Location = new Point(100, 313);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(147, 22);
            lblApellidoPaterno.TabIndex = 3;
            lblApellidoPaterno.Text = "Apellido Paterno ";
            lblApellidoPaterno.Click += lblApellidoPaterno_Click;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoMaterno.Location = new Point(100, 418);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(144, 22);
            lblApellidoMaterno.TabIndex = 4;
            lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNacimiento.Location = new Point(100, 523);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(176, 22);
            lblFechaNacimiento.TabIndex = 5;
            lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblNumTelefono
            // 
            lblNumTelefono.AutoSize = true;
            lblNumTelefono.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumTelefono.Location = new Point(100, 628);
            lblNumTelefono.Name = "lblNumTelefono";
            lblNumTelefono.Size = new Size(167, 22);
            lblNumTelefono.TabIndex = 6;
            lblNumTelefono.Text = "Número de teléfono";
            // 
            // numEmpleado
            // 
            numEmpleado.AutoSize = true;
            numEmpleado.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numEmpleado.Location = new Point(100, 733);
            numEmpleado.Name = "numEmpleado";
            numEmpleado.Size = new Size(181, 22);
            numEmpleado.TabIndex = 7;
            numEmpleado.Text = "Número de empleado";
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(100, 245);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(557, 31);
            txtNombre.TabIndex = 8;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.CharacterCasing = CharacterCasing.Upper;
            txtApellidoPaterno.Location = new Point(100, 351);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(557, 31);
            txtApellidoPaterno.TabIndex = 9;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.CharacterCasing = CharacterCasing.Upper;
            txtApellidoMaterno.Location = new Point(100, 454);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(557, 31);
            txtApellidoMaterno.TabIndex = 10;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(100, 563);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(557, 31);
            dtFechaNacimiento.TabIndex = 11;
            // 
            // nudNumEmpleado
            // 
            nudNumEmpleado.Location = new Point(100, 769);
            nudNumEmpleado.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumEmpleado.Name = "nudNumEmpleado";
            nudNumEmpleado.Size = new Size(557, 31);
            nudNumEmpleado.TabIndex = 13;
            nudNumEmpleado.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.FromArgb(63, 114, 175);
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinuar.ForeColor = SystemColors.Window;
            btnContinuar.Image = (Image)resources.GetObject("btnContinuar.Image");
            btnContinuar.ImageAlign = ContentAlignment.MiddleLeft;
            btnContinuar.Location = new Point(454, 855);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(203, 34);
            btnContinuar.TabIndex = 14;
            btnContinuar.Text = "Continuar";
            btnContinuar.TextAlign = ContentAlignment.MiddleRight;
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // obligatorio
            // 
            obligatorio.AutoSize = true;
            obligatorio.ForeColor = Color.Red;
            obligatorio.Location = new Point(175, 206);
            obligatorio.Name = "obligatorio";
            obligatorio.Size = new Size(20, 25);
            obligatorio.TabIndex = 15;
            obligatorio.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(239, 310);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 16;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(244, 415);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 17;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(275, 520);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 18;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(265, 625);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 19;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(281, 730);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 20;
            label5.Text = "*";
            // 
            // mtxtNumTelefono
            // 
            mtxtNumTelefono.Location = new Point(100, 665);
            mtxtNumTelefono.Mask = "000-000-0000";
            mtxtNumTelefono.Name = "mtxtNumTelefono";
            mtxtNumTelefono.Size = new Size(557, 31);
            mtxtNumTelefono.TabIndex = 21;
            // 
            // DatosPersonales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(746, 908);
            Controls.Add(mtxtNumTelefono);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(obligatorio);
            Controls.Add(btnContinuar);
            Controls.Add(nudNumEmpleado);
            Controls.Add(dtFechaNacimiento);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombre);
            Controls.Add(numEmpleado);
            Controls.Add(lblNumTelefono);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(lblNombre);
            Controls.Add(btnRegresar);
            Controls.Add(lblDatosPersonales);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "DatosPersonales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Wash Leo";
            FormClosing += DatosPersonales_FormClosing;
            Load += DatosPersonales_Load;
            KeyDown += DatosPersonales_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nudNumEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosPersonales;
        private Button btnRegresar;
        private Label lblNombre;
        private Label lblApellidoPaterno;
        private Label lblApellidoMaterno;
        private Label lblFechaNacimiento;
        private Label lblNumTelefono;
        private Label numEmpleado;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private DateTimePicker dtFechaNacimiento;
        private NumericUpDown nudNumEmpleado;
        private Button btnContinuar;
        private Label obligatorio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox mtxtNumTelefono;
    }
}