using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230530_Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 3---");

            int[] a = new int[10];
            int x;
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nInforme o valor de X: ");
            x = int.Parse(Console.ReadLine());
            int indice = Array.IndexOf(a, x);
            if(indice != -1)
            {
                Console.WriteLine("\nO índice que contém o valor de X é {0}", indice);
            }
            else
            {
                Console.WriteLine("\nNão existe o valor X no Array!");
            }
            
            Console.ReadKey();
        }
    }
}
