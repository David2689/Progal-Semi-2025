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
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Location = new System.Drawing.Point(28, 24);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(41, 18);
            this.lblTipoConversor.TabIndex = 0;
            this.lblTipoConversor.Text = "Tipo";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Monedas",
            "Longitud",
            "Masa",
            "Volumen",
            "Almacenamiento",
            "Tiempo"});
            this.cboTipoConversor.Location = new System.Drawing.Point(75, 24);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(147, 26);
            this.cboTipoConversor.TabIndex = 1;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(320, 114);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(167, 105);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(75, 82);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(147, 26);
            this.cboDeConversor.TabIndex = 4;
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Location = new System.Drawing.Point(28, 82);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(29, 18);
            this.lblDeConversor.TabIndex = 3;
            this.lblDeConversor.Text = "De";
            // 
            // cboAConversor
            // 
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Location = new System.Drawing.Point(75, 134);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(147, 26);
            this.cboAConversor.TabIndex = 6;
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Location = new System.Drawing.Point(39, 134);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(18, 18);
            this.lblAConversor.TabIndex = 5;
            this.lblAConversor.Text = "A";
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Location = new System.Drawing.Point(12, 175);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(74, 18);
            this.lblCantidadConversor.TabIndex = 7;
            this.lblCantidadConversor.Text = "Cantidad";
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(98, 195);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(156, 24);
            this.txtCantidadConversor.TabIndex = 8;
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Location = new System.Drawing.Point(12, 238);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(88, 18);
            this.lblRespuestaConversor.TabIndex = 9;
            this.lblRespuestaConversor.Text = "Respuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 346);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
    }
}

