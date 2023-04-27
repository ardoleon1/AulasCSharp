using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230427_For_exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");

            Console.Write("Informe a maior temperatura em Fahrenheit: ");
            int f1 = int.Parse(Console.ReadLine());

            Console.Write("Informe a menor temperatura em Fahrenheit: ");
            int f2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor da escada: ");
            int dec = int.Parse(Console.ReadLine());

            for (; f1 >= f2; f1 = f1 - dec)
            {
                int c = (5 * (f1 - 32)) / 9;
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
