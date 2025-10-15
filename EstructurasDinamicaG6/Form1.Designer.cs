namespace EstructurasDinamicaG6
{
    partial class FrmPilaAG
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.lblEdades = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edad:";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(70, 7);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 26);
            this.tbEdad.TabIndex = 1;
            this.tbEdad.TextChanged += new System.EventHandler(this.tbEdad_TextChanged);
            // 
            // lblEdades
            // 
            this.lblEdades.Location = new System.Drawing.Point(12, 49);
            this.lblEdades.Name = "lblEdades";
            this.lblEdades.Size = new System.Drawing.Size(266, 35);
            this.lblEdades.TabIndex = 2;
            this.lblEdades.Text = "Edades";
            this.lblEdades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPilaAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 374);
            this.Controls.Add(this.lblEdades);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPilaAG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label lblEdades;
    }
}

