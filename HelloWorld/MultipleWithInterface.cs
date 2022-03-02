using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class MultipleWithInterface
    {
        interface IPerson
        {
            void GetBasicInfo();
            void DisBasicInfo();
        }
        interface IEducation
        {
            void GetEducationDetails();
            void DisEducationDetails();
        }
        interface IEmployment
        {
            void GetEmploymentDetails();
            void DisEmploymentDetails();
        }
        class Report : IPerson, IEducation, IEmployment
        {
            string name;
            int age, salary;
            string degree;
            float percent;
            string compName, desig;

            public void GetBasicInfo()
            {
                Console.WriteLine("Enter Your Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter Your Age:");
                age = int.Parse(Console.ReadLine());
            }
            public void DisBasicInfo()
            {
                Console.WriteLine($"Your Name is {name} & Your Age is {age}");
            }
            public void GetEducationDetails()
            {
                Console.WriteLine("Enter Your Degree:");
                degree = Console.ReadLine();
                Console.WriteLine("Enter Your Percentage:");
                percent = float.Parse(Console.ReadLine());
            }
            public void DisEducationDetails()
            {
                Console.WriteLine($"Your degree is {degree} and your                                        percentage is {percent}");
            }
            public void GetEmploymentDetails()
            {
                Console.WriteLine("Enter Your Company Name:");
                compName = Console.ReadLine();
                Console.WriteLine("Enter Your Company Designation:");
                desig = Console.ReadLine();
                Console.WriteLine("Enter Your Salary:");
                salary = int.Parse(Console.ReadLine());
            }
            public void DisEmploymentDetails()
            {
                Console.WriteLine($"You are working in {compName} as                                             {desig} for salary {salary}");
            }
            public void GetAllDetails()
            {
                GetBasicInfo();
                GetEducationDetails();
                GetEmploymentDetails();
            }
            public void DisAllDetails()
            {
                DisBasicInfo();
                DisEducationDetails();
                DisEmploymentDetails();
            }
        }
        static void Main(string[] args)
        {
            Report rep = new Report();
            rep.GetAllDetails();
            rep.DisAllDetails();
            Console.ReadKey();
        }
    }
}
