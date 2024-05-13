using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Ejer15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int maximo = int.Parse(txtMaximo.Text);

                if (maximo <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un número mayor que cero.");
                    return;
                }

                double resultado = CalcularSerie(maximo);

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número entero válido.");
            }
        }

        private double CalcularSerie(int maximo)
        {
            double serie = 0.0;

            for (int i = 1; i <= maximo; i++)
            {
                double numerador;
                double denominador;

                if (i % 2 == 0)
                {
                    numerador = Math.Pow(i + 1, i);
                    denominador = Factorial(i);
                }
                else
                {
                    numerador = Math.Pow(-1, i) * (i * (i + 1));
                    denominador = Factorial(i + 1);
                }

                serie += numerador / denominador;
            }

            return serie;
        }

        private double Factorial(int n)
        {
            double factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
