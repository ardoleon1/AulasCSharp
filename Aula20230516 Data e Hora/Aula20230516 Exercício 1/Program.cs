using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230516_Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Exercício 1---");
            DateTime dtAtual = DateTime.Now;
            string data = dtAtual.ToString("dd/MM/yyyy");
            string hora = dtAtual.ToString("HH:mm");
            Console.WriteLine("Data: " + data);
            Console.WriteLine("Hora: " + hora);

            Console.ReadLine();
        }
    }
}
