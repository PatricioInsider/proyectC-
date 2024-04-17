using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = ".";  // "*.doc"
            openFileDialog1.Filter = "Archivos BMP(.bmp)|.bmp|Archivos jpeg|*.jpg";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                PbxImage.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                MnuCerrar.Enabled = true;

            }else{
                MessageBox.Show("No selecciono una imagen");
            }
        }

        private void MnuCerrar_Click(object sender, EventArgs e)
        {
            
            PbxImage.Image = null;
            MnuCerrar.Enabled=false; //para desabilitar el cerrar mientas esta cargado
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MnuCerrar.Enabled =false;
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void alTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            LblTitulo.ForeColor = colorDialog1.Color;

        }

        private void alFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            LblTitulo.BackColor = colorDialog1.Color;
        }

        private void alTextoYAlFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            LblTitulo.ForeColor = colorDialog1.Color;

            colorDialog1.ShowDialog();
            LblTitulo.BackColor = colorDialog1.Color;
        }

        private void aUnFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioParcial objCt = new formularioParcial();
            objCt.ShowDialog(); 
        }

        private void aUnProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void odontologoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyAplicaciones.Form1 objPro = new ProyAplicaciones.Form1();
            objPro.ShowDialog();
        }

        private void discriminanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAppDiscriminante.Form1 objDiscri = new WinAppDiscriminante.Form1();
            objDiscri.ShowDialog(); //Mostrar en ventana de dialogo
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\Documentos\\Ayuda.htm"); //Anezar cualquier tipo de archivo
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercaFormulario objCt = new acercaFormulario();
            objCt.ShowDialog();
        }
    }
    }
}
