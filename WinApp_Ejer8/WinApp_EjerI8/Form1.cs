using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_EjerI8
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
        double a1, b1;
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

                    Cl_Pt objCr = new Cl_Pt(a1, b1);
                    LblRespuesta.Text = objCr.CalCd().ToString();

                    Lbldis.Text = objCr.Caldis().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtYA.Clear();
            }
        }
    }
    
}
