using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double graFahrenheit = double.Parse(TxtFhre.Text);

            ClTemperatura objTemperatura = new ClTemperatura(graFahrenheit);
            //pasar a la interfaz
            LblResultado.Text = objTemperatura.conv_Celsius().ToString();

        }
    }
}
