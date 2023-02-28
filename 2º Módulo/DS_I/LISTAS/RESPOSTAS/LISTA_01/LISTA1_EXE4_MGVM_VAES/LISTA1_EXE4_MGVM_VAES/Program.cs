using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXE4_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            float n1, n2, n3, n4, media;
            Console.Clear();
            //Entrada De Dados
            Console.WriteLine("De a primeira nota com peso 2: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("De a segunda nota com peso 2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("De a terceira nota com peso 3: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("De a quarta nota com peso 3: ");
            n4 = float.Parse(Console.ReadLine());
            //Processamento (média das notas)
            media = ((n1*2) + (n2*2) + (n3*3) + (n4*3)) / 10;
            //Saída de Dados (Resultado Final)
            Console.WriteLine("A média das notas será: " + media);

            Console.ReadKey();
        }
    }
}
