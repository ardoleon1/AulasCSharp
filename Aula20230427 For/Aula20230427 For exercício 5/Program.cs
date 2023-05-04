using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230427_For_exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 5---");
            string nome;
            double salario, valorImposto;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("\nDigite o nome da pessoa: ");
                nome = Console.ReadLine();
                Console.Write("Digite o salário da pessoa: ");
                salario = double.Parse(Console.ReadLine());
                
                if (salario < 1000.0)
                {
                    Console.WriteLine("Olá {0}! Você está isento do imposto.", nome);
                }
                else if (salario < 1500.0)
                {
                    valorImposto = salario * 0.075 ;
                    Console.WriteLine("Olá {0}! O valor do imposto de renda é de {1:c2}", nome, valorImposto);
                }
                else
                {
                    valorImposto = salario * 0.15;
                    Console.WriteLine("Olá {0}! O valor do imposto de renda é de {1:c2}", nome, valorImposto);
                }
            }

            Console.ReadLine();
        }
    }
}
