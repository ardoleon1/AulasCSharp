using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230530_Array_com_Propriedades_e_Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 1---");

            int[] num = new int[5];
            int i = 0;

            while (i<num.Length)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 50)
                {
                    num[i] = valor;
                    i++;
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente!");
                }
            }
            Console.WriteLine("\n\t\t---Imprimindo os valores na tela---");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
