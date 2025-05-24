namespace presentacion
{
    partial class MessageBoxConfirmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxConfirmar));
            imgAdvertencia = new PictureBox();
            lblMensaje = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)imgAdvertencia).BeginInit();
            SuspendLayout();
            // 
            // imgAdvertencia
            // 
            imgAdvertencia.Image = (Image)resources.GetObject("imgAdvertencia.Image");
            imgAdvertencia.Location = new Point(50, 40);
            imgAdvertencia.Name = "imgAdvertencia";
            imgAdvertencia.Size = new Size(30, 30);
            imgAdvertencia.TabIndex = 0;
            imgAdvertencia.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(111, 40);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(518, 88);
            lblMensaje.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(63, 114, 175);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(54, 198);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(235, 45);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(394, 198);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(235, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // MessageBoxConfirmar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(684, 281);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(lblMensaje);
            Controls.Add(imgAdvertencia);
            Name = "MessageBoxConfirmar";
            Text = "Car Wash Leo";
            ((System.ComponentModel.ISupportInitialize)imgAdvertencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgAdvertencia;
        private Label lblMensaje;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}