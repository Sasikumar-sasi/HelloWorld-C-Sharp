using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HelloWorld
{
    internal class QueueDemo
    {
        static void Main()
        {
            Queue StudentName = new Queue();
            Console.WriteLine("Enter how many Student to add the Queue");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Student name");
                StudentName.Enqueue(Console.ReadLine());

            }
            Console.WriteLine("---------------Elements inside the QUEUE----------------");
            foreach(string name in StudentName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("If you want to Dequeue Any element \nPress 'y'");
            string ch = Console.ReadLine();
            if(ch.Equals("y") || ch.Equals("Y"))
            {
                StudentName.Dequeue();
                Console.WriteLine("--------------After DEQUEUE------------");
                foreach (string name in StudentName)
                {
                    Console.WriteLine(name);
                }
            }
            Console.ReadKey();
        }
    }
}
