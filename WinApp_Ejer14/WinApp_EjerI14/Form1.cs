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

namespace WinApp_EjerI14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num;
        private void TxtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    num = int.Parse(TxtN.Text);
                    string serieFibonacci = ClFib.CalFib(num);
                    LblRes.Text = serieFibonacci;
                }
            }
            catch 
            {
                MessageBox.Show("Ingrese números reales ");
                TxtN.Clear();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbxFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
