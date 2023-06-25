using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao24
    {
        public void Q24()
        {
            int Escolha, PV, SV, Media;

            Console.Write("Digite o primeiro valor: ");
            PV = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            SV = int.Parse(Console.ReadLine());

            Media = (PV + SV) / 2;

            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Verificar se um dos números lidos é ou não múltiplo do outro");
            Console.WriteLine("2 - Verificar se os dois números lidos são pares");
            Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            Escolha = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (Escolha)
            {

                case 1:

                    if (PV % SV == 0)
                    {
                        Console.WriteLine($"{PV} e {SV} são múltiplos um do outro.");
                    }

                    else
                    {
                        Console.WriteLine($"{PV} e {SV} não são múltiplos um do outro.");
                    }

                    break;

                case 2:

                    if (PV % 2 == 0)
                    {
                        Console.WriteLine($"{PV} é um número par");
                    }

                    else
                    {
                        Console.WriteLine($"{PV} é um número ímpar");
                    }

                    if (SV % 2 == 0)
                    {
                        Console.WriteLine($"{SV} é um número par");
                    }

                    else
                    {
                        Console.WriteLine($"{SV} é um número ímpar");
                    }

                    break;

                case 3:

                    if (Media >= 7)
                    {
                        Console.WriteLine($"Média: {Media}");
                        Console.WriteLine("A média dos dois valores é maior ou igual a 7!");
                    }

                    else
                    {
                        Console.WriteLine($"Média: {Media}");
                        Console.WriteLine("A média dos dois valores NÃO é maior ou igual a 7!");
                    }

                    break;

                case 4:

                default:

                    Console.WriteLine("Fim da execução!");

                    break;

            }



            Console.ReadKey();

        }
    }
}
