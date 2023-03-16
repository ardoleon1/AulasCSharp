using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230314_Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 5---");

            Console.Write("Digite o seu salário: ");
            double salario = double.Parse(Console.ReadLine());
            if (salario <= 1500)
            {
                salario = salario + (salario * 0.23);
                Console.WriteLine("Seu novo salário é {0:c2}", salario);
            }
            else
            {
                salario = salario + (salario * 0.18);
                Console.WriteLine("Seu novo salário é {0:c2}", salario);
            }

            Console.ReadLine();
        }
    }
}
