using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_EjerI14
{
    internal class ClFib
    {
        int n;

        public ClFib(int num)
        {

            this.n = num;
        }

        public static string CalFib(int n)
        {
            string serieFibonacci = "";
            for (int i = 0; i < n; i++)
            {
                serieFibonacci += CalSerie(i) + " ";
            }
            return serieFibonacci.Trim();
        }
        public static int CalSerie(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return CalSerie(n-1) + CalSerie(n - 2);
            }
            
        }
    }
}
