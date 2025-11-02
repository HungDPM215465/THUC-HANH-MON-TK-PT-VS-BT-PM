using System;

class Employee
{
    public void CalculatePay()
    {
        double basePay = ComputeBasePay();
        Console.WriteLine($"Base pay: {basePay}");
    }

    // Ẩn đi, chỉ cho phép dùng nội bộ
    private double ComputeBasePay()
    {
        return 1000;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        emp.CalculatePay(); // ✅ Gọi đúng cách

        // emp.ComputeBasePay(); ❌ Compile error – method is private
    }
}
