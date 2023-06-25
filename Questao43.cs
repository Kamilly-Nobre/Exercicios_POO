using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao43
    {
        public void Q43()
        {
            ulong TotalGraos = 0;
            ulong GraosNoQuadro = 1;

            for (int Quadro = 1; Quadro <= 64; Quadro++)
            {
                TotalGraos += GraosNoQuadro;
                GraosNoQuadro *= 2;
            }
            
            Console.WriteLine($"O monge espera um total de {TotalGraos} grãos.");



            Console.ReadKey();

        }
    }
}
