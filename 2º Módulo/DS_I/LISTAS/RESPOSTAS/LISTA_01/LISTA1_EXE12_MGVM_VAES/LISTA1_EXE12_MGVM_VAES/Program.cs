using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXE12_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            int sex;
            double psi;
            float alt;
            Console.WriteLine("Insira a altura em metros <x,xx>: ");
            alt = float.Parse(Console.ReadLine());
            int i=3;
            do
            {
                Console.WriteLine("Insira o sexo: [1]homem ou [2]mulher");
                sex = int.Parse(Console.ReadLine());
                if (sex == 1)
                {
                    i = 0;
                }
                if (sex == 2)
                {
                    i = 1;
                }
            } while (i == 3);
            if (sex == 0)
            {
                psi = (72.7 * alt) - 58;
            }
            else
            {
                psi = (62.1 * alt) -44.7;
            }
            Console.WriteLine("Peso ideal: " +psi+ "kg");
            Console.ReadKey();
        }
    }
}
