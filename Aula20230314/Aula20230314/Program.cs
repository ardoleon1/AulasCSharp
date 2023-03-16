using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 1---");
            Console.Write("\nInforme um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num%2 == 0)
            {
                Console.WriteLine("O número {0} é par!", num);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar!", num);
            }
            Console.ReadKey();
        }
    }
}
