using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao46
    {
        public void Q46()
        {
            int Num;
            int ProdutoEscalar = 0;

            Console.Write("Digite o número de elementos dos vetores: ");
            Num = int.Parse(Console.ReadLine());

            int[] vetorX = new int[Num];
            int[] vetorY = new int[Num];

            Console.WriteLine();
            Console.WriteLine("Digite os elementos do vetor X:");

            for (int i = 0; i < Num; i++)
            {
                Console.Write($"{i + 1}º Elemento: ");
                vetorX[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Digite os elementos do vetor Y:");

            for (int i = 0; i < Num; i++)
            {
                Console.Write($"{i + 1}º Elemento: ");
                vetorY[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Num; i++)
            {
                ProdutoEscalar += vetorX[i] * vetorY[i];
            }

            Console.WriteLine();
            Console.WriteLine($"O produto escalar dos vetores é: {ProdutoEscalar}");



            Console.ReadKey();

        }
    }
}
