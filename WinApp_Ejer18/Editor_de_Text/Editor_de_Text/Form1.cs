using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButtonNegrita_Click(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectionFont != null)
            {
                FontStyle estiloActual = richTextBoxTexto.SelectionFont.Style;
                FontStyle nuevoEstilo = estiloActual ^ FontStyle.Bold;
                richTextBoxTexto.SelectionFont = new Font(richTextBoxTexto.SelectionFont, nuevoEstilo);
            }
        }

        private void toolStripButtonCursiva_Click(object sender, EventArgs e)
        {
            if (richTextBoxTexto.SelectionFont != null)
            {
                FontStyle estiloActual = richTextBoxTexto.SelectionFont.Style;
                FontStyle nuevoEstilo = estiloActual ^ FontStyle.Italic;
                richTextBoxTexto.SelectionFont = new Font(richTextBoxTexto.SelectionFont, nuevoEstilo);
            }
        }

        private void toolStripButtonIzquierda_Click(object sender, EventArgs e)
        {
            richTextBoxTexto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButtonCentro_Click(object sender, EventArgs e)
        {
            richTextBoxTexto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButtonDerecha_Click(object sender, EventArgs e)
        {
            richTextBoxTexto.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxTexto.SelectionColor = colorDialog.Color;
            }
        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivo();
        }

        private void toolStripButtonRecuperar_Click(object sender, EventArgs e)
        {
            RecuperarArchivo();
        }

        private void GuardarArchivo()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxTexto.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }


        private void RecuperarArchivo()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxTexto.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }


        private void richTextBoxTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
