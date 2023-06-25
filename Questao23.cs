using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao23
    {
        public void Q23()
        {
            int Escolha, PV, SV, R;

            Console.WriteLine("Escolha a opção de cálculo:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine();

            Escolha =
            int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (Escolha)
            {
                case 1:

                    Console.Write("Digite o primeiro valor: ");
                    PV = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Digite o segundo valor: ");
                    SV = int.Parse(Console.ReadLine());
                    R = PV + SV;
                    Console.WriteLine();
                    Console.WriteLine($"O Resultado da soma dos dois valores é: {R}");

                    break;

                case 2:

                    Console.Write("Digite o primeiro valor: ");
                    PV = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.Write("Digite o segundo valor: ");
                    SV = int.Parse(Console.ReadLine());
                    R = PV - SV;
                    Console.WriteLine();
                    Console.WriteLine($"O Resultado da subtração dos dois valores é: {R}");

                    break;

                case 3:

                    Console.Write("Digite o primeiro valor: ");
                    PV = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Digite o segundo valor: ");
                    SV = int.Parse(Console.ReadLine());
                    R = PV * SV;
                    Console.WriteLine();
                    Console.WriteLine($"O Resultado da multiplicação dos dois valores é: {R}");

                    break;

                case 4:

                    Console.Write("Digite o primeiro valor: ");
                    PV = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Digite o segundo valor: ");
                    SV = int.Parse(Console.ReadLine());
                    R = PV / SV;
                    Console.WriteLine();
                    Console.WriteLine($"O Resultado da divisão dos dois valores é: {R}");

                    break;

                default:

                    Console.WriteLine("Opção inválida!");

                    break;
            }



            Console.ReadKey();

        }
    }
}
