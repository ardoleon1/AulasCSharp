using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230330
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = " O teste está funcinando ";
            int tam = a.Length; //conta os caracters
            Console.WriteLine(a.Length);
            a = a.Trim(); //tira espaços entre o começo e o fim da string
            Console.WriteLine(a.Length);
            a = a.Replace(" ", ""); //substitui o antiga cadeia para uma nova dentro de uma string
            Console.WriteLine(a);
            Console.WriteLine(a.Length);
            a = "Pai rico Pai pobre";

            char b = a[17]; //usando [] é possível acessar o char de uma string
            Console.WriteLine(b);

            bool resultado = a.Contains("Rico"); //resulta true or false se a cadeia estiver na string
            Console.WriteLine(resultado);
            Console.WriteLine("---");
            Console.WriteLine(a.StartsWith("Pai")); //Se a cadeia estiver no começo da string retorna true, senão false
            Console.WriteLine(a.EndsWith("bre!")); //Se a cadeia estiver no final da string retorna true, senão false

            Console.WriteLine(a.ToUpper()); //escreva tudo em maiúsculo
            Console.WriteLine(a.ToLower()); //escreva tudo em minúsculo

            string data = "30/03/2023";
            string[] date = data.Split('/'); //divide/separa as variáveis uma das outras, e depois agurda dentro de uma array
            Console.WriteLine("Dia: " + date[0]);
            Console.WriteLine("Mês: " + date[1]);
            Console.WriteLine("Ano: " + date[2]);

            int n = 10;
            double m = n; //conversão implícita
            double o = 3.95;
            n = (int)o; //casting = conversão explícita. obs: perde a precisão do valor
            Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
