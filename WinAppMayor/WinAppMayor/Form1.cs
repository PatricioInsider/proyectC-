using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMayor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uno = int.Parse(textBox1.Text);
            int dos = int.Parse(textBox2.Text);
            int tres = int.Parse(textBox3.Text);
            

            ClMayor objmayor = new ClMayor(uno, dos, tres);
            LblRespuesta.Text = objmayor.Mayor().ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //agregar una seccion de validacion en el ingreso de los text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
