using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao4
    {
        public void Q4()
        {
            double V;
            int A, B, C, D;

            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"{A} + {B} = {A + B}");
            Console.WriteLine($"{A} + {C} = {A + C}");
            Console.WriteLine($"{A} + {D} = {A + D}");
            Console.WriteLine($"{B} + {C} = {B + C}");
            Console.WriteLine($"{B} + {D} = {B + D}");
            Console.WriteLine($"{C} + {D} = {C + D}");

            Console.WriteLine();

            Console.WriteLine($"{A} * {B} = {A * B}");
            Console.WriteLine($"{A} * {C} = {A * C}");
            Console.WriteLine($"{A} * {D} = {A * D}");
            Console.WriteLine($"{B} * {C} = {B * C}");
            Console.WriteLine($"{B} * {D} = {B * D}");
            Console.WriteLine($"{C} * {D} = {C * D}");



            Console.ReadKey();

        }
    }
}
