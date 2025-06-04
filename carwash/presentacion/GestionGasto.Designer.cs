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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblEmp = new Label();
            label1 = new Label();
            lblGanDia = new Label();
            separator1 = new ReaLTaiizor.Controls.Separator();
            lblGan = new Label();
            cbEmp = new ComboBox();
            imgFechaVenta = new PictureBox();
            lblFechaVenta = new Label();
            dtFechaVenta = new DateTimePicker();
            label3 = new Label();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFechaVenta).BeginInit();
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
            pnlContenido.Controls.Add(label3);
            pnlContenido.Controls.Add(pictureBox2);
            pnlContenido.Controls.Add(label2);
            pnlContenido.Controls.Add(pictureBox1);
            pnlContenido.Controls.Add(lblEmp);
            pnlContenido.Controls.Add(label1);
            pnlContenido.Controls.Add(lblGanDia);
            pnlContenido.Controls.Add(separator1);
            pnlContenido.Controls.Add(lblGan);
            pnlContenido.Controls.Add(cbEmp);
            pnlContenido.Controls.Add(imgFechaVenta);
            pnlContenido.Controls.Add(lblFechaVenta);
            pnlContenido.Controls.Add(dtFechaVenta);
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(208, 359);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 363);
            label2.Name = "label2";
            label2.Size = new Size(147, 22);
            label2.TabIndex = 20;
            label2.Text = "Correspondencia";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(154, 113);
            label1.Name = "label1";
            label1.Size = new Size(347, 32);
            label1.TabIndex = 3;
            label1.Text = "Ganancia de Empleados";
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
            // imgFechaVenta
            // 
            imgFechaVenta.Image = (Image)resources.GetObject("imgFechaVenta.Image");
            imgFechaVenta.Location = new Point(1483, 143);
            imgFechaVenta.Name = "imgFechaVenta";
            imgFechaVenta.Size = new Size(24, 23);
            imgFechaVenta.TabIndex = 13;
            imgFechaVenta.TabStop = false;
            // 
            // lblFechaVenta
            // 
            lblFechaVenta.AutoSize = true;
            lblFechaVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaVenta.Location = new Point(1516, 145);
            lblFechaVenta.Name = "lblFechaVenta";
            lblFechaVenta.Size = new Size(139, 22);
            lblFechaVenta.TabIndex = 12;
            lblFechaVenta.Text = "Consulta fechas";
            // 
            // dtFechaVenta
            // 
            dtFechaVenta.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFechaVenta.Location = new Point(1408, 184);
            dtFechaVenta.Name = "dtFechaVenta";
            dtFechaVenta.Size = new Size(327, 28);
            dtFechaVenta.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(400, 363);
            label3.Name = "label3";
            label3.Size = new Size(28, 22);
            label3.TabIndex = 22;
            label3.Text = "---";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFechaVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Button btnAltaGas;
        private Label lblGastos;
        private Label lblGestionDe;
        private Panel pnlContenido;
        private DateTimePicker dtFechaVenta;
        private PictureBox imgFechaVenta;
        private Label lblFechaVenta;
        private ComboBox cbEmp;
        private Label lblGan;
        private ReaLTaiizor.Controls.Separator separator1;
        private Label lblGanDia;
        private Label lblEmp;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
    }
}