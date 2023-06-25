using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao25
    {
        public void Q25()
        {
            int Escolha;
            double Altura, PesoIdeal;

            Console.WriteLine("---------- Cálculo do peso ideal ----------");
            Console.WriteLine();
            Console.Write("Digite a sua altura: ");
            Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Homem");
            Console.WriteLine("2 - Mulher");

            Console.WriteLine();

            Escolha = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (Escolha)
            {

                case 1:

                    PesoIdeal = (72.7 * Altura) - 58;
                    Console.WriteLine($"O seu peso ideal é: {PesoIdeal}");

                    break;

                case 2:

                    PesoIdeal = (62.1 * Altura) - 44.7;
                    Console.WriteLine($"O seu peso ideal é: {PesoIdeal}");

                    break;

                default:

                    Console.WriteLine("Opção inválida!");

                    break;

            }



            Console.ReadKey();

        }
    }
}
