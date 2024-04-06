using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantidadCifras
{
    internal class ClNumeroEntero
    {
        int numero; //Atributos

        public ClNumeroEntero ( int num) {// Constructor (dato que recibes de la interfaz)
            this.numero = num;
        }

        public int cal_cifras()
        {

            int numCifras = (int)(Math.Log10(numero) / Math.Log10(10)) + 1;  

            return numCifras; 
        }

    }
}
