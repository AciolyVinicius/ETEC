using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXE3_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            float n1, n2, n3, n4, media;
            Console.Clear();
            //Entrada De Dados
            Console.WriteLine("De a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("De a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("De a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("De a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());
            //Processamento (média das notas)
            media = (n1 + n2 + n3 + n4) / 4;
            //Saída de Dados (Resultado Final)
            Console.WriteLine("A média das notas será: " +media);

            Console.ReadKey();
        }
    }
}
