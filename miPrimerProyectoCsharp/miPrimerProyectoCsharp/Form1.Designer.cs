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
            this.cboOpciones = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OptSuma = new System.Windows.Forms.RadioButton();
            this.OptResta = new System.Windows.Forms.RadioButton();
            this.OptMultiplicacion = new System.Windows.Forms.RadioButton();
            this.OptDivision = new System.Windows.Forms.RadioButton();
            this.OptExponente = new System.Windows.Forms.RadioButton();
            this.Calcular2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboOpciones.SuspendLayout();
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
            // cboOpciones
            // 
            this.cboOpciones.Controls.Add(this.OptExponente);
            this.cboOpciones.Controls.Add(this.OptDivision);
            this.cboOpciones.Controls.Add(this.OptMultiplicacion);
            this.cboOpciones.Controls.Add(this.OptResta);
            this.cboOpciones.Controls.Add(this.OptSuma);
            this.cboOpciones.Location = new System.Drawing.Point(234, 32);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(154, 253);
            this.cboOpciones.TabIndex = 6;
            this.cboOpciones.TabStop = false;
            this.cboOpciones.Text = "Opciones";
            this.cboOpciones.Enter += new System.EventHandler(this.cboOpciones_Enter);
            // 
            // OptSuma
            // 
            this.OptSuma.AutoSize = true;
            this.OptSuma.Location = new System.Drawing.Point(6, 23);
            this.OptSuma.Name = "OptSuma";
            this.OptSuma.Size = new System.Drawing.Size(69, 22);
            this.OptSuma.TabIndex = 0;
            this.OptSuma.TabStop = true;
            this.OptSuma.Text = "Suma";
            this.OptSuma.UseVisualStyleBackColor = true;
            // 
            // OptResta
            // 
            this.OptResta.AutoSize = true;
            this.OptResta.Location = new System.Drawing.Point(6, 51);
            this.OptResta.Name = "OptResta";
            this.OptResta.Size = new System.Drawing.Size(70, 22);
            this.OptResta.TabIndex = 1;
            this.OptResta.TabStop = true;
            this.OptResta.Text = "Resta";
            this.OptResta.UseVisualStyleBackColor = true;
            // 
            // OptMultiplicacion
            // 
            this.OptMultiplicacion.AutoSize = true;
            this.OptMultiplicacion.Location = new System.Drawing.Point(6, 80);
            this.OptMultiplicacion.Name = "OptMultiplicacion";
            this.OptMultiplicacion.Size = new System.Drawing.Size(129, 22);
            this.OptMultiplicacion.TabIndex = 2;
            this.OptMultiplicacion.TabStop = true;
            this.OptMultiplicacion.Text = "Multiplicacion";
            this.OptMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // OptDivision
            // 
            this.OptDivision.AutoSize = true;
            this.OptDivision.Location = new System.Drawing.Point(6, 108);
            this.OptDivision.Name = "OptDivision";
            this.OptDivision.Size = new System.Drawing.Size(86, 22);
            this.OptDivision.TabIndex = 3;
            this.OptDivision.TabStop = true;
            this.OptDivision.Text = "Division";
            this.OptDivision.UseVisualStyleBackColor = true;
            // 
            // OptExponente
            // 
            this.OptExponente.AutoSize = true;
            this.OptExponente.Location = new System.Drawing.Point(6, 137);
            this.OptExponente.Name = "OptExponente";
            this.OptExponente.Size = new System.Drawing.Size(105, 22);
            this.OptExponente.TabIndex = 4;
            this.OptExponente.TabStop = true;
            this.OptExponente.Text = "Exponente";
            this.OptExponente.UseVisualStyleBackColor = true;
            // 
            // Calcular2
            // 
            this.Calcular2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular2.Location = new System.Drawing.Point(398, 169);
            this.Calcular2.Name = "Calcular2";
            this.Calcular2.Size = new System.Drawing.Size(86, 59);
            this.Calcular2.TabIndex = 7;
            this.Calcular2.Text = "Calcular2";
            this.Calcular2.UseVisualStyleBackColor = true;
            this.Calcular2.Click += new System.EventHandler(this.Calcular2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Divicion"});
            this.comboBox1.Location = new System.Drawing.Point(398, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 297);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Calcular2);
            this.Controls.Add(this.cboOpciones);
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
            this.cboOpciones.ResumeLayout(false);
            this.cboOpciones.PerformLayout();
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
        private System.Windows.Forms.GroupBox cboOpciones;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton OptExponente;
        private System.Windows.Forms.RadioButton OptDivision;
        private System.Windows.Forms.RadioButton OptMultiplicacion;
        private System.Windows.Forms.RadioButton OptResta;
        private System.Windows.Forms.RadioButton OptSuma;
        private System.Windows.Forms.Button Calcular2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

