using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LISTA1_EXE11_MGVM_VAES
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            do {
                int mes;
                Console.WriteLine("Insira o número de um mês: ");
                mes = int.Parse(Console.ReadLine());
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Janeiro. ");
                        i = 0;
                        break;
                    case 2:
                        Console.WriteLine("Fevereiro. ");
                        i = 0;
                        break;
                    case 3:
                        Console.WriteLine("Março. ");
                        i = 0;
                        break;
                    case 4:
                        Console.WriteLine("Abril. ");
                        i = 0;
                        break;
                    case 5:
                        Console.WriteLine("Maio. ");
                        i = 0;
                        break;
                    case 6:
                        Console.WriteLine("Junho. ");
                        i = 0;
                        break;
                    case 7:
                        Console.WriteLine("Julho. ");
                        i = 0;
                        break;
                    case 8:
                        Console.WriteLine("Agosto. ");
                        i = 0;
                        break;
                    case 9:
                        Console.WriteLine("Setembro. ");
                        i = 0;
                        break;
                    case 10:
                        Console.WriteLine("Outubro. ");
                        i = 0;
                        break;
                    case 11:
                        Console.WriteLine("Novembro. ");
                        i = 0;
                        break;
                    case 12:
                        Console.WriteLine("Dezembro. ");
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("Data errada. ");
                        i = 1;
                        break;
                }
            } while (i == 1);
            Console.ReadKey();
        }
    }
}
