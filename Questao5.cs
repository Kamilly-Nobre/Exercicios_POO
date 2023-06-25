using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao5
    {
        public void Q5()
        {
            double D, LU, T, V;

            Console.WriteLine("Digite o tempo gasto na viagem: ");
            T = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média: ");
            V = double.Parse(Console.ReadLine());

            Console.WriteLine();

            D = T * V;
            LU = D / 12;

            Console.WriteLine($"Tempo gasto na viagem: {T}");
            Console.WriteLine($"Velocidade média: {V}");
            Console.WriteLine($"Distância percorrida: {D}");
            Console.WriteLine($"Litros usados: {LU}");


            Console.ReadKey();
        }
    }
}
