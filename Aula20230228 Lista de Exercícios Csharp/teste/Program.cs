using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tLista de Exercícios 2");
            Console.WriteLine("\tExercício 1");
            double d = (double)(5 / 2);
            Console.WriteLine("O resultado da conta é {0}\n", d);

            Console.WriteLine("\tExercício 2");
            Console.WriteLine("Digite o valor do número: ");
            double numeropotencia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da potência: ");
            double potencia = double.Parse(Console.ReadLine());
            double valorPotencia = Math.Pow(numeropotencia, potencia);
            Console.WriteLine("O valor da potenciação é {0}\n", valorPotencia);

            Console.WriteLine("\tExercício 3");
            Console.WriteLine("Digite o valor do número: ");
            double numeroraiz = double.Parse(Console.ReadLine());
            double valorRaiz = Math.Sqrt(numeroraiz);
            Console.WriteLine("O valor da raiz quadrada é {0}\n", valorRaiz);

            Console.WriteLine("\tExercício 4");
            Console.WriteLine("Digite o valor do número: ");
            double numeroAbsoluto = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor do número absoluto é {0}\n", numeroAbsoluto);

            Console.WriteLine("\tExercício 5");
            int i = 10;
            Console.WriteLine(i > 100 & i++ < 500);
            Console.WriteLine(i > 100 && i++ < 500);
            Console.WriteLine(i > 0 | i++ < 500);
            Console.WriteLine(i > 0 || i++ < 500);
            Console.WriteLine(i + "\n");

            Console.WriteLine("\tExercício 6");
            Console.WriteLine(1 + 2 + 3 + " testando ");
            Console.WriteLine(" testando " + 1 + 2 + 3 + "\n");

            Console.WriteLine("\tExercício 7");
            Console.WriteLine('a' + 'a' + "\n");

            Console.WriteLine("\tExercício 8");
            Console.WriteLine("Digite um número real: ");
            double numeroReal = double.Parse(Console.ReadLine());
            double numeroQuadrado = numeroReal * numeroReal; //Não encontrei a função math para resolver o exercício
            Console.WriteLine("O resultado é {0}\n", numeroQuadrado);

            Console.WriteLine("\tExercício 9");
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!\n");
            } else
            {
                Console.WriteLine("Você é menor de idade!\n");
            }

            Console.WriteLine("\tExercício 10");
            int j = 10;
            int k = 10;
            Console.WriteLine(j++ == j - 1);
            Console.WriteLine(++k == k);

            Console.ReadLine();
        }
    }
}
