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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEmpleado));
            tblEmpleados = new DataGridView();
            pnlCabecera = new Panel();
            btnBajaEmpleado = new Button();
            btnModEmpleado = new Button();
            btnAltaEmpleado = new Button();
            lblEmpleados = new Label();
            lblGestionDe = new Label();
            pnlContenido = new Panel();
            txtPaginaFinal = new TextBox();
            cbPagina = new ComboBox();
            txtNumregistros = new TextBox();
            lblIndicador = new Label();
            lblPagina = new Label();
            lblNumRegistro = new Label();
            lblNoEmpleados = new Label();
            ((System.ComponentModel.ISupportInitialize)tblEmpleados).BeginInit();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // tblEmpleados
            // 
            tblEmpleados.AllowUserToAddRows = false;
            tblEmpleados.AllowUserToDeleteRows = false;
            tblEmpleados.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tblEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tblEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblEmpleados.Location = new Point(28, 74);
            tblEmpleados.MultiSelect = false;
            tblEmpleados.Name = "tblEmpleados";
            tblEmpleados.ReadOnly = true;
            tblEmpleados.RowHeadersWidth = 62;
            tblEmpleados.ScrollBars = ScrollBars.Horizontal;
            tblEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblEmpleados.Size = new Size(1765, 420);
            tblEmpleados.TabIndex = 0;
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
            pnlContenido.Controls.Add(txtPaginaFinal);
            pnlContenido.Controls.Add(cbPagina);
            pnlContenido.Controls.Add(txtNumregistros);
            pnlContenido.Controls.Add(lblIndicador);
            pnlContenido.Controls.Add(lblPagina);
            pnlContenido.Controls.Add(lblNumRegistro);
            pnlContenido.Controls.Add(lblNoEmpleados);
            pnlContenido.Controls.Add(tblEmpleados);
            pnlContenido.Location = new Point(0, 100);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1820, 547);
            pnlContenido.TabIndex = 3;
            // 
            // txtPaginaFinal
            // 
            txtPaginaFinal.Enabled = false;
            txtPaginaFinal.Location = new Point(1144, 501);
            txtPaginaFinal.Name = "txtPaginaFinal";
            txtPaginaFinal.Size = new Size(72, 31);
            txtPaginaFinal.TabIndex = 12;
            // 
            // cbPagina
            // 
            cbPagina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPagina.FormattingEnabled = true;
            cbPagina.Location = new Point(940, 500);
            cbPagina.Name = "cbPagina";
            cbPagina.Size = new Size(72, 33);
            cbPagina.TabIndex = 11;
            // 
            // txtNumregistros
            // 
            txtNumregistros.Enabled = false;
            txtNumregistros.Location = new Point(681, 501);
            txtNumregistros.Name = "txtNumregistros";
            txtNumregistros.Size = new Size(72, 31);
            txtNumregistros.TabIndex = 10;
            // 
            // lblIndicador
            // 
            lblIndicador.AutoSize = true;
            lblIndicador.Location = new Point(1105, 502);
            lblIndicador.Name = "lblIndicador";
            lblIndicador.Size = new Size(38, 25);
            lblIndicador.TabIndex = 9;
            lblIndicador.Text = "De:";
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(839, 502);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(101, 25);
            lblPagina.TabIndex = 8;
            lblPagina.Text = "Paginación:";
            // 
            // lblNumRegistro
            // 
            lblNumRegistro.AutoSize = true;
            lblNumRegistro.Location = new Point(548, 501);
            lblNumRegistro.Name = "lblNumRegistro";
            lblNumRegistro.Size = new Size(133, 25);
            lblNumRegistro.TabIndex = 7;
            lblNumRegistro.Text = "Num Registros:";
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
            ((System.ComponentModel.ISupportInitialize)tblEmpleados).EndInit();
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
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
        private TextBox txtPaginaFinal;
        private ComboBox cbPagina;
        private TextBox txtNumregistros;
        private Label lblIndicador;
        private Label lblPagina;
        private Label lblNumRegistro;
    }
}