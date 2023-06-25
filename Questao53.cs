using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao53
    {
        public void Q53()
        {
            int N;

            Console.Write("Informe a quantidade de voltas que foram dadas na corrida: ");
            N = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            double[] Tempos = new double[N];

            Console.WriteLine("Informe os tempos registrados em cada volta na corrida: ");
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{i + 1}º volta: ");
                Tempos[i] = double.Parse(Console.ReadLine());
            }

            double MelhorTempo = Tempos[0];
            int VoltaMelhorTempo = 1;
            double SomaTempos = Tempos[0];

            for (int i = 1; i < N; i++)
            {
                if (Tempos[i] < MelhorTempo)
                {
                    MelhorTempo = Tempos[i];
                    VoltaMelhorTempo = i + 1;
                }

                SomaTempos += Tempos[i];
            }

            double tempoMedio = SomaTempos / N;

            Console.WriteLine();
            Console.WriteLine($"Melhor tempo: {MelhorTempo}");
            Console.WriteLine($"Volta do melhor tempo: {VoltaMelhorTempo}");
            Console.WriteLine($"Tempo médio das voltas: {tempoMedio}");



            Console.ReadKey();

        }
    }
}
