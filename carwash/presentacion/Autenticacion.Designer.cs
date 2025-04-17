namespace presentacion
{
    partial class Autenticacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autenticacion));
            lblCarWash = new Label();
            lblLeo = new Label();
            pnlDecorativo = new Panel();
            pnlLogin = new Panel();
            btnMostrarPwd = new Button();
            btnLogin = new Button();
            txtPwd = new ReaLTaiizor.Controls.DreamTextBox();
            txtNombreUsr = new ReaLTaiizor.Controls.DreamTextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCarWash
            // 
            lblCarWash.AutoSize = true;
            lblCarWash.Font = new Font("Inter", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarWash.Location = new Point(649, 89);
            lblCarWash.Name = "lblCarWash";
            lblCarWash.Size = new Size(438, 101);
            lblCarWash.TabIndex = 0;
            lblCarWash.Text = "Car Wash";
            // 
            // lblLeo
            // 
            lblLeo.AutoSize = true;
            lblLeo.Font = new Font("Inter", 42F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeo.ForeColor = Color.FromArgb(63, 114, 175);
            lblLeo.Location = new Point(1061, 89);
            lblLeo.Name = "lblLeo";
            lblLeo.Size = new Size(193, 101);
            lblLeo.TabIndex = 1;
            lblLeo.Text = "Leo";
            // 
            // pnlDecorativo
            // 
            pnlDecorativo.BackColor = Color.FromArgb(17, 45, 78);
            pnlDecorativo.Location = new Point(0, 971);
            pnlDecorativo.Name = "pnlDecorativo";
            pnlDecorativo.Size = new Size(1920, 50);
            pnlDecorativo.TabIndex = 2;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(btnMostrarPwd);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPwd);
            pnlLogin.Controls.Add(txtNombreUsr);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Location = new Point(686, 310);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(534, 582);
            pnlLogin.TabIndex = 3;
            // 
            // btnMostrarPwd
            // 
            btnMostrarPwd.FlatStyle = FlatStyle.Flat;
            btnMostrarPwd.ForeColor = SystemColors.Window;
            btnMostrarPwd.Image = (Image)resources.GetObject("btnMostrarPwd.Image");
            btnMostrarPwd.Location = new Point(471, 390);
            btnMostrarPwd.Name = "btnMostrarPwd";
            btnMostrarPwd.Size = new Size(37, 26);
            btnMostrarPwd.TabIndex = 10;
            btnMostrarPwd.UseVisualStyleBackColor = true;
            btnMostrarPwd.Click += btnMostrarPwd_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(63, 114, 175);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Window;
            btnLogin.Location = new Point(71, 496);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(391, 34);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPwd
            // 
            txtPwd.BackColor = Color.FromArgb(190, 223, 255);
            txtPwd.BorderStyle = BorderStyle.FixedSingle;
            txtPwd.ColorA = Color.FromArgb(31, 31, 31);
            txtPwd.ColorB = Color.FromArgb(41, 41, 41);
            txtPwd.ColorC = Color.FromArgb(51, 51, 51);
            txtPwd.ColorD = Color.FromArgb(0, 0, 0, 0);
            txtPwd.ColorE = Color.FromArgb(25, 255, 255, 255);
            txtPwd.ColorF = Color.Black;
            txtPwd.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.ForeColor = Color.Black;
            txtPwd.Location = new Point(71, 390);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(391, 29);
            txtPwd.TabIndex = 8;
            // 
            // txtNombreUsr
            // 
            txtNombreUsr.BackColor = Color.FromArgb(190, 223, 255);
            txtNombreUsr.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsr.ColorA = Color.FromArgb(31, 31, 31);
            txtNombreUsr.ColorB = Color.FromArgb(41, 41, 41);
            txtNombreUsr.ColorC = Color.FromArgb(51, 51, 51);
            txtNombreUsr.ColorD = Color.FromArgb(0, 0, 0, 0);
            txtNombreUsr.ColorE = Color.FromArgb(25, 255, 255, 255);
            txtNombreUsr.ColorF = Color.Black;
            txtNombreUsr.Font = new Font("Nacelle", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsr.ForeColor = Color.Black;
            txtNombreUsr.Location = new Point(71, 269);
            txtNombreUsr.Name = "txtNombreUsr";
            txtNombreUsr.Size = new Size(391, 29);
            txtNombreUsr.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nacelle", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 344);
            label3.Name = "label3";
            label3.Size = new Size(115, 24);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nacelle", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 226);
            label2.Name = "label2";
            label2.Size = new Size(179, 24);
            label2.TabIndex = 5;
            label2.Text = "Nombre de usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(71, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 26);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 226);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 25);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Inter", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(98, 68);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(329, 49);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Inicio de Sesión";
            // 
            // Autenticacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 223, 255);
            ClientSize = new Size(1898, 1024);
            Controls.Add(pnlLogin);
            Controls.Add(pnlDecorativo);
            Controls.Add(lblLeo);
            Controls.Add(lblCarWash);
            Name = "Autenticacion";
            Text = "Car Wash Leo";
            Load += Autenticacion_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarWash;
        private Label lblLeo;
        private Panel pnlDecorativo;
        private Panel pnlLogin;
        private Label lblLogin;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.DreamTextBox txtNombreUsr;
        private Button btnLogin;
        private ReaLTaiizor.Controls.DreamTextBox txtPwd;
        private Button btnMostrarPwd;
    }
}
