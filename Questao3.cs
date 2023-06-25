using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao3
    {
        public void Q3()
        {
            double Comissao, Valor;
            string Nome;
            int COD, Pecas;

            Console.WriteLine("Digite o nome do vendedor: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o código da peça: ");
            COD = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça: ");
            Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças vendidas");
            Pecas = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Comissao = Pecas * Valor * 0.05;
            Console.WriteLine($"O valor da comissão de {Nome} é: R$ {Comissao},00");


            Console.ReadKey();

        }
    }
}
