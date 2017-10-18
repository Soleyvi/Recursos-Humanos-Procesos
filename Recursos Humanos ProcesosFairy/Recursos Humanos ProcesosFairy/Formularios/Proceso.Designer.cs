namespace Recursos_Humanos_ProcesosFairy
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btRECLUTAMIENTO = new System.Windows.Forms.Button();
            this.btnProceso = new System.Windows.Forms.Button();
            this.btnContratacion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // btRECLUTAMIENTO
            // 
            this.btRECLUTAMIENTO.Location = new System.Drawing.Point(26, 27);
            this.btRECLUTAMIENTO.Name = "btRECLUTAMIENTO";
            this.btRECLUTAMIENTO.Size = new System.Drawing.Size(126, 42);
            this.btRECLUTAMIENTO.TabIndex = 0;
            this.btRECLUTAMIENTO.Text = "RECLUTAMIENTO";
            this.btRECLUTAMIENTO.UseVisualStyleBackColor = true;
            // 
            // btnProceso
            // 
            this.btnProceso.Location = new System.Drawing.Point(26, 158);
            this.btnProceso.Name = "btnProceso";
            this.btnProceso.Size = new System.Drawing.Size(126, 42);
            this.btnProceso.TabIndex = 3;
            this.btnProceso.Text = "PROCESO";
            this.btnProceso.UseVisualStyleBackColor = true;
            // 
            // btnContratacion
            // 
            this.btnContratacion.Location = new System.Drawing.Point(26, 94);
            this.btnContratacion.Name = "btnContratacion";
            this.btnContratacion.Size = new System.Drawing.Size(126, 42);
            this.btnContratacion.TabIndex = 4;
            this.btnContratacion.Text = "CONTRATACION";
            this.btnContratacion.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 268);
            this.Controls.Add(this.btnContratacion);
            this.Controls.Add(this.btnProceso);
            this.Controls.Add(this.btRECLUTAMIENTO);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRECLUTAMIENTO;
        private System.Windows.Forms.Button btnProceso;
        private System.Windows.Forms.Button btnContratacion;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

