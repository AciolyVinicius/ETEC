using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXER9_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            float A, B, C, delta, raiz1, raiz2 ;
            //Entrada De Dados - Coeficientes
            Console.WriteLine("De o valor do coeficiente <A>: ");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("De o valor do coeficiente <B>: ");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine("De o valor do coeficiente <C>: ");
            C = float.Parse(Console.ReadLine());
            delta = (B * B) - 4 * A * C;
            if (A==0)
            {
                Console.WriteLine("Não forma equação de segundo grau");
            }
            if (delta<0)
            {
                Console.WriteLine("Não existem raízes");
            }
            if (A!=0 && delta>=0)
            {
                raiz1 = (-B + delta / 2 * A;
                raiz2 = (-B - delta / 2 * A;
            }
        }
    }
}
