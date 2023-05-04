using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230427_For_exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 3---");
            int ant = 0, atual = 1, prox = 0;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(atual);
                prox = ant + atual;
                ant = atual;
                atual = prox;
            }

            Console.WriteLine("\nImprimido com sucesso!");
            Console.ReadLine();
        }
    }
}
