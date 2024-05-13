using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_EjerI10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int juega;

        private void BtnPiedra_Click(object sender, EventArgs e)
        {
            Ptb1.BackgroundImage = Image.FromFile("./piedra.png");
            Ptb1.BackgroundImageLayout = ImageLayout.Zoom;
            juega = 1;
        }

        private void BtnPapel_Click(object sender, EventArgs e)
        {
            Ptb1.BackgroundImage = Image.FromFile("./papel.png");
            Ptb1.BackgroundImageLayout = ImageLayout.Zoom;

            juega = 2;
        }

        private void BtnTijera_Click(object sender, EventArgs e)
        {
            Ptb1.BackgroundImage = Image.FromFile("./tijeras.png");
            Ptb1.BackgroundImageLayout = ImageLayout.Zoom;

            juega = 3;
        }

        int rd;
        Random con = new Random();
        private void BtnJugar_Click(object sender, EventArgs e)
        {
            rd=con.Next(0,4);
            if (rd==1)
            {

                Ptb2.BackgroundImage= Image.FromFile("./piedra.png");
                Ptb2.BackgroundImageLayout = ImageLayout.Zoom;

            }
            else if (rd==2)
            {
                Ptb2.BackgroundImage = Image.FromFile("./papel.png");
                Ptb2.BackgroundImageLayout = ImageLayout.Zoom;

            }
            else if (rd==3)
            {
                Ptb2.BackgroundImage = Image.FromFile("./tijeras.png");
                Ptb2.BackgroundImageLayout = ImageLayout.Zoom;

            }
            if ((juega==1 && rd==1) || (juega == 2 && rd == 2)|| (juega == 3 && rd == 3))
            {
                MessageBox.Show("Empate");
            }else if((juega==1 && rd == 2) || (juega == 2 && rd == 3)|| (juega == 3 && rd == 1))
            {
                MessageBox.Show("Gana PC");
            }
            else if ((juega==1 && rd == 3)|| (juega == 2 && rd == 1)|| (juega == 3 && rd == 2))
            {
                MessageBox.Show("Gana User");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
