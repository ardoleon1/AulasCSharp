using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230606_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 1---");

            int[,] notas = new int[3, 4];
            int soma = 0;
            double media = 0;

            for (int linha = 0; linha < 3; linha++)
            {
                soma = 0;
                Console.WriteLine("\nInforme as notas do {0}º aluno\n", linha+1);
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write("Informe a nota do {0}º bimestre: ", coluna+1);
                    notas[linha, coluna] = int.Parse(Console.ReadLine());
                    soma = soma + notas[linha, coluna];
                }
                media = soma / 4;
                Console.WriteLine("\nMedia final: "+ media.ToString("n2"));
            }

            Console.WriteLine("\n\t\t---Notas Informadas---\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nNotas do {0}º aluno", i+1);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Nota do {0}º bimestre: {1}", j+1, notas[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
