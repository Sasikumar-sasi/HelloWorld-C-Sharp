using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class UserDefineException
    {
        class NotEligible:Exception
        {
            public NotEligible(string msg) : base(msg)
            {

            }
        }
        static void Main()
        {
            try {
                Console.WriteLine("Enter Age");
                int Age = int.Parse(Console.ReadLine());
                if (Age >= 18)
                {
                    Console.WriteLine(Age);
                }
                else
                {
                    throw new NotEligible("Your age is less than 18");
                } 
            }
            catch (NotEligible ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
