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
            pnlCabecera.SuspendLayout();
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
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 4;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Button btnAltaGas;
        private Label lblGastos;
        private Label lblGestionDe;
        private Panel pnlContenido;
    }
}