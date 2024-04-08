using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinAppCursor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CbxDesplegable_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CbxDesplegable.SelectedIndex){
                
                case 0:
                    this.Cursor = Cursors.Arrow;
                    break;

                case 1:
                    this.Cursor = Cursors.Hand;
                    break;
                case 2:
                    this.Cursor = Cursors.Help;
                    break;
                case 3:
                    this.Cursor = Cursors.Default;
                    break;
                case 4:
                    this.Cursor = Cursors.WaitCursor;
                    break;
                case 5:
                    this.Cursor = Cursors.Default;
                    break;
            }

        }

        private void BtnBeep_Click(object sender, EventArgs e)
        {
            //Aplicar Sonidos en el Visual
            SystemSounds.Beep.Play();
        }

        private void BtnAsteri_Click(object sender, EventArgs e)
        {
            
            SystemSounds.Asterisk.Play();
        }


        private void BtnVentana_Click(object sender, EventArgs e)
        {
            //NOTA DE EXAMEN    
            //Todo formulario es una clase
            FrmCaraFeliz objCaraFeliz = new FrmCaraFeliz();
            objCaraFeliz.ShowDialog();

        }

        private void BtnExclamacion_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play(); 


        }
    }
}
