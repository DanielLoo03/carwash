namespace presentacion
{
    partial class GestionTesoreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionTesoreria));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlCabecera = new Panel();
            btnVerGastosCan = new Button();
            btnCanGas = new Button();
            btnModGastoGan = new Button();
            btnAltaGas = new Button();
            lblGastos = new Label();
            lblGestionDe = new Label();
            pnlContenido = new Panel();
            lblNoGas = new Label();
            tblGastos = new DataGridView();
            lblNoGan = new Label();
            lblGanDia = new Label();
            separator1 = new ReaLTaiizor.Controls.Separator();
            lblGan = new Label();
            imgFechaGas = new PictureBox();
            lblFechaGas = new Label();
            dtFechaGas = new DateTimePicker();
            pictureBox1 = new PictureBox();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblGastos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFechaGas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(btnVerGastosCan);
            pnlCabecera.Controls.Add(btnCanGas);
            pnlCabecera.Controls.Add(btnModGastoGan);
            pnlCabecera.Controls.Add(btnAltaGas);
            pnlCabecera.Controls.Add(lblGastos);
            pnlCabecera.Controls.Add(lblGestionDe);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 3;
            // 
            // btnVerGastosCan
            // 
            btnVerGastosCan.BackColor = Color.FromArgb(63, 114, 175);
            btnVerGastosCan.FlatStyle = FlatStyle.Popup;
            btnVerGastosCan.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerGastosCan.ForeColor = Color.White;
            btnVerGastosCan.Image = (Image)resources.GetObject("btnVerGastosCan.Image");
            btnVerGastosCan.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerGastosCan.Location = new Point(600, 28);
            btnVerGastosCan.Margin = new Padding(4, 5, 4, 5);
            btnVerGastosCan.Name = "btnVerGastosCan";
            btnVerGastosCan.Size = new Size(266, 40);
            btnVerGastosCan.TabIndex = 7;
            btnVerGastosCan.Text = "Mostrar registros Cancelados";
            btnVerGastosCan.TextAlign = ContentAlignment.MiddleRight;
            btnVerGastosCan.UseVisualStyleBackColor = false;
            btnVerGastosCan.Click += btnVerVentasCan_Click;
            // 
            // btnCanGas
            // 
            btnCanGas.BackColor = Color.FromArgb(63, 114, 175);
            btnCanGas.FlatStyle = FlatStyle.Popup;
            btnCanGas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCanGas.ForeColor = Color.White;
            btnCanGas.Image = (Image)resources.GetObject("btnCanGas.Image");
            btnCanGas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCanGas.Location = new Point(900, 28);
            btnCanGas.Name = "btnCanGas";
            btnCanGas.Size = new Size(252, 39);
            btnCanGas.TabIndex = 5;
            btnCanGas.Text = "Cancelar Gasto/Ganancia";
            btnCanGas.TextAlign = ContentAlignment.MiddleRight;
            btnCanGas.UseVisualStyleBackColor = false;
            btnCanGas.Click += btnGas_Click;
            // 
            // btnModGastoGan
            // 
            btnModGastoGan.BackColor = Color.FromArgb(63, 114, 175);
            btnModGastoGan.FlatStyle = FlatStyle.Popup;
            btnModGastoGan.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModGastoGan.ForeColor = Color.White;
            btnModGastoGan.Image = (Image)resources.GetObject("btnModGastoGan.Image");
            btnModGastoGan.ImageAlign = ContentAlignment.MiddleLeft;
            btnModGastoGan.Location = new Point(1192, 28);
            btnModGastoGan.Name = "btnModGastoGan";
            btnModGastoGan.Size = new Size(264, 39);
            btnModGastoGan.TabIndex = 4;
            btnModGastoGan.Text = "Modificar Gasto/Ganancia";
            btnModGastoGan.TextAlign = ContentAlignment.MiddleRight;
            btnModGastoGan.UseVisualStyleBackColor = false;
            btnModGastoGan.Click += btnModGastoGan_Click;
            // 
            // btnAltaGas
            // 
            btnAltaGas.BackColor = Color.FromArgb(63, 114, 175);
            btnAltaGas.FlatStyle = FlatStyle.Popup;
            btnAltaGas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAltaGas.ForeColor = Color.White;
            btnAltaGas.Image = (Image)resources.GetObject("btnAltaGas.Image");
            btnAltaGas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAltaGas.Location = new Point(1487, 28);
            btnAltaGas.Name = "btnAltaGas";
            btnAltaGas.Size = new Size(225, 39);
            btnAltaGas.TabIndex = 2;
            btnAltaGas.Text = "Gestion Tesoreria";
            btnAltaGas.TextAlign = ContentAlignment.MiddleRight;
            btnAltaGas.UseVisualStyleBackColor = false;
            btnAltaGas.Click += btnAltaGas_Click;
            // 
            // lblGastos
            // 
            lblGastos.AutoSize = true;
            lblGastos.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGastos.ForeColor = Color.FromArgb(63, 114, 175);
            lblGastos.Location = new Point(261, 28);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(197, 46);
            lblGastos.TabIndex = 1;
            lblGastos.Text = "Tesoreria";
            // 
            // lblGestionDe
            // 
            lblGestionDe.AutoSize = true;
            lblGestionDe.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDe.ForeColor = Color.White;
            lblGestionDe.Location = new Point(40, 28);
            lblGestionDe.Name = "lblGestionDe";
            lblGestionDe.Size = new Size(235, 46);
            lblGestionDe.TabIndex = 0;
            lblGestionDe.Text = "Gestión de ";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = SystemColors.Window;
            pnlContenido.BorderStyle = BorderStyle.FixedSingle;
            pnlContenido.Controls.Add(pictureBox1);
            pnlContenido.Controls.Add(lblNoGas);
            pnlContenido.Controls.Add(tblGastos);
            pnlContenido.Controls.Add(lblNoGan);
            pnlContenido.Controls.Add(lblGanDia);
            pnlContenido.Controls.Add(separator1);
            pnlContenido.Controls.Add(lblGan);
            pnlContenido.Controls.Add(imgFechaGas);
            pnlContenido.Controls.Add(lblFechaGas);
            pnlContenido.Controls.Add(dtFechaGas);
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 4;
            // 
            // lblNoGas
            // 
            lblNoGas.AutoSize = true;
            lblNoGas.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoGas.Location = new Point(407, 259);
            lblNoGas.Name = "lblNoGas";
            lblNoGas.Size = new Size(482, 32);
            lblNoGas.TabIndex = 25;
            lblNoGas.Text = "No se han registrado gastos en el dia";
            lblNoGas.Visible = false;
            // 
            // tblGastos
            // 
            tblGastos.AllowUserToAddRows = false;
            tblGastos.AllowUserToDeleteRows = false;
            tblGastos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblGastos.Location = new Point(78, 59);
            tblGastos.MultiSelect = false;
            tblGastos.Name = "tblGastos";
            tblGastos.ReadOnly = true;
            tblGastos.RowHeadersWidth = 62;
            tblGastos.ScrollBars = ScrollBars.None;
            tblGastos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblGastos.Size = new Size(1133, 431);
            tblGastos.TabIndex = 24;
            tblGastos.CellFormatting += tblGastos_CellFormatting;
            // 
            // lblNoGan
            // 
            lblNoGan.AutoSize = true;
            lblNoGan.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoGan.ForeColor = Color.Red;
            lblNoGan.Location = new Point(1440, 398);
            lblNoGan.Name = "lblNoGan";
            lblNoGan.Size = new Size(103, 22);
            lblNoGan.TabIndex = 23;
            lblNoGan.Text = "Sin efectivo";
            lblNoGan.Visible = false;
            // 
            // lblGanDia
            // 
            lblGanDia.AutoSize = true;
            lblGanDia.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGanDia.Location = new Point(1466, 352);
            lblGanDia.Name = "lblGanDia";
            lblGanDia.Size = new Size(28, 22);
            lblGanDia.TabIndex = 17;
            lblGanDia.Text = "---";
            // 
            // separator1
            // 
            separator1.LineColor = Color.LightGray;
            separator1.Location = new Point(1393, 334);
            separator1.Name = "separator1";
            separator1.Size = new Size(214, 15);
            separator1.TabIndex = 16;
            separator1.Text = "sepTotales";
            // 
            // lblGan
            // 
            lblGan.AutoSize = true;
            lblGan.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGan.Location = new Point(1423, 309);
            lblGan.Name = "lblGan";
            lblGan.Size = new Size(194, 22);
            lblGan.TabIndex = 15;
            lblGan.Text = "efectivo teórico en caja";
            // 
            // imgFechaGas
            // 
            imgFechaGas.Image = (Image)resources.GetObject("imgFechaGas.Image");
            imgFechaGas.Location = new Point(1395, 131);
            imgFechaGas.Name = "imgFechaGas";
            imgFechaGas.Size = new Size(24, 24);
            imgFechaGas.TabIndex = 13;
            imgFechaGas.TabStop = false;
            // 
            // lblFechaGas
            // 
            lblFechaGas.AutoSize = true;
            lblFechaGas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaGas.Location = new Point(1428, 133);
            lblFechaGas.Name = "lblFechaGas";
            lblFechaGas.Size = new Size(139, 22);
            lblFechaGas.TabIndex = 12;
            lblFechaGas.Text = "Consulta fechas";
            // 
            // dtFechaGas
            // 
            dtFechaGas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFechaGas.Location = new Point(1320, 172);
            dtFechaGas.Name = "dtFechaGas";
            dtFechaGas.Size = new Size(327, 28);
            dtFechaGas.TabIndex = 10;
            dtFechaGas.ValueChanged += dtFechaGas_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1393, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // GestionTesoreria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 647);
            Controls.Add(pnlContenido);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionTesoreria";
            Text = "GestionGastos";
            Load += GestionGasto_Load;
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblGastos).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFechaGas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Button btnAltaGas;
        private Label lblGastos;
        private Label lblGestionDe;
        private Panel pnlContenido;
        private DateTimePicker dtFechaGas;
        private PictureBox imgFechaGas;
        private Label lblFechaGas;
        private ComboBox cbEmp;
        private Label lblGan;
        private ReaLTaiizor.Controls.Separator separator1;
        private Label lblGanDia;
        private Label lblEmp;
        private Label lblGanEmp;
        private PictureBox imgEmp;
        private Label lblCorresp;
        private PictureBox imgCorresp;
        private Label lblCorrespEmp;
        private Label lblNoGan;
        private DataGridView tblGastos;
        private Label lblNoGas;
        private Button btnModGastoGan;
        private Button btnCanGas;
        private Button btnVerGastosCan;
        private PictureBox pictureBox1;
    }
}