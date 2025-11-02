using System;
using System.Diagnostics; // ✅ Quan trọng: dùng Debug.Assert

namespace IntroduceAssertion_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            double limit = emp.GetExpenseLimit();
            Console.WriteLine($"Expense Limit: {limit}");
        }
    }

    class Project
    {
        public double GetMemberExpenseLimit()
        {
            return 5000;
        }
    }

    class Employee
    {
        private const double NULL_EXPENSE = -1;
        private double expenseLimit = NULL_EXPENSE;
        private Project primaryProject = null;

        public double GetExpenseLimit()
        {
            // ✅ Thêm assert để kiểm tra điều kiện hợp lệ
            Debug.Assert(expenseLimit != NULL_EXPENSE || primaryProject != null,
                "Employee must have either an expense limit or a primary project!");

            return (expenseLimit != NULL_EXPENSE)
                ? expenseLimit
                : primaryProject.GetMemberExpenseLimit();
        }
    }
}

