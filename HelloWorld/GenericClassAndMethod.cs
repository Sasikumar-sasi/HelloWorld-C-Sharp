using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class GenericClassAndMethod
    {
        class ListMethods<T>
        {
            public void Sorting(List<T> list)
            {
                list.Sort();
                foreach(T elements in list)
                {
                    Console.WriteLine(elements);
                }
            }
            
        }
        static void Main()
        {
            List<String> names = new List<string> { "Sasikumar","John","Devid","Poul Walker"};
            List<int> id = new List<int> { 100,90,201,89,89,78,67};
            ListMethods<string> stringObj = new ListMethods<string>();
            ListMethods<int> intObj = new ListMethods<int>();
            stringObj.Sorting(names);
            intObj.Sorting(id);
            Console.ReadKey();
        }
    }
}
