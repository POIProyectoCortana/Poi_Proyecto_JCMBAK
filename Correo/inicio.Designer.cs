namespace Correo
{
    partial class forminiciarsesion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.btniniciarsesion = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btniniciarsesion
            // 
            this.btniniciarsesion.Location = new System.Drawing.Point(47, 120);
            this.btniniciarsesion.Name = "btniniciarsesion";
            this.btniniciarsesion.Size = new System.Drawing.Size(152, 32);
            this.btniniciarsesion.TabIndex = 0;
            this.btniniciarsesion.Text = "Iniciar Sesion";
            this.btniniciarsesion.UseVisualStyleBackColor = true;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(6, 34);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(57, 17);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcontrasena);
            this.groupBox1.Controls.Add(this.lblcontrasena);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.btniniciarsesion);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar Sesion";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(108, 34);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(91, 22);
            this.txtusuario.TabIndex = 2;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(6, 78);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(81, 17);
            this.lblcontrasena.TabIndex = 3;
            this.lblcontrasena.Text = "Contraseña";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(108, 73);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(91, 22);
            this.txtcontrasena.TabIndex = 4;
            // 
            // forminiciarsesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 243);
            this.Controls.Add(this.groupBox1);
            this.Name = "forminiciarsesion";
            this.Text = "Iniciar Sesion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btniniciarsesion;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.TextBox txtusuario;
    }
}

