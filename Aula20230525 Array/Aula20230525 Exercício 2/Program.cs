using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230525_Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 2---");
            int[] num = new int[101];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i;
            }
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
