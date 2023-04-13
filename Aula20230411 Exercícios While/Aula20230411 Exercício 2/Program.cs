using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230411_Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");
            Console.Write("Digite a quantidade de discentes: ");
            int discente = int.Parse(Console.ReadLine());
            int nota1, nota2, nota3, nota4, notaMedia, notaTurma = 0, notaTotal, discenteFinal;
            discenteFinal = discente;
            Console.Clear();
            Console.WriteLine("\t\t---Exercício 2---");
            while (discenteFinal != 0)
            {
                Console.Write("Digite a nota do 1º Bimestre: ");
                nota1 = int.Parse(Console.ReadLine());
                Console.Write("Digite a nota do 2º Bimestre: ");
                nota2 = int.Parse(Console.ReadLine());
                Console.Write("Digite a nota do 3º Bimestre: ");
                nota3 = int.Parse(Console.ReadLine());
                Console.Write("Digite a nota do 4º Bimestre: ");
                nota4 = int.Parse(Console.ReadLine());
                notaMedia = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine("A média deste discente é {0}\n", notaMedia);
                notaTurma = notaTurma + notaMedia;
                discenteFinal--;
            }
            notaTotal = notaTurma / discente;
            Console.WriteLine("A média da turma é {0}", notaTotal);
            Console.ReadLine();
        }
    }
}
