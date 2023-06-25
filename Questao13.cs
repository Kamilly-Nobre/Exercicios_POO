using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao13
    {
        public void Q13()
        {
            int Pn, Sn, Tn;

            Console.Write("Digite o primeiro número: ");
            Pn = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            Sn = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            Tn = int.Parse(Console.ReadLine());

            int[] R = { Pn, Sn, Tn };

            Array.Sort(R);
            Array.Reverse(R);

            Console.WriteLine();
            Console.WriteLine($"Ordem decrescente: {R[0]} {R[1]} {R[2]}");


            Console.ReadKey();
        }
    }
}
