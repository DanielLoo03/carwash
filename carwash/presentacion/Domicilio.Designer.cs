namespace presentacion
{
    partial class Domicilio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Domicilio));
            btnConfirmar = new Button();
            txtCodigoPostal = new TextBox();
            txtNumInterior = new TextBox();
            txtColonia = new TextBox();
            txtCalle = new TextBox();
            lblCodigoPostal = new Label();
            lblNumExterior = new Label();
            lblNumInterior = new Label();
            lblColonia = new Label();
            lblCalle = new Label();
            btnRegresar = new Button();
            lblDomicilio = new Label();
            txtNumExterior = new TextBox();
            obligatorio = new Label();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.Window;
            btnConfirmar.Image = (Image)resources.GetObject("btnConfirmar.Image");
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(471, 830);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(203, 34);
            btnConfirmar.TabIndex = 29;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(117, 640);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(557, 31);
            txtCodigoPostal.TabIndex = 27;
            // 
            // txtNumInterior
            // 
            txtNumInterior.Location = new Point(117, 429);
            txtNumInterior.Name = "txtNumInterior";
            txtNumInterior.Size = new Size(557, 31);
            txtNumInterior.TabIndex = 25;
            // 
            // txtColonia
            // 
            txtColonia.Location = new Point(117, 326);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(557, 31);
            txtColonia.TabIndex = 24;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(117, 220);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(557, 31);
            txtCalle.TabIndex = 23;
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigoPostal.Location = new Point(117, 603);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(120, 22);
            lblCodigoPostal.TabIndex = 21;
            lblCodigoPostal.Text = "Código postal";
            // 
            // lblNumExterior
            // 
            lblNumExterior.AutoSize = true;
            lblNumExterior.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumExterior.Location = new Point(117, 498);
            lblNumExterior.Name = "lblNumExterior";
            lblNumExterior.Size = new Size(138, 22);
            lblNumExterior.TabIndex = 20;
            lblNumExterior.Text = "Número exterior";
            // 
            // lblNumInterior
            // 
            lblNumInterior.AutoSize = true;
            lblNumInterior.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumInterior.Location = new Point(117, 393);
            lblNumInterior.Name = "lblNumInterior";
            lblNumInterior.Size = new Size(133, 22);
            lblNumInterior.TabIndex = 19;
            lblNumInterior.Text = "Número interior";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblColonia.Location = new Point(117, 288);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(71, 22);
            lblColonia.TabIndex = 18;
            lblColonia.Text = "Colonia";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalle.Location = new Point(117, 183);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(51, 22);
            lblCalle.TabIndex = 17;
            lblCalle.Text = "Calle";
            lblCalle.Click += lblNombre_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(72, 50);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 16;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomicilio.Location = new Point(283, 45);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(194, 46);
            lblDomicilio.TabIndex = 15;
            lblDomicilio.Text = "Domicilio";
            // 
            // txtNumExterior
            // 
            txtNumExterior.Location = new Point(117, 535);
            txtNumExterior.Name = "txtNumExterior";
            txtNumExterior.Size = new Size(557, 31);
            txtNumExterior.TabIndex = 30;
            // 
            // obligatorio
            // 
            obligatorio.AutoSize = true;
            obligatorio.ForeColor = Color.Red;
            obligatorio.Location = new Point(161, 181);
            obligatorio.Name = "obligatorio";
            obligatorio.Size = new Size(20, 25);
            obligatorio.TabIndex = 31;
            obligatorio.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(184, 285);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 32;
            label1.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(237, 601);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 35;
            label4.Text = "*";
            // 
            // Domicilio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(746, 908);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(obligatorio);
            Controls.Add(txtNumExterior);
            Controls.Add(btnConfirmar);
            Controls.Add(txtCodigoPostal);
            Controls.Add(txtNumInterior);
            Controls.Add(txtColonia);
            Controls.Add(txtCalle);
            Controls.Add(lblCodigoPostal);
            Controls.Add(lblNumExterior);
            Controls.Add(lblNumInterior);
            Controls.Add(lblColonia);
            Controls.Add(lblCalle);
            Controls.Add(btnRegresar);
            Controls.Add(lblDomicilio);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Domicilio";
            Text = "Car Wash Leo";
            FormClosing += Domicilio_FormClosing;
            Load += Domicilio_Load;
            KeyDown += Domicilio_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private TextBox txtCodigoPostal;
        private TextBox txtNumInterior;
        private TextBox txtColonia;
        private TextBox txtCalle;
        private Label lblCodigoPostal;
        private Label lblNumExterior;
        private Label lblNumInterior;
        private Label lblColonia;
        private Label lblCalle;
        private Button btnRegresar;
        private Label lblDomicilio;
        private TextBox txtNumExterior;
        private Label obligatorio;
        private Label label1;
        private Label label4;
    }
}