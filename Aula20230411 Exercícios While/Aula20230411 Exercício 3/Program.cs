using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230411_Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 3---");
            int opcao = 0;
            double conta = 0, verificador = 0;
            while (opcao != 4)
            {
                Console.WriteLine("\nBem-vindo a sua conta corrente!\nO que você quer fazer?");
                Console.WriteLine("Digite [1] para depositar");
                Console.WriteLine("Digite [2] para sacar");
                Console.WriteLine("Digite [3] para exibir saldo");
                Console.WriteLine("Digite [4] para sair");
                Console.Write("Sua opção: ");
                opcao = int.Parse(Console.ReadLine());
                if (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 4)
                {
                    Console.Clear();
                    Console.WriteLine("Digite uma opção válida!\n");
                }
                if (opcao == 1)
                {
                    Console.Clear();
                    Console.Write("Digite o valor para depositar: ");
                    verificador = double.Parse(Console.ReadLine());
                    Console.Clear();
                    if (verificador <= 0)
                    {
                        Console.WriteLine("Digite um número natural válido!");
                    }
                    else
                    {
                        conta = conta + verificador;
                        Console.WriteLine("Seu deposito foi realizado com sucesso!\nO valor atual da conta é {0:c2}!", conta);
                    }
                }
                if (opcao == 2)
                {
                    Console.Clear();
                    Console.Write("Digite o valor para sacar: ");
                    verificador = double.Parse(Console.ReadLine());
                    Console.Clear();
                    if (verificador <= 0)
                    {
                        Console.WriteLine("Digite um número natural válido!");
                    }
                    else
                    {
                        if (verificador > conta)
                        {
                            Console.WriteLine("Você não tem esse valor disponível na conta!");
                        }
                        else
                        {
                            conta = conta - verificador;
                            Console.WriteLine("Seu saque foi realizado com sucesso!\nO valor atual da conta é {0:c2}!", conta);
                        }
                    }
                }
                if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Seu saldo atual é {0:c2}", conta);
                }
            }
            Console.WriteLine("Tenha um bom dia!");
            Console.ReadLine();
        }
    }
}
