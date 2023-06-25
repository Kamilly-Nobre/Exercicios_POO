using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao19
    {
        public void Q19()
        {
            double A, B, C;

            Console.WriteLine("---------- Classificação de um Triângulo ----------");
            Console.WriteLine();
            Console.Write("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            C = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (A < B + C && B < A + C && C < A + B)
            {

                if (A == B && B == C)
                {
                    Console.WriteLine("O triângulo é equilátero");
                }

                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("O triângulo é isósceles");
                }

                else if (A != B && B != C)
                {
                    Console.WriteLine("O triângulo é escaleno");
                }

            }

            else if (A != B && B != C)
            {
                Console.WriteLine("O triângulo é escaleno");
            }

            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo!");
            }


            Console.ReadKey();

        }
    }
}
