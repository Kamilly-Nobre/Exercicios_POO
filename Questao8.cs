using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao8
    {
        public void Q8()
        {
            double V, R, A;

            Console.WriteLine("Cálculo do volume de uma lata de óleo!");

            Console.WriteLine();

            Console.WriteLine("Digite o valor do raio: ");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine();

            V = 3.14159 * R * R * A;
            Console.WriteLine($"O volume da lata é: {V}");


            Console.ReadKey();
        }
    }
}
