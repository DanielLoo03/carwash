namespace presentacion
{
    partial class AltaCorte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCorte));
            lblCorteCaja = new Label();
            btnRegresar = new Button();
            lblContado = new Label();
            lblCalculado = new Label();
            lblDiferencia = new Label();
            txtContado = new TextBox();
            txtCalculado = new TextBox();
            txtDiferencia = new TextBox();
            btnConfirmar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblCorteCaja
            // 
            lblCorteCaja.Font = new Font("Inter", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorteCaja.Location = new Point(278, 40);
            lblCorteCaja.Name = "lblCorteCaja";
            lblCorteCaja.Size = new Size(311, 46);
            lblCorteCaja.TabIndex = 2;
            lblCorteCaja.Text = "Corte de caja";
            lblCorteCaja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(59, 46);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 18;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblContado
            // 
            lblContado.AutoSize = true;
            lblContado.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContado.Location = new Point(127, 164);
            lblContado.Name = "lblContado";
            lblContado.Size = new Size(82, 22);
            lblContado.TabIndex = 26;
            lblContado.Text = "Contado";
            // 
            // lblCalculado
            // 
            lblCalculado.AutoSize = true;
            lblCalculado.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalculado.Location = new Point(388, 164);
            lblCalculado.Name = "lblCalculado";
            lblCalculado.Size = new Size(93, 22);
            lblCalculado.TabIndex = 27;
            lblCalculado.Text = "Calculado";
            // 
            // lblDiferencia
            // 
            lblDiferencia.AutoSize = true;
            lblDiferencia.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiferencia.Location = new Point(650, 164);
            lblDiferencia.Name = "lblDiferencia";
            lblDiferencia.Size = new Size(93, 22);
            lblDiferencia.TabIndex = 28;
            lblDiferencia.Text = "Diferencia";
            // 
            // txtContado
            // 
            txtContado.Location = new Point(69, 209);
            txtContado.Name = "txtContado";
            txtContado.Size = new Size(200, 31);
            txtContado.TabIndex = 29;
            txtContado.TextChanged += txtContado_TextChanged;
            txtContado.KeyDown += txtContado_KeyDown;
            txtContado.KeyPress += txtContado_KeyPress;
            // 
            // txtCalculado
            // 
            txtCalculado.Location = new Point(332, 209);
            txtCalculado.Name = "txtCalculado";
            txtCalculado.ReadOnly = true;
            txtCalculado.Size = new Size(200, 31);
            txtCalculado.TabIndex = 30;
            // 
            // txtDiferencia
            // 
            txtDiferencia.Location = new Point(593, 209);
            txtDiferencia.Name = "txtDiferencia";
            txtDiferencia.Size = new Size(200, 31);
            txtDiferencia.TabIndex = 31;
            txtDiferencia.KeyDown += txtDiferencia_KeyDown;
            txtDiferencia.KeyPress += txtDiferencia_KeyPress;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.Window;
            btnConfirmar.Image = (Image)resources.GetObject("btnConfirmar.Image");
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(332, 298);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(200, 34);
            btnConfirmar.TabIndex = 45;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(204, 162);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 46;
            label3.Text = "*";
            // 
            // AltaCorte
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(878, 394);
            Controls.Add(label3);
            Controls.Add(btnConfirmar);
            Controls.Add(txtDiferencia);
            Controls.Add(txtCalculado);
            Controls.Add(txtContado);
            Controls.Add(lblDiferencia);
            Controls.Add(lblCalculado);
            Controls.Add(lblContado);
            Controls.Add(btnRegresar);
            Controls.Add(lblCorteCaja);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AltaCorte";
            Text = "Car Wash Leo";
            Load += AltaCorte_Load;
            KeyDown += AltaCorte_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorteCaja;
        private Button btnRegresar;
        private Label lblContado;
        private Label lblCalculado;
        private Label lblDiferencia;
        private TextBox txtContado;
        private TextBox txtCalculado;
        private TextBox txtDiferencia;
        private Button btnConfirmar;
        private Label label3;
    }
}