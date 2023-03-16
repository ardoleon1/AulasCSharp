using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230314_Exercício_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 5.2---");

            Console.WriteLine("Digite o primeiro lado: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado: ");
            double c = double.Parse(Console.ReadLine());

            if ((b-a)<a && a<(b+c) || (a-c) < b && b < (a+c) || (a-b) < c && c > (b+c))
            {
                if ((a == b) && (b == c))
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
