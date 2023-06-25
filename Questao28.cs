using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao28
    {
        public void Q28()
        {
            Console.WriteLine();
            Console.WriteLine("---------- Números ímpares entre 100 e 200 ----------");
            Console.WriteLine();

            for (int i = 100; i <= 200; i++)
            {

                if (i % 2 == 1)
                {
                    Console.WriteLine($"Ímpar: {i}");
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine(i);
                    Console.WriteLine();
                }

            }



            Console.ReadKey();

        }
    }
}
