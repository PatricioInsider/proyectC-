using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDiscriminante
{
    public partial class Form1 : Form
    {
        int Valora, Valorb, Valorc;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtC_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
            }
        }

        private void TxtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                

                if (e.KeyChar == (char)Keys.Enter)
                {
                    Valorc = int.Parse(TxtC.Text);

                    ClDiscri objDis = new ClDiscri(Valora, Valorb, Valorc);
                    LblDiscriminante.Text = objDis.Discriminante().ToString();
                    

                }
            }
            catch
            {
                MessageBox.Show("Ingrese nùmeros enteros: ","A ver donde sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                TxtC.Clear();
            }
        }

        private void TxtA_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                

                if (e.KeyChar == (char)Keys.Enter) //validacion para el enter
                {
                    Valora = int.Parse(TxtA.Text); //convertir el texto a entero
                    TxtB.Focus(); // es el a donde comenzamos

                }
            }
            catch
            {
                // Botones al ocurrir un error, ventana emergente
                MessageBox.Show("Ingrese nùmeros enteros: ", "A ver donde sale", System.Windows.Forms.MessageBoxButtons.RetryCancel, System.Windows.Forms.MessageBoxIcon.Error);

                TxtA.Clear(); //limpiar el Tbx al ir al catch
            }
        }

        private void TxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Valora = int.Parse(TxtA.Text);
                    TxtC.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese nùmeros enteros: ", "A ver donde sale", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                TxtB.Clear();
            }
        }
    }
}
