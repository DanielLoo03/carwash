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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionTesoreria));
            pnlCabecera = new Panel();
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
            btnGas = new Button();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblGastos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFechaGas).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(btnGas);
            pnlCabecera.Controls.Add(btnModGastoGan);
            pnlCabecera.Controls.Add(btnAltaGas);
            pnlCabecera.Controls.Add(lblGastos);
            pnlCabecera.Controls.Add(lblGestionDe);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 3;
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
            // 
            // lblNoGan
            // 
            lblNoGan.AutoSize = true;
            lblNoGan.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoGan.ForeColor = Color.Red;
            lblNoGan.Location = new Point(1339, 396);
            lblNoGan.Name = "lblNoGan";
            lblNoGan.Size = new Size(308, 22);
            lblNoGan.TabIndex = 23;
            lblNoGan.Text = "No se han registrado ventas en el dia";
            lblNoGan.Visible = false;
            // 
            // lblGanDia
            // 
            lblGanDia.AutoSize = true;
            lblGanDia.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGanDia.Location = new Point(1452, 352);
            lblGanDia.Name = "lblGanDia";
            lblGanDia.Size = new Size(28, 22);
            lblGanDia.TabIndex = 17;
            lblGanDia.Text = "---";
            // 
            // separator1
            // 
            separator1.LineColor = Color.LightGray;
            separator1.Location = new Point(1402, 334);
            separator1.Name = "separator1";
            separator1.Size = new Size(172, 15);
            separator1.TabIndex = 16;
            separator1.Text = "sepTotales";
            // 
            // lblGan
            // 
            lblGan.AutoSize = true;
            lblGan.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGan.Location = new Point(1416, 309);
            lblGan.Name = "lblGan";
            lblGan.Size = new Size(145, 22);
            lblGan.TabIndex = 15;
            lblGan.Text = "Ganancia del dia";
            // 
            // imgFechaGas
            // 
            imgFechaGas.Image = (Image)resources.GetObject("imgFechaGas.Image");
            imgFechaGas.Location = new Point(1395, 131);
            imgFechaGas.Name = "imgFechaGas";
            imgFechaGas.Size = new Size(24, 23);
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
            // btnGas
            // 
            btnGas.BackColor = Color.FromArgb(63, 114, 175);
            btnGas.FlatStyle = FlatStyle.Popup;
            btnGas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGas.ForeColor = Color.White;
            btnGas.Image = (Image)resources.GetObject("btnGas.Image");
            btnGas.ImageAlign = ContentAlignment.MiddleLeft;
            btnGas.Location = new Point(900, 28);
            btnGas.Name = "btnGas";
            btnGas.Size = new Size(252, 39);
            btnGas.TabIndex = 5;
            btnGas.Text = "Eliminar Gasto/Ganancia";
            btnGas.TextAlign = ContentAlignment.MiddleRight;
            btnGas.UseVisualStyleBackColor = false;
            btnGas.Click += btnGas_Click;
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
        private Button btnGas;
    }
}