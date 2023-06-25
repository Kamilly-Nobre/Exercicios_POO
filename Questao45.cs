using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao45
    {
        public void Q45()
        {
            int Quant;

            Console.WriteLine();
            Console.Write("Digite a quantidade de números para serem lidos: ");
            Quant = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] Numeros = new int[Quant];

            for (int i = 0; i < Quant; i++)
            {
                Console.Write($"Digite o {i + 1}° número: ");
                Numeros[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine("Ordem inversa:");
            Console.WriteLine();

            for (int i = Quant - 1; i >= 0; i--)
            {
                Console.WriteLine(Numeros[i]);
            }



            Console.ReadKey();

        }
    }
}
