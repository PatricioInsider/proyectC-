using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_EjerI9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ha;
        private void TxtH_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ha = TxtH.Text;

                    if (ha == "")
                    {
                        MessageBox.Show("Ingrese un valor positivo");
                        TxtH.Clear();
                        return;
                    }
                    ClHora objT = new ClHora(ha);
                    LblRespuesta.Text = objT.CalHr();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese números reales enteros");
                TxtH.Clear();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbxFoto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
