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
            this.btRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SELECCIONE = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SELECCIONE.SuspendLayout();
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
            // btRegresar
            // 
            this.btRegresar.Location = new System.Drawing.Point(483, 233);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(75, 23);
            this.btRegresar.TabIndex = 6;
            this.btRegresar.Text = "REGRESAR";
            this.btRegresar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(584, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // SELECCIONE
            // 
            this.SELECCIONE.Controls.Add(this.radioButton2);
            this.SELECCIONE.Controls.Add(this.radioButton1);
            this.SELECCIONE.Location = new System.Drawing.Point(228, 28);
            this.SELECCIONE.Name = "SELECCIONE";
            this.SELECCIONE.Size = new System.Drawing.Size(200, 108);
            this.SELECCIONE.TabIndex = 8;
            this.SELECCIONE.TabStop = false;
            this.SELECCIONE.Text = "Seleccione";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(171, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PLANILLA ADMINISTRACION";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(166, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PLANILLA DE COMISIONES ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 268);
            this.Controls.Add(this.SELECCIONE);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btnContratacion);
            this.Controls.Add(this.btnProceso);
            this.Controls.Add(this.btRECLUTAMIENTO);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.SELECCIONE.ResumeLayout(false);
            this.SELECCIONE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRECLUTAMIENTO;
        private System.Windows.Forms.Button btnProceso;
        private System.Windows.Forms.Button btnContratacion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox SELECCIONE;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

