using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
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
        private double[][] tablaImpuesto = {
            new double[] {0.01, 500, 1.5, 0},
            new double[] {500.01, 1000, 1.5, 3},
            new double[] {1000.01, 2000, 3, 3},
            new double[] {2000.01, 3000, 6, 3},
            new double[] {3000.01, 6000, 9, 2},
            new double[] {8000.01, 18000, 15, 2},
            new double[] {18000.01, 30000, 39, 2},
            new double[] {30000.01, 60000, 63, 1},
            new double[] {60000.01, 100000, 93, 0.8},
            new double[] {100000.01,200000, 125, 0.7},
            new double[] {200000.01,300000, 195, 0.6},
            new double[] {300000.01,400000, 255, 0.45},
            new double[] {400000.01,500000, 300, 0.4},
            new double[] {500000.01,1000000, 340, 0.3},
            new double[] {1000000.01,99999999, 490, 0.18}
        };

        private double calcularImpuesto(double monto)
        {
            double impuesto = 0;
            for (int i = 0; i < tablaImpuesto.Length; i++)
            {
                if (monto >= tablaImpuesto[i][0] && monto <= tablaImpuesto[i][1])
                {
                    double desde = tablaImpuesto[i][0];
                    double precioBase = tablaImpuesto[i][2];
                    double adicional = tablaImpuesto[i][3];

                    double excedente = monto - desde;
                    impuesto = precioBase + (excedente / 1000) * adicional;
                    break;
                }
            }
            return impuesto;
        }

        private void btnCalcularImpuestos_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMonto.Text, out double monto))
            {
                MessageBox.Show("Ingrese un monto válido.");
                txtMonto.Focus();
                return;
            }

            double impuesto = calcularImpuesto(monto);

            lblResultado.Text = "Impuesto: " + impuesto.ToString("C2");
        }
    }
}
