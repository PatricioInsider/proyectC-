using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinAppMayor
{
    internal class ClMayor
    {
        int a, b,c;

        public ClMayor( int a1, int b2, int c3)
        {
            this.a = a1;
            this.b = b2;
            this.c = c3;
        }
        public int Mayor()
        { 
            if ((a>b) && (a>c))
            { 
                return a; 
            }
            if ((b>c)&&(b>a))
            {
                return b;
            }
            else
            {
                return c;
            }

        }
    }
}
