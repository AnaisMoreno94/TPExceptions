namespace WindowsExceptions
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearMedicoVacio = new System.Windows.Forms.Button();
            this.btnCrearMedicoLargo = new System.Windows.Forms.Button();
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearMedicoVacio
            // 
            this.btnCrearMedicoVacio.Location = new System.Drawing.Point(248, 83);
            this.btnCrearMedicoVacio.Name = "btnCrearMedicoVacio";
            this.btnCrearMedicoVacio.Size = new System.Drawing.Size(252, 50);
            this.btnCrearMedicoVacio.TabIndex = 0;
            this.btnCrearMedicoVacio.Text = "Crear Medico(Nombre vacio)";
            this.btnCrearMedicoVacio.UseVisualStyleBackColor = true;
            this.btnCrearMedicoVacio.Click += new System.EventHandler(this.btnCrearMedicoVacio_Click);
            // 
            // btnCrearMedicoLargo
            // 
            this.btnCrearMedicoLargo.Location = new System.Drawing.Point(248, 166);
            this.btnCrearMedicoLargo.Name = "btnCrearMedicoLargo";
            this.btnCrearMedicoLargo.Size = new System.Drawing.Size(252, 50);
            this.btnCrearMedicoLargo.TabIndex = 1;
            this.btnCrearMedicoLargo.Text = "Crear Medico (Nombre muy largo)";
            this.btnCrearMedicoLargo.UseVisualStyleBackColor = true;
            this.btnCrearMedicoLargo.Click += new System.EventHandler(this.btnCrearMedicoLargo_Click);
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Location = new System.Drawing.Point(248, 247);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(252, 50);
            this.btnCrearMedico.TabIndex = 2;
            this.btnCrearMedico.Text = "Crear Medico";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearMedico);
            this.Controls.Add(this.btnCrearMedicoLargo);
            this.Controls.Add(this.btnCrearMedicoVacio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearMedicoVacio;
        private System.Windows.Forms.Button btnCrearMedicoLargo;
        private System.Windows.Forms.Button btnCrearMedico;
    }
}

