namespace presentacion
{
    partial class Verificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verificacion));
            btnMostrarPwd1 = new Button();
            txtCont = new TextBox();
            lblCont = new Label();
            lblVerificacion = new Label();
            btnVerificar = new Button();
            btnRegresar = new Button();
            lbltituloVerificacion = new Label();
            SuspendLayout();
            // 
            // btnMostrarPwd1
            // 
            btnMostrarPwd1.FlatStyle = FlatStyle.Flat;
            btnMostrarPwd1.ForeColor = SystemColors.Window;
            btnMostrarPwd1.Image = (Image)resources.GetObject("btnMostrarPwd1.Image");
            btnMostrarPwd1.Location = new Point(687, 199);
            btnMostrarPwd1.Name = "btnMostrarPwd1";
            btnMostrarPwd1.Size = new Size(37, 27);
            btnMostrarPwd1.TabIndex = 80;
            btnMostrarPwd1.UseVisualStyleBackColor = true;
            btnMostrarPwd1.Click += btnMostrarPwd1_Click;
            // 
            // txtCont
            // 
            txtCont.Location = new Point(111, 195);
            txtCont.Name = "txtCont";
            txtCont.Size = new Size(555, 31);
            txtCont.TabIndex = 79;
            txtCont.UseSystemPasswordChar = true;
            // 
            // lblCont
            // 
            lblCont.AutoSize = true;
            lblCont.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCont.Location = new Point(110, 164);
            lblCont.Name = "lblCont";
            lblCont.Size = new Size(103, 22);
            lblCont.TabIndex = 77;
            lblCont.Text = "Contraseña";
            // 
            // lblVerificacion
            // 
            lblVerificacion.AutoSize = true;
            lblVerificacion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVerificacion.Location = new Point(142, 97);
            lblVerificacion.Name = "lblVerificacion";
            lblVerificacion.Size = new Size(502, 28);
            lblVerificacion.TabIndex = 81;
            lblVerificacion.Text = "Ingrese su contraseña de usuario para verificar identidad";
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(63, 114, 175);
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificar.ForeColor = SystemColors.Window;
            btnVerificar.Image = (Image)resources.GetObject("btnVerificar.Image");
            btnVerificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerificar.Location = new Point(111, 294);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(556, 43);
            btnVerificar.TabIndex = 82;
            btnVerificar.Text = "Confirmar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = SystemColors.Window;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(40, 40);
            btnRegresar.TabIndex = 83;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lbltituloVerificacion
            // 
            lbltituloVerificacion.AutoSize = true;
            lbltituloVerificacion.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltituloVerificacion.Location = new Point(282, 9);
            lbltituloVerificacion.Name = "lbltituloVerificacion";
            lbltituloVerificacion.Size = new Size(241, 46);
            lbltituloVerificacion.TabIndex = 84;
            lbltituloVerificacion.Text = "Verificacion";
            // 
            // Verificacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(798, 376);
            Controls.Add(lbltituloVerificacion);
            Controls.Add(btnRegresar);
            Controls.Add(btnVerificar);
            Controls.Add(lblVerificacion);
            Controls.Add(btnMostrarPwd1);
            Controls.Add(txtCont);
            Controls.Add(lblCont);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Verificacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verificacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarPwd1;
        private TextBox txtCont;
        private Label lblCont;
        private Label lblVerificacion;
        private Button btnVerificar;
        private Button btnRegresar;
        private Label lbltituloVerificacion;
    }
}