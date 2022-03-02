using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ExceptionDemo
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter 2 Numbers");
                Console.WriteLine(int.Parse(Console.ReadLine()) / int.Parse(Console.ReadLine()));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
