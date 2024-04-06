using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumenPiramide
{
    internal class ClPiramide
    {
        //Atributos
        double altura = 234;
        double baseL =53;

            
        //Metodos
        public ClPiramide(double a,double b) 
        { 
            this.altura = a;
            this.baseL = b;
        }

        public double cal_volumen()
        {
            double volumen = ((1.0/3.0)* Math.Pow(baseL,2)) * altura;
            return volumen;
        }

    }
}
