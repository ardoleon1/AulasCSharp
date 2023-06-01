using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230530_Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 4---");

            int[] a = new int[10];
            int x;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nInforme o valor de X: ");
            x = int.Parse(Console.ReadLine());

            if (a.Contains(x))
            {
                Console.WriteLine("\nACHEI!");
            }
            else
            {
                Console.WriteLine("\nNÃO ACHEI!");
            }

            Console.ReadKey();
        }
    }
}
