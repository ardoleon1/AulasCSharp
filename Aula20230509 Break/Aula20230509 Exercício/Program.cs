using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230509_Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 1 sobre Break e Continue---");

            decimal numero = 1;
            for (int i = 1; i <=64; i++)
            {
                Console.WriteLine("Casa: " + i + "\nSoma: " + numero.ToString("n2") + "\n");
                numero = numero * 2;
            }

            Console.ReadLine();
        }
    }
}
