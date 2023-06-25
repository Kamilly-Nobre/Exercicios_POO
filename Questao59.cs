using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao59
    {
        public void Q59()
        {
            char PCaractere, SCaractere;
            int NumCaracteres;

            Console.WriteLine("Digite dois caracteres de A a Z em ordem alfabética:");
            Console.WriteLine();
            Console.Write("Primeiro caractere: ");
            PCaractere = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Segundo caractere: ");
            SCaractere = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine();

            if (PCaractere >= 'A' && PCaractere <= 'Z' && SCaractere >= 'A' && SCaractere <= 'Z')
            {

                if (PCaractere <= SCaractere)
                {
                    NumCaracteres = SCaractere - PCaractere - 1;
                    Console.WriteLine("O número de caracteres entre eles é: " + NumCaracteres);

                }

                else
                {
                    Console.WriteLine("Os caracteres não estão em ordem alfabética.");
                }

            }

            else
            {
                Console.WriteLine("Digite caracteres válidos de A a Z.");
            }

            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
