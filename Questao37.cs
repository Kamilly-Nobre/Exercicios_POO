using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao37
    {
        public void Q37()
        {
            bool voltarAoMenu = true;
            int Opcao;
            double N1, N2, R;
            string Decisao;

            while (voltarAoMenu)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Opcao = int.Parse(Console.ReadLine());

                while (Opcao < 1 || Opcao > 4)
                {
                    Console.WriteLine("Digite uma opção válida.");
                    Opcao = int.Parse(Console.ReadLine());
                }

                Console.WriteLine();

                Console.Write("Digite o primeiro número: ");
                N1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                N2 = double.Parse(Console.ReadLine());

                R = 0;

                switch (Opcao)
                {
                    case 1:

                        R = N1 + N2;

                        break;

                    case 2:

                        R = N1 - N2;

                        break;

                    case 3:

                        R = N1 * N2;

                        break;

                    case 4:

                        if (N2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero.");

                            break;
                        }

                        R = N1 / N2;

                        break;
                }

                Console.WriteLine("Resultado: " + R);
                Console.WriteLine("Deseja voltar ao menu principal? (S/N)");
                Decisao = Console.ReadLine();

                if (Decisao.ToLower() != "s")

                    voltarAoMenu = false;
            }
        }
    }
}
