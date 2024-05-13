using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_EjerI4
{
    internal class ClArea
    {
        double a1, b1, c1;
        public ClArea(double a, double b, double c)
        {
            this.a1 = a; this.b1 = b; this.c1 = c;
        }
        public double CalArea()
        {
            double r = (a1 - c1);
            double at = (b1 * r) / 2;
            double ar = (c1*b1);

            return at + ar;
        }
    }
}
