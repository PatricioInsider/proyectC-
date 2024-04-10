using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace WinInterfazVoz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine objEscuchar = new SpeechRecognitionEngine();

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            objEscuchar.SetInputToDefaultAudioDevice(); //activamos al dispositivo para que nos escuche
            objEscuchar.LoadGrammar(new DictationGrammar()); // se carga en un diccionario

            objEscuchar.SpeechRecognized += Mensaje;  //reconocce el mensaje y lo concatena
            objEscuchar.RecognizeAsync(RecognizeMode.Multiple);
        }

        void Mensaje(Object sender, SpeechRecognizedEventArgs e)
        { 
            TxtMensaje.Text = e.Result.Text;
        
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            objEscuchar.RecognizeAsyncStop();
        }
    }
}
