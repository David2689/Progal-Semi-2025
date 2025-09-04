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
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblSeleccionelaunidaddedestino = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneunidad = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblIngreseValor = new System.Windows.Forms.Label();
            this.lblConversordearea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea ",
            ""});
            this.cmbDestino.Location = new System.Drawing.Point(248, 182);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(155, 26);
            this.cmbDestino.TabIndex = 18;
            // 
            // lblSeleccionelaunidaddedestino
            // 
            this.lblSeleccionelaunidaddedestino.AutoSize = true;
            this.lblSeleccionelaunidaddedestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionelaunidaddedestino.Location = new System.Drawing.Point(12, 192);
            this.lblSeleccionelaunidaddedestino.Name = "lblSeleccionelaunidaddedestino";
            this.lblSeleccionelaunidaddedestino.Size = new System.Drawing.Size(230, 16);
            this.lblSeleccionelaunidaddedestino.TabIndex = 17;
            this.lblSeleccionelaunidaddedestino.Text = "Seleccione la unidad de destino";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 234);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 16);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "Relsutado";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(171, 234);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(178, 87);
            this.btnConvertir.TabIndex = 15;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea ",
            ""});
            this.cmbOrigen.Location = new System.Drawing.Point(171, 136);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(155, 26);
            this.cmbOrigen.TabIndex = 14;
            // 
            // lblSeleccioneunidad
            // 
            this.lblSeleccioneunidad.AutoSize = true;
            this.lblSeleccioneunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneunidad.Location = new System.Drawing.Point(12, 136);
            this.lblSeleccioneunidad.Name = "lblSeleccioneunidad";
            this.lblSeleccioneunidad.Size = new System.Drawing.Size(153, 16);
            this.lblSeleccioneunidad.TabIndex = 13;
            this.lblSeleccioneunidad.Text = "Seleccione la unidad";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(132, 85);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(158, 24);
            this.txtValor.TabIndex = 12;
            // 
            // lblIngreseValor
            // 
            this.lblIngreseValor.AutoSize = true;
            this.lblIngreseValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseValor.Location = new System.Drawing.Point(12, 91);
            this.lblIngreseValor.Name = "lblIngreseValor";
            this.lblIngreseValor.Size = new System.Drawing.Size(107, 18);
            this.lblIngreseValor.TabIndex = 11;
            this.lblIngreseValor.Text = "Ingrese Valor";
            // 
            // lblConversordearea
            // 
            this.lblConversordearea.AutoSize = true;
            this.lblConversordearea.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversordearea.Location = new System.Drawing.Point(126, 30);
            this.lblConversordearea.Name = "lblConversordearea";
            this.lblConversordearea.Size = new System.Drawing.Size(270, 31);
            this.lblConversordearea.TabIndex = 10;
            this.lblConversordearea.Text = "Conversor de areas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 346);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.lblSeleccionelaunidaddedestino);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.lblSeleccioneunidad);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblIngreseValor);
            this.Controls.Add(this.lblConversordearea);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblSeleccionelaunidaddedestino;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblSeleccioneunidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblIngreseValor;
        private System.Windows.Forms.Label lblConversordearea;
    }
}

