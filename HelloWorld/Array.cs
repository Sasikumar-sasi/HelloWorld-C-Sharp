using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Array
    {   
        static void Main(string[] args)
        {
            //1D Array
            Console.WriteLine("Enter how many Students");
            int StuCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter How many marks");
            int Subjects = int.Parse(Console.ReadLine());
            int[,] Marks = new int[StuCount, Subjects];
            for(int i = 0; i < StuCount; i++)
            {
                for(int j = 0; j < Subjects; j++)
                {
                    Console.WriteLine($"Student {i+1} and Subject {j+1}");
                    Marks[i,j] = int.Parse(Console.ReadLine());

                }
            }
            for(int i = 0; i < StuCount; i++)
            {
                for(int j = 0; j < Subjects; j++)
                {
                    Console.WriteLine($"Student {i+1} mark{j+1} = " + Marks[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
