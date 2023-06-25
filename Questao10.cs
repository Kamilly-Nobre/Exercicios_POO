using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao10
    {
        public void Q10()
        {
            int N1, N2;

            Console.Write("Digite o primeiro valor: ");
            N1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            N2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (N1 > N2)
            {
                Console.WriteLine("NÃO IGUAL");
                Console.WriteLine($"MAIOR: {N1}");
                Console.WriteLine($"MENOR: {N2}");
                Console.WriteLine($"{N1} é MAIOR OU IGUAL {N2}");
            }

            else if (N1 < N2)
            {
                Console.WriteLine("NÃO IGUAL");
                Console.WriteLine($"MAIOR: {N2}");
                Console.WriteLine($"MENOR: {N1}");
                Console.WriteLine($"{N1} é MENOR OU IGUAL {N2}");
            }

            else if (N1 == N2)
            {
                Console.WriteLine("IGUAL");
                Console.WriteLine($"{N1} e {N2} são iguais.");
            }

            else
            {
                Console.WriteLine("ERRO!");
            }


            Console.ReadKey();
        }
    }
}
