using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao34
    {
        public void Q34()
        {
            int Num;
            int Menor = int.MaxValue;
            int Maior = int.MinValue;

            Console.WriteLine("Digite um número positivo (Para encerrar digite um número negativo): ");
            Console.WriteLine();

            do
            {
                Console.Write("");
                Num = int.Parse(Console.ReadLine());

                if (Num >= 0)
                {

                    if (Num < Menor)
                    {
                        Menor = Num;
                    }

                    if (Num > Maior)
                    {
                        Maior = Num;
                    }

                }

            } while (Num >= 0);

            if (Menor != int.MaxValue)
            {
                Console.WriteLine();
                Console.WriteLine("Menor valor: " + Menor);
                Console.WriteLine("Maior valor: " + Maior);
            }

            else
            {
                Console.WriteLine("Número inválido!");
            }




            Console.ReadKey();

        }
    }
}
