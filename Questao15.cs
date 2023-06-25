using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao15
    {
        public void Q15()
        {
            int Nota1, Nota2, Nota3, Nota4, Media, R, NM;

            Console.Write("Digite o valor da 1° nota: ");
            Nota1 = int.Parse(Console.ReadLine());

            while (Nota1 < 0 || Nota1 > 10)
            {
                Console.WriteLine("Digite uma nota válida de 0 a 10: ");
                Nota1 = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor da 2° nota: ");
            Nota2 = int.Parse(Console.ReadLine());

            while (Nota2 < 0 || Nota2 > 10)
            {
                Console.WriteLine("Digite uma nota válida de 0 a 10: ");
                Nota2 = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor da 3° nota: ");
            Nota3 = int.Parse(Console.ReadLine());

            while (Nota3 < 0 || Nota3 > 10)
            {
                Console.WriteLine("Digite uma nota válida de 0 a 10: ");
                Nota3 = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor da 4° nota: ");
            Nota4 = int.Parse(Console.ReadLine());

            while (Nota4 < 0 || Nota4 > 10)
            {
                Console.WriteLine("Digite uma nota válida de 0 a 10: ");
                Nota4 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            Console.WriteLine("Resultado da Média: " + Media);

            if (Media >= 7)
            {
                Console.WriteLine("APROVADO");
            }

            else
            {
                Console.Write("Digite o valor da nota da recuperação: ");
                R = int.Parse(Console.ReadLine());

                NM = (Media + R) / 2;
                Console.WriteLine("Resultado da nova média: " + NM);

                if (NM >= 7)
                {
                    Console.WriteLine();
                    Console.WriteLine("APROVADO na Recuperação");
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("REPROVADO");
                }

            }


            Console.ReadKey();

        }
    }
}
