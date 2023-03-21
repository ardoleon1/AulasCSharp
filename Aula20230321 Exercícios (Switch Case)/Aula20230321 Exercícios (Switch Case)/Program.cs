using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230321_Exercícios__Switch_Case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 1---");

            Console.WriteLine("\nCargos: \n\t[1] Gerente \n\t[2] Engenheiro \n\t[3] Técnico \n\t[4] Outro");
            Console.Write("\nInforme o cargo: ");
            int cargo = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            double novosal = 0;
            double reajuste = 0;

            switch (cargo)
            {
                case 1:
                    novosal = salario + (salario * 0.1);
                    reajuste = novosal - salario;
                    break;
                case 2:
                    novosal = salario + (salario * 0.2);
                    reajuste = novosal - salario;
                    break;
                case 3:
                    novosal = salario + (salario * 0.3);
                    reajuste = novosal - salario;
                    break;
                case 4:
                    novosal = salario + (salario * 0.4);
                    reajuste = novosal - salario;
                    break;
                default:
                    novosal = salario;
                    break;
            }
            Console.WriteLine("\nSalário antigo: {0:c2} \nSalário novo: {1:c2} \nReajuste: {2:c2}", salario, novosal, reajuste);

            Console.ReadLine();
        }
    }
}
