namespace presentacion
{
    partial class GestionGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionGasto));
            pnlCabecera = new Panel();
            btnAltaGas = new Button();
            lblGastos = new Label();
            lblGestionDe = new Label();
            pnlContenido = new Panel();
            lblCorrespEmp = new Label();
            imgCorresp = new PictureBox();
            lblCorresp = new Label();
            imgEmp = new PictureBox();
            lblEmp = new Label();
            lblGanEmp = new Label();
            lblGanDia = new Label();
            separator1 = new ReaLTaiizor.Controls.Separator();
            lblGan = new Label();
            cbEmp = new ComboBox();
            imgFechaGas = new PictureBox();
            lblFechaGas = new Label();
            dtFechaGas = new DateTimePicker();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCorresp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFechaGas).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(btnAltaGas);
            pnlCabecera.Controls.Add(lblGastos);
            pnlCabecera.Controls.Add(lblGestionDe);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 3;
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
            btnAltaGas.Text = "Agregar Gasto";
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
            lblGastos.Size = new Size(153, 46);
            lblGastos.TabIndex = 1;
            lblGastos.Text = "Gastos";
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
            pnlContenido.Controls.Add(lblCorrespEmp);
            pnlContenido.Controls.Add(imgCorresp);
            pnlContenido.Controls.Add(lblCorresp);
            pnlContenido.Controls.Add(imgEmp);
            pnlContenido.Controls.Add(lblEmp);
            pnlContenido.Controls.Add(lblGanEmp);
            pnlContenido.Controls.Add(lblGanDia);
            pnlContenido.Controls.Add(separator1);
            pnlContenido.Controls.Add(lblGan);
            pnlContenido.Controls.Add(cbEmp);
            pnlContenido.Controls.Add(imgFechaGas);
            pnlContenido.Controls.Add(lblFechaGas);
            pnlContenido.Controls.Add(dtFechaGas);
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 4;
            // 
            // lblCorrespEmp
            // 
            lblCorrespEmp.AutoSize = true;
            lblCorrespEmp.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrespEmp.Location = new Point(400, 363);
            lblCorrespEmp.Name = "lblCorrespEmp";
            lblCorrespEmp.Size = new Size(28, 22);
            lblCorrespEmp.TabIndex = 22;
            lblCorrespEmp.Text = "---";
            // 
            // imgCorresp
            // 
            imgCorresp.Image = (Image)resources.GetObject("imgCorresp.Image");
            imgCorresp.Location = new Point(208, 359);
            imgCorresp.Name = "imgCorresp";
            imgCorresp.Size = new Size(30, 30);
            imgCorresp.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCorresp.TabIndex = 21;
            imgCorresp.TabStop = false;
            // 
            // lblCorresp
            // 
            lblCorresp.AutoSize = true;
            lblCorresp.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorresp.Location = new Point(239, 363);
            lblCorresp.Name = "lblCorresp";
            lblCorresp.Size = new Size(147, 22);
            lblCorresp.TabIndex = 20;
            lblCorresp.Text = "Correspondencia";
            // 
            // imgEmp
            // 
            imgEmp.Image = (Image)resources.GetObject("imgEmp.Image");
            imgEmp.Location = new Point(208, 206);
            imgEmp.Name = "imgEmp";
            imgEmp.Size = new Size(30, 30);
            imgEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEmp.TabIndex = 19;
            imgEmp.TabStop = false;
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmp.Location = new Point(240, 209);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(90, 22);
            lblEmp.TabIndex = 18;
            lblEmp.Text = "Empleado";
            // 
            // lblGanEmp
            // 
            lblGanEmp.AutoSize = true;
            lblGanEmp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanEmp.ForeColor = Color.Black;
            lblGanEmp.Location = new Point(154, 113);
            lblGanEmp.Name = "lblGanEmp";
            lblGanEmp.Size = new Size(347, 32);
            lblGanEmp.TabIndex = 3;
            lblGanEmp.Text = "Ganancia de Empleados";
            // 
            // lblGanDia
            // 
            lblGanDia.AutoSize = true;
            lblGanDia.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGanDia.Location = new Point(1549, 364);
            lblGanDia.Name = "lblGanDia";
            lblGanDia.Size = new Size(28, 22);
            lblGanDia.TabIndex = 17;
            lblGanDia.Text = "---";
            // 
            // separator1
            // 
            separator1.LineColor = Color.LightGray;
            separator1.Location = new Point(1480, 346);
            separator1.Name = "separator1";
            separator1.Size = new Size(172, 15);
            separator1.TabIndex = 16;
            separator1.Text = "sepTotales";
            // 
            // lblGan
            // 
            lblGan.AutoSize = true;
            lblGan.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGan.Location = new Point(1494, 321);
            lblGan.Name = "lblGan";
            lblGan.Size = new Size(145, 22);
            lblGan.TabIndex = 15;
            lblGan.Text = "Ganancia del dia";
            // 
            // cbEmp
            // 
            cbEmp.FormattingEnabled = true;
            cbEmp.Location = new Point(208, 246);
            cbEmp.Name = "cbEmp";
            cbEmp.Size = new Size(220, 33);
            cbEmp.TabIndex = 14;
            cbEmp.SelectedIndexChanged += cbEmp_SelectedIndexChanged;
            // 
            // imgFechaGas
            // 
            imgFechaGas.Image = (Image)resources.GetObject("imgFechaGas.Image");
            imgFechaGas.Location = new Point(1483, 143);
            imgFechaGas.Name = "imgFechaGas";
            imgFechaGas.Size = new Size(24, 23);
            imgFechaGas.TabIndex = 13;
            imgFechaGas.TabStop = false;
            // 
            // lblFechaGas
            // 
            lblFechaGas.AutoSize = true;
            lblFechaGas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaGas.Location = new Point(1516, 145);
            lblFechaGas.Name = "lblFechaGas";
            lblFechaGas.Size = new Size(139, 22);
            lblFechaGas.TabIndex = 12;
            lblFechaGas.Text = "Consulta fechas";
            // 
            // dtFechaGas
            // 
            dtFechaGas.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFechaGas.Location = new Point(1408, 184);
            dtFechaGas.Name = "dtFechaGas";
            dtFechaGas.Size = new Size(327, 28);
            dtFechaGas.TabIndex = 10;
            // 
            // GestionGasto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 647);
            Controls.Add(pnlContenido);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionGasto";
            Text = "GestionGastos";
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgCorresp).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEmp).EndInit();
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
    }
}