using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class InterfaceExample
    {
        interface ICalc
        {
            int Add(int a, int b);
            int Subtract(int a, int b);
            int Multiply(int a, int b);
            float Divide(int a, int b);

        }
        class Calc : ICalc
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public float Divide(int a, int b)
            {
                return a / b;
            }

            public int Multiply(int a, int b)
            {
                return a * b;
            }

            public int Subtract(int a, int b)
            {
                return a - b;
            }
        }
        static void Main()
        {
            ICalc calc = new Calc();
            Console.WriteLine(calc.Add(10, 20));
            Console.WriteLine(calc.Subtract(20, 10));
            Console.WriteLine(calc.Multiply(20, 10));
            Console.WriteLine(calc.Divide(30, 10));
            Console.ReadKey();

        }
    }
}
