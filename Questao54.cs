using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao54
    {
        public void Q54()
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[8];

            Console.WriteLine("Digite os valores do vetor A (5 elementos):");

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write("{0}º elemento: ", i + 1);
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Digite os valores do vetor B (8 elementos):");

            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.Write("{0}º elemento: ", i + 1);
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Elementos em comum:");

            foreach (int elementoA in vetorA)
            {

                foreach (int elementoB in vetorB)
                {

                    if (elementoA == elementoB)
                    {
                        Console.WriteLine(elementoA);
                        break;
                    }

                }

            }


            Console.ReadKey();

        }
    }
}
