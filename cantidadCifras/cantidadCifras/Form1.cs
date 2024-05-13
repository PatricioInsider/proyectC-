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
            TxtNumero.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(TxtNumero.Text);
            
            ClNumeroEntero objNumeroEntero = new ClNumeroEntero(num);

            LblRespuesta.Text = objNumeroEntero.cal_cifras().ToString();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int a = int.Parse(TxtNumero.Text);

                if (a>=0) //validacion para los datos
                {
                    // Los datos son correctos

                }
            }
            catch
            {
                // Botones al ocurrir un error, ventana emergente
                MessageBox.Show("Ingrese nùmeros enteros: ", "A ver donde sale", System.Windows.Forms.MessageBoxButtons.RetryCancel, System.Windows.Forms.MessageBoxIcon.Error);

                TxtNumero.Clear(); //limpiar el Tbx al ir al catch
            }
        }
    }
}
