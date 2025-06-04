namespace presentacion
{
    partial class Bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            lblBit = new Label();
            btnRegresar = new Button();
            lblConsReap = new Label();
            lblAdmin = new Label();
            lblFechaHora = new Label();
            lblDesc = new Label();
            dtReap = new DateTimePicker();
            txtAdmin = new TextBox();
            txtFechaHora = new TextBox();
            txtDesc = new TextBox();
            SuspendLayout();
            // 
            // lblBit
            // 
            lblBit.Font = new Font("Inter", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBit.Location = new Point(143, 62);
            lblBit.Name = "lblBit";
            lblBit.Size = new Size(480, 46);
            lblBit.TabIndex = 3;
            lblBit.Text = "Bitácora de reapertura";
            lblBit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(41, 64);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 19;
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // lblConsReap
            // 
            lblConsReap.AutoSize = true;
            lblConsReap.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsReap.Location = new Point(119, 203);
            lblConsReap.Name = "lblConsReap";
            lblConsReap.Size = new Size(197, 22);
            lblConsReap.TabIndex = 28;
            lblConsReap.Text = "Consulta de reapertura";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmin.Location = new Point(119, 301);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(127, 22);
            lblAdmin.TabIndex = 29;
            lblAdmin.Text = "Administrador";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaHora.Location = new Point(119, 392);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(115, 22);
            lblFechaHora.TabIndex = 30;
            lblFechaHora.Text = "Fecha y hora";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(119, 486);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(108, 22);
            lblDesc.TabIndex = 31;
            lblDesc.Text = "Descripción";
            // 
            // dtReap
            // 
            dtReap.Location = new Point(119, 230);
            dtReap.Name = "dtReap";
            dtReap.Size = new Size(340, 31);
            dtReap.TabIndex = 32;
            // 
            // txtAdmin
            // 
            txtAdmin.Location = new Point(119, 328);
            txtAdmin.Name = "txtAdmin";
            txtAdmin.ReadOnly = true;
            txtAdmin.Size = new Size(504, 31);
            txtAdmin.TabIndex = 33;
            // 
            // txtFechaHora
            // 
            txtFechaHora.Location = new Point(119, 419);
            txtFechaHora.Name = "txtFechaHora";
            txtFechaHora.ReadOnly = true;
            txtFechaHora.Size = new Size(504, 31);
            txtFechaHora.TabIndex = 34;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(119, 513);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(504, 148);
            txtDesc.TabIndex = 35;
            // 
            // Bitacora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(746, 735);
            Controls.Add(txtDesc);
            Controls.Add(txtFechaHora);
            Controls.Add(txtAdmin);
            Controls.Add(dtReap);
            Controls.Add(lblDesc);
            Controls.Add(lblFechaHora);
            Controls.Add(lblAdmin);
            Controls.Add(lblConsReap);
            Controls.Add(btnRegresar);
            Controls.Add(lblBit);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Bitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Wash Leo";
            Load += Bitacora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBit;
        private Button btnRegresar;
        private Label lblConsReap;
        private Label lblAdmin;
        private Label lblFechaHora;
        private Label lblDesc;
        private DateTimePicker dtReap;
        private TextBox txtAdmin;
        private TextBox txtFechaHora;
        private TextBox txtDesc;
    }
}