using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class DelegateGeneric
    {
        delegate void sampleDelegate<T>(T t,T t1);
        public static void addInt(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static void floatAdd(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        public static void stringAdd(string str1,string str2)
        {
            Console.WriteLine(str1 + str2);
        }
        static void Main()
        {
            sampleDelegate<int> dele = new sampleDelegate<int>(addInt);
            dele(10, 20);
            sampleDelegate<string> dele1 = new sampleDelegate<string>(stringAdd);
            dele1("Sasi","Kumar");
            sampleDelegate<float> dele3 = new sampleDelegate<float>(floatAdd);
            dele3(20.90f, 10.23f);

            Console.ReadKey();
        }
    }
}
