using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_EjerI4
{
    public partial class Form1 : Form
    {
        double Valora, Valorb, Valorc;
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtA_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Valora = double.Parse(TxtA.Text);

                    if (Valora < 0)
                    {
                        MessageBox.Show("Ingrese un valor positivo");
                        TxtA.Clear();
                        return;
                    }
                    TxtB.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales positivos");
                TxtA.Clear();
            }
        }


        private void TxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Valorb = double.Parse(TxtB.Text);

                    if (Valorb < 0)
                    {
                        MessageBox.Show("Ingrese un valor positivo");
                        TxtB.Clear();
                        return;
                    }
                    TxtC.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números enteros");
                TxtB.Clear();
            }
        }

        private void TxtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Valorc = double.Parse(TxtC.Text);

                    if (Valorc < 0)
                    {
                        MessageBox.Show("Ingrese un valor positivo");
                        TxtC.Clear();
                        return;
                    }
                    ClArea objarea= new ClArea(Valora, Valorb, Valorc);
                    LblRespuesta.Text= objarea.CalArea().ToString();    
                    
                     
                }

            }
            catch
            {
                MessageBox.Show("Ingrese números enteros");
                TxtC.Clear();
            }

        }


    }
}