using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230525_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 1---");

            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Informe o {0}º nome: ", i+1);
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("\n\t\t---Imprimindo os dados---");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            //for (int i = 0; i < nomes.Length; i++)
            //{
            //    Console.WriteLine(nomes[i]);
            //}

            Console.ReadLine();
        }
    }
}
