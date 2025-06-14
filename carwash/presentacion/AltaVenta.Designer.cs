﻿namespace presentacion
{
    partial class AltaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaVenta));
            lblVenta = new Label();
            btnRegresar = new Button();
            lblModelo = new Label();
            txtModeloCarro = new TextBox();
            txtMarcaCarro = new TextBox();
            lblMarca = new Label();
            txtColorCarro = new TextBox();
            lblColor = new Label();
            txtCorresp = new TextBox();
            lblCorrespondencia = new Label();
            txtGanancia = new TextBox();
            lblGanancia = new Label();
            txtPrecioCarro = new TextBox();
            lblPrecio = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbNomEmpleado = new ComboBox();
            cbNumEmpleado = new ComboBox();
            label6 = new Label();
            lblNumEmp = new Label();
            btnConfirmarVenta = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // lblVenta
            // 
            lblVenta.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(67, 50);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(598, 46);
            lblVenta.TabIndex = 1;
            lblVenta.Text = "Datos de la Venta";
            lblVenta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(72, 50);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 17;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(88, 243);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(147, 22);
            lblModelo.TabIndex = 18;
            lblModelo.Text = "Modelo del Carro";
            // 
            // txtModeloCarro
            // 
            txtModeloCarro.CharacterCasing = CharacterCasing.Upper;
            txtModeloCarro.Location = new Point(88, 274);
            txtModeloCarro.Name = "txtModeloCarro";
            txtModeloCarro.Size = new Size(557, 31);
            txtModeloCarro.TabIndex = 24;
            // 
            // txtMarcaCarro
            // 
            txtMarcaCarro.CharacterCasing = CharacterCasing.Upper;
            txtMarcaCarro.Location = new Point(88, 184);
            txtMarcaCarro.Name = "txtMarcaCarro";
            txtMarcaCarro.Size = new Size(557, 31);
            txtMarcaCarro.TabIndex = 26;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(88, 153);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(138, 22);
            lblMarca.TabIndex = 25;
            lblMarca.Text = "Marca del Carro";
            // 
            // txtColorCarro
            // 
            txtColorCarro.CharacterCasing = CharacterCasing.Upper;
            txtColorCarro.Location = new Point(88, 363);
            txtColorCarro.Name = "txtColorCarro";
            txtColorCarro.Size = new Size(557, 31);
            txtColorCarro.TabIndex = 28;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(88, 332);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(132, 22);
            lblColor.TabIndex = 27;
            lblColor.Text = "Color del Carro";
            // 
            // txtCorresp
            // 
            txtCorresp.Location = new Point(88, 620);
            txtCorresp.Name = "txtCorresp";
            txtCorresp.Size = new Size(557, 31);
            txtCorresp.TabIndex = 34;
            txtCorresp.TextChanged += txtCorresp_TextChanged;
            txtCorresp.KeyDown += txtCorresp_KeyDown;
            txtCorresp.KeyPress += txtCorresp_KeyPress;
            // 
            // lblCorrespondencia
            // 
            lblCorrespondencia.AutoSize = true;
            lblCorrespondencia.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrespondencia.Location = new Point(88, 589);
            lblCorrespondencia.Name = "lblCorrespondencia";
            lblCorrespondencia.Size = new Size(147, 22);
            lblCorrespondencia.TabIndex = 33;
            lblCorrespondencia.Text = "Correspondencia";
            // 
            // txtGanancia
            // 
            txtGanancia.Location = new Point(88, 535);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(557, 31);
            txtGanancia.TabIndex = 32;
            txtGanancia.TextChanged += txtGanancia_TextChanged;
            txtGanancia.KeyDown += txtGanancia_KeyDown;
            txtGanancia.KeyPress += txtGanancia_KeyPress;
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGanancia.Location = new Point(88, 504);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(87, 22);
            lblGanancia.TabIndex = 31;
            lblGanancia.Text = "Ganancia";
            // 
            // txtPrecioCarro
            // 
            txtPrecioCarro.Location = new Point(88, 449);
            txtPrecioCarro.Name = "txtPrecioCarro";
            txtPrecioCarro.Size = new Size(557, 31);
            txtPrecioCarro.TabIndex = 30;
            txtPrecioCarro.TextChanged += txtPrecioCarro_TextChanged;
            txtPrecioCarro.KeyDown += txtPrecioCarro_KeyDown;
            txtPrecioCarro.KeyPress += txtPrecioCarro_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(88, 418);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(140, 22);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "Precio del Carro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(224, 416);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 35;
            label3.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(172, 502);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 36;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(235, 586);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 37;
            label2.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 687);
            label4.Name = "label4";
            label4.Size = new Size(182, 22);
            label4.TabIndex = 38;
            label4.Text = "Empleado Encargado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(267, 684);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 39;
            label5.Text = "*";
            // 
            // cbNomEmpleado
            // 
            cbNomEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNomEmpleado.FormattingEnabled = true;
            cbNomEmpleado.Location = new Point(88, 721);
            cbNomEmpleado.Name = "cbNomEmpleado";
            cbNomEmpleado.Size = new Size(288, 33);
            cbNomEmpleado.TabIndex = 40;
            cbNomEmpleado.SelectedValueChanged += cbNomEmpleado_SelectedValueChanged;
            // 
            // cbNumEmpleado
            // 
            cbNumEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumEmpleado.FormattingEnabled = true;
            cbNumEmpleado.Location = new Point(88, 818);
            cbNumEmpleado.Name = "cbNumEmpleado";
            cbNumEmpleado.Size = new Size(288, 33);
            cbNumEmpleado.TabIndex = 43;
            cbNumEmpleado.SelectedValueChanged += cbNumEmpleado_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(267, 790);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 42;
            label6.Text = "*";
            // 
            // lblNumEmp
            // 
            lblNumEmp.AutoSize = true;
            lblNumEmp.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumEmp.Location = new Point(88, 784);
            lblNumEmp.Name = "lblNumEmp";
            lblNumEmp.Size = new Size(183, 22);
            lblNumEmp.TabIndex = 41;
            lblNumEmp.Text = "Número de Empleado";
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirmarVenta.FlatStyle = FlatStyle.Flat;
            btnConfirmarVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmarVenta.ForeColor = SystemColors.Window;
            btnConfirmarVenta.Image = (Image)resources.GetObject("btnConfirmarVenta.Image");
            btnConfirmarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmarVenta.Location = new Point(88, 912);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(557, 34);
            btnConfirmarVenta.TabIndex = 44;
            btnConfirmarVenta.Text = "Confirmar";
            btnConfirmarVenta.UseVisualStyleBackColor = false;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(365, 119);
            label7.Name = "label7";
            label7.Size = new Size(280, 22);
            label7.TabIndex = 80;
            label7.Text = "Los datos obligatorios contienen *";
            // 
            // AltaVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(746, 968);
            Controls.Add(label7);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(cbNumEmpleado);
            Controls.Add(label6);
            Controls.Add(lblNumEmp);
            Controls.Add(cbNomEmpleado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtCorresp);
            Controls.Add(lblCorrespondencia);
            Controls.Add(txtGanancia);
            Controls.Add(lblGanancia);
            Controls.Add(txtPrecioCarro);
            Controls.Add(lblPrecio);
            Controls.Add(txtColorCarro);
            Controls.Add(lblColor);
            Controls.Add(txtMarcaCarro);
            Controls.Add(lblMarca);
            Controls.Add(txtModeloCarro);
            Controls.Add(lblModelo);
            Controls.Add(btnRegresar);
            Controls.Add(lblVenta);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AltaVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Wash Leo";
            FormClosing += AltaVenta_FormClosing;
            Load += AltaVenta_Load;
            KeyDown += AltaVenta_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVenta;
        private Button btnRegresar;
        private Label lblModelo;
        private TextBox txtModeloCarro;
        private TextBox txtMarcaCarro;
        private Label lblMarca;
        private TextBox txtColorCarro;
        private Label lblColor;
        private TextBox txtCorresp;
        private Label lblCorrespondencia;
        private TextBox txtGanancia;
        private Label lblGanancia;
        private TextBox txtPrecioCarro;
        private Label lblPrecio;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox cbNomEmpleado;
        private ComboBox cbNumEmpleado;
        private Label label6;
        private Label lblNumEmp;
        private Button btnConfirmarVenta;
        private Label label7;
    }
}