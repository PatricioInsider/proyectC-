using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra_Interactiva_con_precios
{
    internal class calcularIva
    {
        public calcularIva() { }
        public double calculoIva(double precio)
        {
            double ivaPrecio = precio * 0.15;
            return Math.Round(precio + ivaPrecio, 2);
        }
    }
}
