using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230425_do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Ajuda nas Compras---");

            Console.Write("Informe o valor disponível: ");
            double saldo = double.Parse(Console.ReadLine());
            double compra = 0;
            double somaCompras = 0;
            int cont = 0;
            bool podeComprar = true;

            do
            {
                Console.Write("\nValor da compra: ");
                compra = double.Parse(Console.ReadLine());
                if (compra > 0)
                {
                    if (compra <= saldo)
                    {
                        saldo = saldo - compra;
                        somaCompras = somaCompras + compra;
                        cont++;
                        Console.WriteLine("\nCompra registrada!\nSaldo disponível: {0:c2}", saldo);
                    }
                    else
                    {
                        podeComprar = false;
                        Console.WriteLine("Você não possui saldo suficiente para realizar essa compra");
                    }
                }
                else
                {
                    Console.WriteLine("\nValor inválido!");
                }

            } while (podeComprar);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("\t\t---Resultado das Compras---");
            Console.WriteLine("\nNúmero de Compras: {0}\nTotal Gasto: {1:c2}\nSaldo Restante: {2:c2}", cont, somaCompras, saldo);
            Console.ReadKey();
        }
    }
}
