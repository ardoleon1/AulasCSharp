using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230509_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Instrução Break---");
            
            int soma = 0;
            Random random = new Random();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Jogada: " + i);
                int numero = random.Next(1,6);
                Console.WriteLine("Número: " + numero);
                soma = soma + numero;
                Console.WriteLine("Soma total: " + soma + "\n");
                if (soma > 9)
                {
                    Console.WriteLine("Você ganhou com " + i + " jogada(s)!");
                    break;
                }
            }
            if (soma <= 9)
            {
                Console.WriteLine("Você perdeu!");
            }
            Console.ReadLine();
        }
    }
}
