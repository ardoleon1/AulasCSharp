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

            Console.WriteLine("Calculador de IMC\n");
            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / (altura * altura);
            if (imc < 16.00)
            {
                Console.WriteLine("\nSeu IMC: {0}", imc);
                Console.WriteLine("Classificação: baixo peso grau III");
            }
            if (imc >= 16.00 && imc <= 16.99)
            {
                Console.WriteLine("\nSeu IMC: {0}", imc);
                Console.WriteLine("Classificação: baixo peso grau II");
            }
            if (imc >= 17.00 && imc <= 18.49)
            {
                Console.WriteLine("\nSeu IMC: {0}", imc);
                Console.WriteLine("Classificação: baixo peso grau I");
            }
            if (imc >= 18.50 && imc <= 24.99)
            {
                Console.WriteLine("\nSeu IMC: {0}", imc);
                Console.WriteLine("Classificação: peso ideal");
            }
            if (imc >= 25.00 && imc <= 29.99)
            {
                Console.WriteLine("\nSeu IMC: {0}", imc);
                Console.WriteLine("Classificação: sobrepeso");
            }
            if (imc >= 30.00 && imc <= 34.99)
            {
                Console.WriteLine("\nSeu IMC: {0}", imc);
                Console.WriteLine("Classificação: obesidade grau I");
            }
            if (imc >= 35.00 && imc <= 39.99)
            {
                Console.WriteLine("\nSeu IMC: {0}", imc);
                Console.WriteLine("Classificação: obesidade grau II");
            }
            if (imc >= 40.00)
            {
                Console.WriteLine("\nSeu IMC: {0}", imc);
                Console.WriteLine("Classificação: obesidade grau III");
            }

            Console.ReadLine();
        }
    }
}