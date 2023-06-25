using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao48
    {
        public void Q48()
        {
            string[] Nomes = new string[20];
            int[] Idades = new int[20];

            for (int i = 0; i < 20; i++)
            {

                Console.Write($"Nome da {i + 1}º candidata : ");
                Nomes[i] = Console.ReadLine();
                Console.Write($"Idade da {i + 1}º candidata : ");
                Idades[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine("Candidatas aptas para a campanha milionária:");

            for (int i = 0; i < 20; i++)
            {

                if (Idades[i] >= 18 && Idades[i] <= 20)
                {
                    Console.WriteLine(Nomes[i]);
                }

            }



            Console.ReadKey();

        }
    }
}
