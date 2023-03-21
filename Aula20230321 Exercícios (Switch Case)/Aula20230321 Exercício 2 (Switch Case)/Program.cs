using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230321_Exercício_2__Switch_Case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");

            Console.WriteLine("\nDigite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a nota do 1º Bimestre: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 2º Bimestre: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 3º Bimestre: ");
            int nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 4º Bimestre: ");
            int nota4 = int.Parse(Console.ReadLine());
            int notaMedia = (nota1 + nota2 + nota3 + nota4) / 4;

            char Conceito = ' ';

            if (notaMedia > 100)
            {
                Console.WriteLine("Erro na média da nota: está ultrapassado!");
            }
            else if (notaMedia >= 90)
            {
                Conceito = 'A';
            } 
            else if (notaMedia >= 80)
            {
                Conceito = 'B';
            }
            else if (notaMedia >= 60)
            {
                Conceito = 'C';
            }
            else if (notaMedia >= 40)
            {
                Conceito = 'D';
            }
            else if (notaMedia >= 20)
            {
                Conceito = 'E';
            }
            else if (notaMedia < 20)
            {
                Conceito = 'F';
            }
            else if (notaMedia < 0)
            {
                Console.WriteLine("Erro na média da nota: está negativo!");
            }
            switch (Conceito)
            {
                case 'A':
                    Console.WriteLine("Olá {0}! Sua nota é {1} e você está aprovado", nome, Conceito);
                    break;
                case 'B':
                    Console.WriteLine("Olá {0}! Sua nota é {1} e você está aprovado", nome, Conceito);
                    break;
                case 'C':
                    Console.WriteLine("Olá {0}! Sua nota é {1} e você está aprovado", nome, Conceito);
                    break;
                case 'D':
                    Console.WriteLine("Olá {0}! Sua nota é {1} e você está de recuperação", nome, Conceito);
                    break;
                case 'E':
                    Console.WriteLine("Olá {0}! Sua nota é {1} e você está de exame", nome, Conceito);
                    break;
                case 'F':
                    Console.WriteLine("Olá {0}! Sua nota é {1} e você está reprovado", nome, Conceito);
                    break;
            }

            Console.ReadLine();
        }
    }
}
