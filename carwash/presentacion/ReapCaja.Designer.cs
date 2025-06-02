namespace presentacion
{
    partial class ReapCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReapCaja));
            lblReapCaja = new Label();
            btnRegresar = new Button();
            lblAdmin = new Label();
            lblFechaHora = new Label();
            lblDesc = new Label();
            txtAdmin = new TextBox();
            txtFechaHora = new TextBox();
            txtDesc = new TextBox();
            label3 = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // lblReapCaja
            // 
            lblReapCaja.Font = new Font("Inter", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReapCaja.Location = new Point(183, 69);
            lblReapCaja.Name = "lblReapCaja";
            lblReapCaja.Size = new Size(414, 46);
            lblReapCaja.TabIndex = 3;
            lblReapCaja.Text = "Reapertura de caja";
            lblReapCaja.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(62, 73);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 19;
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmin.Location = new Point(122, 197);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(127, 22);
            lblAdmin.TabIndex = 27;
            lblAdmin.Text = "Administrador";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaHora.Location = new Point(122, 296);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(115, 22);
            lblFechaHora.TabIndex = 28;
            lblFechaHora.Text = "Fecha y hora";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(122, 391);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(108, 22);
            lblDesc.TabIndex = 29;
            lblDesc.Text = "Descripción";
            // 
            // txtAdmin
            // 
            txtAdmin.Location = new Point(122, 231);
            txtAdmin.Name = "txtAdmin";
            txtAdmin.Size = new Size(506, 31);
            txtAdmin.TabIndex = 30;
            // 
            // txtFechaHora
            // 
            txtFechaHora.Location = new Point(122, 328);
            txtFechaHora.Name = "txtFechaHora";
            txtFechaHora.Size = new Size(506, 31);
            txtFechaHora.TabIndex = 31;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(122, 425);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(506, 162);
            txtDesc.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(224, 388);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 47;
            label3.Text = "*";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = SystemColors.Window;
            btnConfirmar.Image = (Image)resources.GetObject("btnConfirmar.Image");
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(122, 614);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(506, 34);
            btnConfirmar.TabIndex = 48;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // ReapCaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(746, 687);
            Controls.Add(btnConfirmar);
            Controls.Add(label3);
            Controls.Add(txtDesc);
            Controls.Add(txtFechaHora);
            Controls.Add(txtAdmin);
            Controls.Add(lblDesc);
            Controls.Add(lblFechaHora);
            Controls.Add(lblAdmin);
            Controls.Add(btnRegresar);
            Controls.Add(lblReapCaja);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ReapCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Wash Leo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReapCaja;
        private Button btnRegresar;
        private Label lblAdmin;
        private Label lblFechaHora;
        private Label lblDesc;
        private TextBox txtAdmin;
        private TextBox txtFechaHora;
        private TextBox txtDesc;
        private Label label3;
        private Button btnConfirmar;
    }
}