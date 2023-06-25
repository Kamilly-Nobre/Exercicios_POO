using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao7
    {
        public void Q7()
        {
            double C, F;

            Console.WriteLine("Digite uma temperatura em graus Fahrenheit: ");
            F = double.Parse(Console.ReadLine());

            Console.WriteLine();

            C = (F - 32) * 5 / 9;
            Console.WriteLine($"A conversão para graus Celsius é: {C}");


            Console.ReadKey();
        }
    }
}
