using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao51
    {
        public void Q51()
        {
            int Qtdlunos;
            double SomaNotas = 0;
            int AcimaSete = 0;
            double Media;

            Console.Write("Digite a quantidade de alunos: ");
            Qtdlunos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double[] Notas = new double[Qtdlunos];

            for (int i = 0; i < Qtdlunos; i++)
            {

                Console.Write($"Digite a nota do {i + 1}º aluno : ");
                Notas[i] = double.Parse(Console.ReadLine());
                SomaNotas += Notas[i];

                if (Notas[i] >= 7)
                {
                    AcimaSete++;
                }

            }

            Console.WriteLine();

            Media = SomaNotas / Qtdlunos;
            Console.WriteLine($"Média das notas: {Media:F2}");

            if (AcimaSete > 0)
            {
                Console.WriteLine($"Alunos com nota acima de 7: {AcimaSete}");
            }

            else
            {
                Console.WriteLine("Não há nenhum aluno com nota acima de 7");
            }



            Console.ReadKey();

        }
    }
}
