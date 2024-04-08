using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConSumarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Nùmero de paràmetros ingresad ¨{0}",args.Length);
            if (args.Length == 2)
            {
                int sumar = int.Parse(args[0]) + int.Parse(args[1]);
                Console.WriteLine("La suma es: {0}", sumar);
            }
            else {
                Console.WriteLine("Ingrese 2 argumentos");
            }
        }
    }
}
