using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class AnonymouseMethodDemo
    {
        static void Main()
        {
            var student = new
            {
                student_id = 100,
                student_name = "sasi",
                depart = "CSE"
            };
            Console.WriteLine("Student Id :{0}", student.student_id);
            Console.WriteLine("Student name :{0}", student.student_name);
            Console.WriteLine("Student Department :{0}", student.depart);
            Display(student);
            Console.ReadKey();
        }
        public static void Display(dynamic studentList)
        {
            Console.WriteLine("-----------------Calling from another Method--------------------");
            Console.WriteLine("Student Id :{0}", studentList.student_id);
            Console.WriteLine("Student name :{0}", studentList.student_name);
            Console.WriteLine("Student Department :{0}", studentList.depart);
        }
    }
}
