using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class MultiThreadDemo
    {
        public static void Process1()
        {
            for(int i = 0; i < 30; i++)
            {
                Console.Write($"{"Hello",-10}");
            }
        }
        public static void Process2()
        {
            for(int i = 0; i < 30; i++)
            {
                Console.Write($"{"Hai",-10}");
            }
        }
        static void Main()
        {
            Thread first = new Thread(Process1);
            Thread second = new Thread(Process2);
            first.Start();
            second.Start();
            Console.ReadKey();
        }
    }
}
