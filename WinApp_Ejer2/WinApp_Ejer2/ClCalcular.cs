using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_Ejer2
{
    internal class ClDistancia
    {
        double x1, y1, x2, y2;

        public ClDistancia(double xa, double ya, double xb, double yb)
        {
            this.x1 = xa;
            this.y1 = ya;
            this.x2 = xb;
            this.y2 = yb;
        }

        public double CalDis()
        {
            double dis = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 3);
            return dis;

        }
    }
}
