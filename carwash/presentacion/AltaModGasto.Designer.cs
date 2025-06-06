namespace presentacion
{
    partial class AltaModGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaModGasto));
            btnConfirmar = new Button();
            label3 = new Label();
            lblMonto = new Label();
            lblRegistroGasto = new Label();
            btnRegresar = new Button();
            label1 = new Label();
            lblTipoGasto = new Label();
            label4 = new Label();
            lblDescripcion = new Label();
            txtMont = new TextBox();
            txtDesc = new TextBox();
            cbTipoGas = new ComboBox();
            lblEfecTeo = new Label();
            lblEfec = new Label();
            dtFechaGas = new DateTimePicker();
            label2 = new Label();
            label5 = new Label();
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
            btnConfirmar.Location = new Point(154, 763);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(416, 34);
            btnConfirmar.TabIndex = 46;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(210, 310);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 48;
            label3.Text = "*";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(154, 312);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(59, 22);
            lblMonto.TabIndex = 47;
            lblMonto.Text = "Monto";
            // 
            // lblRegistroGasto
            // 
            lblRegistroGasto.AutoSize = true;
            lblRegistroGasto.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistroGasto.Location = new Point(190, 50);
            lblRegistroGasto.Name = "lblRegistroGasto";
            lblRegistroGasto.Size = new Size(359, 46);
            lblRegistroGasto.TabIndex = 51;
            lblRegistroGasto.Text = "Registro de Gasto";
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(76, 59);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 79;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(277, 416);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 81;
            label1.Text = "*";
            // 
            // lblTipoGasto
            // 
            lblTipoGasto.AutoSize = true;
            lblTipoGasto.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoGasto.Location = new Point(154, 418);
            lblTipoGasto.Name = "lblTipoGasto";
            lblTipoGasto.Size = new Size(124, 22);
            lblTipoGasto.TabIndex = 80;
            lblTipoGasto.Text = "Tipo de Gasto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(255, 530);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 83;
            label4.Text = "*";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(154, 532);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(104, 22);
            lblDescripcion.TabIndex = 82;
            lblDescripcion.Text = "Descripción";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMont
            // 
            txtMont.Location = new Point(154, 338);
            txtMont.Name = "txtMont";
            txtMont.Size = new Size(416, 31);
            txtMont.TabIndex = 84;
            txtMont.TextChanged += txtMont_TextChanged;
            txtMont.KeyPress += txtMont_KeyPress;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(154, 558);
            txtDesc.MaxLength = 100;
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(416, 149);
            txtDesc.TabIndex = 86;
            txtDesc.TextChanged += txtDesc_TextChanged;
            // 
            // cbTipoGas
            // 
            cbTipoGas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoGas.FormattingEnabled = true;
            cbTipoGas.Location = new Point(154, 454);
            cbTipoGas.Name = "cbTipoGas";
            cbTipoGas.Size = new Size(416, 33);
            cbTipoGas.TabIndex = 87;
            // 
            // lblEfecTeo
            // 
            lblEfecTeo.AutoSize = true;
            lblEfecTeo.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEfecTeo.Location = new Point(217, 153);
            lblEfecTeo.Name = "lblEfecTeo";
            lblEfecTeo.Size = new Size(196, 22);
            lblEfecTeo.TabIndex = 88;
            lblEfecTeo.Text = "Efectivo teórico en caja";
            // 
            // lblEfec
            // 
            lblEfec.AutoSize = true;
            lblEfec.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEfec.Location = new Point(423, 153);
            lblEfec.Name = "lblEfec";
            lblEfec.Size = new Size(28, 22);
            lblEfec.TabIndex = 89;
            lblEfec.Text = "---";
            // 
            // dtFechaGas
            // 
            dtFechaGas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFechaGas.Location = new Point(154, 246);
            dtFechaGas.Name = "dtFechaGas";
            dtFechaGas.Size = new Size(416, 28);
            dtFechaGas.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 205);
            label2.Name = "label2";
            label2.Size = new Size(175, 22);
            label2.TabIndex = 91;
            label2.Text = "Fecha de realizacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(330, 202);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 92;
            label5.Text = "*";
            // 
            // AltaModGasto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(738, 844);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dtFechaGas);
            Controls.Add(lblEfec);
            Controls.Add(lblEfecTeo);
            Controls.Add(cbTipoGas);
            Controls.Add(txtDesc);
            Controls.Add(txtMont);
            Controls.Add(label4);
            Controls.Add(lblDescripcion);
            Controls.Add(label1);
            Controls.Add(lblTipoGasto);
            Controls.Add(btnRegresar);
            Controls.Add(lblRegistroGasto);
            Controls.Add(label3);
            Controls.Add(lblMonto);
            Controls.Add(btnConfirmar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AltaModGasto";
            Text = "Car Wash Leo";
            FormClosing += AltaModGasto_FormClosing;
            Load += AltaModGasto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private Label label3;
        private Label lblMonto;
        private Label lblRegistroGasto;
        private Button btnRegresar;
        private Label label1;
        private Label lblTipoGasto;
        private Label label4;
        private Label lblDescripcion;
        private TextBox txtMont;
        private TextBox txtDesc;
        private ComboBox cbTipoGas;
        private Label lblEfecTeo;
        private Label lblEfec;
        private DateTimePicker dtFechaGas;
        private Label label2;
        private Label label5;
    }
}