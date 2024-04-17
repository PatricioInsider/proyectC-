using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppClasificarNota
{
    internal class ClClasificacion
    {
        int a;


        public ClClasificacion(int a1)
        { this.a = a1; }

        public string clasificacion()
        {
            if (a>10 && (a<0))
            {
                return "Valor no valido";                
            }
            else
            {
                if (a >= 0 && (a >= 3)) { return "Inst"; }
                if (a >= 4 && (a >= 5)) { return "Bue"; }
                if (a >= 6 && (a >= 7)) { return "MB"; } else { return "Excelente"; }
            }
            
        }
    }
}
