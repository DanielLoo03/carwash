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
            lblNoCorte = new Label();
            tblCorte = new DataGridView();
            dtFecha = new DateTimePicker();
            imgFecha = new PictureBox();
            txtAdmin = new TextBox();
            txtDiferencia = new TextBox();
            txtCalculado = new TextBox();
            lblDiaCorte = new Label();
            lblAdmin = new Label();
            lblDiferencia = new Label();
            lblCalculado = new Label();
            lblContado = new Label();
            lblDatosCorte = new Label();
            txtContado = new TextBox();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblCorte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFecha).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(lblCaja);
            pnlCabecera.Controls.Add(btnRealizarCorte);
            pnlCabecera.Controls.Add(lblCorte);
            pnlCabecera.Location = new Point(1, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 3;
            // 
            // lblCaja
            // 
            lblCaja.AutoSize = true;
            lblCaja.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaja.ForeColor = Color.FromArgb(63, 114, 175);
            lblCaja.Location = new Point(209, 34);
            lblCaja.Name = "lblCaja";
            lblCaja.Size = new Size(98, 44);
            lblCaja.TabIndex = 7;
            lblCaja.Text = "Caja";
            // 
            // btnRealizarCorte
            // 
            btnRealizarCorte.BackColor = Color.FromArgb(63, 114, 175);
            btnRealizarCorte.FlatStyle = FlatStyle.Popup;
            btnRealizarCorte.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            pnlContenido.Controls.Add(lblNoCorte);
            pnlContenido.Controls.Add(tblCorte);
            pnlContenido.Controls.Add(dtFecha);
            pnlContenido.Controls.Add(imgFecha);
            pnlContenido.Controls.Add(txtAdmin);
            pnlContenido.Controls.Add(txtDiferencia);
            pnlContenido.Controls.Add(txtCalculado);
            pnlContenido.Controls.Add(lblDiaCorte);
            pnlContenido.Controls.Add(lblAdmin);
            pnlContenido.Controls.Add(lblDiferencia);
            pnlContenido.Controls.Add(lblCalculado);
            pnlContenido.Controls.Add(lblContado);
            pnlContenido.Controls.Add(lblDatosCorte);
            pnlContenido.Controls.Add(txtContado);
            pnlContenido.Location = new Point(1, 101);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 545);
            pnlContenido.TabIndex = 4;
            // 
            // lblNoCorte
            // 
            lblNoCorte.AutoSize = true;
            lblNoCorte.Font = new Font("Nacelle", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoCorte.Location = new Point(473, 251);
            lblNoCorte.Name = "lblNoCorte";
            lblNoCorte.Size = new Size(742, 34);
            lblNoCorte.TabIndex = 27;
            lblNoCorte.Text = "No se ha realizado un corte de caja en el día seleccionado.";
            lblNoCorte.Visible = false;
            // 
            // tblCorte
            // 
            tblCorte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblCorte.Enabled = false;
            tblCorte.Location = new Point(28, 15);
            tblCorte.Name = "tblCorte";
            tblCorte.RowHeadersWidth = 62;
            tblCorte.Size = new Size(13, 15);
            tblCorte.TabIndex = 26;
            tblCorte.Visible = false;
            // 
            // dtFecha
            // 
            dtFecha.Checked = false;
            dtFecha.Location = new Point(1442, 97);
            dtFecha.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(332, 31);
            dtFecha.TabIndex = 25;
            dtFecha.ValueChanged += dtFecha_ValueChanged;
            // 
            // imgFecha
            // 
            imgFecha.Image = (Image)resources.GetObject("imgFecha.Image");
            imgFecha.Location = new Point(1528, 57);
            imgFecha.Name = "imgFecha";
            imgFecha.Size = new Size(24, 24);
            imgFecha.TabIndex = 24;
            imgFecha.TabStop = false;
            // 
            // txtAdmin
            // 
            txtAdmin.Location = new Point(1123, 295);
            txtAdmin.Name = "txtAdmin";
            txtAdmin.ReadOnly = true;
            txtAdmin.Size = new Size(227, 31);
            txtAdmin.TabIndex = 23;
            // 
            // txtDiferencia
            // 
            txtDiferencia.Location = new Point(860, 295);
            txtDiferencia.Name = "txtDiferencia";
            txtDiferencia.Size = new Size(227, 31);
            txtDiferencia.TabIndex = 22;
            txtDiferencia.KeyDown += txtDiferencia_KeyDown;
            txtDiferencia.KeyPress += txtDiferencia_KeyPress;
            // 
            // txtCalculado
            // 
            txtCalculado.Location = new Point(596, 295);
            txtCalculado.Name = "txtCalculado";
            txtCalculado.ReadOnly = true;
            txtCalculado.Size = new Size(227, 31);
            txtCalculado.TabIndex = 21;
            // 
            // lblDiaCorte
            // 
            lblDiaCorte.AutoSize = true;
            lblDiaCorte.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiaCorte.Location = new Point(1569, 57);
            lblDiaCorte.Name = "lblDiaCorte";
            lblDiaCorte.Size = new Size(109, 22);
            lblDiaCorte.TabIndex = 20;
            lblDiaCorte.Text = "Día de corte";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmin.Location = new Point(1173, 258);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(127, 22);
            lblAdmin.TabIndex = 19;
            lblAdmin.Text = "Administrador";
            // 
            // lblDiferencia
            // 
            lblDiferencia.AutoSize = true;
            lblDiferencia.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiferencia.Location = new Point(928, 258);
            lblDiferencia.Name = "lblDiferencia";
            lblDiferencia.Size = new Size(93, 22);
            lblDiferencia.TabIndex = 18;
            lblDiferencia.Text = "Diferencia";
            // 
            // lblCalculado
            // 
            lblCalculado.AutoSize = true;
            lblCalculado.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalculado.Location = new Point(666, 258);
            lblCalculado.Name = "lblCalculado";
            lblCalculado.Size = new Size(93, 22);
            lblCalculado.TabIndex = 17;
            lblCalculado.Text = "Calculado";
            // 
            // lblContado
            // 
            lblContado.AutoSize = true;
            lblContado.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContado.Location = new Point(397, 258);
            lblContado.Name = "lblContado";
            lblContado.Size = new Size(82, 22);
            lblContado.TabIndex = 16;
            lblContado.Text = "Contado";
            // 
            // lblDatosCorte
            // 
            lblDatosCorte.AutoSize = true;
            lblDatosCorte.Font = new Font("Inter", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosCorte.Location = new Point(697, 70);
            lblDatosCorte.Name = "lblDatosCorte";
            lblDatosCorte.Size = new Size(308, 49);
            lblDatosCorte.TabIndex = 15;
            lblDatosCorte.Text = "Datos de corte";
            // 
            // txtContado
            // 
            txtContado.Location = new Point(329, 295);
            txtContado.Name = "txtContado";
            txtContado.ReadOnly = true;
            txtContado.Size = new Size(227, 31);
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
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblCorte).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFecha).EndInit();
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
        private TextBox txtAdmin;
        private TextBox txtDiferencia;
        private TextBox txtCalculado;
        private Label lblDiaCorte;
        private Label lblAdmin;
        private Label lblDiferencia;
        private Label lblCalculado;
        private Label lblContado;
        private Label lblDatosCorte;
        private TextBox txtContado;
        private DateTimePicker dtFecha;
        private PictureBox imgFecha;
        private DataGridView tblCorte;
        private Label lblNoCorte;
    }
}