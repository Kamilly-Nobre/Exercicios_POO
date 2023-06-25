using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao60
    {
        public void Q60()
        {
            int X, Y, Quadrante;

            Console.WriteLine("Digite as coordenadas (x, y):");
            Console.WriteLine();
            Console.Write("X: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Quadrante = VerificaQuadrante(X, Y);
            Console.WriteLine($"O ponto está no {Quadrante}° quadrante: ");
            Console.WriteLine();

        }

        static int VerificaQuadrante(int X, int Y)
        {

            if (X > 0 && Y > 0)
            {
                return 1;
            }

            else if (X > 0 && Y < 0)
            {
                return 2;
            }

            else if (X < 0 && Y < 0)
            {
                return 3;
            }

            else if (X < 0 && Y > 0)
            {
                return 4;
            }

            else
            {
                return 0;
            }


            Console.ReadKey();

        }
    }
}
