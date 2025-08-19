using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            respuesta = num1 + num2;
            lblRespuesta.Text = "Respuesta: " + respuesta;

        }

        private void Calcular2_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    break;
                case 3:
                    respuesta = num1 / num2;
                    break;
            }
            lblRespuesta.Text = "Respuesta =" + respuesta;
        }

        private void cboOpciones_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }