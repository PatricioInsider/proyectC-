using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinInterfazSimple
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

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = TbxNombre.Text;
            string apellido = TbxApellido.Text;
            string edad = TbxEdad.Text;
            
            LblRespuesta.Text = ($"Hola {nombre} {apellido} , tù edad es: {edad}");
        }
    }
}
