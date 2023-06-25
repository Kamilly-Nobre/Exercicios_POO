using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao58
    {
        public void Q58()
        {
            int QtdNum, Maior;
            double soma = 0;
            double Media;

            Console.WriteLine("Digite a quantidade de números a serem lidos:");
            QtdNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] Numeros = new int[QtdNum];

            Console.WriteLine("Digite os números:");

            for (int i = 0; i < QtdNum; i++)
            {
                Console.Write($"{i + 1}° número : ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            foreach (int Numero in Numeros)
            {
                soma += Numero;
            }

            Media = soma / QtdNum;
            Maior = Numeros[0];

            for (int i = 1; i < QtdNum; i++)
            {

                if (Numeros[i] > Maior)
                {
                    Maior = Numeros[i];
                }

            }

            Console.WriteLine();
            Console.WriteLine("Média: " + Media);
            Console.WriteLine("Maior número: " + Maior);
            Console.WriteLine();



            Console.ReadKey();

        }
    }
}
