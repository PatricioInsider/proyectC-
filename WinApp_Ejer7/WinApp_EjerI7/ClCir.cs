using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_EjerI7
{
    internal class ClCir
    {
        double x1, y1, x2, y2, r1, r2;

        public ClCir(double xa, double ya, double xb, double yb, double ra, double rb)
        {
            this.x1 = xa;
            this.y1 = ya;
            this.x2 = xb;
            this.y2 = yb;
            this.r1 = ra;
            this.r2 = rb;
        }

        public string CalCr()
        {
            double dis = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)), 3);

            if (x1 == x2 && y1 == y2)
            {
                return "Concéntricas.";
            }
            else if(dis > (r1 + r2))
            {
                return "Exteriores.";
            }
            else if (dis == (r1 + r2))
            {
                return "Tangentes exteriores.";
            }
            else if (dis < (r1 + r2) && dis > Math.Abs(r1 - r2))
            {
                return "Secantes.";
            }
            else if (dis == Math.Abs(r1 - r2))
            {
                return "Tangentes interiores.";
            }
            else if (dis < Math.Abs(r1 - r2))
            {
                return "Interiores.";
            }

            return "de ningún tipo.";
        }
    }
}
