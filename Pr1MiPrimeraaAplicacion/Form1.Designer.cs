namespace MiPrimeraaAplicacion
{
    partial class Form1
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
            IblInstruccion = new Label();
            btnSaludar = new Button();
            btnDespedir = new Button();
            SuspendLayout();
            // 
            // IblInstruccion
            // 
            IblInstruccion.AutoSize = true;
            IblInstruccion.Location = new Point(294, 132);
            IblInstruccion.Name = "IblInstruccion";
            IblInstruccion.Size = new Size(216, 15);
            IblInstruccion.TabIndex = 0;
            IblInstruccion.Text = "Pulsa el botón para mostrar un mensaje";
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(369, 169);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(75, 23);
            btnSaludar.TabIndex = 1;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // btnDespedir
            // 
            btnDespedir.Location = new Point(369, 214);
            btnDespedir.Name = "btnDespedir";
            btnDespedir.Size = new Size(75, 23);
            btnDespedir.TabIndex = 2;
            btnDespedir.Text = "Despedir";
            btnDespedir.UseVisualStyleBackColor = true;
            btnDespedir.Click += btnDespedir_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDespedir);
            Controls.Add(btnSaludar);
            Controls.Add(IblInstruccion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IblInstruccion;
        private Button btnSaludar;
        private Button btnDespedir;
    }
}
