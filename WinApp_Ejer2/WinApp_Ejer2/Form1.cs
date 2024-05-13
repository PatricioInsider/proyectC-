using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a1, b1, a2, b2;

        private void TxtXB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtYB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    double a2 = double.Parse(TxtXB.Text);

                    TxtYB.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtXB.Clear();
            }
        }

        private void TxtYB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    b2 = double.Parse(TxtYB.Text);

                    ClDistancia objdis = new ClDistancia(a1, b1, a2, b2);
                    LblRespuesta.Text = objdis.CalDis().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtYB.Clear();
            }
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtXA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    double a2 = double.Parse(TxtXB.Text);

                    TxtYB.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtXB.Clear();
            }
        }

        private void TxtYA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    b2 = double.Parse(TxtYB.Text);

                    ClDistancia objdis = new ClDistancia(a1, b1, a2, b2);
                    LblRespuesta.Text = objdis.CalDis().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtYB.Clear();
            }
        }








    }
}
