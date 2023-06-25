using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lista_002_POO
{
    public class Questao64
    {
        static int[] vetor;

        public void Q64()
        {
            int opcao = 0;
           
            while (opcao != 7)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine();
                Console.WriteLine("1 - Carregar Vetor");
                Console.WriteLine("2 - Listar Vetor");
                Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                Console.WriteLine("5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor");
                Console.WriteLine("6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor");
                Console.WriteLine("7 - Sair");
                
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine();
                        CarregarVetor();

                        break;

                    case 2:

                        Console.WriteLine();
                        ListarVetor();

                        break;

                    case 3:

                        Console.WriteLine();
                        ExibirNumerosPares();

                        break;

                    case 4:

                        Console.WriteLine();
                        ExibirNumerosImpares();

                        break;

                    case 5:

                        Console.WriteLine();
                        ExibirParesNasPosicoesImpares();

                        break;

                    case 6:

                        Console.WriteLine();
                        ExibirImparesNasPosicoesPares();

                        break;

                    case 7:

                        Console.WriteLine();
                        Console.WriteLine("Programa encerrado.");

                        break;

                    default:

                        Console.WriteLine();
                        Console.WriteLine("Opção inválida.");

                        break;
                }

                Console.WriteLine();

            }
        }

        static void CarregarVetor()
        {

            Console.Write("Digite a quantidade de elementos do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            Console.WriteLine();

            vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o {i + 1}º elemento: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Vetor carregado com sucesso.");
        }

        static void ListarVetor()
        {
            Console.WriteLine("Vetor:");
            Console.WriteLine();

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        static void ExibirNumerosPares()
        {
            Console.WriteLine("Números pares:");
            Console.WriteLine();

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        static void ExibirNumerosImpares()
        {
            Console.WriteLine("Números ímpares:");
            Console.WriteLine();

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        static void ExibirParesNasPosicoesImpares()
        {
            int contador = 0;

            for (int i = 1; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 == 0)
                {
                    contador++;
                }
            }

            Console.WriteLine($"Quantidade de números pares nas posições ímpares: {contador}");
        }

        static void ExibirImparesNasPosicoesPares()
        {
            int contador = 0;

            for (int i = 0; i < vetor.Length; i += 2)
            {
                if (vetor[i] % 2 != 0)
                {
                    contador++;
                }
            }

            Console.WriteLine($"Quantidade de números ímpares nas posições pares: {contador}");

        }
    }
}
