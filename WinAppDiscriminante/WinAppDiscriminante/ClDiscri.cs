using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDiscriminante
{
    internal class ClDiscri
    {
        int a1, b2, c3;
        public ClDiscri(int a, int b, int c)
        {
            this.a1 = a; this.b2 = b; this.c3 = c;
        }

        public double Discriminante()
        {
            return Math.Pow(b2, 2) -(4*a1*c3);
        }
    }
}
