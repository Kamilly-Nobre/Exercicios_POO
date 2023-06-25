using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao61
    {
        public void Q61()
        {
            Console.Write("Informe o valor do salário: ");
            double Salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Informe o índice de reajuste: ");
            double IndiceReajuste = double.Parse(Console.ReadLine());

            Console.WriteLine();    

            double SalarioAtualizado = Reajuste(Salario, IndiceReajuste);
           
            Console.WriteLine($"O valor salário atualizado é: {SalarioAtualizado}");

            Console.ReadKey();
        }

        static double Reajuste(double Salario, double IndiceReajuste)
        {
            double SalarioAtualizado = Salario + (Salario * (IndiceReajuste / 100));
            return SalarioAtualizado;
        }


    }
    
}
