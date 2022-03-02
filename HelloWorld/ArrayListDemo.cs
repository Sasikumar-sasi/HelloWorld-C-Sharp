using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HelloWorld
{
    internal class ArrayListDemo
    {
        static void Main()
        {
            ArrayList student = new ArrayList();
            Console.WriteLine("How many student want to be insert");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i+1} name");
                string PersonName = Console.ReadLine();
                student.Add(PersonName);
            }
           
            int ch;
            do {
                Console.WriteLine("Enter Your choice\n1.Add new\n2.Delete\n3.View All\n4.Exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Name :");
                        string name = Console.ReadLine();
                        student.Add(name);
                        Console.WriteLine("Inserted Success");
                        break;
                    case 2:
                        Console.WriteLine("Which Name want to be delete");
                        student.Remove(Console.ReadLine());
                        Console.WriteLine("Deleted Success");
                        break;
                    case 3:
                        Console.WriteLine("Names Are....");
                        foreach (string temp in student)
                        {
                            Console.WriteLine(temp);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Entry!!!.Please Try again");
                        break;

                }


            } while (ch!=4);
            Console.ReadKey();
        }
    }
}
