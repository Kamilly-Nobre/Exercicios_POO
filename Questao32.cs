using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao32
    {
        public void Q32()
        {
            int Num;
            int Contador = 0;
            int Soma = 0;

            Console.Write("Digite um número positivo, inteiro e ímpar: ");
            Num = int.Parse(Console.ReadLine());

            while (Num < 1 || Num > 10)
            {
                Console.WriteLine("Digite um número válido: ");
                Num = int.Parse(Console.ReadLine());
            }

            while (Contador < 20)
            {

                if (Num % 2 == 1)
                {
                    Soma += Num * Num;
                    Contador++;
                }

                Num++;
            }

            Console.WriteLine();

            Console.WriteLine("Resultado: " + Soma);



            Console.ReadKey();

        }
    }
}
