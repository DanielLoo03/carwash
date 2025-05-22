namespace presentacion
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            pnlCabecera = new Panel();
            btnModVenta = new Button();
            btnConfigVentas = new Button();
            btnAltaVenta = new Button();
            lblVentas = new Label();
            pnlContenido = new Panel();
            pnlBorde = new Panel();
            lblNoVentas = new Label();
            tblVentas = new DataGridView();
            imgFechaVenta = new PictureBox();
            lblFechaVenta = new Label();
            dtFechaVenta = new DateTimePicker();
            separator1 = new ReaLTaiizor.Controls.Separator();
            lblCorrespMonto = new Label();
            lblGanMonto = new Label();
            lblPrecioMonto = new Label();
            lblCorresp = new Label();
            lblGan = new Label();
            lblPrecio = new Label();
            lblTotales = new Label();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFechaVenta).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(btnModVenta);
            pnlCabecera.Controls.Add(btnConfigVentas);
            pnlCabecera.Controls.Add(btnAltaVenta);
            pnlCabecera.Controls.Add(lblVentas);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 2;
            // 
            // btnModVenta
            // 
            btnModVenta.BackColor = Color.FromArgb(63, 114, 175);
            btnModVenta.FlatStyle = FlatStyle.Popup;
            btnModVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModVenta.ForeColor = Color.White;
            btnModVenta.Image = (Image)resources.GetObject("btnModVenta.Image");
            btnModVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnModVenta.Location = new Point(1204, 32);
            btnModVenta.Name = "btnModVenta";
            btnModVenta.Size = new Size(225, 39);
            btnModVenta.TabIndex = 4;
            btnModVenta.Text = "Modificar Venta";
            btnModVenta.TextAlign = ContentAlignment.MiddleRight;
            btnModVenta.UseVisualStyleBackColor = false;
            btnModVenta.Click += btnModVenta_Click;
            // 
            // btnConfigVentas
            // 
            btnConfigVentas.BackColor = Color.FromArgb(63, 114, 175);
            btnConfigVentas.FlatStyle = FlatStyle.Popup;
            btnConfigVentas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfigVentas.ForeColor = Color.White;
            btnConfigVentas.Image = (Image)resources.GetObject("btnConfigVentas.Image");
            btnConfigVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfigVentas.Location = new Point(921, 32);
            btnConfigVentas.Name = "btnConfigVentas";
            btnConfigVentas.Size = new Size(225, 39);
            btnConfigVentas.TabIndex = 3;
            btnConfigVentas.Text = "Configuraciones";
            btnConfigVentas.TextAlign = ContentAlignment.MiddleRight;
            btnConfigVentas.UseVisualStyleBackColor = false;
            btnConfigVentas.Click += btnConfigVentas_Click;
            // 
            // btnAltaVenta
            // 
            btnAltaVenta.BackColor = Color.FromArgb(63, 114, 175);
            btnAltaVenta.FlatStyle = FlatStyle.Popup;
            btnAltaVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAltaVenta.ForeColor = Color.White;
            btnAltaVenta.Image = (Image)resources.GetObject("btnAltaVenta.Image");
            btnAltaVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAltaVenta.Location = new Point(1487, 32);
            btnAltaVenta.Name = "btnAltaVenta";
            btnAltaVenta.Size = new Size(225, 39);
            btnAltaVenta.TabIndex = 2;
            btnAltaVenta.Text = "Agregar Venta";
            btnAltaVenta.TextAlign = ContentAlignment.MiddleRight;
            btnAltaVenta.UseVisualStyleBackColor = false;
            btnAltaVenta.Click += btnAddVenta_Click;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = Color.FromArgb(63, 114, 175);
            lblVentas.Location = new Point(43, 28);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(150, 46);
            lblVentas.TabIndex = 1;
            lblVentas.Text = "Ventas";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = SystemColors.Window;
            pnlContenido.BorderStyle = BorderStyle.FixedSingle;
            pnlContenido.Controls.Add(pnlBorde);
            pnlContenido.Controls.Add(imgFechaVenta);
            pnlContenido.Controls.Add(lblFechaVenta);
            pnlContenido.Controls.Add(dtFechaVenta);
            pnlContenido.Controls.Add(separator1);
            pnlContenido.Controls.Add(lblCorrespMonto);
            pnlContenido.Controls.Add(lblGanMonto);
            pnlContenido.Controls.Add(lblPrecioMonto);
            pnlContenido.Controls.Add(lblCorresp);
            pnlContenido.Controls.Add(lblGan);
            pnlContenido.Controls.Add(lblPrecio);
            pnlContenido.Controls.Add(lblTotales);
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 3;
            // 
            // pnlBorde
            // 
            pnlBorde.BorderStyle = BorderStyle.FixedSingle;
            pnlBorde.Controls.Add(lblNoVentas);
            pnlBorde.Controls.Add(tblVentas);
            pnlBorde.Location = new Point(76, 169);
            pnlBorde.Name = "pnlBorde";
            pnlBorde.Size = new Size(1669, 321);
            pnlBorde.TabIndex = 13;
            // 
            // lblNoVentas
            // 
            lblNoVentas.AutoSize = true;
            lblNoVentas.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoVentas.Location = new Point(686, 133);
            lblNoVentas.Name = "lblNoVentas";
            lblNoVentas.Size = new Size(309, 32);
            lblNoVentas.TabIndex = 12;
            lblNoVentas.Text = "No hay ventas en el día";
            // 
            // tblVentas
            // 
            tblVentas.BackgroundColor = Color.White;
            tblVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblVentas.Location = new Point(-1, -1);
            tblVentas.MultiSelect = false;
            tblVentas.Name = "tblVentas";
            tblVentas.ReadOnly = true;
            tblVentas.RowHeadersWidth = 62;
            tblVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblVentas.Size = new Size(1669, 321);
            tblVentas.TabIndex = 0;
            tblVentas.Visible = false;
            // 
            // imgFechaVenta
            // 
            imgFechaVenta.Image = (Image)resources.GetObject("imgFechaVenta.Image");
            imgFechaVenta.Location = new Point(1060, 54);
            imgFechaVenta.Name = "imgFechaVenta";
            imgFechaVenta.Size = new Size(24, 24);
            imgFechaVenta.TabIndex = 11;
            imgFechaVenta.TabStop = false;
            // 
            // lblFechaVenta
            // 
            lblFechaVenta.AutoSize = true;
            lblFechaVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaVenta.Location = new Point(1102, 54);
            lblFechaVenta.Name = "lblFechaVenta";
            lblFechaVenta.Size = new Size(111, 22);
            lblFechaVenta.TabIndex = 10;
            lblFechaVenta.Text = "Día de venta";
            // 
            // dtFechaVenta
            // 
            dtFechaVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFechaVenta.Location = new Point(1016, 88);
            dtFechaVenta.Name = "dtFechaVenta";
            dtFechaVenta.Size = new Size(327, 28);
            dtFechaVenta.TabIndex = 9;
            dtFechaVenta.ValueChanged += dtFechaVenta_ValueChanged;
            // 
            // separator1
            // 
            separator1.LineColor = Color.LightGray;
            separator1.Location = new Point(1400, 79);
            separator1.Name = "separator1";
            separator1.Size = new Size(345, 15);
            separator1.TabIndex = 8;
            separator1.Text = "sepTotales";
            // 
            // lblCorrespMonto
            // 
            lblCorrespMonto.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrespMonto.Location = new Point(1623, 119);
            lblCorrespMonto.Name = "lblCorrespMonto";
            lblCorrespMonto.Size = new Size(82, 22);
            lblCorrespMonto.TabIndex = 7;
            lblCorrespMonto.Text = "---";
            lblCorrespMonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGanMonto
            // 
            lblGanMonto.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGanMonto.Location = new Point(1501, 119);
            lblGanMonto.Name = "lblGanMonto";
            lblGanMonto.Size = new Size(77, 22);
            lblGanMonto.TabIndex = 6;
            lblGanMonto.Text = "---";
            lblGanMonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrecioMonto
            // 
            lblPrecioMonto.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioMonto.Location = new Point(1392, 119);
            lblPrecioMonto.Name = "lblPrecioMonto";
            lblPrecioMonto.Size = new Size(77, 22);
            lblPrecioMonto.TabIndex = 5;
            lblPrecioMonto.Text = "---";
            lblPrecioMonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCorresp
            // 
            lblCorresp.AutoSize = true;
            lblCorresp.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorresp.Location = new Point(1593, 97);
            lblCorresp.Name = "lblCorresp";
            lblCorresp.Size = new Size(147, 22);
            lblCorresp.TabIndex = 4;
            lblCorresp.Text = "Correspondencia";
            // 
            // lblGan
            // 
            lblGan.AutoSize = true;
            lblGan.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGan.Location = new Point(1494, 97);
            lblGan.Name = "lblGan";
            lblGan.Size = new Size(87, 22);
            lblGan.TabIndex = 3;
            lblGan.Text = "Ganancia";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(1400, 97);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(61, 22);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // lblTotales
            // 
            lblTotales.AutoSize = true;
            lblTotales.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotales.Location = new Point(1502, 54);
            lblTotales.Name = "lblTotales";
            lblTotales.Size = new Size(70, 22);
            lblTotales.TabIndex = 1;
            lblTotales.Text = "Totales";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 647);
            Controls.Add(pnlContenido);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            pnlBorde.ResumeLayout(false);
            pnlBorde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFechaVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Button btnElimEmpleado;
        private Button btnModEmpleado;
        private Button btnAltaVenta;
        private Label lblVentas;
        private Panel pnlContenido;
        private DataGridView tblVentas;
        private Button btnConfigVentas;
        private Label lblTotales;
        private Label lblCorrespMonto;
        private Label lblGanMonto;
        private Label lblPrecioMonto;
        private Label lblCorresp;
        private Label lblGan;
        private Label lblPrecio;
        private ReaLTaiizor.Controls.Separator separator1;
        private Label lblFechaVenta;
        private DateTimePicker dtFechaVenta;
        private PictureBox imgFechaVenta;
        private Label lblNoVentas;
        private Panel pnlBorde;
        private Button btnModVenta;
    }
}