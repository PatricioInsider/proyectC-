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

namespace WinApp_EjerI12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dv, dr;

 

        private void TxtDv_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                   dv = int.Parse(TxtDv.Text);
                    if (dv>0)
                    {
                        TxtDsr.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese nùmeros validos ");
                        TxtDv.Clear();
                    }
                    

                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtDv.Clear();
            }
        }


        private void TxtDsr_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                dr = int.Parse(TxtDsr.Text);
               
                if (e.KeyChar == (char)Keys.Enter)
                {
                    
                    if (dr > dv)
                    {
                        MessageBox.Show("El dividendo debe ser mayor");
                        TxtDsr.Clear();

                    }
                    else
                    {
                        ClRest objCr = new ClRest(dv, dr);
                        LblCoc.Text = objCr.CalDiv().ToString();

                        ClRest objR = new ClRest(dv, dr);
                        LblRes.Text = objR.CalR().ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales ");
                TxtDsr.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtDv.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
