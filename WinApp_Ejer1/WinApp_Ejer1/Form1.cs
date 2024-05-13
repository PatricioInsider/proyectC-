using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Ejer1
{
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    n = int.Parse(TxtNum.Text);

                    ClCifras objdis = new ClCifras(n);
                    LblRespuesta.Text = objdis.Numcifas().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtNum.Clear();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
