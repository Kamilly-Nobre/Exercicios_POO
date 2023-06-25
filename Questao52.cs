using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao52
    {
        public void Q52()
        {
            const int Maximo = 100;
            int[] Vetor = new int[Maximo];
            int QtdSequencia = 0;
            int Posicao = 0;
            int Num;

            Console.WriteLine("Digite os números do vetor (digite -1 para sair):");
            Console.WriteLine();

            while (Posicao < Maximo)
            {
                Console.Write($"Digite o valor da {Posicao + 1}º posição: ");
                Num = int.Parse(Console.ReadLine());

                if (Num == -1)
                {
                    break;
                }

                Vetor[Posicao] = Num;

                if (Posicao >= 2 && Vetor[Posicao - 2] == 1 && Vetor[Posicao - 1] == 2 && Vetor[Posicao] == 3)
                {
                    QtdSequencia++;
                }

                Posicao++;

            }

            Console.WriteLine();
            Console.WriteLine($"Quantidade de vezes que aparece a sequência 1, 2, 3: {QtdSequencia}");



            Console.ReadKey();

        }
    }
}
