using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sexto_Numero
{
    internal class ClSextoNum
    {
        int uno, dos, tres, cuatro, cinco;

        //declarar atributos, metodos constructor, y el proceso

        public ClSextoNum(int a, int b, int c, int d, int e) //Constructor  
        { 
            this.uno = a; this.dos = b; // accedemos a los atributos con 
            this.tres = c; this.cuatro = d; //this.Atributo = asignacion que viene de interfaz
            this.cinco = e;

        } 
        public int sextoNum() // public, retorna o void, numero
        {
            int n1, n2, n3, n4, n5, n6;
            
            n1 = uno / 10000; //primer dig
            n2 = (dos/1000)%10; //segundo dig
            n3 = (tres/100)%10;
            n4 = (cuatro/10)%10;
            n5 = cinco%10; // tercer dig
            
            n6 = n1*10000 + n2*1000 + n3*100 + n4*10 + n5;
            return n6;

        }
    }
}
