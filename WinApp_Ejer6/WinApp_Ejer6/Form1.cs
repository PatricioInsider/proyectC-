using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinApp_Ejer6
{
    public partial class Form1 : Form
    {
        int Valora, Valorb, Valorc;
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxtA_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Valora = int.Parse(TxtA.Text);

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
                MessageBox.Show("Ingrese números reales enteros");
                TxtA.Clear();
            }
        }
        private void TxtB_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Valorb = int.Parse(TxtB.Text);

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


        private void TxtC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Valorc = int.Parse(TxtC.Text);

                    if (Valorc < 0)
                    {
                        MessageBox.Show("Ingrese un valor positivo");
                        TxtC.Clear();
                        return;
                    }

                    ClTriang objT = new ClTriang(Valora, Valorb, Valorc);
                    LblRes.Text = objT.CalTr().ToString();

                    if (LblRes.Text == "SI")
                    {
                        // Llamar al método correspondiente según el valor de LblRespuesta
                        ClTriang objTrg = new ClTriang(Valora, Valorb, Valorc);
                        LblRespuesta.Text = objTrg.CalTp().ToString();
                         
                    }
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
