namespace Recursos_Humanos_ProcesosFairy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.USUARIO = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.texUsuario = new System.Windows.Forms.TextBox();
            this.texContraseña = new System.Windows.Forms.TextBox();
            this.btnAceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSize = true;
            this.USUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.USUARIO.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.USUARIO.Location = new System.Drawing.Point(16, 32);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(65, 16);
            this.USUARIO.TabIndex = 0;
            this.USUARIO.Text = "USUARIO";
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbContraseña.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbContraseña.Location = new System.Drawing.Point(16, 59);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(92, 16);
            this.lbContraseña.TabIndex = 1;
            this.lbContraseña.Text = "CONTRASEÑA";
            // 
            // texUsuario
            // 
            this.texUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.texUsuario.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texUsuario.Location = new System.Drawing.Point(127, 29);
            this.texUsuario.Name = "texUsuario";
            this.texUsuario.Size = new System.Drawing.Size(151, 23);
            this.texUsuario.TabIndex = 2;
            // 
            // texContraseña
            // 
            this.texContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.texContraseña.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texContraseña.Location = new System.Drawing.Point(127, 58);
            this.texContraseña.Name = "texContraseña";
            this.texContraseña.Size = new System.Drawing.Size(151, 23);
            this.texContraseña.TabIndex = 3;
            // 
            // btnAceder
            // 
            this.btnAceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAceder.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAceder.Location = new System.Drawing.Point(87, 115);
            this.btnAceder.Name = "btnAceder";
            this.btnAceder.Size = new System.Drawing.Size(135, 39);
            this.btnAceder.TabIndex = 4;
            this.btnAceder.Text = "ACCEDER";
            this.btnAceder.UseVisualStyleBackColor = false;
            this.btnAceder.Click += new System.EventHandler(this.btnAceder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 188);
            this.Controls.Add(this.btnAceder);
            this.Controls.Add(this.texContraseña);
            this.Controls.Add(this.texUsuario);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.USUARIO);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox texUsuario;
        private System.Windows.Forms.TextBox texContraseña;
        private System.Windows.Forms.Button btnAceder;

    }
}