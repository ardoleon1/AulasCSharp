using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230516_Data_e_Hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023,05,16,10,50,52);
            Console.WriteLine(dt);

            DateTime agora = DateTime.Now;
            Console.WriteLine("Agora: " + agora);

            string hora = DateTime.Now.ToShortTimeString();
            Console.WriteLine("Hora: " + hora);

            string data = DateTime.Now.ToShortDateString();
            Console.WriteLine("Data: " + data);

            DateTime dtAtual = DateTime.Now;
            //string dtFormatada = DateTime.Now.ToString("dd/MM/yyyy");
            string dtFormatada = dtAtual.ToString("dd/MM/yy");
            Console.WriteLine(dtFormatada);

            DateTime dtOntem = DateTime.Now.AddDays(-1);
            DateTime dtAmanha = DateTime.Now.AddDays(1);

            TimeSpan diferenca = dtAmanha - dtOntem;
            int dtDiferencia = diferenca.Days; //Se quiser fazer com meses ou anos basta dividir por 30 e 365 respectivamente
            Console.WriteLine("TimeSpan: " + diferenca);
            Console.WriteLine("Diferença: " + dtDiferencia);

            Console.ReadLine();
        }
    }
}
