using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao12
    {
        public void Q12()
        {
            int X, Modulo;

            Console.Write("Digite um número: ");
            X = int.Parse(Console.ReadLine());

            Modulo = X >= 0 ? X : X * (-1);

            Console.WriteLine("O módulo do número digitado é: " + Modulo);


            Console.ReadKey();
        }
    }
}
