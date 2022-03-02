using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class IntExtentions
    {
        public static bool IsValid(this int ScoredMark, int MaxMark)
        {
            return (ScoredMark >= 0 && ScoredMark <= MaxMark); //true 
        }
    }

    class ExtenstionMethodDemo
    {
        static void Main()
        {
            Console.WriteLine("Enter the max mark");
            int MaxMark = int.Parse(Console.ReadLine());

        GetMark:
            Console.WriteLine("Enter scored mark");
            int ScoredMark = int.Parse(Console.ReadLine());

            bool result = ScoredMark.IsValid(MaxMark);
            if (result)
            {
                Console.WriteLine("You have scored : {0}", ScoredMark);
            }
            else
            {
                Console.WriteLine("Invalid mark entered");
                goto GetMark;
            }

            Console.ReadKey();
        }
    }
}
