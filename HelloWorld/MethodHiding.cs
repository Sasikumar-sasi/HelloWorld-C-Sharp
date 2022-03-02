using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class MethodHiding
    {
        class Person
        {
            public void Display()
            {
                Console.WriteLine("Person Class Display");
            }

        }
        class Employee : Person
        {
            public void Display()
            {
                Console.WriteLine("Employee Class Display");
            }
        }
        class Manager : Employee
        {
            public void Display()
            {
                Console.WriteLine("Manager Class Display");
            }
        }
        static void Main()
        {
            //Create Referance as the parent class
            Person p; 
            p = new Person();
            p.Display();
            p = new Employee();
            p.Display();
            p = new Manager();
            p.Display();

            //Create Referance for the employee class
            Employee e;
            e = new Employee();
            e.Display();
            e = new Manager();
            e.Display();

            //Create Referrace for Manager Class
            Manager m;
            m = new Manager();
            m.Display();

            Console.ReadKey();

        }
    }
}
