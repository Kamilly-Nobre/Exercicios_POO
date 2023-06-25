using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao44
    {
        public void Q44()
        {
            int Escolha;
            double F, C, CalculoF, CalculoM, IMC;
            
            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("5 - Sair");
                Console.WriteLine();

                Escolha = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (Escolha)
                {
                    case 1:

                        Console.WriteLine("Digite uma temperatura em graus Celsius: ");
                        C = double.Parse(Console.ReadLine());
                        F = (9 * C + 160) / 5;
                        Console.WriteLine($"A conversão para graus Fahrenheit é: {F}");
                        Console.WriteLine();

                        break;

                    case 2:

                        Console.WriteLine("Digite uma temperatura em graus Fahrenheit: ");
                        F = double.Parse(Console.ReadLine());
                        C = (F - 32) * 5 / 9;
                        Console.WriteLine($"A conversão para graus Celsius é: {C}");
                        Console.WriteLine();

                        break;

                    case 3:

                        Console.WriteLine("Digite a sua altura:");
                        double Altura = double.Parse(Console.ReadLine());
                        CalculoM = (72.7 * Altura) - 58.0;
                        Console.WriteLine($"Seu peso ideal é {CalculoM:F2}");
                        Console.WriteLine();
                        Console.WriteLine("Digite o seu peso:");
                        double Peso = double.Parse(Console.ReadLine());
                        double A2 = Math.Pow(Altura, 2);
                        IMC = Peso / A2;
                        Console.WriteLine($"{IMC:F2}");

                        if (IMC < 18.5)
                        {
                            Console.WriteLine("Você está abaixo do peso!");
                            Console.WriteLine();
                        }

                        else if (IMC >= 18.5 && IMC <= 25)
                        {
                            Console.WriteLine("Você está no peso ideal!");
                            Console.WriteLine();
                        }

                        else if (IMC > 25 && IMC < 30)
                        {
                            Console.WriteLine("Você está acima do peso!");
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("Você está com obesidade!");
                            Console.WriteLine();
                        }

                        break;

                    case 4:

                        Console.WriteLine("Digite a sua altura:");
                        Altura = double.Parse(Console.ReadLine());
                        CalculoF = (62.1 * Altura) - 44.7;
                        Console.WriteLine($"Seu peso ideal é {CalculoF:F2}");
                        Console.WriteLine();
                        Console.WriteLine("Digite o seu peso:");
                        Peso = double.Parse(Console.ReadLine());
                        A2 = Math.Pow(Altura, 2);
                        IMC = Peso / A2;
                        Console.WriteLine($"{IMC:F2}");

                        if (IMC < 18.5)
                        {
                            Console.WriteLine("Você está abaixo do peso!");
                            Console.WriteLine();
                        }

                        else if (IMC >= 18.5 && IMC <= 25)
                        {
                            Console.WriteLine("Você está no peso ideal!");
                            Console.WriteLine();
                        }

                        else if (IMC > 25 && IMC < 30)
                        {
                            Console.WriteLine("Você está acima do peso!");
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("Você está com obesidade!");
                            Console.WriteLine();
                        }

                        break;

                    case 5:

                        break;

                    default:

                        Console.WriteLine("Código inválido!");

                        break;

                }

            } while (Escolha != 5);

        }
    }
}
