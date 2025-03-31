namespace presentacion
{
    partial class Autenticacion
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
            labelCarWash = new Label();
            SuspendLayout();
            // 
            // labelCarWash
            // 
            labelCarWash.AutoSize = true;
            labelCarWash.ForeColor = SystemColors.ControlText;
            labelCarWash.Location = new Point(521, 206);
            labelCarWash.Name = "labelCarWash";
            labelCarWash.Size = new Size(57, 15);
            labelCarWash.TabIndex = 0;
            labelCarWash.Text = "Car Wash";
            labelCarWash.Click += label1_Click;
            // 
            // Autenticacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelCarWash);
            Name = "Autenticacion";
            Text = "Autenticacion";
            Load += Autenticacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCarWash;
    }
}