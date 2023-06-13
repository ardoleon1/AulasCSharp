using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230606_Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");

            int[,] numeros = new int[4, 5];
            int soma = 0;

            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    Console.Write("Informe o valor na posição [{0},{1}]: ", linha, coluna);
                    numeros[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            //Soma os valores de cada coluna
            int[] somaValores = new int[5];

            for (int coluna = 0; coluna < 5; coluna++)
            {
                for (int linha = 0; linha < 4; linha++)
                {
                    soma = numeros[linha, coluna] + soma;
                }
                somaValores[coluna] = soma;
                Console.WriteLine("\nA soma da {0}º coluna é: {1}", coluna+1, somaValores[coluna]);
            }

            Console.ReadKey();
        }
    }
}
