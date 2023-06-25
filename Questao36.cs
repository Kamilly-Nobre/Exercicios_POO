using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao36
    {
        public void Q36()
        {
            int Quantidade = 10;
            int Menor = int.MaxValue;
            int Maior = int.MinValue;
            int Soma = 0;
            int Valor;
            double Media;

            Console.WriteLine();
            Console.WriteLine("Digite 10 valores inteiros e positivos:");
            Console.WriteLine();

            for (int i = 1; i <= Quantidade; i++)
            {
                Console.Write($"{i}° Valor: ");
                Valor = int.Parse(Console.ReadLine());

                if (Valor < 0)
                {
                    Console.WriteLine("Valor inválido! Digite um valor inteiro e positivo.");
                    i--;
                    continue;
                }

                if (Valor < Menor)
                {
                    Menor = Valor;
                }

                if (Valor > Maior)
                {
                    Maior = Valor;
                }

                Soma += Valor;
            }

            Media = (double)Soma / Quantidade;

            Console.WriteLine();
            Console.WriteLine("Menor valor: " + Menor);
            Console.WriteLine("Maior valor: " + Maior);
            Console.WriteLine($"Média dos valores: {Media:F2}");



            Console.ReadKey();

        }
    }
}
