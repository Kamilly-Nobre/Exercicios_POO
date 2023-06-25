using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao55
    {
        public void Q55()
        {
            string Frase, SemEspaco;
            int QtdEspacos;

            Console.WriteLine("Digite uma frase de até 50 caracteres:");
            Frase = Console.ReadLine();

            SemEspaco = RemoverEspacos(Frase);
            QtdEspacos = ContarEspacos(Frase);

            Console.WriteLine();
            Console.WriteLine("Frase sem espaços: " + SemEspaco);
            Console.WriteLine("Quantidade de espaços em branco: " + QtdEspacos);

        }

        static string RemoverEspacos(string frase)
        {
            return frase.Replace(" ", "");
        }

        static int ContarEspacos(string frase)
        {
            int contador = 0;

            foreach (char caractere in frase)
            {

                if (caractere == ' ')
                {
                    contador++;
                }

            }

            return contador;

        }
    }
}
