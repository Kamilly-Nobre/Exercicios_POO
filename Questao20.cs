using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao20
    {
        public void Q20()
        {
            int A, B, C, Menor, Maior, Mult;
            double Div;

            Console.WriteLine("---------- Classificação de um Triângulo ----------");
            Console.WriteLine();
            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            while (A < 0)
            {

                Console.Write("O valor digitado não é válido. Digite um valor válido (Maior que 0): ");
                A = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            while (B < 0)
            {

                Console.Write("O valor digitado não é válido. Digite um valor válido (Maior que 0): ");
                B = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();

            Console.Write("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());

            while (C < 0)
            {

                Console.Write("O valor digitado não é válido. Digite um valor válido (Maior que 0): ");
                C = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();

            Menor = Math.Min(A, Math.Min(B, C));
            Maior = Math.Max(A, Math.Max(B, C));

            Console.WriteLine("Menor valor: " + Menor);
            Console.WriteLine("Maior valor: " + Maior);

            Console.WriteLine();

            Mult = Menor * Maior;
            Div = (double)Maior / Menor;

            Console.WriteLine($"Menor valor multiplicado pelo maior: {Mult}");
            Console.WriteLine($"Maior valor dividido pelo menor: {Div}");



            Console.ReadKey();

        }
    }
}
