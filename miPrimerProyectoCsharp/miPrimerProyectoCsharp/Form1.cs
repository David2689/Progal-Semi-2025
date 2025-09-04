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
            CargarUnidades();
        }
        private readonly string[] unidades = {
            "Pie cuadrado",
            "Vara cuadrada",
            "Yarda cuadrada",
            "Metro cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea"
        };

        private readonly double[] factores = {
            0.092903, // Pie cuadrado
            0.698737, // Vara cuadrada
            0.836127, // Yarda cuadrada
            1,        // Metro cuadrado
            437.5,    // Tareas
            6987,     // Manzana
            10000     // Hectárea
        };
        private void CargarUnidades()
        {
            cmbOrigen.Items.Clear();
            cmbDestino.Items.Clear();
            cmbOrigen.Items.AddRange(unidades);
            cmbDestino.Items.AddRange(unidades);

            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbOrigen.SelectedIndex = 3;  // Metro cuadrado
            cmbDestino.SelectedIndex = 0; // Pie cuadrado
        }
        private double Convertir(double valor, int origen, int destino)
        {
            double valorEnMetros = valor * factores[origen]; // ✅ usa la matriz
            return valorEnMetros / factores[destino];
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtValor.Text, out double valor))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                txtValor.Focus();
                return;
            }

            if (cmbOrigen.SelectedIndex < 0 || cmbDestino.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione las unidades de origen y destino.");
                return;
            }

            int iOrigen = cmbOrigen.SelectedIndex;
            int iDestino = cmbDestino.SelectedIndex;

            double res = Convertir(valor, iOrigen, iDestino);

            lblResultado.Text = $"{res:N4} {unidades[iDestino]}";
        }
    }
}
