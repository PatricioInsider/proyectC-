using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_Ejer1
{
    internal class ClCifras
    {
        int num;

        public ClCifras(int n)
        {
            this.num = n;
        }
        public int Numcifas()
        {
            int result = (int)(Math.Log(num) / Math.Log(10)) + 1;

            return result;
        }
    }
}
