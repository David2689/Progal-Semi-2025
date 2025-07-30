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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.lblNUm2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(99, 42);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 24);
            this.txtNum1.TabIndex = 0;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.Location = new System.Drawing.Point(12, 46);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(55, 20);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Num 1";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(99, 217);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(88, 49);
            this.btn.TabIndex = 2;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblNUm2
            // 
            this.lblNUm2.AutoSize = true;
            this.lblNUm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUm2.Location = new System.Drawing.Point(12, 112);
            this.lblNUm2.Name = "lblNUm2";
            this.lblNUm2.Size = new System.Drawing.Size(55, 20);
            this.lblNUm2.TabIndex = 4;
            this.lblNUm2.Text = "Num 2";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(99, 108);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 24);
            this.txtNum2.TabIndex = 3;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(12, 169);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(96, 20);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 295);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblNUm2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtNum1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblNUm2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblRespuesta;
    }
}

