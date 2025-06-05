namespace presentacion
{
    partial class CorrespEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrespEmp));
            imgEmp = new PictureBox();
            lblEmp = new Label();
            lblGanEmp = new Label();
            cbEmp = new ComboBox();
            lblCorrespEmp = new Label();
            imgCorresp = new PictureBox();
            lblCorresp = new Label();
            btnRegresar = new Button();
            lblNoGan = new Label();
            ((System.ComponentModel.ISupportInitialize)imgEmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCorresp).BeginInit();
            SuspendLayout();
            // 
            // imgEmp
            // 
            imgEmp.Image = (Image)resources.GetObject("imgEmp.Image");
            imgEmp.Location = new Point(187, 161);
            imgEmp.Name = "imgEmp";
            imgEmp.Size = new Size(30, 30);
            imgEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEmp.TabIndex = 23;
            imgEmp.TabStop = false;
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmp.Location = new Point(219, 164);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(90, 22);
            lblEmp.TabIndex = 22;
            lblEmp.Text = "Empleado";
            // 
            // lblGanEmp
            // 
            lblGanEmp.AutoSize = true;
            lblGanEmp.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanEmp.ForeColor = Color.Black;
            lblGanEmp.Location = new Point(142, 70);
            lblGanEmp.Name = "lblGanEmp";
            lblGanEmp.Size = new Size(448, 32);
            lblGanEmp.TabIndex = 20;
            lblGanEmp.Text = "Correspondencia de Empleados";
            lblGanEmp.Click += lblGanEmp_Click;
            // 
            // cbEmp
            // 
            cbEmp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmp.FormattingEnabled = true;
            cbEmp.Location = new Point(187, 201);
            cbEmp.Name = "cbEmp";
            cbEmp.Size = new Size(319, 33);
            cbEmp.TabIndex = 21;
            cbEmp.SelectedIndexChanged += cbEmp_SelectedIndexChanged;
            // 
            // lblCorrespEmp
            // 
            lblCorrespEmp.AutoSize = true;
            lblCorrespEmp.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrespEmp.Location = new Point(412, 313);
            lblCorrespEmp.Name = "lblCorrespEmp";
            lblCorrespEmp.Size = new Size(28, 22);
            lblCorrespEmp.TabIndex = 26;
            lblCorrespEmp.Text = "---";
            // 
            // imgCorresp
            // 
            imgCorresp.Image = (Image)resources.GetObject("imgCorresp.Image");
            imgCorresp.Location = new Point(220, 309);
            imgCorresp.Name = "imgCorresp";
            imgCorresp.Size = new Size(30, 30);
            imgCorresp.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCorresp.TabIndex = 25;
            imgCorresp.TabStop = false;
            // 
            // lblCorresp
            // 
            lblCorresp.AutoSize = true;
            lblCorresp.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorresp.Location = new Point(251, 313);
            lblCorresp.Name = "lblCorresp";
            lblCorresp.Size = new Size(147, 22);
            lblCorresp.TabIndex = 24;
            lblCorresp.Text = "Correspondencia";
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(55, 62);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 79;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblNoGan
            // 
            lblNoGan.AutoSize = true;
            lblNoGan.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoGan.ForeColor = Color.Red;
            lblNoGan.Location = new Point(198, 371);
            lblNoGan.Name = "lblNoGan";
            lblNoGan.Size = new Size(308, 22);
            lblNoGan.TabIndex = 80;
            lblNoGan.Text = "No se han registrado ventas en el dia";
            lblNoGan.Visible = false;
            // 
            // CorrespEmp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(719, 450);
            Controls.Add(lblNoGan);
            Controls.Add(btnRegresar);
            Controls.Add(lblCorrespEmp);
            Controls.Add(imgCorresp);
            Controls.Add(lblCorresp);
            Controls.Add(imgEmp);
            Controls.Add(lblEmp);
            Controls.Add(lblGanEmp);
            Controls.Add(cbEmp);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CorrespEmp";
            Text = "Car Wash Leo";
            Load += CorrespEmp_Load;
            ((System.ComponentModel.ISupportInitialize)imgEmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCorresp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgEmp;
        private Label lblEmp;
        private Label lblGanEmp;
        private ComboBox cbEmp;
        private Label lblCorrespEmp;
        private PictureBox imgCorresp;
        private Label lblCorresp;
        private Button btnRegresar;
        private Label lblNoGan;
    }
}