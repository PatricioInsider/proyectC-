using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantidadCifras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TxtNumero.Text);
            
            ClNumeroEntero objNumeroEntero = new ClNumeroEntero(num);

            LblRespuesta.Text = objNumeroEntero.cal_cifras().ToString();
        }
    }
}
