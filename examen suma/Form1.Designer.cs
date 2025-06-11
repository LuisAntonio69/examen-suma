namespace examen_suma
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
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(345, 50);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(138, 24);
            this.cbGenero.TabIndex = 0;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(37, 50);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(100, 22);
            this.txtnombres.TabIndex = 1;
            this.txtnombres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(185, 50);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 22);
            this.txtedad.TabIndex = 2;
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(547, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 25);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 16;
            this.lstDatos.Location = new System.Drawing.Point(557, 113);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(225, 228);
            this.lstDatos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.cbGenero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstDatos;
    }
}

