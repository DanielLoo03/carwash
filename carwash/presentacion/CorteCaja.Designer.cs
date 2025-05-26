namespace presentacion
{
    partial class CorteCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorteCaja));
            pnlCabecera = new Panel();
            lblCaja = new Label();
            btnRealizarCorte = new Button();
            lblCorte = new Label();
            pnlContenido = new Panel();
            pnlBorde = new Panel();
            txtContado = new TextBox();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlBorde.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(lblCaja);
            pnlCabecera.Controls.Add(btnRealizarCorte);
            pnlCabecera.Controls.Add(lblCorte);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 3;
            // 
            // lblCaja
            // 
            lblCaja.AutoSize = true;
            lblCaja.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaja.ForeColor = Color.FromArgb(63, 114, 175);
            lblCaja.Location = new Point(211, 34);
            lblCaja.Name = "lblCaja";
            lblCaja.Size = new Size(98, 44);
            lblCaja.TabIndex = 7;
            lblCaja.Text = "Caja";
            // 
            // btnRealizarCorte
            // 
            btnRealizarCorte.BackColor = Color.FromArgb(63, 114, 175);
            btnRealizarCorte.FlatStyle = FlatStyle.Popup;
            btnRealizarCorte.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRealizarCorte.ForeColor = Color.White;
            btnRealizarCorte.Image = (Image)resources.GetObject("btnRealizarCorte.Image");
            btnRealizarCorte.ImageAlign = ContentAlignment.MiddleLeft;
            btnRealizarCorte.Location = new Point(1487, 32);
            btnRealizarCorte.Name = "btnRealizarCorte";
            btnRealizarCorte.Size = new Size(225, 39);
            btnRealizarCorte.TabIndex = 2;
            btnRealizarCorte.Text = "Realizar corte";
            btnRealizarCorte.TextAlign = ContentAlignment.MiddleRight;
            btnRealizarCorte.UseVisualStyleBackColor = false;
            btnRealizarCorte.Click += btnRealizarCorte_Click;
            // 
            // lblCorte
            // 
            lblCorte.AutoSize = true;
            lblCorte.Font = new Font("Inter", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorte.ForeColor = Color.White;
            lblCorte.Location = new Point(29, 31);
            lblCorte.Name = "lblCorte";
            lblCorte.Size = new Size(200, 49);
            lblCorte.TabIndex = 1;
            lblCorte.Text = "Corte de ";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = SystemColors.Window;
            pnlContenido.BorderStyle = BorderStyle.FixedSingle;
            pnlContenido.Controls.Add(pnlBorde);
            pnlContenido.Location = new Point(0, 101);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 4;
            // 
            // pnlBorde
            // 
            pnlBorde.BorderStyle = BorderStyle.FixedSingle;
            pnlBorde.Controls.Add(txtContado);
            pnlBorde.Location = new Point(76, 169);
            pnlBorde.Name = "pnlBorde";
            pnlBorde.Size = new Size(1669, 321);
            pnlBorde.TabIndex = 13;
            // 
            // txtContado
            // 
            txtContado.Location = new Point(38, 43);
            txtContado.Name = "txtContado";
            txtContado.Size = new Size(150, 31);
            txtContado.TabIndex = 14;
            // 
            // CorteCaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 647);
            Controls.Add(pnlContenido);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CorteCaja";
            Text = "CorteCaja";
            Load += CorteCaja_Load;
            KeyDown += CorteCaja_KeyDown;
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlBorde.ResumeLayout(false);
            pnlBorde.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Label lblCaja;
        private Button btnVerVentasCan;
        private Button btnCanVenta;
        private Button btnModVenta;
        private Button btnConfigVentas;
        private Button btnRealizarCorte;
        private Label lblCorte;
        private Panel pnlContenido;
        private Panel pnlBorde;
        private TextBox txtContado;
    }
}