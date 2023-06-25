using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao42
    {
        public void Q42()
        {
            double Numero;
            double Menor = int.MaxValue;
            double Maior = int.MinValue;

            Console.WriteLine("Digite um número (para encerrar digite 0):");
            Console.WriteLine();

            while (true)
            {
                Numero = double.Parse(Console.ReadLine());

                if (Numero == 0)

                    break;

                if (Numero < Menor)

                    Menor = Numero;

                if (Numero > Maior)

                    Maior = Numero;

            }

            if (Menor != int.MaxValue && Maior != int.MinValue)
            {
                Console.WriteLine();
                Console.WriteLine($"Menor número digitado: {Menor}");
                Console.WriteLine($"Maior número digitado: {Maior}");
            }

            else
            {
                Console.WriteLine("Valor inválido!");
            }



            Console.ReadKey();

        }
    }
}
