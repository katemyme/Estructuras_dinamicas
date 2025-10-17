namespace EstructurasDinamicaG6
{
    partial class FrmPilaVA
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblEdades = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lblOrdenada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "edad";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(147, 22);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 22);
            this.tbEdad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(297, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblEdades
            // 
            this.lblEdades.AutoSize = true;
            this.lblEdades.Location = new System.Drawing.Point(37, 77);
            this.lblEdades.Name = "lblEdades";
            this.lblEdades.Size = new System.Drawing.Size(54, 16);
            this.lblEdades.TabIndex = 3;
            this.lblEdades.Text = "edades";
            this.lblEdades.Click += new System.EventHandler(this.lblEdades_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(297, 62);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(297, 114);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(211, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar ultima";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(297, 156);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(261, 23);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar de mayor y menor";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lblOrdenada
            // 
            this.lblOrdenada.AutoSize = true;
            this.lblOrdenada.Location = new System.Drawing.Point(37, 120);
            this.lblOrdenada.Name = "lblOrdenada";
            this.lblOrdenada.Size = new System.Drawing.Size(66, 16);
            this.lblOrdenada.TabIndex = 7;
            this.lblOrdenada.Text = "ordenada";
            // 
            // FrmPilaVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.lblOrdenada);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.lblEdades);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.label1);
            this.Name = "FrmPilaVA";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPilaVA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEdades;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblOrdenada;
    }
}

