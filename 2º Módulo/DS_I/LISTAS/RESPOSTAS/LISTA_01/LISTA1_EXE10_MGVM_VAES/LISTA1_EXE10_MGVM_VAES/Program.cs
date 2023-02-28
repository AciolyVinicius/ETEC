using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXE10_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano, valida;
            Console.WriteLine("Digite um ano: ");
            ano = int.Parse(Console.ReadLine());
            valida = ano % 4;
            if (valida == 0)
            {
                Console.WriteLine("Esse ano é bissexto.");
            }
            else
            {
                Console.WriteLine("Esse ano não é bissexto.");
            }
            Console.ReadKey();
        }
    }
}
