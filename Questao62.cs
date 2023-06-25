using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_002_POO
{
    public class Questao62
    {
        public void Q62()
        {
            double Base, Altura, Hipotenusa;

            Console.Write("Digite o valor da base do triângulo: ");
            Base = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do triângulo: ");
            Altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Hipotenusa = hipotenusa(Base, Altura);
            Console.WriteLine("O valor da hipotenusa é: " + Hipotenusa);

        }

        static double hipotenusa(double Base, double Altura)
        {

            double hipotenusa = Math.Pow(Base, 2) + Math.Pow(Altura, 2);
            return hipotenusa;

        }
    }
}
