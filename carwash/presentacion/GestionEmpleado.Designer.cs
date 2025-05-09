namespace presentacion
{
    partial class GestionEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEmpleado));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlCabecera = new Panel();
            btnBajaEmpleado = new Button();
            btnModEmpleado = new Button();
            btnAltaEmpleado = new Button();
            lblEmpleados = new Label();
            lblGestionDe = new Label();
            pnlContenido = new Panel();
            lblNoEmpleados = new Label();
            tblEmpleados = new DataGridView();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblEmpleados).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(btnBajaEmpleado);
            pnlCabecera.Controls.Add(btnModEmpleado);
            pnlCabecera.Controls.Add(btnAltaEmpleado);
            pnlCabecera.Controls.Add(lblEmpleados);
            pnlCabecera.Controls.Add(lblGestionDe);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 2;
            // 
            // btnBajaEmpleado
            // 
            btnBajaEmpleado.BackColor = Color.FromArgb(63, 114, 175);
            btnBajaEmpleado.FlatStyle = FlatStyle.Popup;
            btnBajaEmpleado.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBajaEmpleado.ForeColor = Color.White;
            btnBajaEmpleado.Image = (Image)resources.GetObject("btnBajaEmpleado.Image");
            btnBajaEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnBajaEmpleado.Location = new Point(1194, 32);
            btnBajaEmpleado.Name = "btnBajaEmpleado";
            btnBajaEmpleado.Size = new Size(225, 39);
            btnBajaEmpleado.TabIndex = 4;
            btnBajaEmpleado.Text = "Eliminar Empleado";
            btnBajaEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnBajaEmpleado.UseVisualStyleBackColor = false;
            btnBajaEmpleado.Click += btnElimEmpleado_Click;
            // 
            // btnModEmpleado
            // 
            btnModEmpleado.BackColor = Color.FromArgb(63, 114, 175);
            btnModEmpleado.FlatStyle = FlatStyle.Popup;
            btnModEmpleado.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModEmpleado.ForeColor = Color.White;
            btnModEmpleado.Image = (Image)resources.GetObject("btnModEmpleado.Image");
            btnModEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnModEmpleado.Location = new Point(899, 32);
            btnModEmpleado.Name = "btnModEmpleado";
            btnModEmpleado.Size = new Size(225, 39);
            btnModEmpleado.TabIndex = 3;
            btnModEmpleado.Text = "Modificar Empleado";
            btnModEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnModEmpleado.UseVisualStyleBackColor = false;
            btnModEmpleado.Click += btnModEmpleado_Click;
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
            btnAltaEmpleado.Text = "Agregar Empleado";
            btnAltaEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnAltaEmpleado.UseVisualStyleBackColor = false;
            btnAltaEmpleado.Click += btnAddEmpleado_Click;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleados.ForeColor = Color.FromArgb(63, 114, 175);
            lblEmpleados.Location = new Point(261, 28);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(229, 46);
            lblEmpleados.TabIndex = 1;
            lblEmpleados.Text = "Empleados";
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
            pnlContenido.Controls.Add(lblNoEmpleados);
            pnlContenido.Controls.Add(tblEmpleados);
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 3;
            // 
            // lblNoEmpleados
            // 
            lblNoEmpleados.AutoSize = true;
            lblNoEmpleados.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoEmpleados.Location = new Point(599, 249);
            lblNoEmpleados.Name = "lblNoEmpleados";
            lblNoEmpleados.Size = new Size(570, 32);
            lblNoEmpleados.TabIndex = 1;
            lblNoEmpleados.Text = "No se encuentran empleados dados de alta.";
            lblNoEmpleados.Visible = false;
            // 
            // tblEmpleados
            // 
            tblEmpleados.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblEmpleados.Location = new Point(81, 74);
            tblEmpleados.MultiSelect = false;
            tblEmpleados.Name = "tblEmpleados";
            tblEmpleados.ReadOnly = true;
            tblEmpleados.RowHeadersWidth = 62;
            tblEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblEmpleados.Size = new Size(1669, 404);
            tblEmpleados.TabIndex = 0;
            // 
            // GestionEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 647);
            Controls.Add(pnlContenido);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionEmpleado";
            Text = "GestionEmpleado";
            Load += GestionEmpleado_Load;
            KeyDown += GestionEmpleado_KeyDown;
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Button btnBajaEmpleado;
        private Button btnModEmpleado;
        private Button btnAltaEmpleado;
        private Label lblEmpleados;
        private Label lblGestionDe;
        private Panel pnlContenido;
        private Label lblNoEmpleados;
        private DataGridView tblEmpleados;
    }
}