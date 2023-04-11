using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230411_Exercícios_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op == 1)
            {
                Console.WriteLine("\t\t---Exercício 1---");
                Console.Write("Informe um número: ");
                int num = int.Parse(Console.ReadLine());

                int cont = 0;
                while (cont <= 10)
                {
                    Console.WriteLine($"{num} x {cont} = {num * cont}");
                    cont++;
                }
                Console.WriteLine("\nDeseja realizar outra operação?\n[0]Não\n[1]Sim");
                Console.Write("Escolha uma opção: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
