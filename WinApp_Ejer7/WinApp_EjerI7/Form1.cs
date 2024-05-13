using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_EjerI7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double a1, b1, a2, b2,r1,r2;
        private void TxtXA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    a1 = double.Parse(TxtXA.Text);

                    TxtYA.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtXA.Clear();
            }
        }

        private void TxtYA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    b1 = double.Parse(TxtYA.Text);

                    TxtR1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtYA.Clear();
            }
        }

        private void TxtR1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    r1 = double.Parse(TxtR1.Text);

                    TxtXB.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtR1.Clear();
            }
        }

        private void TxtXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    a2 = double.Parse(TxtXB.Text);

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

                    TxtR2.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtYB.Clear();
            }
        }

        private void TxtR2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    r2 = double.Parse(TxtR2.Text);

                    ClCir objCr = new ClCir(a1, b1, a2, b2,r1,r2);
                    LblRespuesta.Text = objCr.CalCr().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtR2.Clear();
            }
        }

    }
}
