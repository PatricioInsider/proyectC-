using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trinaguloRectangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int cA = int.Parse(TxtCa.Text);
            int cB = int.Parse(TxtCb.Text);

            ClTrianguloRectangulo objTrianguloRec = new ClTrianguloRectangulo(cA,cB);
            LblResultado.Text = objTrianguloRec.cal_Hipotenusa().ToString();
        }
    }
}
