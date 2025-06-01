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
            btnAltaEmpleado = new Button();
            lblEmpleados = new Label();
            lblGestionDe = new Label();
            pnlCabecera.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(btnAltaEmpleado);
            pnlCabecera.Controls.Add(lblEmpleados);
            pnlCabecera.Controls.Add(lblGestionDe);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 3;
            // 
            // btnAltaEmpleado
            // 
            btnAltaEmpleado.BackColor = Color.FromArgb(63, 114, 175);
            btnAltaEmpleado.FlatStyle = FlatStyle.Popup;
            btnAltaEmpleado.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAltaEmpleado.ForeColor = Color.White;
            btnAltaEmpleado.Image = (Image)resources.GetObject("btnAltaEmpleado.Image");
            btnAltaEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnAltaEmpleado.Location = new Point(1487, 32);
            btnAltaEmpleado.Name = "btnAltaEmpleado";
            btnAltaEmpleado.Size = new Size(225, 39);
            btnAltaEmpleado.TabIndex = 2;
            btnAltaEmpleado.Text = "Agregar Gasto";
            btnAltaEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnAltaEmpleado.UseVisualStyleBackColor = false;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleados.ForeColor = Color.FromArgb(63, 114, 175);
            lblEmpleados.Location = new Point(261, 28);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(153, 46);
            lblEmpleados.TabIndex = 1;
            lblEmpleados.Text = "Gastos";
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
            // GestionGasto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 547);
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
        private Button btnAltaEmpleado;
        private Label lblEmpleados;
        private Label lblGestionDe;
    }
}