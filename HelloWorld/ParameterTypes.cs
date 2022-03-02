using System;

namespace HelloWorld
{
    internal class ParameterTypes  //      Default parameters, named parameters
    {
        public static int Add(int Num1,int Num2)
        {
            return Num1 + Num2;
        }
        static void Main(string[] args)
        {
            int sum = Add(Num1:12,Num2:124);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
