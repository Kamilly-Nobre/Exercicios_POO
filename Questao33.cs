using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao33
    {
        public void Q33()
        {
            int Contador = 0;
            double Soma = 0;
            int Matricula;
            double Media, Nota;

            while (true)
            {

                Console.Write("Matrícula do aluno: ");
                Matricula = int.Parse(Console.ReadLine());

                if (Matricula < 0)
                {
                    break;
                }

                Console.Write("Nota do aluno: ");
                Nota = double.Parse(Console.ReadLine());

                Console.WriteLine();

                while (Nota > 10)
                {
                    Console.WriteLine("Digite uma nota válida!");
                    Nota = double.Parse(Console.ReadLine());
                }

                if (Nota < 0)
                {
                    break;
                }

                Contador++;
                Soma += Nota;

            }

            Console.WriteLine();

            if (Contador > 0)
            {
                Media = Soma / Contador;
                Console.WriteLine($"A média da nota dos alunos é: {Media:F2}");
            }

            else
            {
                Console.WriteLine("Nenhum dado válido inserido.");
            }

        }
    }
}
