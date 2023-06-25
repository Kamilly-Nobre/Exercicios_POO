using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao30
    {
        public void Q30()
        {
            Console.WriteLine();
            Console.WriteLine("---------- Tabuadas ----------");
            Console.WriteLine();

            for (int N = 1; N <= 10; N++)
            {
                Console.WriteLine("Tabuada do " + N + ":");
                Console.WriteLine();

                for (int i = 1; i <= 10; i++)
                {
                    int R = N * i;
                    Console.WriteLine(N + " x " + i + " = " + R);
                }

                Console.WriteLine();

                Console.ReadKey();

            }
        }
    }
}
