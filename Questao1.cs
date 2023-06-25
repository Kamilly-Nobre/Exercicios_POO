using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao1
    {
        public void Q1()
        {
            int EM, QMI, QMA;

            Console.WriteLine("Digite a quantidade mínima de peças: ");
            QMI = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade Máxima de peças: ");
            QMA = int.Parse(Console.ReadLine());

            Console.WriteLine();

            EM = QMI + QMA / 2;
            Console.WriteLine($"O estoque médio de peças é: {EM}");


            Console.ReadKey();

        }
    }
} 
