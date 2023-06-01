using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230530_Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");

            int[] x = new int[10];
            int i = 0;

            while(i < x.Length)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                int valor = int.Parse(Console.ReadLine());

                x[i] = valor;
                i++;
            }
            int[] y = (int[]) x.Clone();
            Array.Reverse(y);
            Console.WriteLine("\n\t\t---Imprimindo os valores na tela---");
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
