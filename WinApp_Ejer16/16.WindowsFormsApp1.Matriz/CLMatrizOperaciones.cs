using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.WindowsFormsApp1.Matriz
{
    internal class CLMatrizOperaciones
    {
        int[,] matriz;

        public CLMatrizOperaciones(int[,] matrizE)
        {
            this.matriz = matrizE;
        }

        public int elementosPositivos()
        {
            int contador = 0;
            foreach (int elemento in matriz)
            {
                if (elemento > 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        public int elementosNegativos()
        {
            int contador = 0;
            foreach (int elemento in matriz)
            {
                if (elemento < 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        public int sumaTotal()
        {
            int suma = 0;
            foreach (int elemento in matriz)
            {
                suma += elemento;
            }
            return suma;
        }

        public int sumaColumnasPares()
        {
            int suma = 0;
            int columnas = matriz.GetLength(1);
            for (int columna = 0; columna < columnas; columna += 2)
            {
                for (int fila = 0; fila < matriz.GetLength(0); fila++)
                {
                    suma += matriz[fila, columna];
                }
            }
            return suma;
        }

        public int multiplicacionNegativos()
        {
            int multiplicacion = 1;
            foreach (int elemento in matriz)
            {
                if (elemento < 0)
                {
                    multiplicacion *= elemento;
                }
            }
            return multiplicacion;
        }
    }
}
