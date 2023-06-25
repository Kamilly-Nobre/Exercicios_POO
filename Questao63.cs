using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao63
    {
        public void Q63()
        {
            int N;

            Console.Write("Digite um número inteiro para verificar se é Par ou Ímpar: ");
            N = int.Parse(Console.ReadLine());
            string Resultado = Verifica(N);
            Console.WriteLine(Resultado);

        }

        static string Verifica(int N)
        {

            if (N % 2 == 0)
            {
                return "PAR";
            }

            else
            {
                return "ÍMPAR";
            }

        }
    }
}
