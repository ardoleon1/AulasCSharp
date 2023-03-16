using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230314_Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");
            Console.WriteLine("\t Escreva três números inteiros e retornará o maior");

            Console.Write("Digite o valor do primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor do terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine("O maior número é o {0}", num1);
                }
                else
                {
                    Console.WriteLine("O maior número é o {0}", num3);
                }
            }
            else if (num2 >= num1)
            {
                if (num2 >= num3)
                {
                    Console.WriteLine("O maior número é o {0}", num2);
                }
                else
                {
                    Console.WriteLine("O maior número é o {0}", num3);
                }
            }

            Console.ReadLine();
        }
    }
}
