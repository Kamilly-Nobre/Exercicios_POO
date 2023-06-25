using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao9
    {
        public void Q9()
        {
            int Anos, Meses, Dias, Idade;

            Console.Write("Digite a sua idade em anos: ");
            Anos = int.Parse(Console.ReadLine());
            Console.Write("Digite a sua idade em meses: ");
            Meses = int.Parse(Console.ReadLine());
            Console.Write("Digite a sua idade em dias: ");
            Dias = int.Parse(Console.ReadLine());

            Idade = (Anos * 365) + (Meses * 30) + Dias;

            Console.WriteLine("O total da sua idade apenas em dias é: " + Idade);


            Console.ReadKey();
        }
    }
}
