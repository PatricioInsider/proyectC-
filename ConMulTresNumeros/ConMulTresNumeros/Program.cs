using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTresNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa de multiplicacion de tres numeros");
            System.Console.WriteLine("Nùmero de paràmetros ingresados ¨{0}", args.Length);


            if (args.Length == 3)
            {
                int resultado = int.Parse(args[0]) * int.Parse(args[1]) * int.Parse(args[2]);

                Console.WriteLine("La multiplicación de los 3 números es: {0}", resultado);
            }
            else
            {
                Console.WriteLine("Error. Ingrese solo 3 argumentos");
            }
        }
    }
}