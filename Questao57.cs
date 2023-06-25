using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao57
    {
        public void Q57()
        {
            string Frase;
            string Vogais;

            Console.WriteLine("Digite uma frase:");
            Frase = Console.ReadLine();

            Vogais = ExtrairVogais(Frase);
            Console.WriteLine("Vogais da frase: " + Vogais);
            Console.WriteLine();

        }

        static string ExtrairVogais(string Frase)
        {
            string Vogais = "";

            foreach (char Caractere in Frase)
            {

                if (EhVogal(Caractere))
                {
                    Vogais += Caractere;
                }

            }

            return Vogais;

        }

        static bool EhVogal(char Caractere)
        {
            char[] Vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return Array.IndexOf(Vogais, Caractere) != -1;

        }
    }
}
