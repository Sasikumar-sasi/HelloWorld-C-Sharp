using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class DelegateDemo
    {
        delegate void sampleDelegate(int n, string s);
        public static void EmployeeNames(int count,string name)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Employee Name :{0}", name);
            }
        }
        public static void StudentNames(int count,string name)
        {
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Student Name :{0}", name);
                }
            }
        }
        static void Main()
        {
            sampleDelegate dele;
            dele = new sampleDelegate(EmployeeNames);
            dele(10,"Sasi");
            dele = new sampleDelegate(StudentNames);
            dele(10, "Makesh");
            Console.ReadKey();


        }
    }
}
