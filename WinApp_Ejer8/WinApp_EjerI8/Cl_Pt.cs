using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_EjerI8
{
    internal class Cl_Pt
    {
        double x, y;
        public Cl_Pt(double xa, double ya)
        {
            this.x = xa;
            this.y = ya;
        }

        public string CalCd()
        {
            if (x == 0 && y == 0)
            {
                return "centro del cuadrante";
            }
            else if (x == 0)
            {
                return "eje y";
            }
            else if (y == 0)
            {
                return "eje x";
            }
            else if (x > 0 && y > 0)
            {
                return "primer cuadrante";
            }
            else if (x < 0 && y > 0)
            {
                return "segundo cuadrante";
            }
            else if (x < 0 && y < 0)
            {
                return "tercer cuadrante";
            }
            else
            {
                return "cuarto cuadrante";
            }
           
        }

        public double Caldis()
        {
            //Calcular la distancia del punto al origen(0,0)
            double dis = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return dis;
        }
    }
}
