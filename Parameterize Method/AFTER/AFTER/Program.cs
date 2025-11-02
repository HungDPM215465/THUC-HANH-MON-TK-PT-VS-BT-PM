using System;

namespace ParameterizeMethod_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1000);
            emp.Raise(5);   // tăng 5%
            emp.Raise(10);  // tăng 10%
        }
    }

    class Employee
    {
        private double salary;

        public Employee(double initialSalary)
        {
            salary = initialSalary;
        }

        // Một hàm duy nhất, nhận tham số phần trăm tăng lương
        public void Raise(double percentage)
        {
            salary += salary * (percentage / 100);
            Console.WriteLine($"After {percentage}% raise: {salary}");
        }
    }
}

