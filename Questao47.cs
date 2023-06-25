using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao47
    {
        public void Q47()
        {
            int[] vetor = new int[10];
            int x, maiores = 0, menores = 0, iguais = 0;
           
            Console.WriteLine("Digite os 10 números do vetor:");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("");
                Console.Write($"Digite o {i + 1}º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");
            Console.Write("Digite o número X: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] > x)
                {
                    maiores++;
                }
                else if (vetor[i] < x)
                {
                    menores++;
                }
                else
                {
                    iguais++;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine($"Quantidade de números maiores que X: {maiores}");
            Console.WriteLine($"Quantidade de números menores que X: {menores}");
            Console.WriteLine($"Quantidade de números iguais a X: {iguais}");

            Console.ReadKey();


        }
    }
}
