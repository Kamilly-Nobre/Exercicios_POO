using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao11
    {
        public void Q11()
        {
            int A, B, Troca;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Troca = A;
            A = B;
            B = Troca;

            Console.WriteLine("A= " + A);
            Console.WriteLine("B= " + B);


            Console.ReadKey();
        }
    }
}
