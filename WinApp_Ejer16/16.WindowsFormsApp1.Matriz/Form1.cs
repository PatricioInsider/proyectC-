using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _16.WindowsFormsApp1.Matriz
{
    public partial class Form1 : Form
    {
        int f, c, i = 0, j = 0;
        int[,] matriz;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtFilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    f = int.Parse(txtFilas.Text);
                    txtColumnas.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un número válido para las filas.");
                txtFilas.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtColumnas_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    c = int.Parse(txtColumnas.Text);
                    matriz = new int[f, c];
                    txtElemento.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un número válido para las columnas.");
                txtColumnas.Clear();
            }
        }

        private void txtElemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtColumnas.Enabled = false;
            txtFilas.Enabled = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (matriz != null && i < f && j < c)
                {
                    matriz[i, j] = int.Parse(txtElemento.Text);
                    listBox1.Items.Add(matriz[i, j]);

                    txtElemento.Clear();
                    txtElemento.Focus();
                    j++;
                    if (j == c)
                    {
                        i++;
                        j = 0;
                    }
                    if (i == f)
                    {
                        txtElemento.Enabled = false;
                        MessageBox.Show("Matriz llena");
                    }
                }
                else
                {
                    MessageBox.Show("La matriz no ha sido inicializada correctamente o ya se han ingresado todos los elementos.");
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CLMatrizOperaciones objMatrizOperaciones = new CLMatrizOperaciones(matriz);

            lblElementosPositivos.Text = objMatrizOperaciones.elementosPositivos().ToString();
            lblElementosNegativos.Text = objMatrizOperaciones.elementosNegativos().ToString();
            lblSumaTotal.Text = objMatrizOperaciones.sumaTotal().ToString();
            lblSumaColumnasPares.Text = objMatrizOperaciones.sumaColumnasPares().ToString();
            lblMultiplicacionNegativos.Text = objMatrizOperaciones.multiplicacionNegativos().ToString();
        }
    }
}
