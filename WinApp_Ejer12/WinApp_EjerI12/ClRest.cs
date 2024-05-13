using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_EjerI12
{
    internal class ClRest
    {
        int d, dr;
        public  ClRest(int d1,int d2)
        {
            this.d = d1;
            this.dr = d2;
        }

        public int CalDiv()
        {
            int c = 0;

            while (d >= dr)
            {
                d -= dr;
                c++;
            }
            return c;
        }

        public int CalR()
        {
            int c = 0;

            while (d >= dr)
            {
                d -= dr;
                c++;
            }
            int r = d;
            return r;
        }
    }
}
