using System;

class Employee
{
    public void CalculatePay()
    {
        double basePay = ComputeBasePay();
        Console.WriteLine($"Base pay: {basePay}");
    }

    // Method này chỉ được gọi bên trong class, nhưng lại để public
    public double ComputeBasePay()
    {
        return 1000;
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        // Người dùng không nên gọi trực tiếp method này!
        Console.WriteLine(emp.ComputeBasePay()); // ❌ Thiết kế kém
    }
}
    