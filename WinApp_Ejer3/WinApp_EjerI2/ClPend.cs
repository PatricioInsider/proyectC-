using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_EjerI2
{
    internal class ClPend
    {
        double x1, y1, x2, y2;

        public ClPend(double xa, double ya, double xb, double yb)
        {
            this.x1 = xa;
            this.y1 = ya;
            this.x2 = xb;
            this.y2 = yb;
        }

        public double CalPend()
        {
            double m = Math.Round((y2-y1)/(x2-x1), 3);
            return m;

        }
    }
}

