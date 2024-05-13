using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_EjerI20
{
    public partial class Form1 : Form
    {
        Random objRnd = new Random();
        int num;
        string c1, c2, c3;
        private int[] votos = new int[3];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TxtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == (char)Keys.Enter)
                {
                    num = int.Parse(TxtNum.Text);
                    Txt1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese solo números enteros");
                TxtNum.Clear();

            }
        }
        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    // Si el carácter ingresado no es una letra, una tecla de control o un espacio en blanco, cancela el evento.
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    c1 = Txt1.Text;
                    Txt2.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese solo caracteres ");
                Txt1.Clear();
                
            }
        }

        private void Txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    // Si el carácter ingresado no es una letra, una tecla de control o un espacio en blanco, cancela el evento.
                    e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    c2 = Txt2.Text;
                    Txt3.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese solo caracteres ");
                Txt2.Clear();

            }
        }

        

        private void Txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    int can = int.Parse(TxtNum.Text);
                    string[] candidatos = { Txt1.Text, Txt2.Text, Txt3.Text };

                    if (can > 0)
                    {
                        num = can;
                        for (int i = 0; i < votos.Length; i++)
                        {
                            votos[i] = 0;
                        }

                        Random rand = new Random();
                        for (int i = 0; i < num; i++)
                        {
                            int voto = rand.Next(0, 3); // Generar un número aleatorio entre 0 y 2
                            votos[voto]++;
                        }

                        int gan = 0;
                        for (int i = 1; i < votos.Length; i++)
                        {
                            if (votos[i] > votos[gan])
                            {
                                gan = i;
                            }
                        }

                        LblRespuesta.Text = $"{candidatos[gan]} con {votos[gan]} votos.";
                        //PtbPresi.Visible = true;

                        // Mostrar votos de cada candidato
                        Lbl1.Text = $"{votos[0]} votos";
                        Lbl2.Text = $" {votos[1]} votos";
                        Lbl3.Text = $"{votos[2]} votos";
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad de votantes.", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNum.Clear();
                    }
                    //respuesta = true;
                    LblRespuesta.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ingrese solo caracteres ");
                Txt3.Clear();

            }
        }


        /*private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int lim = int.Parse(TxtNum.Text);

            int num1 = objRnd.Next(0, lim + 1); // Suma máxima es igual al número de votantes
            int num2 = objRnd.Next(0, lim + 1 - num1); // Restringir el rango para garantizar que la suma sea igual al número de votantes

            // El tercer número será la diferencia entre el número de votantes y la suma de los dos primeros números
            int num3 = lim - num1 - num2;

            // Mostrar los números aleatorios en los Label
            Lbl1.Text = num1.ToString();
            Lbl2.Text = num2.ToString();
            Lbl3.Text = num3.ToString();

        }*/


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
