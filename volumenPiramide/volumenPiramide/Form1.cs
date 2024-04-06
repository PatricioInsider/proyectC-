using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volumenPiramide
{
    public partial class volumenPiramide : Form
    {
        public volumenPiramide()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(TxtAltura.Text);
            int baseL = int.Parse(TxtBase.Text);

            ClPiramide objPiramide = new ClPiramide(altura,baseL);

            LblResultado.Text = Math.Round(objPiramide.cal_volumen(),2).ToString();
        }
    }
}
