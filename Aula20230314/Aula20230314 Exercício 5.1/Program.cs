using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230314_Exercício_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 5.1---");

            Console.WriteLine("Calculador de IMC");
            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            if (imc < 16.00)
            {
                Console.WriteLine("Baixo peso grau III");
            }
            if (imc >= 16.00 && imc <= 16.99)
            {
                Console.WriteLine("Baixo peso grau II");
            }
            if (imc >= 17.00 && imc <= 18.49)
            {
                Console.WriteLine("Baixo peso grau I");
            }
            if (imc >= 18.50 && imc <= 24.99)
            {
                Console.WriteLine("Peso ideal");
            }
            if (imc >= 25.00 && imc <= 29.99)
            {
                Console.WriteLine("Sobrepeso");
            }
            if (imc >= 30.00 && imc <= 34.99)
            {
                Console.WriteLine("Obesidade grau I");
            }
            if (imc >= 35.00 && imc <= 39.99)
            {
                Console.WriteLine("Obesidade grau II");
            }
            if (imc >= 40.00)
            {
                Console.WriteLine("Obesidade grau III");
            }

            Console.ReadLine();
        }
    }
}