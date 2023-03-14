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
            Console.WriteLine("\tDesafio");
            Console.Write("Digite o nome do funcionário: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Digite o valor do salário fixo: ");
            double salarioFixo = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor total das vendas realizadas: ");
            double valorVendas = double.Parse(Console.ReadLine());
            Console.Write("Digite o percentual de ganho das vendas: ");
            double percentualVendas = double.Parse(Console.ReadLine());
            double percentualAplicado = valorVendas * (percentualVendas * 0.01);
            double salarioTotal = salarioFixo + percentualAplicado;
            Console.WriteLine("O valor total do seu salário é {0}\n", salarioTotal);

            Console.ReadLine();
        }
    }
}
