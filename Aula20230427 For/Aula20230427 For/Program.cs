using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230427_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\t\t---Exercício 1 - Calcula o reajuste salarial---");

                double salario, reajuste, novoSalario;

                Console.Write("Informe seu salário: ");
                salario = double.Parse(Console.ReadLine());

                if (salario < 1000)
                {
                    reajuste = salario * 0.55;
                    novoSalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---");
                    Console.WriteLine("Salário atual: {0:c2}", salario);
                    Console.WriteLine("Reajuste: {0:c2}", reajuste);
                    Console.WriteLine("Novo salário: {0:c2}", novoSalario);
                }
                else if (salario < 2500)
                {
                    reajuste = salario * 0.30;
                    novoSalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---");
                    Console.WriteLine("Salário atual: {0:c2}", salario);
                    Console.WriteLine("Reajuste: {0:c2}", reajuste);
                    Console.WriteLine("Novo salário: {0:c2}", novoSalario);
                }
                else
                {
                    reajuste = salario * 0.20;
                    novoSalario = salario + reajuste;
                    Console.WriteLine("\n\t\t---Reajuste---");
                    Console.WriteLine("Salário atual: {0:c2}", salario);
                    Console.WriteLine("Reajuste: {0:c2}", reajuste);
                    Console.WriteLine("Novo salário: {0:c2}", novoSalario);
                }
            }
            Console.ReadKey();
        }
    }
}
