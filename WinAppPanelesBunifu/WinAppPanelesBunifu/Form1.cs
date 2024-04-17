using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPanelesBunifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton_Click_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            else {
                Form x;
                x = new FrmCaraFeliz();
                x.TopLevel = false;
                x.Dock = DockStyle.Fill;
                panel3.Controls.Add(x);
                panel3.Tag = x;
                x.Show();
            }
        }

        private void bunifuFlatButton2_Discriminante_Click(object sender, EventArgs e)
        {
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            else
            {
                Form x;
                x = new WinAppDiscriminante.Form1(); //obligatoriamente debe ser .form1() para poder trabajar
                x.TopLevel = false; // 
                x.Dock = DockStyle.Fill;
                panel3.Controls.Add(x);
                panel3.Tag = x;
                x.Show();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
