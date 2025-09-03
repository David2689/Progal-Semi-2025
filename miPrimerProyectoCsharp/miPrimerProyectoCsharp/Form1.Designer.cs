namespace miPrimerProyectoCsharp
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCalcularImpuestos = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblIngreseelmonto = new System.Windows.Forms.Label();
            this.lblImpuestosaactividadeseconomica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularImpuestos
            // 
            this.btnCalcularImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImpuestos.Location = new System.Drawing.Point(173, 154);
            this.btnCalcularImpuestos.Name = "btnCalcularImpuestos";
            this.btnCalcularImpuestos.Size = new System.Drawing.Size(185, 77);
            this.btnCalcularImpuestos.TabIndex = 9;
            this.btnCalcularImpuestos.Text = "Calcular Impuesto";
            this.btnCalcularImpuestos.UseVisualStyleBackColor = true;
            this.btnCalcularImpuestos.Click += new System.EventHandler(this.btnCalcularImpuestos_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(173, 90);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(142, 24);
            this.txtMonto.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(13, 143);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(96, 20);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblIngreseelmonto
            // 
            this.lblIngreseelmonto.AutoSize = true;
            this.lblIngreseelmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseelmonto.Location = new System.Drawing.Point(13, 90);
            this.lblIngreseelmonto.Name = "lblIngreseelmonto";
            this.lblIngreseelmonto.Size = new System.Drawing.Size(154, 20);
            this.lblIngreseelmonto.TabIndex = 6;
            this.lblIngreseelmonto.Text = "Ingrese el monto: ";
            // 
            // lblImpuestosaactividadeseconomica
            // 
            this.lblImpuestosaactividadeseconomica.AutoSize = true;
            this.lblImpuestosaactividadeseconomica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestosaactividadeseconomica.Location = new System.Drawing.Point(12, 25);
            this.lblImpuestosaactividadeseconomica.Name = "lblImpuestosaactividadeseconomica";
            this.lblImpuestosaactividadeseconomica.Size = new System.Drawing.Size(516, 25);
            this.lblImpuestosaactividadeseconomica.TabIndex = 5;
            this.lblImpuestosaactividadeseconomica.Text = "IMPUESTO A LAS ACTIVIDADES ECONOMICAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 346);
            this.Controls.Add(this.btnCalcularImpuestos);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblIngreseelmonto);
            this.Controls.Add(this.lblImpuestosaactividadeseconomica);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCalcularImpuestos;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblIngreseelmonto;
        private System.Windows.Forms.Label lblImpuestosaactividadeseconomica;
    }
}

