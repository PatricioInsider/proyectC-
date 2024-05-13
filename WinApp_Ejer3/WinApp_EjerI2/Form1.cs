using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_EjerI2
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

        /*private void BtnCalcular_Click(object sender, EventArgs e)
        {
            float XA = float.Parse(TxtXA.Text);
            float YA = float.Parse(TxtYA.Text);
            float XB = float.Parse(TxtXB.Text);
            float YB = float.Parse(TxtYB.Text);

            ClPend objdis = new ClPend(XA, YA, XB, YB);
            LblRespuesta.Text = objdis.CalPend().ToString();

        }*/

        double a1, b1, a2, b2;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtYA_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    b1 = double.Parse(TxtYA.Text);

                    TxtXB.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtYA.Clear();
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

                    ClPend objdis = new ClPend(a1, b1, a2, b2);
                    LblRespuesta.Text = objdis.CalPend().ToString();
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
