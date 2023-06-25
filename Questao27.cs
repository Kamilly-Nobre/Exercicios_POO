using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao27
    {
        public void Q27()
        {
            int Numero, Quant;
            long Fatorial;

            Console.Write("Informe a quantidade de números que você deseja que sejam processados: ");
            Quant = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= Quant; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                Numero = int.Parse(Console.ReadLine());

                Fatorial = 1;

                for (int j = 1; j <= Numero; j++)
                {
                    Fatorial *= j;
                }
                
                Console.WriteLine($"O fatorial do número {Numero} é: {Fatorial}.");
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
