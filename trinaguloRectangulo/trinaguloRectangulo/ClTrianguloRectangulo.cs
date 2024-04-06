using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trinaguloRectangulo
{
    internal class ClTrianguloRectangulo
    {
        int catetoA;
        int catetoB;

        public ClTrianguloRectangulo(int a, int b) 
        {
            this.catetoA = a; this.catetoB = b;
        }

        public double cal_Hipotenusa()
        {
            double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
            return Math.Round(hipotenusa,2);
        }
        

    }
}
