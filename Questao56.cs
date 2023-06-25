using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao56
    {
        public void Q56()
        {
            int[] vetor = new int[50];
            int QtdPares = 0;
            int QtdMultiplos5 = 0;

            Console.WriteLine("Digite os valores do vetor:");
            Console.WriteLine();

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{i + 1}° elemento : ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            foreach (int Num in vetor)
            {

                if (Num % 2 == 0)
                {
                    QtdPares++;
                }

                if (Num % 5 == 0)
                {
                    QtdMultiplos5++;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Quantidade de números pares: " + QtdPares);
            Console.WriteLine("Quantidade de múltiplos de 5: " + QtdMultiplos5);

        }
    }
}
