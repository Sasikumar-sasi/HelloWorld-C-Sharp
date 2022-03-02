using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
namespace HelloWorld
{
    internal class InterfaceDemoClass
    {
        interface ISalaryProcess
        {
            void getSalary(EmployeeDetails emp);
            void DisplayDetails(EmployeeDetails emp);
        }
        class SalaryProcess:ISalaryProcess
        {
            public void getSalary(EmployeeDetails emp)
            {
                int salary = emp.Salary;
                Console.WriteLine("Salary :" +salary);
            }
            public void DisplayDetails(EmployeeDetails emp)
            {
                Console.WriteLine("----------------------EMPLOYEE DETAILS-----------------");
                Console.WriteLine("Emp Id :"+emp.EmpId);
                Console.WriteLine("Employee Name :" + emp.EmpName + "\nEmployee salary :" + emp.Salary + "\nEmployee Department :" + emp.EmpDept);
            }


        }
        static void Main()
        {
            Console.WriteLine("How many Employee Details want to be Entry");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            ISalaryProcess process = new SalaryProcess();
            EmployeeDetails[] emp = new EmployeeDetails[n];
            Console.WriteLine("Enter Employee Details (Comma Separated)");
            Console.WriteLine("Employee id,Employee name, Employee Department,Salary");
            for (int i = 0; i < n; i++)
            {
                process = new SalaryProcess();
                emp[i] = new EmployeeDetails();
                string input = Console.ReadLine();
                string[] details = input.Split(',');
                emp[i].EmpId = int.Parse(details[0]);
                emp[i].EmpName = details[1];
                emp[i].EmpDept = details[2];
                emp[i].Salary = int.Parse(details[3]);
                
            }
            for(int i = 0; i < n; i++)
            {
                process.DisplayDetails(emp[i]);
            }

            Console.ReadKey();
        }
    }
}
