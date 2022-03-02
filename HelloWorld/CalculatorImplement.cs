using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace HelloWorld
{
    internal class CalculatorImplement
    {
        static void Main(string[] args)
        {
            Arithmetric arth = new Arithmetric();
            Console.WriteLine("Enter number 1");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of Numbers {0}" + arth.Add(Num1, Num2));
            Console.WriteLine($"Difference of Two Numbers {0}" + arth.Sub(Num1, Num2));
            Console.WriteLine($"Multiplecation of Two Numbers{0} " + arth.Multiple(Num1, Num2));
            Console.WriteLine($"Divide Of two number {0}" + arth.Divide(Num1, Num2));

            Console.ReadKey();
        }
    }
}
