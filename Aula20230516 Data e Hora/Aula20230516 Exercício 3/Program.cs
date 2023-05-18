using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230516_Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 3---");

            Console.Write("Informe a data de nascimento (Obs.: no formato dd/mm/yyyy): ");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

            CalcularIdadeDetalhada(dtNascimento);
            Console.ReadKey();
        }
        static void CalcularIdadeDetalhada(DateTime dtNascimento)
        {
            DateTime dtAtual = DateTime.Now;
            TimeSpan diferenca = dtAtual - dtNascimento;
            DateTime idade = DateTime.MinValue + diferenca;

            int anos = idade.Year - 1;
            int meses = idade.Month - 1;
            int dias = idade.Day - 1;

            Console.WriteLine("{0} Anos\n{1} Meses\n{2} Dias", anos, meses, dias);
        }
    }
}
