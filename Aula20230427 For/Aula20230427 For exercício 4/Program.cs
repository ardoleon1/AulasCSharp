using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230427_For_exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 4---");

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            int nLetra = (nome.Trim()).Length;

            for (int i = 1; i <= nLetra; i++)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();
        }
    }
}
