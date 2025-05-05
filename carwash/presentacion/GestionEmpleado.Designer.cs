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
            pnlCabecera = new Panel();
            btnElimEmpleado = new Button();
            btnModEmpleado = new Button();
            btnAddEmpleado = new Button();
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
            pnlCabecera.Controls.Add(btnElimEmpleado);
            pnlCabecera.Controls.Add(btnModEmpleado);
            pnlCabecera.Controls.Add(btnAddEmpleado);
            pnlCabecera.Controls.Add(lblEmpleados);
            pnlCabecera.Controls.Add(lblGestionDe);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 2;
            // 
            // btnElimEmpleado
            // 
            btnElimEmpleado.BackColor = Color.FromArgb(63, 114, 175);
            btnElimEmpleado.FlatStyle = FlatStyle.Popup;
            btnElimEmpleado.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnElimEmpleado.ForeColor = Color.White;
            btnElimEmpleado.Image = (Image)resources.GetObject("btnElimEmpleado.Image");
            btnElimEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnElimEmpleado.Location = new Point(1194, 32);
            btnElimEmpleado.Name = "btnElimEmpleado";
            btnElimEmpleado.Size = new Size(225, 39);
            btnElimEmpleado.TabIndex = 4;
            btnElimEmpleado.Text = "Eliminar Empleado";
            btnElimEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnElimEmpleado.UseVisualStyleBackColor = false;
            btnElimEmpleado.Click += btnElimEmpleado_Click;
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
            // btnAddEmpleado
            // 
            btnAddEmpleado.BackColor = Color.FromArgb(63, 114, 175);
            btnAddEmpleado.FlatStyle = FlatStyle.Popup;
            btnAddEmpleado.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmpleado.ForeColor = Color.White;
            btnAddEmpleado.Image = (Image)resources.GetObject("btnAddEmpleado.Image");
            btnAddEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddEmpleado.Location = new Point(1487, 32);
            btnAddEmpleado.Name = "btnAddEmpleado";
            btnAddEmpleado.Size = new Size(225, 39);
            btnAddEmpleado.TabIndex = 2;
            btnAddEmpleado.Text = "Agregar Empleado";
            btnAddEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnAddEmpleado.UseVisualStyleBackColor = false;
            btnAddEmpleado.Click += btnAddEmpleado_Click;
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
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Button btnElimEmpleado;
        private Button btnModEmpleado;
        private Button btnAddEmpleado;
        private Label lblEmpleados;
        private Label lblGestionDe;
        private Panel pnlContenido;
        private Label lblNoEmpleados;
        private DataGridView tblEmpleados;
    }
}