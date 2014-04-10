namespace Correo
{
    partial class correorecibidos
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
            this.txtpara = new System.Windows.Forms.TextBox();
            this.txtde = new System.Windows.Forms.TextBox();
            this.lblpara = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbmensaje = new System.Windows.Forms.RichTextBox();
            this.btnrespuesta = new System.Windows.Forms.Button();
            this.btnbandejareg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpara);
            this.groupBox1.Controls.Add(this.txtde);
            this.groupBox1.Controls.Add(this.lblpara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(77, 70);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(254, 22);
            this.txtpara.TabIndex = 3;
            // 
            // txtde
            // 
            this.txtde.Location = new System.Drawing.Point(77, 30);
            this.txtde.Name = "txtde";
            this.txtde.Size = new System.Drawing.Size(254, 22);
            this.txtde.TabIndex = 2;
            // 
            // lblpara
            // 
            this.lblpara.AutoSize = true;
            this.lblpara.Location = new System.Drawing.Point(13, 70);
            this.lblpara.Name = "lblpara";
            this.lblpara.Size = new System.Drawing.Size(42, 17);
            this.lblpara.TabIndex = 1;
            this.lblpara.Text = "Para:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "De;";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnrespuesta);
            this.groupBox2.Controls.Add(this.rtbmensaje);
            this.groupBox2.Location = new System.Drawing.Point(21, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensaje";
            // 
            // rtbmensaje
            // 
            this.rtbmensaje.Location = new System.Drawing.Point(16, 34);
            this.rtbmensaje.Name = "rtbmensaje";
            this.rtbmensaje.Size = new System.Drawing.Size(548, 230);
            this.rtbmensaje.TabIndex = 0;
            this.rtbmensaje.Text = "";
            // 
            // btnrespuesta
            // 
            this.btnrespuesta.Location = new System.Drawing.Point(480, 269);
            this.btnrespuesta.Name = "btnrespuesta";
            this.btnrespuesta.Size = new System.Drawing.Size(93, 26);
            this.btnrespuesta.TabIndex = 4;
            this.btnrespuesta.Text = "Responder";
            this.btnrespuesta.UseVisualStyleBackColor = true;
            // 
            // btnbandejareg
            // 
            this.btnbandejareg.Location = new System.Drawing.Point(29, 5);
            this.btnbandejareg.Name = "btnbandejareg";
            this.btnbandejareg.Size = new System.Drawing.Size(99, 24);
            this.btnbandejareg.TabIndex = 2;
            this.btnbandejareg.Text = "Bandeja";
            this.btnbandejareg.UseVisualStyleBackColor = true;
            // 
            // correorecibidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 493);
            this.Controls.Add(this.btnbandejareg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "correorecibidos";
            this.Text = "correorecibidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.TextBox txtde;
        private System.Windows.Forms.Label lblpara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbmensaje;
        private System.Windows.Forms.Button btnrespuesta;
        private System.Windows.Forms.Button btnbandejareg;
    }
}