using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao2
    {
        public void Q2()
        {
            double Converssao, Dolar, VD;

            Console.WriteLine("Digite o valor atual do dólar: ");
            Dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor em dólar para ser convertido: ");
            VD = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Converssao = VD * Dolar;
            Console.WriteLine($"O valor em Real é: R$ {Converssao}");



            Console.ReadKey();

        }
    }
}
