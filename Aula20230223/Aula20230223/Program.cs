using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tExercício 1");
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Escreva seu endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Escreva seu telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Nome: {0} | Endereço: {1} | Telefone: {2}\n", nome, endereco, telefone);

            Console.WriteLine("\tExercício 2");
            Console.Write("Digite o valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());
            double valor3 = valor1 * valor2;
            Console.WriteLine("O produto dos dois números é: {0}\n", valor3);

            Console.WriteLine("\tExercício 3");
            Console.Write("Digite a idade do discente 1: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do discente 2: ");
            int idade2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do discente 3: ");
            int idade3 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do discente 4: ");
            int idade4 = int.Parse(Console.ReadLine());
            Console.Write("Digite a idade do discente 5: ");
            int idade5 = int.Parse(Console.ReadLine());
            int idadeMédia = (idade1 + idade2 + idade3 + idade4 + idade5)/5;
            Console.WriteLine("A média das idades é {0}\n", idadeMédia);

            Console.WriteLine("\tExercício 4");
            Console.Write("Digite o valor do comprimento: ");
            int comprimento = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da largura: ");
            int largura = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura: ");
            int altura = int.Parse(Console.ReadLine());
            int caixaRetangular = comprimento * largura * altura;
            Console.WriteLine("O volume da caixa retangular é {0}\n", caixaRetangular);

            Console.WriteLine("\tExercício 5");
            Console.Write("Informe a quantidade de litros: ");
            double litroCombustivel = double.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de quilômetro: ");
            double quilômetro = double.Parse(Console.ReadLine());
            double quilômetroporLitro = (quilômetro / litroCombustivel);
            Console.WriteLine("A quantidade de quilômetros por litro é {0}\n", quilômetroporLitro);

            Console.WriteLine("\tExercício 6");
            Console.Write("Informe os dias: ");
            double dias = double.Parse(Console.ReadLine());
            double semana = dias / 7;
            double mês = dias / 30;
            double ano = dias / 365;
            Console.WriteLine("A quantidade de semanas é {0}, o de meses é {1} e o de ano é {2}\n", semana, mês, ano);

            Console.WriteLine("\tExercício 7");
            Console.Write("Qual é o número total de prestações? ");
            double prestacoesTotal = double.Parse(Console.ReadLine());
            Console.Write("Quantas prestações você já pagou? ");
            double prestacoesPagas = double.Parse(Console.ReadLine());
            Console.Write("Qual é o valor de cada prestação? ");
            double prestacoesValor = double.Parse(Console.ReadLine());
            double valorTotalPago = prestacoesPagas * prestacoesValor;
            double saldoDevedor = (prestacoesTotal - prestacoesPagas) * prestacoesValor;
            Console.WriteLine("O valor total pago é {0} e o saldo devedor é {1}\n", valorTotalPago, saldoDevedor);

            Console.WriteLine("\tExercício 8");
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());
            double numerosoma = numero1 + numero2;
            double numerosubtracao = numero1 - numero2;
            double numeromultiplicacao = numero1 * numero2;
            double numerodivisao = numero1 / numero2;
            Console.WriteLine("A soma dos dois números é {0}", numerosoma);
            Console.WriteLine("A subtração dos dois números é {0}", numerosubtracao);
            Console.WriteLine("A multiplicação dos dois números é {0}", numeromultiplicacao);
            Console.WriteLine("A divisão dos dois números é {0}\n", numerodivisao);

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
