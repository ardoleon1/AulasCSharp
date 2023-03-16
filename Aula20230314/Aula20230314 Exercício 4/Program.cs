using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230314_Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 4---");

            Console.Write("Digite o nome da primeira pessoa: ");
            string pessoa1 = Console.ReadLine();
            Console.Write("Digite o nome da segunda pessoa: ");
            string pessoa2 = Console.ReadLine();
            if (pessoa1.Length > pessoa2.Length)
            {
                Console.WriteLine("O nome da {0} é maior e possui {1}!", pessoa1, pessoa1.Length);
            }
            else
            {
                Console.WriteLine("O nome da {0} é maior e possui {1}!", pessoa2, pessoa2.Length);
            }

            Console.ReadLine();
        }
    }
}
