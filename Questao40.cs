using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao40
    {
        public void Q40()
        {
            bool Encerrar = false;

            double Indice;

            string Op;



            while (!Encerrar)

            {

                Console.Write("Digite o índice de poluição medido: ");

                Indice = double.Parse(Console.ReadLine());



                if (Indice >= 0.5)

                {

                    Console.WriteLine("Notificação para todos os grupos: Paralisar atividades!");

                }

                else if (Indice >= 0.4)

                {

                    Console.WriteLine("Notificação para 1º grupo e 2º grupo: Suspender atividades!");

                }

                else if (Indice >= 0.3)

                {

                    Console.WriteLine("Notificação para 1º grupo: Suspender atividades!");

                }

                else if (Indice >= 0.05 && Indice <= 0.25)

                {

                    Console.WriteLine("Índice de poluição dentro do limite aceitável.");

                }

                else if (Indice < 0.05)

                {

                    Console.WriteLine("Índice de poluição abaixo do limite aceitável.");

                }

                else

                {

                    Console.WriteLine("Valor inválido para o índice de poluição.");

                }



                Console.WriteLine("Deseja encerrar o programa? (S/N)");

                Op = Console.ReadLine();



                if (Op.ToLower() == "s")

                    Encerrar = true;



                Console.WriteLine();

            }


        }
    }
}
