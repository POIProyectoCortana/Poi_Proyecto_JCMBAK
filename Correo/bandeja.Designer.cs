namespace Correo
{
    partial class Bandejaentrada
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbcorreos = new System.Windows.Forms.ListBox();
            this.lbentrada = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbentrada);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbcorreos);
            this.groupBox2.Location = new System.Drawing.Point(194, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 413);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Correos";
            // 
            // lbcorreos
            // 
            this.lbcorreos.FormattingEnabled = true;
            this.lbcorreos.ItemHeight = 16;
            this.lbcorreos.Location = new System.Drawing.Point(44, 51);
            this.lbcorreos.Name = "lbcorreos";
            this.lbcorreos.Size = new System.Drawing.Size(512, 340);
            this.lbcorreos.TabIndex = 0;
            // 
            // lbentrada
            // 
            this.lbentrada.FormattingEnabled = true;
            this.lbentrada.ItemHeight = 16;
            this.lbentrada.Location = new System.Drawing.Point(6, 60);
            this.lbentrada.Name = "lbentrada";
            this.lbentrada.Size = new System.Drawing.Size(129, 324);
            this.lbentrada.TabIndex = 0;
            // 
            // Bandejaentrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bandejaentrada";
            this.Text = "Bandeja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbentrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbcorreos;
    }
}