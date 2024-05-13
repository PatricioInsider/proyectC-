using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primerNumero, segundoNumero;
        char operador;
        Boolean punto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn4_Click_1(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            TxtPantalla.Text += boton.Text;
        }

        private void BtnSeno_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (boton.Text != "Sen" && boton.Text != "Cos" && boton.Text != "Tan" && boton.Text != "√" && boton.Text != "Log") // Verificar si el botón presionado no es una operación de un solo número
            {
                primerNumero = double.Parse(TxtPantalla.Text);
                operador = char.Parse(boton.Text);
                TxtPantalla.Clear();
                punto = false;
            }
            else
            {
                try
                {
                    primerNumero = double.Parse(TxtPantalla.Text);
                    double resultado = 0;

                    switch (boton.Text)
                    {
                        case "Sen":
                            resultado = Math.Sin(primerNumero * Math.PI / 180); // Convertir a radianes
                            break;
                        case "Cos":
                            resultado = Math.Cos(primerNumero * Math.PI / 180); // Convertir a radianes
                            break;
                        case "Tan":
                            resultado = Math.Tan(primerNumero * Math.PI / 180); // Convertir a radianes
                            break;
                        case "√":
                            resultado = Math.Sqrt(primerNumero);
                            break;
                        case "Log":
                            resultado = Math.Log(primerNumero);
                            break;

                    }

                    LblRespuesta.Text = resultado.ToString("F2");
                }
                catch (FormatException)
                {
                    LblRespuesta.Text = "Error de formato";
                }
                catch (OverflowException)
                {
                    LblRespuesta.Text = "Desbordamiento";
                }
            }
        }
    

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (!punto)
            {
                TxtPantalla.Text += ",";
                punto = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtPantalla.Clear();
        }

        private void BtnIgual_Click_1(object sender, EventArgs e)
        {

            segundoNumero = double.Parse(TxtPantalla.Text);
            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;
                case '/':
                    if (segundoNumero == 0)
                    {
                        LblRespuesta.Text = "Error";
                        return;
                    }
                    else
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    break;
                case '√':
                    resultado = Math.Sqrt(primerNumero);
                    break;
                case '^':
                    resultado = Math.Pow(primerNumero, segundoNumero);
                    break;
                case 'l':
                    resultado = Math.Log(primerNumero, segundoNumero);
                    break;
                case 's':
                    resultado = Math.Sin(primerNumero);
                    break;
                case 'c':
                    resultado = Math.Cos(primerNumero);
                    break;
                case 't':
                    resultado = Math.Tan(primerNumero);
                    break;
            }

            LblRespuesta.Text = resultado.ToString("F2");
            punto = false;
        }

        

    }
}