using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
namespace HelloWorld
{
    internal class IndexersDemo
    {
        static void Main()
        {
            NameSupport Studentname = new NameSupport();
            Console.WriteLine("How many Student name list want to be Add");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter Student Names:");
            for(int i = 0; i < n; i++)
            {
                Studentname[i] = Console.ReadLine();
            }
            Console.WriteLine("Inserted names are");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(Studentname[i]);
            }
            Console.ReadKey();
        }
    }
}
