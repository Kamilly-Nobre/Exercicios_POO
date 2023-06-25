using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao31
    {
        public void Q31()
        {
            int Num;
            int SomaPar = 0;
            int SomaImpar = 0;

            Console.WriteLine("Digite um número positivo (ou um número negativo para encerrar): ");
            Console.WriteLine();

            while (true)
            {
                Num =
                int.Parse(Console.ReadLine());

                if (Num < 0)

                    break;

                if (Num % 2 == 0)

                    SomaPar += Num;

                else

                    SomaImpar += Num;

                Console.WriteLine(Num % 2 == 0 ? "Par" : "Ímpar");
                Console.WriteLine();

            }

            Console.WriteLine();
            Console.WriteLine($"Soma dos números pares: {SomaPar}");
            Console.WriteLine($"Soma dos números ímpares: {SomaImpar}");



            Console.ReadKey();

        }
    }
}
