using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20230606_Desafio_Enfermaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Desafio Enfermaria---\n");

            int[,] pulsacoes = new int[24, 4];

            for (int linha = 0; linha < 24; linha++)
            {
                Console.WriteLine("\t\t---Leitura de pulsações na {0}º hora---\n", linha+1);
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    Console.Write("Paciente {0}: ", coluna+1);
                    pulsacoes[linha, coluna] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("");
            }
            int media = 0;
            int maiorMedia = 0;
            int cama = 0;
            int soma = 0;

            for (int coluna = 0; coluna < 4; coluna++)
            {
                for (int linha = 0; linha < 24; linha++)
                {
                    soma = soma + pulsacoes[linha, coluna];
                }
                media = soma / 4;
                Console.WriteLine("Média das pulsações do paciente da cama {0}: {1}", coluna+1, media);
                if (maiorMedia < media)
                {
                    maiorMedia = media;
                    cama = coluna + 1;
                }
                soma = 0;
                media = 0;
            }
            Console.WriteLine("A maior média de pulsações: {0}\nPaciente: {1}", maiorMedia, cama);

            //Maior pulsação
            cama = 0;
            int maior = 0;
            int hora = 0;
            for (int c = 0; c < 4; c++)
            {
                for (int l = 0; l < 24; l++)
                {
                    if (maior < pulsacoes[l,c])
                    {
                        maior = pulsacoes[l,c];
                        cama = c + 1;
                        hora = l;
                    }
                }
            }
            Console.WriteLine("Maior pulsação: {0}\nPaciente: {1}\nHora: {2}", maior, cama, hora);

            Console.ReadKey();
        }
    }
}