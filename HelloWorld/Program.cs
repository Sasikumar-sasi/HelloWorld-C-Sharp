using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome To OnBoarding\n");
            Console.Write("Enter Your name\n");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello " + Name);
            Console.ReadKey();
        }
    }
}
