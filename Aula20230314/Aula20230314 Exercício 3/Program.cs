using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula202303014_Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t--- Exercício 3---");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite sua quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());
            double notaFinal = (nota1 + nota2 + nota3 + nota4)/4;
            if (notaFinal >= 60)
            {
                Console.WriteLine("Olá {0} sua nota média é {1} e está aprovado!", nome, notaFinal);
            }
            else
            {
                Console.WriteLine("Olá {0} sua nota média é {1} e está reprovado!", nome, notaFinal);
            }

            Console.ReadLine();
        }
    }
}
