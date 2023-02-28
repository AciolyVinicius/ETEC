using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXE1_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            float C, L, area, perimetro;
            Console.Clear();
            //Entrada De Dados
            Console.WriteLine("De o valor do comprimento: ");
            C = float.Parse(Console.ReadLine());
            Console.WriteLine("De o valor da largura: ");
            L = float.Parse(Console.ReadLine());
            //Processamento (Área e Perimetro)
            area = C * L;
            perimetro = (2 * C) + (2 * L);
            //Saída de Dados (Resultado Final)
            Console.WriteLine("O valor da área é: "+ area);
            Console.WriteLine("O valor do perimetro é: "+ perimetro);
            Console.ReadLine(); 
        }
    }
}
