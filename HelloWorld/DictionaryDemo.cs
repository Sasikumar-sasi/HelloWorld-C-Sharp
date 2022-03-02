using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class DictionaryDemo
    {
        static void Main()
        {
            Dictionary<string, int> CarList = new Dictionary<string, int>();
            Console.WriteLine("How many cars List you Want to be insert");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter car name and price(separated by comma");
                string input = Console.ReadLine();
                string[] details = input.Split(',');
                CarList.Add(details[0], int.Parse(details[1]));
            }
            foreach(KeyValuePair<string,int> cars in CarList)
            {
                Console.WriteLine("{0} is {1}", cars.Key, cars.Value);
            }
            Console.ReadKey();
        }

    }
}
