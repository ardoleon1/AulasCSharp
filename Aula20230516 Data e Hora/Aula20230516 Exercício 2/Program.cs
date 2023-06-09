﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230516_Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");
            Console.Write("Digite a sua data de Nascimento (Obs.: no formato dd/mm/yyyy): ");
            DateTime dtNascimento = DateTime.Parse(Console.ReadLine());
            
            var idade = CalcularIdade(dtNascimento);
            Console.WriteLine("Você tem {0} anos", idade);

            Console.ReadLine();
        }
        static int CalcularIdade(DateTime dtNascimento)
        {
            var idade = DateTime.Today.Year - dtNascimento.Year;
            if (DateTime.Today.DayOfYear < dtNascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
    }
}
