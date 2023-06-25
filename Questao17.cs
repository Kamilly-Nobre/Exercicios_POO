using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao17
    {
        public void Q17()
        {
            int Pn;

            Console.Write("Digite um número: ");
            Pn = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (Pn >= 0 && Pn <= 9)
            {
                Console.WriteLine("Valor válido!");
            }

            else
            {
                Console.WriteLine("Valor inválido!");
            }


            Console.ReadKey();

        }
    }
}
