using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class HashsetDemo
    {
        static void Main() {
            HashSet<string> username = new HashSet<string>();
            Console.WriteLine("How many username want to be insert");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Enter Username (usernme must be unique)");
            for(int i = 0; i < n; i++)
            {
                username.Add(Console.ReadLine());
            }
            Console.WriteLine("------------After inserting---------------");
            foreach(string names in username)
            {
                Console.WriteLine(names);
            }
            Console.ReadKey();
        }
    }
}
