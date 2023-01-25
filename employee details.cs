using System;
using EmployeeDetails;
namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Class1 c1 = new Class1();
                Console.WriteLine("Enter Employee id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Employee salary:");
                double sal = Convert.ToDouble(Console.ReadLine());

                c1.EmpNo = id;
                c1.EmpName = name;
                c1.Salary = sal;
                c1.CalculateSalary();
                Console.WriteLine("Employee Grosssalary:{0}", c1.GrossSalary);
                Console.WriteLine("Employee Hra:{0}", c1.HRA);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}