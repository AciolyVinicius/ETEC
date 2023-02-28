using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXE2_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            float raio;
            double volume;
            //Entradas de dado
            Console.WriteLine("Insira o raio da esfera em cm: ");
            raio = float.Parse(Console.ReadLine());
            //Processamento
            volume = raio * 4 / 3 * 3.14;
            //Saída de dados
            Console.WriteLine("O volume da esfera é: " + volume + " cm³");
            Console.ReadKey();
        }
    }
}
