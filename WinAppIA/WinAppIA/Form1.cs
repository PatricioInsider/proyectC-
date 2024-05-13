using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;
using System.Windows.Forms;

namespace WinAppIA
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        
        private void bunifuAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;
                Bitmap imagen = new Bitmap(strfilename);
                PbxArchivo.Image = (System.Drawing.Image)imagen;
                string nombreimg = openFileDialog1.SafeFileName;

                var imgen = new Bitmap(openFileDialog1.FileName);
                var tesirc = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndLstm);
                var page = tesirc.Process(imgen);
                TbxTextoFinal.Text = page.GetText();
                BfnCheck.Show();


            }
        }

        

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
