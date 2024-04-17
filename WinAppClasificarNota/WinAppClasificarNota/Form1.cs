using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppClasificarNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            
        }

        private void TxtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int a = int.Parse(TxtNota.Text);
                if (e.KeyChar == (char)Keys.Enter)
                {
                    
                    ClClasificacion ObjNota = new ClClasificacion(a);
                    LblRespuesta.Text = ObjNota.clasificacion().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese una nota valida de 0-10", "", System.Windows.Forms.MessageBoxButtons.RetryCancel, System.Windows.Forms.MessageBoxIcon.Error);
                TxtNota.Clear(); //borar
            }
        }
    }
}
