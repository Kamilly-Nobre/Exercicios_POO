using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao50
    {
        public void Q50()
        {
            Random Random = new Random();
            int NumeroSorteado = Random.Next(101);
            int Tentativas = 0;
            int T;

            Console.WriteLine("---------- Jogo de adivinhação ----------");
            Console.WriteLine();

            do
            {
                Console.Write("Digite um número de 0 a 100: ");
                T = int.Parse(Console.ReadLine());
                Tentativas++;

                if (T < NumeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior!");
                }

                else if (T > NumeroSorteado)
                {
                    Console.WriteLine("O número sorteado é menor!");
                }

            } while (T != NumeroSorteado);

            Console.WriteLine();
            Console.WriteLine($"Parabéns, você acertou o número sorteado em {Tentativas} tentativas!");



            Console.ReadKey();

        }
    }
}
