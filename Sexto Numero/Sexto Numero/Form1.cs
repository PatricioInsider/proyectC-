using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sexto_Numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string Dato1 = TbUno.Text; //llamamos al name.tipo
            string Dato2 = TbDos.Text;
            string Dato3 = TbTres.Text;
            string Dato4 = TbCuatro.Text;
            string Dato5 = TbCinco.Text;
            string Respuesta = TxtRespuesta.Text;

            int UnoTrans = int.Parse(Dato1);
            int DosTrans = int.Parse(Dato2);
            int TresTrans = int.Parse(Dato3);
            int CuatroTrans = int.Parse(Dato4);
            int CincoTrans = int.Parse(Dato5);

            ClSextoNum ObjSextoNum = new ClSextoNum(UnoTrans,DosTrans,TresTrans,CuatroTrans,CincoTrans);
            
            TxtRespuesta.Text = ObjSextoNum.sextoNum().ToString();

        }
    }
}
