using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class OperatorOverloadingDemo
    {
        class Student
        {
            int _RollNo;
            string _StudentName;
            string _Department;
            int _Year;
            int _Fees;
            public Student(int RollNo,string StudentName,string Department,int Year,int Fees)
            {
                _RollNo = RollNo;
                _StudentName = StudentName;
                _Department = Department;
                _Year = Year;
                _Fees = Fees;
            }
            public static Student operator +(Student stu1,Student stu2)
            {
                Student stuPlus = new Student(0, "", "", 0, 0);
                stuPlus._StudentName = stu1._StudentName + stu2._StudentName;
                stuPlus._Fees = stu1._Fees + stu2._Fees;
                return stuPlus;
            }
            public void Display(Student stu)
            {
                Console.WriteLine(stu._StudentName);
                Console.WriteLine(stu._Fees);
            }

        }

        static void Main()
        {
            Student stu = new Student(42, "Sasikumar", "CSE", 4, 10000);
            Student stu2 = new Student(23, "John", "CSE", 4, 20000);
            Student stu3;
            stu3 = stu + stu2;

            stu.Display(stu3);
            Console.ReadKey();
            
        }
    }
}
