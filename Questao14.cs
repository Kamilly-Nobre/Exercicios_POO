using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao14
    {
        public void Q14()
        {
            int N1, N2, D;

            Console.Write("Digite o primeiro número: ");
            N1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            N2 = int.Parse(Console.ReadLine());

            if (N1 > N2)
            {
                D = N1 - N2;
            }

            else
            {
                D = N2 - N1;
            }

            Console.WriteLine();

            Console.WriteLine($"A diferença do maior número para o menor é: {D}");


            Console.ReadKey();
        }
    }
}
