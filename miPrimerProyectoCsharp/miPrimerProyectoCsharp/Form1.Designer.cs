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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrbOpciones = new System.Windows.Forms.GroupBox();
            this.OptSuma = new System.Windows.Forms.RadioButton();
            this.OptResta = new System.Windows.Forms.RadioButton();
            this.OptDivision = new System.Windows.Forms.RadioButton();
            this.OptMultiplicacion = new System.Windows.Forms.RadioButton();
            this.OptExponenciacion = new System.Windows.Forms.RadioButton();
            this.CboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCalcularOpciones = new System.Windows.Forms.Button();
            this.OptPrimo = new System.Windows.Forms.RadioButton();
            this.OptFactorial = new System.Windows.Forms.RadioButton();
            this.OptPorcentaje = new System.Windows.Forms.RadioButton();
            this.GrbOpciones.SuspendLayout();
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
            // GrbOpciones
            // 
            this.GrbOpciones.Controls.Add(this.OptPorcentaje);
            this.GrbOpciones.Controls.Add(this.OptFactorial);
            this.GrbOpciones.Controls.Add(this.OptPrimo);
            this.GrbOpciones.Controls.Add(this.OptExponenciacion);
            this.GrbOpciones.Controls.Add(this.OptMultiplicacion);
            this.GrbOpciones.Controls.Add(this.OptDivision);
            this.GrbOpciones.Controls.Add(this.OptResta);
            this.GrbOpciones.Controls.Add(this.OptSuma);
            this.GrbOpciones.Location = new System.Drawing.Point(229, 42);
            this.GrbOpciones.Name = "GrbOpciones";
            this.GrbOpciones.Size = new System.Drawing.Size(213, 293);
            this.GrbOpciones.TabIndex = 6;
            this.GrbOpciones.TabStop = false;
            this.GrbOpciones.Text = "Opcioens";
            // 
            // OptSuma
            // 
            this.OptSuma.AutoSize = true;
            this.OptSuma.Location = new System.Drawing.Point(6, 34);
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
            this.OptResta.Location = new System.Drawing.Point(6, 66);
            this.OptResta.Name = "OptResta";
            this.OptResta.Size = new System.Drawing.Size(70, 22);
            this.OptResta.TabIndex = 1;
            this.OptResta.TabStop = true;
            this.OptResta.Text = "Resta";
            this.OptResta.UseVisualStyleBackColor = true;
            // 
            // OptDivision
            // 
            this.OptDivision.AutoSize = true;
            this.OptDivision.Location = new System.Drawing.Point(6, 94);
            this.OptDivision.Name = "OptDivision";
            this.OptDivision.Size = new System.Drawing.Size(96, 22);
            this.OptDivision.TabIndex = 2;
            this.OptDivision.TabStop = true;
            this.OptDivision.Text = "Division  ";
            this.OptDivision.UseVisualStyleBackColor = true;
            // 
            // OptMultiplicacion
            // 
            this.OptMultiplicacion.AutoSize = true;
            this.OptMultiplicacion.Location = new System.Drawing.Point(6, 125);
            this.OptMultiplicacion.Name = "OptMultiplicacion";
            this.OptMultiplicacion.Size = new System.Drawing.Size(129, 22);
            this.OptMultiplicacion.TabIndex = 3;
            this.OptMultiplicacion.TabStop = true;
            this.OptMultiplicacion.Text = "Multiplicacion";
            this.OptMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // OptExponenciacion
            // 
            this.OptExponenciacion.AutoSize = true;
            this.OptExponenciacion.Location = new System.Drawing.Point(6, 153);
            this.OptExponenciacion.Name = "OptExponenciacion";
            this.OptExponenciacion.Size = new System.Drawing.Size(105, 22);
            this.OptExponenciacion.TabIndex = 4;
            this.OptExponenciacion.TabStop = true;
            this.OptExponenciacion.Text = "Exponente";
            this.OptExponenciacion.UseVisualStyleBackColor = true;
            // 
            // CboOpciones
            // 
            this.CboOpciones.FormattingEnabled = true;
            this.CboOpciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.CboOpciones.Location = new System.Drawing.Point(459, 46);
            this.CboOpciones.Name = "CboOpciones";
            this.CboOpciones.Size = new System.Drawing.Size(121, 26);
            this.CboOpciones.TabIndex = 7;
            // 
            // btnCalcularOpciones
            // 
            this.btnCalcularOpciones.Location = new System.Drawing.Point(459, 169);
            this.btnCalcularOpciones.Name = "btnCalcularOpciones";
            this.btnCalcularOpciones.Size = new System.Drawing.Size(102, 52);
            this.btnCalcularOpciones.TabIndex = 8;
            this.btnCalcularOpciones.Text = "Calcular2";
            this.btnCalcularOpciones.UseVisualStyleBackColor = true;
            
            // 
            // OptPrimo
            // 
            this.OptPrimo.AutoSize = true;
            this.OptPrimo.Location = new System.Drawing.Point(6, 181);
            this.OptPrimo.Name = "OptPrimo";
            this.OptPrimo.Size = new System.Drawing.Size(71, 22);
            this.OptPrimo.TabIndex = 5;
            this.OptPrimo.TabStop = true;
            this.OptPrimo.Text = "Primo";
            this.OptPrimo.UseVisualStyleBackColor = true;
            // 
            // OptFactorial
            // 
            this.OptFactorial.AutoSize = true;
            this.OptFactorial.Location = new System.Drawing.Point(5, 209);
            this.OptFactorial.Name = "OptFactorial";
            this.OptFactorial.Size = new System.Drawing.Size(92, 22);
            this.OptFactorial.TabIndex = 6;
            this.OptFactorial.TabStop = true;
            this.OptFactorial.Text = "Factorial";
            this.OptFactorial.UseVisualStyleBackColor = true;
            // 
            // OptPorcentaje
            // 
            this.OptPorcentaje.AutoSize = true;
            this.OptPorcentaje.Location = new System.Drawing.Point(6, 237);
            this.OptPorcentaje.Name = "OptPorcentaje";
            this.OptPorcentaje.Size = new System.Drawing.Size(107, 22);
            this.OptPorcentaje.TabIndex = 7;
            this.OptPorcentaje.TabStop = true;
            this.OptPorcentaje.Text = "Porcentaje";
            this.OptPorcentaje.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 347);
            this.Controls.Add(this.btnCalcularOpciones);
            this.Controls.Add(this.CboOpciones);
            this.Controls.Add(this.GrbOpciones);
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
            this.GrbOpciones.ResumeLayout(false);
            this.GrbOpciones.PerformLayout();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GrbOpciones;
        private System.Windows.Forms.RadioButton OptExponenciacion;
        private System.Windows.Forms.RadioButton OptMultiplicacion;
        private System.Windows.Forms.RadioButton OptDivision;
        private System.Windows.Forms.RadioButton OptResta;
        private System.Windows.Forms.RadioButton OptSuma;
        private System.Windows.Forms.ComboBox CboOpciones;
        private System.Windows.Forms.Button btnCalcularOpciones;
        private System.Windows.Forms.RadioButton OptFactorial;
        private System.Windows.Forms.RadioButton OptPrimo;
        private System.Windows.Forms.RadioButton OptPorcentaje;
    }
}

