using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao6
    {
        public void Q6()
        {
            double F, C;

            Console.WriteLine("Digite uma temperatura em graus Celsius: ");
            C = double.Parse(Console.ReadLine());

            Console.WriteLine();

            F = (9 * C + 160) / 5;
            Console.WriteLine($"A conversão para graus Fahrenheit é: {F}");


            Console.ReadKey();
        }
    }
}
