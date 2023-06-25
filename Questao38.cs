using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao38
    {
        public void Q38()
        {
            bool Encerrar = false;
            int N, C, HE;
            double S = 0;
            double E = 0;
            double ST;
            string Op;

            while (!Encerrar)
            {

                Console.Write("Digite o código do operário: ");
                C = int.Parse(Console.ReadLine());
                Console.Write("Digite o número de horas trabalhadas: ");
                N = int.Parse(Console.ReadLine());

                if (N > 50)
                {
                    HE = N - 50;
                    S = 50 * 10;
                    E = HE * 20;
                }

                else
                {
                    S = N * 10;
                    E = 0;
                }

                ST = S + E;

                Console.WriteLine($"Salário total: R$ {ST:F2}");
                Console.WriteLine($"Salário excedente: R$ {E:F2}");
                Console.WriteLine();
                Console.WriteLine("Deseja encerrar o programa? (S/N)");
                Op = Console.ReadLine();

                if (Op.ToLower() == "s")

                    Encerrar = true;

                Console.WriteLine();

            }
        }
    }
}
