namespace Correo
{
    partial class enviarcorreo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpara = new System.Windows.Forms.Label();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.lblasunto = new System.Windows.Forms.Label();
            this.txtasunto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btadjuntar = new System.Windows.Forms.Button();
            this.btenviar = new System.Windows.Forms.Button();
            this.rtbmensaje = new System.Windows.Forms.RichTextBox();
            this.lblarchivos = new System.Windows.Forms.Label();
            this.txtarchivos = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtarchivos);
            this.groupBox1.Controls.Add(this.lblarchivos);
            this.groupBox1.Controls.Add(this.btadjuntar);
            this.groupBox1.Controls.Add(this.txtasunto);
            this.groupBox1.Controls.Add(this.lblasunto);
            this.groupBox1.Controls.Add(this.txtpara);
            this.groupBox1.Controls.Add(this.lblpara);
            this.groupBox1.Location = new System.Drawing.Point(18, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lblpara
            // 
            this.lblpara.AutoSize = true;
            this.lblpara.Location = new System.Drawing.Point(11, 21);
            this.lblpara.Name = "lblpara";
            this.lblpara.Size = new System.Drawing.Size(42, 17);
            this.lblpara.TabIndex = 0;
            this.lblpara.Text = "Para;";
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(78, 21);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(402, 22);
            this.txtpara.TabIndex = 1;
            // 
            // lblasunto
            // 
            this.lblasunto.AutoSize = true;
            this.lblasunto.Location = new System.Drawing.Point(11, 55);
            this.lblasunto.Name = "lblasunto";
            this.lblasunto.Size = new System.Drawing.Size(56, 17);
            this.lblasunto.TabIndex = 2;
            this.lblasunto.Text = "Asunto:";
            // 
            // txtasunto
            // 
            this.txtasunto.Location = new System.Drawing.Point(78, 55);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(402, 22);
            this.txtasunto.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbmensaje);
            this.groupBox2.Location = new System.Drawing.Point(20, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensaje";
            // 
            // btadjuntar
            // 
            this.btadjuntar.Location = new System.Drawing.Point(345, 91);
            this.btadjuntar.Name = "btadjuntar";
            this.btadjuntar.Size = new System.Drawing.Size(80, 24);
            this.btadjuntar.TabIndex = 4;
            this.btadjuntar.Text = "Adjuntar";
            this.btadjuntar.UseVisualStyleBackColor = true;
            // 
            // btenviar
            // 
            this.btenviar.Location = new System.Drawing.Point(257, 456);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(84, 30);
            this.btenviar.TabIndex = 2;
            this.btenviar.Text = "Enviar";
            this.btenviar.UseVisualStyleBackColor = true;
            // 
            // rtbmensaje
            // 
            this.rtbmensaje.Location = new System.Drawing.Point(12, 31);
            this.rtbmensaje.Name = "rtbmensaje";
            this.rtbmensaje.Size = new System.Drawing.Size(584, 250);
            this.rtbmensaje.TabIndex = 0;
            this.rtbmensaje.Text = "";
            // 
            // lblarchivos
            // 
            this.lblarchivos.AutoSize = true;
            this.lblarchivos.Location = new System.Drawing.Point(11, 97);
            this.lblarchivos.Name = "lblarchivos";
            this.lblarchivos.Size = new System.Drawing.Size(62, 17);
            this.lblarchivos.TabIndex = 6;
            this.lblarchivos.Text = "Archivos";
            // 
            // txtarchivos
            // 
            this.txtarchivos.Location = new System.Drawing.Point(78, 92);
            this.txtarchivos.Name = "txtarchivos";
            this.txtarchivos.Size = new System.Drawing.Size(245, 22);
            this.txtarchivos.TabIndex = 7;
            // 
            // enviarcorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 498);
            this.Controls.Add(this.btenviar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "enviarcorreo";
            this.Text = "enviarcorreo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtarchivos;
        private System.Windows.Forms.Label lblarchivos;
        private System.Windows.Forms.Button btadjuntar;
        private System.Windows.Forms.TextBox txtasunto;
        private System.Windows.Forms.Label lblasunto;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.Label lblpara;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbmensaje;
        private System.Windows.Forms.Button btenviar;
    }
}