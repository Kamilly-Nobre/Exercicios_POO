using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao49
    {
        public void Q49()
        {
            int N;
            int Contador = 0;

            Console.Write("Digite o número de elementos dos vetores (até 50): ");
            N = int.Parse(Console.ReadLine());

            int[] V1 = new int[N];
            int[] V2 = new int[N];

            Console.WriteLine();
            Console.WriteLine("Digite os elementos do vetor V1:");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{i + 1}º elemento: ");
                V1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Digite os elementos do vetor V2:");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{i + 1}º elemento: ");
                V2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {

                if (V1[i] == V2[i])
                {
                    Contador++;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"Quantidade de valores idênticos nas mesmas posições: {Contador}");



            Console.ReadKey();

        }
    }
}
