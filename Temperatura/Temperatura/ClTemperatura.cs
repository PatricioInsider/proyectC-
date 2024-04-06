using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    internal class ClTemperatura
    {
        //Atributos
        double graFahrenheit;
        //Metodos

        public ClTemperatura(double a) 
        {
            this.graFahrenheit = a;
        }

        public double conv_Celsius()
        { 
            double graCelsius = (graFahrenheit - 32) * 5 / 9;
            return Math.Round(graCelsius,2); 
        }
    }
}
