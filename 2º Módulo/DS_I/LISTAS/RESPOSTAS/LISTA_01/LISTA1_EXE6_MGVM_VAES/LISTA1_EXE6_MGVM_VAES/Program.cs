using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXE6_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            float n1, n2, n3;
            //Entrada De Dados - Números
            Console.WriteLine("De o primeiro número: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("De o segundo número: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("De o terceiro número: ");
            n3 = float.Parse(Console.ReadLine());
            //Estrutura de Decisão (Achar o maior)
            if (n1>n2 && n1>n3)
            {
                Console.WriteLine("O Maior valor é: "+n1);
            }
            if (n2>n3 && n2>n1)
            {
                Console.WriteLine("O Maior valor é: "+n2);
            }
            if (n3>n2 && n3>n1)
            {
                Console.WriteLine("O Maior valor é: " + n3);
            }
            Console.ReadKey();
        }
    }
}
