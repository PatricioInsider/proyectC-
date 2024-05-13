using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadena_Suma_Nùmeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string entrada = txtEntrada.Text;
            int suma = CalcularSumaNumeros(entrada);
            LblRespuesta.Text = $"{suma}";
        }

        private int CalcularSumaNumeros(string entrada)
        {
            // Expresión regular para encontrar números (positivos o negativos) en la cadena
            Regex regex = new Regex(@"-?\d+");
            // Obtener todas las coincidencias de números en la cadena
            MatchCollection matches = regex.Matches(entrada);

            int suma = 0;
            // Iterar sobre cada coincidencia y sumar los números
            foreach (Match match in matches)
            {
                suma += int.Parse(match.Value);
            }

            return suma;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = "";
            LblRespuesta.Text = "___________________";
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCalcular.Focus();
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
