namespace presentacion
{
    partial class ConfigVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigVenta));
            btnRegresar = new Button();
            lblConfigVenta = new Label();
            lblModelo = new Label();
            txtPorGan = new TextBox();
            txtPorCorresp = new TextBox();
            label1 = new Label();
            btnConfirmar = new Button();
            obligatorio = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(69, 45);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 19;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblConfigVenta
            // 
            lblConfigVenta.AutoSize = true;
            lblConfigVenta.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfigVenta.Location = new Point(166, 45);
            lblConfigVenta.Name = "lblConfigVenta";
            lblConfigVenta.Size = new Size(460, 46);
            lblConfigVenta.TabIndex = 18;
            lblConfigVenta.Text = "Configuración de Venta";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(287, 164);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(203, 22);
            lblModelo.TabIndex = 20;
            lblModelo.Text = "Porcentaje de Ganancia";
            // 
            // txtPorGan
            // 
            txtPorGan.Location = new Point(227, 189);
            txtPorGan.Name = "txtPorGan";
            txtPorGan.Size = new Size(329, 31);
            txtPorGan.TabIndex = 25;
            txtPorGan.TextChanged += txtPorGan_TextChanged;
            txtPorGan.KeyPress += txtPorGan_KeyPress;
            // 
            // txtPorCorresp
            // 
            txtPorCorresp.Location = new Point(228, 295);
            txtPorCorresp.Name = "txtPorCorresp";
            txtPorCorresp.Size = new Size(329, 31);
            txtPorCorresp.TabIndex = 27;
            txtPorCorresp.TextChanged += txtPorCorresp_TextChanged;
            txtPorCorresp.KeyPress += txtPorCorresp_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 267);
            label1.Name = "label1";
            label1.Size = new Size(263, 22);
            label1.TabIndex = 26;
            label1.Text = "Porcentaje de Correspondencia";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.Window;
            btnConfirmar.Image = (Image)resources.GetObject("btnConfirmar.Image");
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(228, 393);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(335, 34);
            btnConfirmar.TabIndex = 45;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // obligatorio
            // 
            obligatorio.AutoSize = true;
            obligatorio.ForeColor = Color.Red;
            obligatorio.Location = new Point(483, 161);
            obligatorio.Name = "obligatorio";
            obligatorio.Size = new Size(20, 25);
            obligatorio.TabIndex = 46;
            obligatorio.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(513, 264);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 47;
            label2.Text = "*";
            // 
            // ConfigVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 486);
            Controls.Add(label2);
            Controls.Add(obligatorio);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPorCorresp);
            Controls.Add(label1);
            Controls.Add(txtPorGan);
            Controls.Add(lblModelo);
            Controls.Add(btnRegresar);
            Controls.Add(lblConfigVenta);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ConfigVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Wash Leo";
            Load += ConfigVenta_Load;
            KeyDown += ConfigVenta_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Label lblConfigVenta;
        private Label lblModelo;
        private TextBox txtPorGan;
        private TextBox txtPorCorresp;
        private Label label1;
        private Button btnConfirmar;
        private Label obligatorio;
        private Label label2;
    }
}