using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Eventos_Click(object sender, EventArgs e)
        {
            TxtValor.Text = "4";
        }

        private void Eventos_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Eventos_MouseEnter(object sender, EventArgs e)
        {
            PbxFoto.Visible = true;

        }

        private void BtnEventos_Load(object sender, EventArgs e)
        {
            PbxFoto.Visible = false;
           
        }

        private void BtnEventos_MouseLeave(object sender, EventArgs e)
        {
            PbxFoto.Visible = false;
            LblMessage.Text = ("Estamos Funcionando de Maravilla");
            //Form.BackColor = Color.Blue;
        }

        private void TxtValor_MouseEnter(object sender, EventArgs e)
        {
            PbxFoto.Visible = false;

        }

        

        private void BtnEventos_MouseHover(object sender, EventArgs e)
        {
            //Mostrar la imagen
            PbxFoto.Visible = false;
            BtnEventos.BackColor = Color.Red;

            //Mostrar un mensaje informativo
            LblMessage.Text = "IMAGEN ELIINADA DEL FORM";
        }
    }
}
