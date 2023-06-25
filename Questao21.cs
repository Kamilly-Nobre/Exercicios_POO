using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao21
    {
        public void Q21()
        {
            int Num;

            Console.Write("Digite um número: ");
            Num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (Num > 0)
            {
                Console.WriteLine($"O número {Num} é positivo!");
            }

            if (Num < 0)
            {
                Console.WriteLine($"O número {Num} é negativo!");
            }

            if (Num == 0)
            {
                Console.WriteLine("Valor neutro, ou seja, igual a 0.");
            }



            Console.ReadKey();

        }
    }
}

