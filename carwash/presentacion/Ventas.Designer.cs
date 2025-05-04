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
            btnConfigVentas = new Button();
            btnAddVenta = new Button();
            lblVentas = new Label();
            pnlContenido = new Panel();
            tblVentas = new DataGridView();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblVentas).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(btnConfigVentas);
            pnlCabecera.Controls.Add(btnAddVenta);
            pnlCabecera.Controls.Add(lblVentas);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 2;
            // 
            // btnConfigVentas
            // 
            btnConfigVentas.BackColor = Color.FromArgb(63, 114, 175);
            btnConfigVentas.FlatStyle = FlatStyle.Popup;
            btnConfigVentas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfigVentas.ForeColor = Color.White;
            btnConfigVentas.Image = (Image)resources.GetObject("btnConfigVentas.Image");
            btnConfigVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfigVentas.Location = new Point(1216, 32);
            btnConfigVentas.Name = "btnConfigVentas";
            btnConfigVentas.Size = new Size(225, 39);
            btnConfigVentas.TabIndex = 3;
            btnConfigVentas.Text = "Configuraciones";
            btnConfigVentas.TextAlign = ContentAlignment.MiddleRight;
            btnConfigVentas.UseVisualStyleBackColor = false;
            btnConfigVentas.Click += btnConfigVentas_Click;
            // 
            // btnAddVenta
            // 
            btnAddVenta.BackColor = Color.FromArgb(63, 114, 175);
            btnAddVenta.FlatStyle = FlatStyle.Popup;
            btnAddVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddVenta.ForeColor = Color.White;
            btnAddVenta.Image = (Image)resources.GetObject("btnAddVenta.Image");
            btnAddVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddVenta.Location = new Point(1487, 32);
            btnAddVenta.Name = "btnAddVenta";
            btnAddVenta.Size = new Size(225, 39);
            btnAddVenta.TabIndex = 2;
            btnAddVenta.Text = "Registrar Venta";
            btnAddVenta.TextAlign = ContentAlignment.MiddleRight;
            btnAddVenta.UseVisualStyleBackColor = false;
            btnAddVenta.Click += btnAddVenta_Click;
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
            pnlContenido.Controls.Add(tblVentas);
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 3;
            // 
            // tblVentas
            // 
            tblVentas.BackgroundColor = Color.White;
            tblVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblVentas.Location = new Point(76, 72);
            tblVentas.MultiSelect = false;
            tblVentas.Name = "tblVentas";
            tblVentas.ReadOnly = true;
            tblVentas.RowHeadersWidth = 62;
            tblVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblVentas.Size = new Size(1669, 404);
            tblVentas.TabIndex = 0;
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
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Button btnElimEmpleado;
        private Button btnModEmpleado;
        private Button btnAddVenta;
        private Label lblVentas;
        private Panel pnlContenido;
        private DataGridView tblVentas;
        private Button btnConfigVentas;
    }
}