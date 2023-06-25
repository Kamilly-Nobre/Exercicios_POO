using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao22
    {
        public void Q22()
        {
            int Num, A, B;

            Console.Write("Digite um número: ");
            Num = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (Num > 0)
            {
                A = Num;
                Console.WriteLine($"A= {A}");
            }

            if (Num < 0)
            {
                B = Num;
                Console.WriteLine($"B= {B}");
            }

            if (Num == 0)
            {
                Console.WriteLine("Valor neutro, ou seja, igual a 0.");
            }



            Console.ReadKey();

        }
    }
}
