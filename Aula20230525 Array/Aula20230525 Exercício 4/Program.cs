using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230525_Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 4---");
            string[] nomes = new string[10];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Informe {0}º o nome: ", i+1);
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("\n\t\t---Pesquisa---");
            Console.Write("Informe o índice: ");
            int ind = int.Parse(Console.ReadLine());
            if (ind >= 0 && ind <= 10)
            {
                Console.WriteLine(nomes[ind-1]);
            }
            else
            {
                Console.WriteLine("Valor informado não encontrado!");
            }

            Console.ReadLine();
        }
    }
}
