using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230525_Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 3---");
            char[] alfabeto = new char[26];
            for (int i = 0; i < alfabeto.Length; i++)
            {
                alfabeto[i] = (char)('A' + i);
            }
            foreach (char letra in alfabeto)
            {
                Console.WriteLine(letra);
            }
            Console.ReadLine();
        }
    }
}
