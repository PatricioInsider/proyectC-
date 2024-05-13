using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_Ejer6
{
    internal class ClTriang
    {
        int a1, b1, c1;
        public ClTriang(int a, int b, int c)
        {
            this.a1 = a; this.b1 = b; this.c1 = c;
        }
        public string CalTr()
        {
            if ((a1 >= b1) && (a1 >= c1))
            {
                if (a1 < (b1 + c1))
                {
                    return "SI";
                }
                else
                    return "NO";

            }
            else{
                
                if ((b1 >= a1) && (b1 >= c1))
                {
                    if (b1 < (a1 + c1))
                    {
                        return "SI";
                    }
                    else
                        return "NO";

                }

                if ((c1 >= a1) && (c1 >= b1))
                {
                    if (c1 < (a1 + b1))
                    {
                        return "SI";
                    }
                    else
                    return "NO";

                }
            }
            return "NO";

            
        }

        public string CalTp()
        {
            
                if (a1 == b1 && b1 == c1)
                {
                    return "Equilátero";
                }
                else if (a1 == b1 || a1 == c1 || b1 == c1)
                {
                    return "Isósceles";
                }
                else
                {
                    return "Escaleno";
                }
            
        }

    }
}
