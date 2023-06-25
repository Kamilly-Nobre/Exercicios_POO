using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao41
    {
        public void Q41()
        {
            int Idade;

            Console.Write("Digite A sua idade: ");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (Idade < 0)
            {
                Console.Write("Digite uma idade válida: ");
                Idade = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            if (Idade < 5 && Idade >= 0)
            {
                Console.WriteLine("Idade insuficiente.");
            }

            else if (Idade >= 5 && Idade <= 7)
            {
                Console.WriteLine("Categoria: Infantil A");
            }

            else if (Idade >= 8 && Idade <= 11)
            {
                Console.WriteLine("Categoria: Infantil B");
            }

            else if (Idade >= 12 && Idade <= 13)
            {
                Console.WriteLine("Categoria: Juvenil A");
            }

            else if (Idade >= 14 && Idade <= 17)
            {
                Console.WriteLine("Categoria: Juvenil B");
            }

            else if (Idade >= 18)
            {
                Console.WriteLine("Categoria: Adultos");
            }

            else
            {
                Console.WriteLine("ERRO!");
            }



            Console.ReadKey();

        }
    }
}
