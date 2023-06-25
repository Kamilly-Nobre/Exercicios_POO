using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao16
    {
        public void Q16()
        {
            int Pn, Sn;

            Console.Write("Digite o primeiro número: ");
            Pn = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            Sn = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (Pn > Sn)
            {
                Console.WriteLine($"Maior número: {Pn}");
                Console.WriteLine($"Menor número: {Sn}");
            }

            if (Sn > Pn)
            {
                Console.WriteLine($"Maior número: {Sn}");
                Console.WriteLine($"Menor número: {Pn}");
            }

            if (Pn == Sn)
            {
                Console.WriteLine("Os valores são iguais!");
            }


            Console.ReadKey();

        }
    }
}
