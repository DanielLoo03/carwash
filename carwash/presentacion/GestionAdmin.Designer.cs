namespace presentacion
{
    partial class GestionAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionAdmin));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlCabecera = new Panel();
            btnAltaAdmin = new Button();
            btnModAdmin = new Button();
            lblGestionDe = new Label();
            lblAdmins = new Label();
            pnlContenido = new Panel();
            pnlBorde = new Panel();
            txtPaginaFinal = new TextBox();
            cbPagina = new ComboBox();
            txtNumregistros = new TextBox();
            lblIndicador = new Label();
            lblPagina = new Label();
            lblNumRegistro = new Label();
            tblAdmins = new DataGridView();
            pnlCabecera.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlBorde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblAdmins).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecera
            // 
            pnlCabecera.BackColor = Color.FromArgb(190, 223, 255);
            pnlCabecera.Controls.Add(btnAltaAdmin);
            pnlCabecera.Controls.Add(btnModAdmin);
            pnlCabecera.Controls.Add(lblGestionDe);
            pnlCabecera.Controls.Add(lblAdmins);
            pnlCabecera.Location = new Point(0, 0);
            pnlCabecera.Name = "pnlCabecera";
            pnlCabecera.Size = new Size(1820, 100);
            pnlCabecera.TabIndex = 4;
            // 
            // btnAltaAdmin
            // 
            btnAltaAdmin.BackColor = Color.FromArgb(63, 114, 175);
            btnAltaAdmin.FlatStyle = FlatStyle.Popup;
            btnAltaAdmin.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAltaAdmin.ForeColor = Color.White;
            btnAltaAdmin.Image = (Image)resources.GetObject("btnAltaAdmin.Image");
            btnAltaAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAltaAdmin.Location = new Point(1516, 27);
            btnAltaAdmin.Name = "btnAltaAdmin";
            btnAltaAdmin.Size = new Size(225, 39);
            btnAltaAdmin.TabIndex = 5;
            btnAltaAdmin.Text = "Agregar Administrador";
            btnAltaAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnAltaAdmin.UseVisualStyleBackColor = false;
            btnAltaAdmin.Click += btnAltaAdmin_Click;
            // 
            // btnModAdmin
            // 
            btnModAdmin.BackColor = Color.FromArgb(63, 114, 175);
            btnModAdmin.FlatStyle = FlatStyle.Popup;
            btnModAdmin.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModAdmin.ForeColor = Color.White;
            btnModAdmin.Image = (Image)resources.GetObject("btnModAdmin.Image");
            btnModAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnModAdmin.Location = new Point(1243, 27);
            btnModAdmin.Name = "btnModAdmin";
            btnModAdmin.Size = new Size(231, 39);
            btnModAdmin.TabIndex = 4;
            btnModAdmin.Text = "Modificar Administrador";
            btnModAdmin.TextAlign = ContentAlignment.MiddleRight;
            btnModAdmin.UseVisualStyleBackColor = false;
            // 
            // lblGestionDe
            // 
            lblGestionDe.AutoSize = true;
            lblGestionDe.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionDe.ForeColor = Color.White;
            lblGestionDe.Location = new Point(16, 27);
            lblGestionDe.Name = "lblGestionDe";
            lblGestionDe.Size = new Size(235, 46);
            lblGestionDe.TabIndex = 2;
            lblGestionDe.Text = "Gestión de ";
            // 
            // lblAdmins
            // 
            lblAdmins.AutoSize = true;
            lblAdmins.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmins.ForeColor = Color.FromArgb(63, 114, 175);
            lblAdmins.Location = new Point(247, 28);
            lblAdmins.Name = "lblAdmins";
            lblAdmins.Size = new Size(323, 46);
            lblAdmins.TabIndex = 1;
            lblAdmins.Text = "Administradores";
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = SystemColors.Window;
            pnlContenido.BorderStyle = BorderStyle.FixedSingle;
            pnlContenido.Controls.Add(pnlBorde);
            pnlContenido.Location = new Point(1, 98);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1819, 547);
            pnlContenido.TabIndex = 5;
            // 
            // pnlBorde
            // 
            pnlBorde.BorderStyle = BorderStyle.FixedSingle;
            pnlBorde.Controls.Add(txtPaginaFinal);
            pnlBorde.Controls.Add(cbPagina);
            pnlBorde.Controls.Add(txtNumregistros);
            pnlBorde.Controls.Add(lblIndicador);
            pnlBorde.Controls.Add(lblPagina);
            pnlBorde.Controls.Add(lblNumRegistro);
            pnlBorde.Controls.Add(tblAdmins);
            pnlBorde.Location = new Point(76, 47);
            pnlBorde.Name = "pnlBorde";
            pnlBorde.Size = new Size(1663, 489);
            pnlBorde.TabIndex = 13;
            // 
            // txtPaginaFinal
            // 
            txtPaginaFinal.Enabled = false;
            txtPaginaFinal.Location = new Point(1003, 446);
            txtPaginaFinal.Name = "txtPaginaFinal";
            txtPaginaFinal.Size = new Size(72, 31);
            txtPaginaFinal.TabIndex = 6;
            // 
            // cbPagina
            // 
            cbPagina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPagina.FormattingEnabled = true;
            cbPagina.Location = new Point(799, 445);
            cbPagina.Name = "cbPagina";
            cbPagina.Size = new Size(72, 33);
            cbPagina.TabIndex = 5;
            cbPagina.SelectedIndexChanged += cbPagina_SelectedIndexChanged;
            // 
            // txtNumregistros
            // 
            txtNumregistros.Enabled = false;
            txtNumregistros.Location = new Point(540, 446);
            txtNumregistros.Name = "txtNumregistros";
            txtNumregistros.Size = new Size(72, 31);
            txtNumregistros.TabIndex = 4;
            // 
            // lblIndicador
            // 
            lblIndicador.AutoSize = true;
            lblIndicador.Location = new Point(964, 447);
            lblIndicador.Name = "lblIndicador";
            lblIndicador.Size = new Size(38, 25);
            lblIndicador.TabIndex = 3;
            lblIndicador.Text = "De:";
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(698, 447);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(101, 25);
            lblPagina.TabIndex = 2;
            lblPagina.Text = "Paginación:";
            // 
            // lblNumRegistro
            // 
            lblNumRegistro.AutoSize = true;
            lblNumRegistro.Location = new Point(407, 446);
            lblNumRegistro.Name = "lblNumRegistro";
            lblNumRegistro.Size = new Size(133, 25);
            lblNumRegistro.TabIndex = 1;
            lblNumRegistro.Text = "Num Registros:";
            // 
            // tblAdmins
            // 
            tblAdmins.AllowUserToAddRows = false;
            tblAdmins.AllowUserToDeleteRows = false;
            tblAdmins.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblAdmins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblAdmins.Location = new Point(392, -1);
            tblAdmins.MultiSelect = false;
            tblAdmins.Name = "tblAdmins";
            tblAdmins.ReadOnly = true;
            tblAdmins.RowHeadersWidth = 62;
            tblAdmins.ScrollBars = ScrollBars.None;
            tblAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblAdmins.Size = new Size(782, 431);
            tblAdmins.TabIndex = 0;
            // 
            // GestionAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 647);
            Controls.Add(pnlContenido);
            Controls.Add(pnlCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionAdmin";
            Text = "Administradores";
            Load += GestionAdmin_Load;
            KeyDown += GestionAdmin_KeyDown;
            pnlCabecera.ResumeLayout(false);
            pnlCabecera.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlBorde.ResumeLayout(false);
            pnlBorde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblAdmins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecera;
        private Button btnModAdmin;
        private Label lblGestionDe;
        private Label lblAdmins;
        private Panel pnlContenido;
        private Panel pnlBorde;
        private Button btnAltaAdmin;
        private DataGridView tblAdmins;
        private Label lblIndicador;
        private Label lblPagina;
        private Label lblNumRegistro;
        private TextBox txtNumregistros;
        private ComboBox cbPagina;
        private TextBox txtPaginaFinal;
    }
}