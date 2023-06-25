using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao35
    {
        public void Q35()
        {
            Console.WriteLine("---------- Números múltiplos de 10 ----------");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10");
                    Console.WriteLine();
                }

            }



            Console.ReadKey();

        }
    }
}
