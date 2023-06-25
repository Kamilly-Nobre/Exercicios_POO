using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao18
    {
        public void Q18()
        {
            int CODIGO;

            Console.Write("Digite o valor do Código: ");
            CODIGO = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (CODIGO)
            {
                case 1:

                    Console.WriteLine("Um");

                    break;

                case 2:

                    Console.WriteLine("Dois");

                    break;

                case 3:

                    Console.WriteLine("Três");

                    break;

                default:

                    Console.WriteLine("CÓDIGO INVÁLIDO!");

                    break;

            }


            Console.ReadKey();

        }
    }
}
