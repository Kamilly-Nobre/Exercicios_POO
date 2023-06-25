using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao39
    {
        public void Q39()
        {
            int Num;
            string Encerrar;

            do
            {
                Console.Write("Digite um número: ");
                Num = int.Parse(Console.ReadLine());

                if (Num % 2 == 0 && Num > 0)
                {
                    Console.WriteLine("O número é par e Positivo.");
                }

                else if (Num % 2 == 0 && Num < 0)
                {
                    Console.WriteLine("O número é par e Negativo.");
                }

                else if (Num % 2 == 1 && Num > 0)
                {
                    Console.WriteLine("O número é ímpar e Positivo.");
                }

                else
                {
                    Console.WriteLine("O número é ímpar e Negativo.");
                }

                Console.WriteLine();
                Console.Write("Deseja encerrar o programa? (S/N): ");
                Encerrar = Console.ReadLine();
                Console.WriteLine();

            } while (Encerrar != "S" && Encerrar != "s");

        }
    }
}
