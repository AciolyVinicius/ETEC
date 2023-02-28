using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


namespace LISTA1_EXE5_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = DateTime.Now.Year;
            int nascimento, idade;
            Console.WriteLine("Digite seu ano de nascimento: ");
            nascimento = int.Parse(Console.ReadLine());
            idade = year - nascimento;
            Console.WriteLine("Você tem " + idade +" anos de idade.");
            Console.ReadKey();
        }
    }
}
